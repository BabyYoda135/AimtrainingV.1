
namespace AimLab
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Easybutton = new System.Windows.Forms.Button();
            this.Intermediatebutton = new System.Windows.Forms.Button();
            this.Hardbutton = new System.Windows.Forms.Button();
            this.Impossiblebutton = new System.Windows.Forms.Button();
            this.Startbutton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Targetlabel = new System.Windows.Forms.Label();
            this.EndStatslabel = new System.Windows.Forms.Label();
            this.Buttonsecond15 = new System.Windows.Forms.Button();
            this.Buttonsecond30 = new System.Windows.Forms.Button();
            this.Buttonsecond45 = new System.Windows.Forms.Button();
            this.Buttonsecond60 = new System.Windows.Forms.Button();
            this.Autoshottimer = new System.Windows.Forms.Timer(this.components);
            this.Fullautobutton = new System.Windows.Forms.Button();
            this.Boltactionbutton = new System.Windows.Forms.Button();
            this.Semiautobutton = new System.Windows.Forms.Button();
            this.Reloadbutton = new System.Windows.Forms.Button();
            this.Ammolabel = new System.Windows.Forms.Label();
            this.Gamemode1button = new System.Windows.Forms.Button();
            this.Gamemode2button = new System.Windows.Forms.Button();
            this.Boltactiontimer = new System.Windows.Forms.Timer(this.components);
            this.selectgunmessage = new System.Windows.Forms.Timer(this.components);
            this.pickagunlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Easybutton
            // 
            this.Easybutton.Location = new System.Drawing.Point(61, 36);
            this.Easybutton.Name = "Easybutton";
            this.Easybutton.Size = new System.Drawing.Size(103, 36);
            this.Easybutton.TabIndex = 1;
            this.Easybutton.Text = "Easy";
            this.Easybutton.UseVisualStyleBackColor = true;
            this.Easybutton.Click += new System.EventHandler(this.Easybutton_Click);
            // 
            // Intermediatebutton
            // 
            this.Intermediatebutton.Location = new System.Drawing.Point(250, 36);
            this.Intermediatebutton.Name = "Intermediatebutton";
            this.Intermediatebutton.Size = new System.Drawing.Size(113, 36);
            this.Intermediatebutton.TabIndex = 2;
            this.Intermediatebutton.Text = "Intermediate";
            this.Intermediatebutton.UseVisualStyleBackColor = true;
            this.Intermediatebutton.Click += new System.EventHandler(this.Intermediatebutton_Click);
            // 
            // Hardbutton
            // 
            this.Hardbutton.Location = new System.Drawing.Point(457, 36);
            this.Hardbutton.Name = "Hardbutton";
            this.Hardbutton.Size = new System.Drawing.Size(103, 36);
            this.Hardbutton.TabIndex = 3;
            this.Hardbutton.Text = "Hard";
            this.Hardbutton.UseVisualStyleBackColor = true;
            this.Hardbutton.Click += new System.EventHandler(this.Hardbutton_Click);
            // 
            // Impossiblebutton
            // 
            this.Impossiblebutton.Location = new System.Drawing.Point(669, 36);
            this.Impossiblebutton.Name = "Impossiblebutton";
            this.Impossiblebutton.Size = new System.Drawing.Size(106, 36);
            this.Impossiblebutton.TabIndex = 4;
            this.Impossiblebutton.Text = "Impossible";
            this.Impossiblebutton.UseVisualStyleBackColor = true;
            this.Impossiblebutton.Click += new System.EventHandler(this.Impossiblebutton_Click);
            // 
            // Startbutton
            // 
            this.Startbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Startbutton.Location = new System.Drawing.Point(318, 352);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(176, 66);
            this.Startbutton.TabIndex = 5;
            this.Startbutton.Text = "START";
            this.Startbutton.UseVisualStyleBackColor = true;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Targetlabel
            // 
            this.Targetlabel.AutoSize = true;
            this.Targetlabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Targetlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Targetlabel.Location = new System.Drawing.Point(365, 251);
            this.Targetlabel.Name = "Targetlabel";
            this.Targetlabel.Size = new System.Drawing.Size(85, 29);
            this.Targetlabel.TabIndex = 6;
            this.Targetlabel.Text = "100 hp";
            this.Targetlabel.Click += new System.EventHandler(this.Targetlabel_Click);
            // 
            // EndStatslabel
            // 
            this.EndStatslabel.AutoSize = true;
            this.EndStatslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.EndStatslabel.Location = new System.Drawing.Point(296, 153);
            this.EndStatslabel.Name = "EndStatslabel";
            this.EndStatslabel.Size = new System.Drawing.Size(0, 36);
            this.EndStatslabel.TabIndex = 7;
            this.EndStatslabel.Visible = false;
            // 
            // Buttonsecond15
            // 
            this.Buttonsecond15.Location = new System.Drawing.Point(61, 98);
            this.Buttonsecond15.Name = "Buttonsecond15";
            this.Buttonsecond15.Size = new System.Drawing.Size(103, 36);
            this.Buttonsecond15.TabIndex = 8;
            this.Buttonsecond15.Text = "15 seconds";
            this.Buttonsecond15.UseVisualStyleBackColor = true;
            this.Buttonsecond15.Click += new System.EventHandler(this.Buttonsecond15_Click);
            // 
            // Buttonsecond30
            // 
            this.Buttonsecond30.Location = new System.Drawing.Point(250, 99);
            this.Buttonsecond30.Name = "Buttonsecond30";
            this.Buttonsecond30.Size = new System.Drawing.Size(113, 36);
            this.Buttonsecond30.TabIndex = 9;
            this.Buttonsecond30.Text = "30 seconds";
            this.Buttonsecond30.UseVisualStyleBackColor = true;
            this.Buttonsecond30.Click += new System.EventHandler(this.Buttonsecond30_Click);
            // 
            // Buttonsecond45
            // 
            this.Buttonsecond45.Location = new System.Drawing.Point(457, 99);
            this.Buttonsecond45.Name = "Buttonsecond45";
            this.Buttonsecond45.Size = new System.Drawing.Size(103, 35);
            this.Buttonsecond45.TabIndex = 10;
            this.Buttonsecond45.Text = "45 seconds";
            this.Buttonsecond45.UseVisualStyleBackColor = true;
            this.Buttonsecond45.Click += new System.EventHandler(this.Buttonsecond45_Click);
            // 
            // Buttonsecond60
            // 
            this.Buttonsecond60.Location = new System.Drawing.Point(669, 99);
            this.Buttonsecond60.Name = "Buttonsecond60";
            this.Buttonsecond60.Size = new System.Drawing.Size(106, 35);
            this.Buttonsecond60.TabIndex = 11;
            this.Buttonsecond60.Text = "60 seconds";
            this.Buttonsecond60.UseVisualStyleBackColor = true;
            this.Buttonsecond60.Click += new System.EventHandler(this.Buttonsecond60_Click);
            // 
            // Autoshottimer
            // 
            this.Autoshottimer.Interval = 500;
            // 
            // Fullautobutton
            // 
            this.Fullautobutton.Location = new System.Drawing.Point(168, 166);
            this.Fullautobutton.Name = "Fullautobutton";
            this.Fullautobutton.Size = new System.Drawing.Size(75, 54);
            this.Fullautobutton.TabIndex = 12;
            this.Fullautobutton.Text = "Full auto";
            this.Fullautobutton.UseVisualStyleBackColor = true;
            this.Fullautobutton.Click += new System.EventHandler(this.Fullautobutton_Click);
            // 
            // Boltactionbutton
            // 
            this.Boltactionbutton.Location = new System.Drawing.Point(578, 166);
            this.Boltactionbutton.Name = "Boltactionbutton";
            this.Boltactionbutton.Size = new System.Drawing.Size(75, 54);
            this.Boltactionbutton.TabIndex = 13;
            this.Boltactionbutton.Text = "Bolt Action";
            this.Boltactionbutton.UseVisualStyleBackColor = true;
            this.Boltactionbutton.Click += new System.EventHandler(this.Boltactionbutton_Click);
            // 
            // Semiautobutton
            // 
            this.Semiautobutton.Location = new System.Drawing.Point(370, 166);
            this.Semiautobutton.Name = "Semiautobutton";
            this.Semiautobutton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Semiautobutton.Size = new System.Drawing.Size(75, 54);
            this.Semiautobutton.TabIndex = 14;
            this.Semiautobutton.Text = "Semi Auto";
            this.Semiautobutton.UseVisualStyleBackColor = true;
            this.Semiautobutton.Click += new System.EventHandler(this.Semiautobutton_Click);
            // 
            // Reloadbutton
            // 
            this.Reloadbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reloadbutton.Location = new System.Drawing.Point(693, 370);
            this.Reloadbutton.Name = "Reloadbutton";
            this.Reloadbutton.Size = new System.Drawing.Size(95, 48);
            this.Reloadbutton.TabIndex = 15;
            this.Reloadbutton.Text = "Reload";
            this.Reloadbutton.UseVisualStyleBackColor = true;
            this.Reloadbutton.Click += new System.EventHandler(this.Reloadbutton_Click);
            // 
            // Ammolabel
            // 
            this.Ammolabel.AutoSize = true;
            this.Ammolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Ammolabel.Location = new System.Drawing.Point(573, 379);
            this.Ammolabel.Name = "Ammolabel";
            this.Ammolabel.Size = new System.Drawing.Size(82, 29);
            this.Ammolabel.TabIndex = 16;
            this.Ammolabel.Text = "Ammo";
            // 
            // Gamemode1button
            // 
            this.Gamemode1button.Location = new System.Drawing.Point(266, 112);
            this.Gamemode1button.Name = "Gamemode1button";
            this.Gamemode1button.Size = new System.Drawing.Size(117, 38);
            this.Gamemode1button.TabIndex = 17;
            this.Gamemode1button.Text = "Customizable";
            this.Gamemode1button.UseVisualStyleBackColor = true;
            this.Gamemode1button.Click += new System.EventHandler(this.Gamemode1button_Click);
            // 
            // Gamemode2button
            // 
            this.Gamemode2button.Location = new System.Drawing.Point(485, 112);
            this.Gamemode2button.Name = "Gamemode2button";
            this.Gamemode2button.Size = new System.Drawing.Size(86, 38);
            this.Gamemode2button.TabIndex = 18;
            this.Gamemode2button.Text = "Boring";
            this.Gamemode2button.UseVisualStyleBackColor = true;
            this.Gamemode2button.Click += new System.EventHandler(this.Gamemode2button_Click);
            // 
            // Boltactiontimer
            // 
            this.Boltactiontimer.Interval = 2000;
            // 
            // selectgunmessage
            // 
            this.selectgunmessage.Interval = 2000;
            this.selectgunmessage.Tick += new System.EventHandler(this.selectgunmessage_Tick);
            // 
            // pickagunlabel
            // 
            this.pickagunlabel.AutoSize = true;
            this.pickagunlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.pickagunlabel.Location = new System.Drawing.Point(111, 151);
            this.pickagunlabel.Name = "pickagunlabel";
            this.pickagunlabel.Size = new System.Drawing.Size(606, 69);
            this.pickagunlabel.TabIndex = 19;
            this.pickagunlabel.Text = "pick a gun stupid smh";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pickagunlabel);
            this.Controls.Add(this.Gamemode2button);
            this.Controls.Add(this.Gamemode1button);
            this.Controls.Add(this.Ammolabel);
            this.Controls.Add(this.Reloadbutton);
            this.Controls.Add(this.Semiautobutton);
            this.Controls.Add(this.Boltactionbutton);
            this.Controls.Add(this.Fullautobutton);
            this.Controls.Add(this.Buttonsecond60);
            this.Controls.Add(this.Buttonsecond45);
            this.Controls.Add(this.Buttonsecond30);
            this.Controls.Add(this.Buttonsecond15);
            this.Controls.Add(this.EndStatslabel);
            this.Controls.Add(this.Targetlabel);
            this.Controls.Add(this.Startbutton);
            this.Controls.Add(this.Impossiblebutton);
            this.Controls.Add(this.Hardbutton);
            this.Controls.Add(this.Intermediatebutton);
            this.Controls.Add(this.Easybutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Easybutton;
        private System.Windows.Forms.Button Intermediatebutton;
        private System.Windows.Forms.Button Hardbutton;
        private System.Windows.Forms.Button Impossiblebutton;
        private System.Windows.Forms.Button Startbutton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Targetlabel;
        private System.Windows.Forms.Label EndStatslabel;
        private System.Windows.Forms.Button Buttonsecond15;
        private System.Windows.Forms.Button Buttonsecond30;
        private System.Windows.Forms.Button Buttonsecond45;
        private System.Windows.Forms.Button Buttonsecond60;
        private System.Windows.Forms.Timer Autoshottimer;
        private System.Windows.Forms.Button Fullautobutton;
        private System.Windows.Forms.Button Boltactionbutton;
        private System.Windows.Forms.Button Semiautobutton;
        private System.Windows.Forms.Button Reloadbutton;
        private System.Windows.Forms.Label Ammolabel;
        private System.Windows.Forms.Button Gamemode1button;
        private System.Windows.Forms.Button Gamemode2button;
        private System.Windows.Forms.Timer Boltactiontimer;
        private System.Windows.Forms.Timer selectgunmessage;
        private System.Windows.Forms.Label pickagunlabel;
    }
}

