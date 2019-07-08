using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Configuration;
using System.Web.UI.WebControls;
using System.Collections.Specialized;

namespace WoZControl {
    public partial class Form1 : Form {
        private AsynchronousClient client;
        private Form form_new_child = null;
        private string lastIP = "127.0.0.1";
        private int currentstep = 0;
        private object currentSession = "";
        private object currentMemory = "";
        private object currentlyLoadedMemory = null;
        private string mObject = "none";
        private bool robotbeh = false;
        private const string SESSION_DIR = "C:\\l2tor\\sessions\\";
        private const string MEMORIE_DIR = "C:\\l2tor\\memories";
        public Dictionary<String, Boolean> moduleStatus = new Dictionary<String, Boolean>();
        public List<string> memoryList = null;

        public Form1() {
            InitializeComponent();
        }

        public AsynchronousClient getTCP() {
            return client;
        }

        private void Form1_Load(object sender, EventArgs e) {
            client = new AsynchronousClient(); //client for TCP connection
            cb_lang.SelectedIndex = Int32.Parse(ConfigurationManager.AppSettings.Get("preferredLang"));

            //fillDDL(SESSION_DIR, ddlSessions);
            //fillDDL(MEMORIE_DIR, ddlMemories);
            //this.btn_load_memory.Enabled = (this.ddlMemories.Items.Count >= 0);

            moduleStatus.Add("uwds", false);
            moduleStatus.Add("kinectVAD", false);
            moduleStatus.Add("ControlPanel", false);
            moduleStatus.Add("interactionmanager", false);
            moduleStatus.Add("outputmanager", false);
            moduleStatus.Add("tabletgame", false);

            this.cmdIntro.Enabled = false;
            this.btnContinue.Enabled = false;
        }

        private void updateStatus(string module, Boolean value) {
            if (module == "interactionmanager") {
                if (value) {
                    if (!moduleStatus[module]) {
                        requestUpdate();
                        this.Invoke((MethodInvoker)delegate {
                            this.btn_new_memory.Enabled = true;
                        });
                    }
                } else {
                    setStatusOfModule("uwds", "Offline");
                    if (currentlyLoadedMemory != null) {
                        currentlyLoadedMemory = null;
                        this.txtChildName.Invoke((MethodInvoker)delegate {
                            txtChildName.Text = txtuserID.Text = "";
                        });
                    }
                    this.Invoke((MethodInvoker)delegate {
                        btn_save_memory.Enabled = cmdIntro.Enabled = btnContinue.Enabled = btn_unload_memory.Enabled = btn_load_memory.Enabled = btn_new_memory.Enabled = btn_delete_memory.Enabled = btnVAD.Enabled = false;
                        ddlMemories.Items.Clear();
                        ddlSessions.Items.Clear();
                        memoryList = null;
                        lbl_task_type.Text = "";
                        lbl_scene.Text = "";
                        lbl_task_id.Text = "";
                    });
                }
            }
            moduleStatus[module] = value;
            //Boolean _allOnline = moduleStatus.Aggregate(true, (_online, nextStatus) => _online && nextStatus.Value);
        }

        private void requestMemoryList() {
            client.Send("call:tablet.interactionmanager.get_memories");
        }

        private void requestUpdate() {
            client.Send("call:tablet.interactionmanager.get_updated_information");
        }

        private void requestSessionList() {
            client.Send("call:tablet.interactionmanager.get_sessions");
        }

        private void fillDDL(string targetDirectory, ComboBox ddl) {
            ddl.Items.Clear();
            if (Directory.Exists(targetDirectory)) {
                // Process the list of files found in the directory.
                string[] fileEntries = Directory.GetFiles(targetDirectory);
                foreach (string fileName in fileEntries) {
                    string[] tmp_fn = fileName.Replace("\\", "/").Split('/');
                    ddl.Items.Add(tmp_fn[tmp_fn.Length - 1]);
                }
                if (ddl.Items.Count > 0) ddl.SelectedIndex = 0;
            }
        }

        private void fillDDL(string[] items, ComboBox ddl) {
            ddl.Items.Clear();
            memoryList = new List<string>();
            foreach (string element in items) {
                string itm = element.Replace("\"", "").Trim();
                ddl.Items.Add(itm);
                memoryList.Add(itm);
            }
        }

        private void BtnConnect_Click(object sender, EventArgs e) {
            lastIP = txtIP.Text;
            if (client.bConnected == true) //close active connections first
                client.CloseSocket();
            client.StartClient(System.Net.IPAddress.Parse(lastIP), this);
            if (client.bConnected == true) {
                //register the client
                System.Threading.Thread.Sleep(1000);
                client.Send("register:ControlPanel");
                btnConnect.Enabled = txtIP.Enabled = !client.bConnected;
                btnDisconnect.Enabled = btncrouch.Enabled = btnQi.Enabled = btnResetGaze.Enabled = btnSay.Enabled = client.bConnected; 
            } else {
                btnConnect.Enabled = btncrouch.Enabled = btnQi.Enabled = btnResetGaze.Enabled = btnSay.Enabled = client.bConnected;
                btnDisconnect.Enabled = txtIP.Enabled = !client.bConnected;
            }
        }

