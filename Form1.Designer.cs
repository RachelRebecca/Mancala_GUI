namespace Mancala_GUI
{
    partial class Mancala
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelSelectSettings = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btnSelectSettings = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Panel();
            this.randomizedMarbles = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OpponentDifficulty = new System.Windows.Forms.ListBox();
            this.playerGoesFirst = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.background = new System.Windows.Forms.Panel();
            this.playerMessage = new System.Windows.Forms.Label();
            this.computerMessage = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.spot6 = new System.Windows.Forms.Label();
            this.spot5 = new System.Windows.Forms.Label();
            this.spot4 = new System.Windows.Forms.Label();
            this.spot3 = new System.Windows.Forms.Label();
            this.spot2 = new System.Windows.Forms.Label();
            this.spot1 = new System.Windows.Forms.Label();
            this.computerCup = new System.Windows.Forms.Panel();
            this.playerCup = new System.Windows.Forms.Panel();
            this.player6 = new System.Windows.Forms.Panel();
            this.computer1 = new System.Windows.Forms.Panel();
            this.player5 = new System.Windows.Forms.Panel();
            this.player3 = new System.Windows.Forms.Panel();
            this.player4 = new System.Windows.Forms.Panel();
            this.computer2 = new System.Windows.Forms.Panel();
            this.computer4 = new System.Windows.Forms.Panel();
            this.computer3 = new System.Windows.Forms.Panel();
            this.player2 = new System.Windows.Forms.Panel();
            this.computer5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.player1 = new System.Windows.Forms.Panel();
            this.computer6 = new System.Windows.Forms.Panel();
            this.Settings.SuspendLayout();
            this.background.SuspendLayout();
            this.computer5.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSelectSettings
            // 
            this.labelSelectSettings.AutoSize = true;
            this.labelSelectSettings.Location = new System.Drawing.Point(14, 9);
            this.labelSelectSettings.Name = "labelSelectSettings";
            this.labelSelectSettings.Size = new System.Drawing.Size(119, 13);
            this.labelSelectSettings.TabIndex = 8;
            this.labelSelectSettings.Text = "Do you want to go first?";
            // 
            // btnSelectSettings
            // 
            this.btnSelectSettings.Location = new System.Drawing.Point(39, 127);
            this.btnSelectSettings.Name = "btnSelectSettings";
            this.btnSelectSettings.Size = new System.Drawing.Size(134, 23);
            this.btnSelectSettings.TabIndex = 9;
            this.btnSelectSettings.Text = "Ready?";
            this.btnSelectSettings.UseVisualStyleBackColor = true;
            this.btnSelectSettings.Click += new System.EventHandler(this.btnSelectSettings_Click);
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.randomizedMarbles);
            this.Settings.Controls.Add(this.label2);
            this.Settings.Controls.Add(this.label1);
            this.Settings.Controls.Add(this.OpponentDifficulty);
            this.Settings.Controls.Add(this.playerGoesFirst);
            this.Settings.Controls.Add(this.labelSelectSettings);
            this.Settings.Controls.Add(this.btnSelectSettings);
            this.Settings.Location = new System.Drawing.Point(471, 12);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(279, 165);
            this.Settings.TabIndex = 10;
            // 
            // randomizedMarbles
            // 
            this.randomizedMarbles.AutoSize = true;
            this.randomizedMarbles.Location = new System.Drawing.Point(247, 38);
            this.randomizedMarbles.Name = "randomizedMarbles";
            this.randomizedMarbles.Size = new System.Drawing.Size(15, 14);
            this.randomizedMarbles.TabIndex = 14;
            this.randomizedMarbles.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Do you want to use randomly colored marbles?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select Opponent Difficulty Level";
            // 
            // OpponentDifficulty
            // 
            this.OpponentDifficulty.FormattingEnabled = true;
            this.OpponentDifficulty.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.OpponentDifficulty.Location = new System.Drawing.Point(179, 62);
            this.OpponentDifficulty.Name = "OpponentDifficulty";
            this.OpponentDifficulty.Size = new System.Drawing.Size(76, 43);
            this.OpponentDifficulty.TabIndex = 11;
            // 
            // playerGoesFirst
            // 
            this.playerGoesFirst.AutoSize = true;
            this.playerGoesFirst.Location = new System.Drawing.Point(140, 9);
            this.playerGoesFirst.Name = "playerGoesFirst";
            this.playerGoesFirst.Size = new System.Drawing.Size(15, 14);
            this.playerGoesFirst.TabIndex = 10;
            this.playerGoesFirst.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Need help? Get instructions";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // background
            // 
            this.background.BackgroundImage = global::Mancala_GUI.Properties.Resources.MyMancala_small;
            this.background.Controls.Add(this.playerMessage);
            this.background.Controls.Add(this.computerMessage);
            this.background.Controls.Add(this.label14);
            this.background.Controls.Add(this.label13);
            this.background.Controls.Add(this.label12);
            this.background.Controls.Add(this.label11);
            this.background.Controls.Add(this.label10);
            this.background.Controls.Add(this.label9);
            this.background.Controls.Add(this.spot6);
            this.background.Controls.Add(this.spot5);
            this.background.Controls.Add(this.spot4);
            this.background.Controls.Add(this.spot3);
            this.background.Controls.Add(this.spot2);
            this.background.Controls.Add(this.spot1);
            this.background.Controls.Add(this.computerCup);
            this.background.Controls.Add(this.playerCup);
            this.background.Controls.Add(this.player6);
            this.background.Controls.Add(this.computer1);
            this.background.Controls.Add(this.player5);
            this.background.Controls.Add(this.player3);
            this.background.Controls.Add(this.player4);
            this.background.Controls.Add(this.computer2);
            this.background.Controls.Add(this.computer4);
            this.background.Controls.Add(this.computer3);
            this.background.Controls.Add(this.player2);
            this.background.Controls.Add(this.computer5);
            this.background.Controls.Add(this.player1);
            this.background.Controls.Add(this.computer6);
            this.background.Location = new System.Drawing.Point(38, 95);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1232, 463);
            this.background.TabIndex = 0;
            this.background.Visible = false;
            // 
            // playerMessage
            // 
            this.playerMessage.AutoSize = true;
            this.playerMessage.Location = new System.Drawing.Point(469, 439);
            this.playerMessage.Name = "playerMessage";
            this.playerMessage.Size = new System.Drawing.Size(151, 13);
            this.playerMessage.TabIndex = 21;
            this.playerMessage.Text = "Your Turn: Choose Your Move";
            this.playerMessage.Visible = false;
            // 
            // computerMessage
            // 
            this.computerMessage.AccessibleDescription = "";
            this.computerMessage.AutoSize = true;
            this.computerMessage.Location = new System.Drawing.Point(491, 70);
            this.computerMessage.Name = "computerMessage";
            this.computerMessage.Size = new System.Drawing.Size(84, 13);
            this.computerMessage.TabIndex = 20;
            this.computerMessage.Text = "Computer\'s Turn";
            this.computerMessage.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(216, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "6";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(354, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "5";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(469, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "4";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(593, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(729, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(835, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "1";
            // 
            // spot6
            // 
            this.spot6.AutoSize = true;
            this.spot6.Location = new System.Drawing.Point(835, 397);
            this.spot6.Name = "spot6";
            this.spot6.Size = new System.Drawing.Size(13, 13);
            this.spot6.TabIndex = 13;
            this.spot6.Text = "6";
            this.spot6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.spot_MouseClick);
            // 
            // spot5
            // 
            this.spot5.AutoSize = true;
            this.spot5.Location = new System.Drawing.Point(729, 397);
            this.spot5.Name = "spot5";
            this.spot5.Size = new System.Drawing.Size(13, 13);
            this.spot5.TabIndex = 12;
            this.spot5.Text = "5";
            this.spot5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.spot_MouseClick);
            // 
            // spot4
            // 
            this.spot4.AutoSize = true;
            this.spot4.Location = new System.Drawing.Point(593, 397);
            this.spot4.Name = "spot4";
            this.spot4.Size = new System.Drawing.Size(13, 13);
            this.spot4.TabIndex = 11;
            this.spot4.Text = "4";
            this.spot4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.spot_MouseClick);
            // 
            // spot3
            // 
            this.spot3.AutoSize = true;
            this.spot3.Location = new System.Drawing.Point(469, 397);
            this.spot3.Name = "spot3";
            this.spot3.Size = new System.Drawing.Size(13, 13);
            this.spot3.TabIndex = 10;
            this.spot3.Text = "3";
            this.spot3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.spot_MouseClick);
            // 
            // spot2
            // 
            this.spot2.AutoSize = true;
            this.spot2.Location = new System.Drawing.Point(354, 397);
            this.spot2.Name = "spot2";
            this.spot2.Size = new System.Drawing.Size(13, 13);
            this.spot2.TabIndex = 9;
            this.spot2.Text = "2";
            this.spot2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.spot_MouseClick);
            // 
            // spot1
            // 
            this.spot1.AutoSize = true;
            this.spot1.Location = new System.Drawing.Point(216, 397);
            this.spot1.Name = "spot1";
            this.spot1.Size = new System.Drawing.Size(13, 13);
            this.spot1.TabIndex = 8;
            this.spot1.Text = "1";
            this.spot1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.spot_MouseClick);
            // 
            // computerCup
            // 
            this.computerCup.BackgroundImage = global::Mancala_GUI.Properties.Resources.MancalaCup;
            this.computerCup.Location = new System.Drawing.Point(41, 123);
            this.computerCup.Name = "computerCup";
            this.computerCup.Size = new System.Drawing.Size(115, 265);
            this.computerCup.TabIndex = 7;
            // 
            // playerCup
            // 
            this.playerCup.BackgroundImage = global::Mancala_GUI.Properties.Resources.MancalaCup;
            this.playerCup.Location = new System.Drawing.Point(920, 123);
            this.playerCup.Name = "playerCup";
            this.playerCup.Size = new System.Drawing.Size(115, 265);
            this.playerCup.TabIndex = 6;
            // 
            // player6
            // 
            this.player6.BackgroundImage = global::Mancala_GUI.Properties.Resources.individualCup;
            this.player6.Location = new System.Drawing.Point(796, 274);
            this.player6.Name = "player6";
            this.player6.Size = new System.Drawing.Size(120, 120);
            this.player6.TabIndex = 5;
            this.player6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.playerMove_MouseClick);
            // 
            // computer1
            // 
            this.computer1.BackgroundImage = global::Mancala_GUI.Properties.Resources.individualCup;
            this.computer1.Location = new System.Drawing.Point(796, 139);
            this.computer1.Name = "computer1";
            this.computer1.Size = new System.Drawing.Size(120, 120);
            this.computer1.TabIndex = 5;
            // 
            // player5
            // 
            this.player5.BackgroundImage = global::Mancala_GUI.Properties.Resources.individualCup;
            this.player5.Location = new System.Drawing.Point(677, 274);
            this.player5.Name = "player5";
            this.player5.Size = new System.Drawing.Size(120, 120);
            this.player5.TabIndex = 4;
            this.player5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.playerMove_MouseClick);
            // 
            // player3
            // 
            this.player3.BackgroundImage = global::Mancala_GUI.Properties.Resources.individualCup;
            this.player3.Location = new System.Drawing.Point(415, 274);
            this.player3.Name = "player3";
            this.player3.Size = new System.Drawing.Size(120, 120);
            this.player3.TabIndex = 5;
            this.player3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.playerMove_MouseClick);
            // 
            // player4
            // 
            this.player4.BackgroundImage = global::Mancala_GUI.Properties.Resources.individualCup;
            this.player4.Location = new System.Drawing.Point(549, 274);
            this.player4.Name = "player4";
            this.player4.Size = new System.Drawing.Size(120, 120);
            this.player4.TabIndex = 3;
            this.player4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.playerMove_MouseClick);
            // 
            // computer2
            // 
            this.computer2.BackgroundImage = global::Mancala_GUI.Properties.Resources.individualCup;
            this.computer2.Location = new System.Drawing.Point(669, 139);
            this.computer2.Name = "computer2";
            this.computer2.Size = new System.Drawing.Size(120, 120);
            this.computer2.TabIndex = 4;
            // 
            // computer4
            // 
            this.computer4.BackgroundImage = global::Mancala_GUI.Properties.Resources.individualCup;
            this.computer4.Location = new System.Drawing.Point(415, 139);
            this.computer4.Name = "computer4";
            this.computer4.Size = new System.Drawing.Size(120, 120);
            this.computer4.TabIndex = 2;
            // 
            // computer3
            // 
            this.computer3.BackgroundImage = global::Mancala_GUI.Properties.Resources.individualCup;
            this.computer3.Location = new System.Drawing.Point(549, 139);
            this.computer3.Name = "computer3";
            this.computer3.Size = new System.Drawing.Size(120, 120);
            this.computer3.TabIndex = 3;
            // 
            // player2
            // 
            this.player2.BackgroundImage = global::Mancala_GUI.Properties.Resources.individualCup;
            this.player2.Location = new System.Drawing.Point(296, 274);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(120, 120);
            this.player2.TabIndex = 4;
            this.player2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.playerMove_MouseClick);
            // 
            // computer5
            // 
            this.computer5.BackgroundImage = global::Mancala_GUI.Properties.Resources.individualCup;
            this.computer5.Controls.Add(this.panel2);
            this.computer5.Location = new System.Drawing.Point(296, 139);
            this.computer5.Name = "computer5";
            this.computer5.Size = new System.Drawing.Size(120, 120);
            this.computer5.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(119, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(66, 163);
            this.panel2.TabIndex = 1;
            // 
            // player1
            // 
            this.player1.BackgroundImage = global::Mancala_GUI.Properties.Resources.individualCup;
            this.player1.Location = new System.Drawing.Point(168, 274);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(120, 120);
            this.player1.TabIndex = 3;
            this.player1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.playerMove_MouseClick);
            // 
            // computer6
            // 
            this.computer6.BackgroundImage = global::Mancala_GUI.Properties.Resources.individualCup;
            this.computer6.Location = new System.Drawing.Point(168, 139);
            this.computer6.Name = "computer6";
            this.computer6.Size = new System.Drawing.Size(120, 120);
            this.computer6.TabIndex = 0;
            // 
            // Mancala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 594);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.background);
            this.Name = "Mancala";
            this.Text = "Mancala";
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            this.computer5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel background;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Panel computer6;
        private System.Windows.Forms.Panel computer5;
        private System.Windows.Forms.Panel player6;
        private System.Windows.Forms.Panel computer1;
        private System.Windows.Forms.Panel player5;
        private System.Windows.Forms.Panel player3;
        private System.Windows.Forms.Panel player4;
        private System.Windows.Forms.Panel computer2;
        private System.Windows.Forms.Panel computer4;
        private System.Windows.Forms.Panel computer3;
        private System.Windows.Forms.Panel player2;
        private System.Windows.Forms.Panel player1;
        private System.Windows.Forms.Panel computerCup;
        private System.Windows.Forms.Panel playerCup;
        private System.Windows.Forms.Label labelSelectSettings;
        private System.Windows.Forms.Button btnSelectSettings;
        private System.Windows.Forms.Panel Settings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox OpponentDifficulty;
        private System.Windows.Forms.CheckBox playerGoesFirst;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label spot6;
        private System.Windows.Forms.Label spot5;
        private System.Windows.Forms.Label spot4;
        private System.Windows.Forms.Label spot3;
        private System.Windows.Forms.Label spot2;
        private System.Windows.Forms.Label spot1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox randomizedMarbles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label playerMessage;
        private System.Windows.Forms.Label computerMessage;
    }
}

