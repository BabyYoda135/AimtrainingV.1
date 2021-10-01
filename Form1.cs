//ideas space
// make ammo, then based on ammo and how many times the target was hit calculate accuracy
//use a timer to shoot multiple times on an interval if your holding down the mouse, add recoil so that accuracy plays a part
//make different types of simulations ex: moving left to right, rng teleport when clicked
/*sometime in the future possibly make a health for each target  &/or for you and have it be an actual 1v1 against the target,
 use rng to determine how many of the target's bullets hit you, and have a selector to control how hard it is */
/*make a level system so that you can upgrade guns to shoot faster / do more damage
add shop system to do this with and make admin passcode so that you can keep your progress inbetween games*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AimLab
{
    public partial class Form1 : Form
    {
        int cpm;
        int targethp = 100;
        int magammo;
        int totalammo;
        int ammomag;
        int gamemode = 0;
        int gamemodetype = 0;
        int shotsfired = 0;
        int guntype = 0;
        int accuracy;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startmenucustomizable(false);
            startmenuboring(false);
            Playingmenu(false);
            gamemodemenu(true);
            pickagunmessage(false);
        }

        private void Startbutton_Click(object sender, EventArgs e)
        {
            if (guntype == 0 && gamemodetype == 1) 
            {
                pickagunmessage(true);
                selectgunmessage.Enabled = true;
            } else {
                startmenucustomizable(false);
                startmenuboring(false);
                Playingmenu(true);
                pickagunmessage(false);
                timer1.Enabled = true;
                gamemode = 1;
                if (gamemodetype == 2)
                {
                    Ammolabel.Visible = false;
                    Reloadbutton.Visible = false;
                }
            }
        }

        private void gamemodemenu(bool value) 
        {
            Gamemode1button.Visible = value;
            Gamemode2button.Visible = value;
            Targetlabel.Visible = value;
        }
        private void startmenucustomizable(bool value)
        {
            Startbutton.Visible = value;
            Easybutton.Visible = value;
            Intermediatebutton.Visible = value;
            Hardbutton.Visible = value;
            Impossiblebutton.Visible = value;
            Buttonsecond15.Visible = value;
            Buttonsecond30.Visible = value;
            Buttonsecond45.Visible = value;
            Buttonsecond60.Visible = value;
            Semiautobutton.Visible = value;
            Fullautobutton.Visible = value;
            Boltactionbutton.Visible = value;
            Startbutton.Visible = value;
            Targetlabel.Visible = true;
        }
        private void startmenuboring(bool value) 
        {
            Startbutton.Visible = value;
            Easybutton.Visible = value;
            Intermediatebutton.Visible = value;
            Hardbutton.Visible = value;
            Impossiblebutton.Visible = value;
            Buttonsecond15.Visible = value;
            Buttonsecond30.Visible = value;
            Buttonsecond45.Visible = value;
            Buttonsecond60.Visible = value;
            Startbutton.Visible = value;
            Targetlabel.Visible = true;
        }
        private void Playingmenu(bool value) 
        {
            Reloadbutton.Visible = value;
            Ammolabel.Visible = value;
        
        }

        private void Easybutton_Click(object sender, EventArgs e)
        {
            Targetlabel.Font = new Font(Targetlabel.Font.Name, 15f,
                Targetlabel.Font.Style, Targetlabel.Font.Unit);
        }

        private void Intermediatebutton_Click(object sender, EventArgs e)
        {
            Targetlabel.Font = new Font(Targetlabel.Font.Name, 11f,
    Targetlabel.Font.Style, Targetlabel.Font.Unit);
        }

        private void Hardbutton_Click(object sender, EventArgs e)
        {
            Targetlabel.Font = new Font(Targetlabel.Font.Name, 8f,
    Targetlabel.Font.Style, Targetlabel.Font.Unit);
        }

        private void Impossiblebutton_Click(object sender, EventArgs e)
        {
            Targetlabel.Font = new Font(Targetlabel.Font.Name, 1f,
    Targetlabel.Font.Style, Targetlabel.Font.Unit);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //accuracy = (cpm/shotsfired) * 100;
            if (gamemodetype == 1)
            {
                EndStatslabel.Text = "You got " + cpm + " " + "hits, " /*+ accuracy + "% accuracy"*/;
            }
            else 
            {
                EndStatslabel.Text = "You got " + cpm + " " + "hits" /*+ accuracy + "% accuracy"*/;
            }
            Targetlabel.Visible = false;
            EndStatslabel.Visible = true;
            gamemode = 2;
        }

        private int randomtargetloation(int min, int max)
        {
            return random.Next(max - min) + min;
        }

        private void Targetlabel_Click(object sender, EventArgs e)
        {
            if (ammomag == 0 && gamemodetype ==1) 
            {

            }
            else {
                if (!Startbutton.Visible && gamemodetype == 1)
                {

                    if (guntype == 1)
                    {
                        targethp = targethp - 10;
                        Targetlabel.Text = targethp + " hp";
                    }
                    else
                    {
                        if (guntype == 2)
                        {
                            targethp = targethp - 25;
                            Targetlabel.Text = targethp + " hp";
                        }
                        else
                        {
                            targethp = 0;
                            Targetlabel.Text = targethp + " hp";
                        }
                    }

                    if (targethp <= 0)
                    {

                        targethp = 100;
                        Targetlabel.Text = targethp + "";
                    }
                    shotsfired++;
                    ammomag--;
                    Ammolabel.Text = ammomag + "";
                    cpm++;
                }
                else 
                {
                    if (!Startbutton.Visible && gamemodetype == 2) 
                    {
                        Targetlabel.Location = new Point(randomtargetloation(50, Width - 50), randomtargetloation(50, Height - 50));
                        cpm++;
                    }
                }
                            }
            
        }

        private void Buttonsecond15_Click(object sender, EventArgs e)
        {
            timer1.Interval = 15000;
            EndStatslabel.Text = "You got " + cpm + " " + "clicks per 15 sec";
        }

        private void Buttonsecond30_Click(object sender, EventArgs e)
        {
            timer1.Interval = 30000;
            EndStatslabel.Text = "You got " + cpm + " " + "clicks per 30 sec";
        }

        private void Buttonsecond45_Click(object sender, EventArgs e)
        {
            timer1.Interval = 45000;
            EndStatslabel.Text = "You got " + cpm + " " + "clicks per 45 sec";
        }

        private void Buttonsecond60_Click(object sender, EventArgs e)
        {
            timer1.Interval = 60000;
            EndStatslabel.Text = "You got " + cpm + " " + "clicks per minute";
        }

        private void Fullautobutton_Click(object sender, EventArgs e)
        {
            ammomag = 30;
            magammo = 30;
            totalammo = 180;
            Ammolabel.Text = "30";
            guntype = 1;
        }

        private void Semiautobutton_Click(object sender, EventArgs e)
        {
            ammomag = 12;
            magammo = 12;
            totalammo = 72;
            Ammolabel.Text = "12";
            guntype = 2;
        }

        private void Boltactionbutton_Click(object sender, EventArgs e)
        {
            ammomag = 1;
            magammo = 1;
            totalammo = 20;
            Ammolabel.Text = "1";
            guntype = 3;
        }

        private void Reloadbutton_Click(object sender, EventArgs e)
        {
            totalammo = totalammo - (magammo - ammomag);
            ammomag = magammo;
            Ammolabel.Text = ammomag + "";

        }
    /*    private void Control1_MouseClick(Object sender, MouseEventArgs e) 
        {
           if (gamemode == 1)
            { }
                ammomag--;
                Ammolabel.Text = ammomag + "";
                shotsfired++;
            
            Console.WriteLine("hi");
        } */

        private void Gamemode1button_Click(object sender, EventArgs e)
        {
            startmenuboring(false);
            Playingmenu(false);
            gamemodemenu(false);
            startmenucustomizable(true);
            pickagunmessage(false);
            gamemodetype = 1;
        }

        private void Gamemode2button_Click(object sender, EventArgs e)
        {
            gamemodemenu(false);
            Playingmenu(false);
            startmenucustomizable(false);
            startmenuboring(true);
            pickagunmessage(false);
            gamemodetype = 2;
        }
        private void selectgunmessage_Tick(object sender, EventArgs e)
        {
            pickagunmessage(false);
            selectgunmessage.Enabled = false;
        }
        private void pickagunmessage(bool value) 
        {
            pickagunlabel.Visible = value;
        }
    }
}