        public void setStatusOfModule(String module, String status) {
            Color color = Color.Red;
            if (status == "Online") color = Color.Green;

            var name = string.Format("lblStatus{0}", module);
            if (this.groupStatus.Controls.ContainsKey(name)) {
                var currentLabel = this.groupStatus.Controls[name] as Label;
                if (currentLabel != null) {
                    currentLabel.Invoke((MethodInvoker)delegate {
                        currentLabel.Text = status;
                        currentLabel.ForeColor = color;
                    });
                    updateStatus(module, status == "Online");
                }
            }
        }

        public void setMemoryList(String[] list) {
            this.ddlMemories.Invoke((MethodInvoker)delegate {
                int _index = 0;
                this.fillDDL(list, this.ddlMemories);
                for (int i = 0; i < this.ddlMemories.Items.Count; ++i) {
                    if (this.ddlMemories.Items[i].Equals(currentMemory)) {
                        _index = i;
                        break;
                    }
                }
                this.ddlMemories.SelectedIndex = _index;
            });
        }

        public void setSessionList(String[] list) {
            this.ddlMemories.Invoke((MethodInvoker)delegate {
                this.fillDDL(list, this.ddlSessions);
                this.ddlSessions.SelectedIndex = getIndexOfElement(currentSession, this.ddlSessions);
            });
        }

        public void setSessionInformation(String[] information) {
            this.Invoke((MethodInvoker)delegate {
                btnVAD.Enabled = (information[1].Trim() == "VOICE_ACTIVATION_CRITERIUM" || information[1].Trim() == "RESPONSE_DELAY_CRITERIUM");
                lbl_task_id.Text = information[0].Trim();
                lbl_task_type.Text = information[1].Trim();
                lbl_scene.Text = information[2].Trim();
            });
        }

        public void setExtendedSessionInformation(String[] information) {
            this.Invoke((MethodInvoker)delegate {
                for (int i = 0; i < information.Length; ++i) {
                    information[i] = information[i].Replace('"', ' ').Trim();
                    Console.WriteLine(information[i]);
                }
                String[] fileInfo = information[2].Split('_');
                if (information[3].Trim() == "true") {
                    lbl_task_id.Text = information[0].Trim() + "." + information[1].Trim();
                    this.ddlSessions.SelectedIndex = this.ddlSessions.FindString(information[2]);
                    lbl_task_type.Text = information[2].Replace(".json", "") + " NOT completed";
                    lbl_scene.Text = "";
                    this.btnContinue.Enabled = true;
                } else if (information[3].Trim() == "false") {
                    //this.ddlSessions.SelectedIndex = this.ddlSessions.FindString(information[2]);
                    lbl_task_type.Text = information[2].Replace(".json", "") + " completed";
                    string[] tmpSplit = information[2].Split('_');
                    if (tmpSplit.Length >= 4) {
                        int oldSession = Convert.ToInt32(tmpSplit[3].Replace(".json", "")) + 1;
                        tmpSplit[3] = oldSession.ToString() + ".json";
                        string tmpStr = String.Join("_", tmpSplit);
                        if (ddlSessions.FindString(tmpStr) == -1) {
                            int lesson = Convert.ToInt32(tmpSplit[1]) + 1;
                            tmpSplit[1] = lesson.ToString();
                            oldSession--;
                            tmpSplit[3] = oldSession.ToString() + ".json";
                            tmpStr = String.Join("_", tmpSplit);
                        }
                        this.ddlSessions.SelectedIndex = this.ddlSessions.FindString(tmpStr);
                    }

                    lbl_scene.Text = "";
                    lbl_task_id.Text = "";
                } else if (information[3].Trim() == "clean") {
                    lbl_task_type.Text = "No session stored yet.";
                    lbl_scene.Text = "";
                    lbl_task_id.Text = "";
                    this.ddlSessions.SelectedIndex = 0;
                } else if (information[3].Trim() == "no_point") {
                    lbl_task_id.Text = information[0].Trim() + "." + information[1].Trim();
                    this.ddlSessions.SelectedIndex = this.ddlSessions.FindString(information[2]);
                    lbl_task_type.Text = information[2].Replace(".json", "") + " NOT completed";
                    lbl_scene.Text = "No Checkpoint";
                }
            });
        }

        public int getIndexOfElement(object elem, ComboBox ddl) {
            int _index = 0;
            for (int i = 0; i < ddl.Items.Count; ++i) {
                if (this.ddlSessions.Items[i].Equals(elem)) {
                    _index = i;
                    break;
                }
            }
            return _index;
        }

        public void setMemory(String id, String name, String filename, String langCombo, String condition) {
            this.Invoke((MethodInvoker)delegate {
                currentMemory = filename.Replace('"', ' ').Trim();
                currentlyLoadedMemory = currentMemory;
                requestMemoryList();

                this.txtuserID.Text = id.Replace('"',' ').Trim();
                this.txtChildName.Text = name.Replace('"', ' ').Trim();
                langCombo = langCombo.Replace('"', ' ').Trim();
                this.cb_lang.SelectedIndex = (langCombo == "" || langCombo == "null") ? Int32.Parse(ConfigurationManager.AppSettings.Get("preferredLang")) : this.cb_lang.FindString(langCombo);
                condition = condition.Replace('"', ' ').Trim();
                this.txtChildName.Enabled = true;
                this.cmdIntro.Enabled = true;
                this.btn_unload_memory.Enabled = true;
                this.btn_save_memory.Enabled = false;
                this.cmdFinish.Enabled = false;
            });
        }

