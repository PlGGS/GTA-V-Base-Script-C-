using GTA;
using System;
using System.Windows.Forms;

/*
    If you would like to properly use this application as a starting point for
    your own work, please reference a scripthookdotnet dll file.
    
    You can obtain the newest build from here: 
    https://github.com/crosire/scripthookvdotnet/releases 
*/

public class BaseScript : Script {

    public BaseScript() {

        Tick += OnTick;
        KeyDown += OnKeyDown;
        KeyUp += OnKeyUp;

        Interval = 1;

    }

    void OnTick(object sender, EventArgs e) {



    }

    void OnKeyDown(object sender, KeyEventArgs e) {



    }

    void OnKeyUp(object sender, KeyEventArgs e) {



    }

}