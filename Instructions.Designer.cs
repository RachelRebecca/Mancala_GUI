namespace Mancala_GUI
{
    partial class Instructions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instructions));
            this.rulesPage2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rulesPage3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rulesPage1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rulesPage2.SuspendLayout();
            this.rulesPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.rulesPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rulesPage2
            // 
            this.rulesPage2.BackColor = System.Drawing.Color.White;
            this.rulesPage2.Controls.Add(this.button2);
            this.rulesPage2.Controls.Add(this.label12);
            this.rulesPage2.Controls.Add(this.label11);
            this.rulesPage2.Controls.Add(this.label10);
            this.rulesPage2.Controls.Add(this.label9);
            this.rulesPage2.Controls.Add(this.label8);
            this.rulesPage2.Controls.Add(this.label7);
            this.rulesPage2.Controls.Add(this.label6);
            this.rulesPage2.Location = new System.Drawing.Point(140, 3);
            this.rulesPage2.Name = "rulesPage2";
            this.rulesPage2.Size = new System.Drawing.Size(514, 412);
            this.rulesPage2.TabIndex = 2;
            this.rulesPage2.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(326, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "See More Rules";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(34, 314);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(396, 56);
            this.label12.TabIndex = 6;
            this.label12.Text = resources.GetString("label12.Text");
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(34, 261);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(396, 26);
            this.label11.TabIndex = 5;
            this.label11.Text = "5. If the last stone of a move lands in the player\'s mancala (left for computer, " +
    "right for human player), that player goes again.";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(34, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(396, 49);
            this.label10.TabIndex = 4;
            this.label10.Text = resources.GetString("label10.Text");
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(34, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(396, 41);
            this.label9.TabIndex = 3;
            this.label9.Text = "3. While distributing the stones, computer skips the mancala at right, and the hu" +
    "man player skips the mancala at left.";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(34, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(396, 48);
            this.label8.TabIndex = 2;
            this.label8.Text = "2. Each move consists of picking up all the stones in any (non-empty) circle and " +
    "distributing them in a counterclockwise direction to the next pits: one stone to" +
    " each consecutive circle. ";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(34, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(396, 33);
            this.label7.TabIndex = 1;
            this.label7.Text = "1. Human player can only move the stones from the bottom row.  Computer can only " +
    "move the stones from the top row.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(412, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Computer and human player take turns moving stones according to the following rul" +
    "es:";
            // 
            // rulesPage3
            // 
            this.rulesPage3.BackColor = System.Drawing.Color.White;
            this.rulesPage3.Controls.Add(this.button3);
            this.rulesPage3.Controls.Add(this.pictureBox2);
            this.rulesPage3.Controls.Add(this.label14);
            this.rulesPage3.Controls.Add(this.pictureBox1);
            this.rulesPage3.Controls.Add(this.label13);
            this.rulesPage3.Location = new System.Drawing.Point(12, 12);
            this.rulesPage3.Name = "rulesPage3";
            this.rulesPage3.Size = new System.Drawing.Size(776, 431);
            this.rulesPage3.TabIndex = 3;
            this.rulesPage3.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(84, 335);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 74);
            this.button3.TabIndex = 4;
            this.button3.Text = "Ready to continue playing?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Mancala_GUI.Properties.Resources.SelectMove;
            this.pictureBox2.Location = new System.Drawing.Point(362, 243);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(259, 185);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(64, 213);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(470, 62);
            this.label14.TabIndex = 2;
            this.label14.Text = "To make a move, click on the cup numbers in the bottom row to empty that cup of i" +
    "ts marbles and make the move with that cup.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mancala_GUI.Properties.Resources.StarterBoard_small;
            this.pictureBox1.Location = new System.Drawing.Point(84, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 147);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(58, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(337, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Each player starts with 4 marbles in each cup, except for the mancala.";
            // 
            // rulesPage1
            // 
            this.rulesPage1.BackgroundImage = global::Mancala_GUI.Properties.Resources.MyMancala_resized;
            this.rulesPage1.Controls.Add(this.label5);
            this.rulesPage1.Controls.Add(this.label4);
            this.rulesPage1.Controls.Add(this.button1);
            this.rulesPage1.Controls.Add(this.label3);
            this.rulesPage1.Controls.Add(this.label2);
            this.rulesPage1.Controls.Add(this.label1);
            this.rulesPage1.Location = new System.Drawing.Point(73, 21);
            this.rulesPage1.Name = "rulesPage1";
            this.rulesPage1.Size = new System.Drawing.Size(645, 332);
            this.rulesPage1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(551, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "      Your          Mancala";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(41, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Opponent\'s     Mancala";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(528, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "See More Rules";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(494, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "The object of the game is to get more marbles in your mancala (yours is at the ri" +
    "ght) than your opponent.";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(611, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "The six small circles on the bottom row of the board belong to you (the human pla" +
    "yer), and the top row belongs to the computer (your opponent).";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(620, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "The mancala board consists of 2 rows. There are six circles in each row, and a la" +
    "rger circle, the mancala, is located on either end. ";
            // 
            // Instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rulesPage3);
            this.Controls.Add(this.rulesPage2);
            this.Controls.Add(this.rulesPage1);
            this.Name = "Instructions";
            this.Text = "Instructions";
            this.rulesPage2.ResumeLayout(false);
            this.rulesPage2.PerformLayout();
            this.rulesPage3.ResumeLayout(false);
            this.rulesPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.rulesPage1.ResumeLayout(false);
            this.rulesPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel rulesPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel rulesPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel rulesPage3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button3;
    }
}