        public void unsetMemory() {
            this.Invoke((MethodInvoker)delegate {
                this.lbl_task_id.Text = "";
                this.lbl_scene.Text = "";
                this.lbl_task_type.Text = "";
                this.txtuserID.Text = "";
                this.txtChildName.Text = "";
                this.txtChildName.Enabled = false;
                this.cmdIntro.Enabled = false;
                this.btnContinue.Enabled = false;
                this.btn_unload_memory.Enabled = false;
                this.btn_save_memory.Enabled = false;
                this.cmdFinish.Enabled = false;
            });
        }

        private void cmdIntro_Click(object sender, EventArgs e) {
            if (txtChildName.Text != "") {
                Console.WriteLine(txtChildName.Text);
                client.Send("call:tablet.[outputmanager,interactionmanager].set_lang|" + cb_lang.SelectedItem);
                client.Send("call:tablet.interactionmanager.CPinit|{\"session_file\":\"" + ddlSessions.SelectedItem + "\",\"lang_combo\":\"" + cb_lang.SelectedItem + "\"}");
                cmdFinish.Enabled = cmdPause.Enabled = cmdResume.Enabled = true;
                cmdIntro.Enabled = false;
                btnContinue.Enabled = false;
            }
        }

        private void cmdFinish_Click(object sender, EventArgs e) {
            client.Send("call:tablet.*.exit_interaction");
            cmdFinish.Enabled = cmdPause.Enabled = cmdResume.Enabled = false;
            cmdIntro.Enabled = true;
        }

        private void btnDisconnect_Click(object sender, EventArgs e) {
            if (client.bConnected == true) {
                if (currentlyLoadedMemory != null && moduleStatus["interactionmanager"]) {
                    unloadMemory();
                    currentlyLoadedMemory = null;
                    txtChildName.Text = txtuserID.Text = "";
                }
                btn_save_memory.Enabled = cmdFinish.Enabled = btnVAD.Enabled = cmdIntro.Enabled = btn_unload_memory.Enabled = btn_load_memory.Enabled = btn_new_memory.Enabled = btn_delete_memory.Enabled = btncrouch.Enabled = btnQi.Enabled = btnResetGaze.Enabled = btnSay.Enabled = false;
                txtIP.Enabled = true;
                lbl_task_type.Text = "";
                lbl_scene.Text = "";
                lbl_task_id.Text = "";
                ddlMemories.Items.Clear();
                ddlSessions.Items.Clear();
                memoryList = null;
                client.Send("exit");
                client.CloseSocket();
                btnConnect.Enabled = !client.bConnected;
                btnDisconnect.Enabled = client.bConnected;
                cleanModuleStatus();
            }
        }

        private void cleanModuleStatus() {
            foreach (var module in moduleStatus.Keys.ToList()) {
                moduleStatus[module] = false;
                Color color = Color.Red;
                string status = "Offline";
                var name = string.Format("lblStatus{0}", module);
                if (this.groupStatus.Controls.ContainsKey(name)) {
                    var currentLabel = this.groupStatus.Controls[name] as Label;
                    if (currentLabel != null) {
                        currentLabel.Invoke((MethodInvoker)delegate {
                            currentLabel.Text = status;
                            currentLabel.ForeColor = color;
                        });
                    }
                }
            }
        }

        private void btncrouch_Click(object sender, EventArgs e) {
            client.Send("call:nao.BehaviourM.crouch");
        }

        private void btnQi_Click(object sender, EventArgs e) {
            client.Send("call:nao.ALMotion.rest");
        }

        private void btnSay_Click(object sender, EventArgs e) {
            client.Send("call:tablet.outputmanager.say|" + txtSay.Text);
        }

        #region old

