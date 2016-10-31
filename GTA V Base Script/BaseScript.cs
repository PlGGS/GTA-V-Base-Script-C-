using GTA;
using System;
using System.Windows.Forms;

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