# ControlPanel

This git contains the latest version of the Study Control-Panel. If you don't want to install Visual Studio you just can use the .exe in the WoZControl\bin\Release folder.

### License
This code was developed as part of the L2TOR project, which has received funding from the European Union’s Horizon 2020 research and innovation programme under the Grant Agreement No. 688014.
If you use this system in any way, please include a reference to the following paper:
@inproceedings{vogt2019second,
title={Second Language Tutoring using Social Robots: A Large-Scale Study},
author={Vogt, Paul and van den Berghe, Rianne and de Haas, Mirjam and Hoffmann, Laura and Kanero, Junko and Mamus, Ezgi and Montanier, Jean-Marc and Oran\c{c}, Cansu and Oudgenoeg-Paz, Ora and Garc'{i}a, Daniel Hern'{a}ndez and Papadopoulos, Fotios and Schodde, Thorsten and Verhagen, Josje and Wallbridge, Christopher D. and Willemsen, Bram and de Wit, Jan and Belpaeme, Tony and G"{o}ksun, Tilbe and Kopp, Stefan and Krahmer, Emiel and K"{u}ntay, Aylin C. and Leseman, Paul and Pandey, Amit K.},
booktitle={Proceedings of the 2019 ACM/IEEE International Conference on Human-Robot Interaction},
year={2019},
organization={ACM/IEEE}
}

**Important things:**
*   If you want to move the ControlPanel (CP) to another location you have to move the .config file as well. This file is storing the preferred language selection.
*   After the CP is connected to the connectionmanager it will receive notifications about other running modules. This can take up to 5 seconds.
*   The memory- and session-file lists are filled with contented by the interaction manager. It is responsible to read the coresponding directories (C:/l2tor/memories and C:/l2tor/lessons) and to send the information back to the CP.
*   To start the interaction, when all necessary modules are loaded, you first have to load or create a memory for the new child (this process requires the a running interactionmanager instance)
*   After loading/creating a memory you can use the "Start Lesson" button to start the interaction.

**Checkpoint system:**
*   If you load a memory you will see the last status of the interaction in the down most info section. If a system crash happend, it will show that the
*   previous session has NOT be finished and if a checkpoint was found for that session the task id and subtask id will be shown from where the interaction will go on.
*   If a checkpoint was found the "Continue Lesson" button is activated and you can continue the lesson. But for the case you get stuck, because something is wrong with the checkpoint you can start the session from the beginning again by pressing "Start Lesson" the button as usual.
*   If NO checkpoint was found but the system crashed and the child is in the mid of the interaction --> An info will be shown that there is no checkpoint available to be loaded and the session hsa to be started from the beginning again (the "Continue Lesson" button also will be disabled).