        /*private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void enablecmd(bool enable)
        {
            cmdMoveObj.Enabled = enable;
            cmdRight.Enabled = enable;
            cmdWrongPoint.Enabled = enable;
            cmdWrong.Enabled = enable;


        }
        private void cmdIntro_Click(object sender, EventArgs e)
        {
            currentscene = 0;
            currentstep = 0;
            lblscene.Text = "0";
            lblStep.Text = "0";
            enablecmd(false);
            cmdFinish.Enabled = true;
            cmdNext.Enabled = true;
            cmdRepeat.Enabled = true;

            if (client.bConnected == true)
            {
                client.Send("call:tablet.WebSocket.intro 00"); 
                client.Send("call:nao.BehaviourM.sayD hoi");
            }
        }

        private void cmdNext_Click(object sender, EventArgs e)
        {
            robotbeh = false;
            if (currentscene == 0)
            {
                if (currentstep < 10)
                {
                    currentstep++;

                }
                else
                {
                    currentstep = 0;
                    currentscene = 1;
                }
                lblStep.Text = currentstep.ToString() + "/10";
            }
            else if (currentscene == 1)
                {
                    if (currentstep < 12)
                    {
                        currentstep++;

                    }
                    else
                    {
                        currentstep = 1;
                        currentscene = 2;
                        if (conditionllist.SelectedIndex == 0)
                        {
                            conditionllist.SelectedIndex = 1;
                            client.Send("call:nao.BehaviourM.sayD oh nu ben jij");
                        }
                        else
                        {
                            conditionllist.SelectedIndex = 0;
                            client.Send("call:nao.BehaviourM.sayD jeej nu ben ik!");
                        }
                    }
                    lblStep.Text = currentstep.ToString() + "/12";
                }
                else if (currentscene == 2)
                {
                    if (currentstep < 11)
                    {
                        currentstep++;

                    }
                    else
                    {
                        currentstep = 0;
                        currentscene = 3;
                        if (conditionllist.SelectedIndex == 0)
                        {
                            conditionllist.SelectedIndex = 1;
                            client.Send("call:nao.BehaviourM.sayD oh nu ben jij");
                         }
                        else
                        {
                            conditionllist.SelectedIndex = 0;
                            client.Send("call:nao.BehaviourM.sayD jeej nu ben ik!");
                        }
                }
                    lblStep.Text = currentstep.ToString() + "/11";
                }
                else if (currentscene == 3)
                {
                    if (currentstep < 4)
                    {
                        currentstep++;

                    }
                    else
                    {
                        currentstep = 1;
                        currentscene = 4;
                        if (conditionllist.SelectedIndex == 0)
                        {
                            conditionllist.SelectedIndex = 1;
                            client.Send("call:nao.BehaviourM.sayD nu ben jij weer");
                        }
                        else
                        {
                            conditionllist.SelectedIndex = 0;
                            client.Send("call:nao.BehaviourM.sayD yes nu ben ik");
                        }
                }
                    lblStep.Text = currentstep.ToString() + "/4";
                }
                else if (currentscene == 4)
                {
                    if (currentstep < 6)
                    {
                        currentstep++;

                    }
                    lblStep.Text = currentstep.ToString() + "/6";

                }

            
            lblscene.Text = currentscene.ToString() + "/4";
            
            handler();
            
        }
        private void handler()
        {
            switch (currentscene)
            {

                case 0: //the first scene handler
                    switch(currentstep)
                    {
                        case 1:
                            client.Send("call:nao.BehaviourM.sayD ik ben heel benieuwd wat gaan doen");
                            break;
                        case 2:
                            client.Send("call:tablet.WebSocket.nextscene");
                            break;

                        case 3:
                            client.Send("call:nao.BehaviourM.drag");
                            client.Send("call:tablet.WebSocket.moveElephant1");
                            break;
                        case 4:
                            client.Send("call:tablet.WebSocket.nextscene");
                            break;
                        case 5:
                            client.Send("call:nao.BehaviourM.drag");
                            client.Send("call:tablet.WebSocket.moveCan");
                            break;
                        case 6:
                            client.Send("call:tablet.WebSocket.nextscene");
                            break;
                        case 7:
                            client.Send("call:nao.BehaviourM.drag");
                            client.Send("call:tablet.WebSocket.moveGiraffes");
                            break;
                        case 8:
                            client.Send("call:tablet.WebSocket.nextscene");
                            break;
                        case 9:
                            client.Send("call:nao.BehaviourM.drag");
                            client.Send("call:tablet.WebSocket.moveBall");
                            break;
                        case 10:
                            client.Send("call:tablet.WebSocket.intro " + txtuserID.Text.PadLeft(2, '0'));
                            break;

                    }
                    break;
                case 1: //the first scene handler
                    switch (currentstep)
                    {

                        case 0:
                            lblWord.Text = "heavy";
                            client.Send("call:tablet.WebSocket.nextscene");

                            break;

                        case 1:
                            lblWord.Text = "heavy";

                            client.Send("call:nao.BehaviourM.say " + lblWord.Text);
                            enablecmd(false);
                            break;

                        case 2:
                            if (conditionllist.SelectedIndex == 0) //robot's turn
                            {
                                mObject = "Elephant1";

                                cmdMoveObj.Enabled = true;
                                cmdMoveObj.Text = "Move Object:" + mObject;
                            }
                            else
                            { //child's turn
                                lblWord.Text = "";
                                txtRightfeed.Text = "Yes nu staat ie in het hok";
                                txtWrongFeed.Text = "ik denk dat hij daarheen moet";
                                cmdRight.Enabled = true;
                                cmdWrongPoint.Enabled = true;
                            }
                            break;

                        case 3:
                            lblWord.Text = "heavy";
                            txtRightfeed.Text = "o ja dat is";
                            txtWrongFeed.Text = "volgens mij is het";


                            if (conditionllist.SelectedIndex == 0)
                            {
                                cmdMoveObj.Enabled = false;
                                cmdRight.Enabled = true;
                                cmdWrong.Enabled = true;
                            }
                            else
                            {
                                cmdWrongPoint.Enabled = false;
                                cmdRight.Enabled = true;
                                cmdWrong.Enabled = true;
                            }
                            break;
                        case 4:
                            txtRightfeed.Text = "";
                            txtWrongFeed.Text = "";
                            lblWord.Text = "light";
                            client.Send("call:nao.BehaviourM.say " + lblWord.Text);
                            enablecmd(false);
  
                            break;
                        case 5:
                            lblWord.Text = "";
                            if (conditionllist.SelectedIndex == 0)
                            {
                                mObject = "Elephant2";
                                cmdMoveObj.Enabled = true;
                                cmdMoveObj.Text = "Move Object:" + mObject;
                            }
                            else
                            {
                                txtRightfeed.Text = "Nu staan ze samen in het hok";
                                txtWrongFeed.Text = "ik denk dat hij daar bij de mama olifant moet staan";
                                cmdRight.Enabled = true;
                                cmdWrongPoint.Enabled = true;

                            }
                            break;
                        case 6:
                            
                            txtRightfeed.Text = "Ja";
                            txtWrongFeed.Text = "ik denk...";

                            if (conditionllist.SelectedIndex == 0)
                            {
                                cmdMoveObj.Enabled = false;
                                cmdRight.Enabled = true;
                                cmdWrong.Enabled = true;

                            }
                            else
                            {
                                cmdMoveObj.Enabled = false;
                                cmdRight.Enabled = true;
                                cmdWrong.Enabled = true;
                            }
                            break;
                        case 7:
                            txtRightfeed.Text = "";
                            txtWrongFeed.Text = "";
                            if (conditionllist.SelectedIndex == 0)
                            {
                                client.Send("call:nao.BehaviourM.sayD " + "Hij is leeg");
                                enablecmd(false);
                            }
                            else
                            {
                                enablecmd(false);
                            }
                            break;
                        case 8:
                            lblWord.Text = "empty";
                            client.Send("call:nao.BehaviourM.say " + lblWord.Text);
                            break;
                        case 9:
                            txtRightfeed.Text = "o ja dat is";
                            txtWrongFeed.Text = "volgens mij is het";
                            if (conditionllist.SelectedIndex == 0)
                            {
                                cmdWrong.Enabled = true;
                                cmdRight.Enabled = true;

                            }
                            else
                            {

                                cmdWrong.Enabled = true;
                                cmdRight.Enabled = true;
                            }
                            break;
                        case 10:
                            lblWord.Text = "";
                            if (conditionllist.SelectedIndex == 0)
                            {
                                enablecmd(false);
                                mObject = "Leafs";
                                cmdMoveObj.Enabled = true;
                                cmdMoveObj.Text = "Move Object:" + mObject;
                            }
                            else
                            {
                                lblWord.Text = "";
                                txtRightfeed.Text = "wat een hoop blaadjes";
                                txtWrongFeed.Text = "daar kunnen ze in";
                                cmdWrong.Enabled = false;
                                cmdRight.Enabled = true;
                                cmdWrongPoint.Enabled = true;
                            }
                            break;
                        case 11:
                            txtRightfeed.Text = "";
                            txtWrongFeed.Text = "";
                            lblWord.Text = "full";
                            client.Send("call:nao.BehaviourM.say " + lblWord.Text);
                            enablecmd(false);

                            break;

                        case 12:
                            txtRightfeed.Text = " ";
                            txtWrongFeed.Text = "ik weet het, het is";
                            lblWord.Text = "full";
                            cmdWrong.Enabled = true;
                            cmdRight.Enabled = true;

                            break;

                    }
                    break;

                case 2:
                    switch (currentstep)
                    {

                        case 1:
                            client.Send("call:tablet.WebSocket.nextscene");
                            lblWord.Text = "";
                            mObject = "MumPolar";
                            if (conditionllist.SelectedIndex == 0) //first condition selected
                            {
                                //client.Send("call:nao.BehaviourM.say " + lblWord.Text);
                                enablecmd(false);

                                cmdMoveObj.Enabled = true;
                                cmdMoveObj.Text = "Move Object:" + mObject;
                            }
                            else
                            {
                                txtRightfeed.Text = " ";
                                txtWrongFeed.Text = "Hij moet daarheen";
                                cmdRight.Enabled = true;
                                cmdWrongPoint.Enabled = true;
                            }
                            break;

                        case 2:
                            if (conditionllist.SelectedIndex == 0) //robot's turn
                            {
                                mObject = "BabyPolar";

                                cmdMoveObj.Enabled = true;
                                cmdMoveObj.Text = "Move Object:" + mObject;
                            }
                            else
                            { //child's turn
                                txtRightfeed.Text = "Nu staan ze samen voor de boot.";
                                txtWrongFeed.Text = "Hij moet daar bij de mama";
                                cmdRight.Enabled = true;
                                cmdWrongPoint.Enabled = true;
                            }
                            break;

                        case 3:
                            txtRightfeed.Text = "";
                            txtWrongFeed.Text = "";
                            lblWord.Text = "in front off";
                            enablecmd(false);
                                client.Send("call:nao.BehaviourM.say " + lblWord.Text);
                   

                            break;
                        case 4:
                            txtRightfeed.Text = "O ja dat was";
                            txtWrongFeed.Text = "ik denk...";
                            
                            cmdRight.Enabled = true;
                            cmdWrong.Enabled = true;
                            if (conditionllist.SelectedIndex == 0)
                            {

                            }

                            break;
                        case 5:
                            lblWord.Text = "behind";
                            enablecmd(false);
                            txtRightfeed.Text = "";
                            txtWrongFeed.Text = "";
                            
                                client.Send("call:nao.BehaviourM.say " + lblWord.Text);
                            break;
                        case 6:
                            lblWord.Text = "";
                            mObject = "Bucket";
                            if (conditionllist.SelectedIndex == 0)
                            {
                                cmdMoveObj.Enabled = true;
                                cmdMoveObj.Text = "Move Object:" + mObject;
                                cmdRight.Enabled = false;
                                cmdWrong.Enabled = false;
                                cmdWrongPoint.Enabled = false;

                            }
                            else
                            {
                                lblWord.Text = "";
                                txtRightfeed.Text = " ";
                                txtWrongFeed.Text = "de emmer moet daar";
                                cmdMoveObj.Enabled = false;
                                cmdRight.Enabled = true;
                                cmdWrongPoint.Enabled = true;
                            }
                            break;
                        case 7:
                            mObject = "Fish";


                            if (conditionllist.SelectedIndex == 0)
                            {
                                txtRightfeed.Text = "";
                                txtWrongFeed.Text = "";

                                enablecmd(false);
                                cmdMoveObj.Enabled = true;
                                cmdMoveObj.Text = "Move Object:" + mObject;
                            }
                            else
                            {
                                enablecmd(false);
                                txtRightfeed.Text = "Nu gaan ze lekker eten!";
                                txtWrongFeed.Text = "ik denk dat hij daarheen moet.";
                                cmdMoveObj.Enabled = false;
                                cmdRight.Enabled = true;
                                cmdWrongPoint.Enabled = true;
                            }
                            break;
                        case 8:
                            mObject = "BucketBack";

                            if (conditionllist.SelectedIndex == 0)
                            {
                                txtRightfeed.Text = "";
                                txtWrongFeed.Text = "";

                                enablecmd(false);
                                cmdMoveObj.Enabled = true;
                                cmdMoveObj.Text = "Move Object:" + mObject;
                            }
                            else
                            {
                                enablecmd(false);
                                txtRightfeed.Text = " ";
                                txtWrongFeed.Text = "Daar moet de emmer heen";
                                cmdMoveObj.Enabled = false;
                                cmdRight.Enabled = true;
                                cmdWrongPoint.Enabled = true;

                            }
                            break;
                        case 9:
                            lblWord.Text = "behind";

                            txtRightfeed.Text = " ";
                            txtWrongFeed.Text = "was het niet...";
                            enablecmd(false);
                            cmdWrong.Enabled = true;
                            cmdRight.Enabled = true;

                            break;
                        case 10:
                            lblWord.Text = "";
                            mObject = "Ball";
                            enablecmd(false);
                            if (conditionllist.SelectedIndex == 0)
                            {
                                enablecmd(false);
                                txtRightfeed.Text = "";
                                txtWrongFeed.Text = "";
                                cmdMoveObj.Enabled = true;
                                cmdMoveObj.Text = "Move Object:" + mObject;
                            }
                            else
                            {
                                txtRightfeed.Text = "ja daar moet hij in";
                                txtWrongFeed.Text = "daar is de bak waar de bal in moet";
                                cmdWrong.Enabled = false;
                                cmdRight.Enabled = true;
                                cmdWrongPoint.Enabled = true;
                            }
                            break;
                        case 11:
                            mObject = "Can";
                            txtRightfeed.Text = "";
                            txtWrongFeed.Text = "";
                            lblWord.Text = "";
                            if (conditionllist.SelectedIndex == 0)
                            {
                                enablecmd(false);
                                txtRightfeed.Text = "";
                                txtWrongFeed.Text = "";
                                cmdMoveObj.Enabled = true;
                                cmdMoveObj.Text = "Move Object:" + mObject;
                            }
                            else
                            {
                                txtRightfeed.Text = " ";
                                txtWrongFeed.Text = "daar moet de gieter";
                                cmdWrong.Enabled = false;
                                cmdRight.Enabled = true;
                                cmdWrongPoint.Enabled = true;
                            }


                            break;



                    }
                    break;
                case 3:
                    switch (currentstep)
                    {
                        case 0:
                            client.Send("call:tablet.WebSocket.nextscene");
                            lblWord.Text = "Giraffes";
                            mObject = "Giraffes";
                            txtRightfeed.Text = " ";
                            txtWrongFeed.Text = "";
                            cmdMoveObj.Text = "";
                            enablecmd(false);

                            break;

                        case 1:
                            
                            if (conditionllist.SelectedIndex == 0) //first condition selected
                            {
                                client.Send("call:nao.BehaviourM.sayD ik zie de sjiraffe achter de boom!");
                                client.Send("call:nao.BehaviourM.point " + mObject);
                                
                            }
                            else
                            {
                                client.Send("call:nao.BehaviourM.sayD ik zie de sjiraffe achter de boom!");
                            }
                            break;

                        case 2:
                            if (conditionllist.SelectedIndex == 0) //robot's turn
                            {
                                cmdMoveObj.Text = "Move Object:" + mObject;
                                cmdMoveObj.Enabled = true;
                                
                            }
                            else
                            { //child's turn
                                txtRightfeed.Text = "Leuk nu staan ze samen";
                                txtWrongFeed.Text = "ik denk dat ze daarheen moeten";
                                cmdRight.Enabled = true;
                                cmdWrongPoint.Enabled = true;
                            }
                            break;

                        case 3:
                            
                            mObject = "Tray";
                            txtRightfeed.Text = "";
                            txtWrongFeed.Text = "";
                            
                            enablecmd(false);

                            if (conditionllist.SelectedIndex == 0)
                            {
                                cmdMoveObj.Text = "Move Object:" + mObject;
                                cmdMoveObj.Enabled = true;
                            }
                            else
                            {

                                txtRightfeed.Text = "volgens mij hebben ze heel erg honger";
                                txtWrongFeed.Text = "kijk hij kan daar staan bij de sjiraffen";
                                cmdRight.Enabled = true;
                                cmdWrongPoint.Enabled = true;
                            }
                            break;
                        case 4:

                            lblWord.Text = "Leafs";
                            mObject = "Leafs";
                            txtRightfeed.Text = "";
                            txtWrongFeed.Text = "";

                            enablecmd(false);
                            if (conditionllist.SelectedIndex == 0)
                            {
                                cmdMoveObj.Text = "Move Object:" + mObject;
                                cmdMoveObj.Enabled = true;
                            }
                            else
                            {
                                txtRightfeed.Text = "yes nu gaan ze lekker eten!";
                                txtWrongFeed.Text = "daar kunnen de blaadjes in";
                                cmdRight.Enabled = true;
                                cmdWrongPoint.Enabled = true;
                            }
                            break;



                    }
                    break;
                case 4:
                    switch (currentstep)
                    {

                        case 1:
                            client.Send("call:tablet.WebSocket.nextscene");
                            lblWord.Text = "";
                            mObject = "MumPolar";
                            if (conditionllist.SelectedIndex == 0) //first condition selected
                            {
                                //client.Send("call:nao.BehaviourM.say " + lblWord.Text);
                                enablecmd(false);

                                cmdMoveObj.Enabled = true;
                                cmdMoveObj.Text = "Move Object:" + mObject;
                            }
                            else
                            {
                                txtRightfeed.Text = "Nu kan ze lekker gaan slapen";
                                txtWrongFeed.Text = "Kijk daar is het zwembad";
                                cmdRight.Enabled = true;
                                cmdWrongPoint.Enabled = true;
                            }
                            break;

                        case 2:
                            if (conditionllist.SelectedIndex == 0) //robot's turn
                            {
                                mObject = "BabyPolar";

                                cmdMoveObj.Enabled = true;
                                cmdMoveObj.Text = "Move Object:" + mObject;
                            }
                            else
                            { //child's turn
                                txtRightfeed.Text = "Nu gaan ze samen slapen";
                                txtWrongFeed.Text = "Hij kan daar bij de mama ijsbeer";
                                cmdRight.Enabled = true;
                                cmdWrongPoint.Enabled = true;
                            }
                            break;

                        case 3:
                     

                            if (conditionllist.SelectedIndex == 0)
                            {
                                mObject = "Ball";

                                cmdMoveObj.Enabled = true;
                                cmdMoveObj.Text = "Move Object:" + mObject;
                            }
                            else
                            {
                                txtRightfeed.Text = "Ik hou van spelen met de bal!";
                                txtWrongFeed.Text = "Kijk daar kan de bal";
                                cmdRight.Enabled = true;
                                cmdWrongPoint.Enabled = true;
                            }
                            break;
                        case 4:
                            if (conditionllist.SelectedIndex == 0)
                            {
                                mObject = "Leafs";

                                cmdMoveObj.Enabled = true;
                                cmdMoveObj.Text = "Move Object:" + mObject;
                            }
                            else
                            {
                                txtRightfeed.Text = "ze hebben vast honger";
                                txtWrongFeed.Text = "daar kunnen de blaadjes in";
                                cmdRight.Enabled = true;
                                cmdWrongPoint.Enabled = true;
                            }
                            break;


                        case 5:
                            lblWord.Text = "";
                            mObject = "";
                            enablecmd(false);
                            txtRightfeed.Text = "";
                            txtWrongFeed.Text = "";
                            client.Send("call:tablet.WebSocket.nextscene");
                            
                            break;

                        case 6:
                            client.Send("call:nao.BehaviourM.sayD Jee dit was heel leuk!");
                            break;
                        case 7:
                            client.Send("call:nao.BehaviourM.sayD Slaap lekker");
                            client.Send("call:nao.ALMotion.rest");
                            break;


                    }
                    break;

            }
        }
        private void cmdMoveObj_Click(object sender, EventArgs e)
        {
            if (robotbeh == false)
            {
                client.Send("call:nao.BehaviourM.drag");
                robotbeh = true;
            }
        
            //System.Threading.Thread.Sleep(100);
            client.Send("call:tablet.WebSocket.move" + mObject);
        }

        private void cmdRight_Click(object sender, EventArgs e)
        {
            if(txtRightfeed.Text!="")
                client.Send("call:nao.BehaviourM.sayD " + txtRightfeed.Text);
            System.Threading.Thread.Sleep(500);
            if (lblWord.Text!="")
                client.Send("call:nao.BehaviourM.say " + lblWord.Text);

        }

        private void cmdWrong_Click(object sender, EventArgs e)
        {
            if (txtWrongFeed.Text != "")
                client.Send("call:nao.BehaviourM.sayD " + txtWrongFeed.Text);
            System.Threading.Thread.Sleep(500);
            if (lblWord.Text != "")
                client.Send("call:nao.BehaviourM.say " + lblWord.Text);
        }

        private void cmdWrongPoint_Click(object sender, EventArgs e)
        {
            if (txtWrongFeed.Text != "")
                client.Send("call:nao.BehaviourM.sayD " + txtWrongFeed.Text);
            System.Threading.Thread.Sleep(500);
            if (lblWord.Text != "") 
                client.Send("call:nao.BehaviourM.say " + lblWord.Text);
            System.Threading.Thread.Sleep(500);
            client.Send("call:nao.BehaviourM.point " + mObject);
        }

        private void btncrouch_Click(object sender, EventArgs e)
        {
            client.Send("call:nao.BehaviourM.crouch");
        }

        private void btnQi_Click(object sender, EventArgs e)
        {
            client.Send("call:nao.ALMotion.rest");
        }

        private void cmdRepeat_Click(object sender, EventArgs e)
        {
            handler();
            robotbeh = false;

        }

        private void txtuserID_TextChanged(object sender, EventArgs e)
        {

        }*/
        #endregion

        private void btn_new_memory_Click(object sender, EventArgs e) {
            form_new_child = new Form2(this);
            form_new_child.ShowDialog();
        }

        private void btn_load_memory_Click(object sender, EventArgs e) {
            client.Send("call:tablet.interactionmanager.load_memory|" + this.ddlMemories.SelectedItem);
            this.cmdIntro.Enabled = true;
        }

        private void btnResetGaze_Click(object sender, EventArgs e) {
            client.Send("call:tablet.outputmanager.reset_gaze");
        }

        private void cmdPause_Click(object sender, EventArgs e) {
            client.Send("call:tablet.interactionmanager.pause_interaction");
        }

        private void cmdResume_Click(object sender, EventArgs e) {
            client.Send("call:tablet.interactionmanager.resume_interaction");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            if (currentlyLoadedMemory != null && moduleStatus["interactionmanager"]) unloadMemory();
            client.Send("exit");
            client.CloseSocket();
            btnConnect.Enabled = !client.bConnected;
            btnDisconnect.Enabled = client.bConnected;
        }

        private void btnVAD_Click(object sender, EventArgs e) {
            client.Send("call:tablet.interactionmanager.vadFake");
        }

        private void ddlMemories_SelectedIndexChanged(object sender, EventArgs e) {
            currentMemory = ddlMemories.SelectedItem.ToString();
            btn_load_memory.Enabled = btn_delete_memory.Enabled = (currentMemory.ToString() != "");
            txtChildName.Enabled = (currentlyLoadedMemory != null && currentlyLoadedMemory.ToString().Trim() == currentMemory.ToString().Trim());
        }

        private void btn_refresh_lists_Click(object sender, EventArgs e) {
            requestUpdate();
        }

        private void ddlSessions_SelectedIndexChanged(object sender, EventArgs e) {
            currentSession = ddlSessions.SelectedItem.ToString();
        }

        private void btnVadInvalid_Click(object sender, EventArgs e) {
            client.Send("call:tablet.interactionmanager.vadFakeFalse");
        }

        private void btn_delete_memory_Click(object sender, EventArgs e) {
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??", "Confirm Delete!!", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes) {
                client.Send("call:tablet.interactionmanager.delete_memory|{\"filename\":\"" + this.ddlMemories.SelectedItem.ToString() + "\"}");
                if (this.ddlMemories.SelectedItem.Equals(currentlyLoadedMemory)) {
                    currentlyLoadedMemory = null;
                    this.btn_unload_memory.Enabled = false;
                    this.txtuserID.Text = "";
                    this.txtChildName.Text = "";
                }
            }
        }

        private void btn_save_memory_Click(object sender, EventArgs e) {
            client.Send("call:tablet.interactionmanager.change_memory|{\"name\":\"" + this.txtChildName.Text.Trim() + "\"}");
            btn_save_memory.Enabled = false;
        }

        private void btn_unload_Click(object sender, EventArgs e) {
            unloadMemory();
        }

        private void unloadMemory() {
            client.Send("call:tablet.interactionmanager.unload_memory");
        }

        private void txtChildName_TextChanged(object sender, EventArgs e) {
            btn_save_memory.Enabled = true;
        }

        private void cb_lang_SelectedIndexChanged(object sender, EventArgs e) {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["preferredLang"].Value = cb_lang.SelectedIndex.ToString();
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void btnContinue_Click(object sender, EventArgs e) {
            if (txtChildName.Text != "") {
                client.Send("call:tablet.[outputmanager,interactionmanager].set_lang|" + cb_lang.SelectedItem);
                client.Send("call:tablet.interactionmanager.CPinitContinue|{\"session_file\":\"" + ddlSessions.SelectedItem + "\",\"lang_combo\":\"" + cb_lang.SelectedItem + "\"}");
                cmdFinish.Enabled = cmdPause.Enabled = cmdResume.Enabled = true;
                cmdIntro.Enabled = false;
                btnContinue.Enabled = false;
            }
        }
    }
}
