namespace Game_of_Pig
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dicePictureBox = new System.Windows.Forms.PictureBox();
            this.totalScorelabel = new System.Windows.Forms.Label();
            this.rollButton = new System.Windows.Forms.Button();
            this.keepButton = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.turn1Label = new System.Windows.Forms.Label();
            this.turn1ScoreLabel = new System.Windows.Forms.Label();
            this.turn2Label = new System.Windows.Forms.Label();
            this.turn2ScoreLabel = new System.Windows.Forms.Label();
            this.turn3Label = new System.Windows.Forms.Label();
            this.turn3ScoreLabel = new System.Windows.Forms.Label();
            this.turn4Label = new System.Windows.Forms.Label();
            this.turn4ScoreLabel = new System.Windows.Forms.Label();
            this.turn5Label = new System.Windows.Forms.Label();
            this.turn5ScoreLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dicePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dicePictureBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 175);
            this.panel1.TabIndex = 0;
            // 
            // dicePictureBox
            // 
            this.dicePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.dicePictureBox.Location = new System.Drawing.Point(23, 23);
            this.dicePictureBox.Name = "dicePictureBox";
            this.dicePictureBox.Size = new System.Drawing.Size(125, 125);
            this.dicePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dicePictureBox.TabIndex = 0;
            this.dicePictureBox.TabStop = false;
            // 
            // totalScorelabel
            // 
            this.totalScorelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalScorelabel.Location = new System.Drawing.Point(225, 9);
            this.totalScorelabel.Name = "totalScorelabel";
            this.totalScorelabel.Size = new System.Drawing.Size(156, 73);
            this.totalScorelabel.TabIndex = 1;
            this.totalScorelabel.Text = "0";
            this.totalScorelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rollButton
            // 
            this.rollButton.BackColor = System.Drawing.SystemColors.Control;
            this.rollButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.rollButton.FlatAppearance.BorderSize = 3;
            this.rollButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rollButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rollButton.Location = new System.Drawing.Point(12, 193);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(81, 35);
            this.rollButton.TabIndex = 0;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = false;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // keepButton
            // 
            this.keepButton.BackColor = System.Drawing.SystemColors.Control;
            this.keepButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.keepButton.FlatAppearance.BorderSize = 3;
            this.keepButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.keepButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.keepButton.Location = new System.Drawing.Point(106, 193);
            this.keepButton.Name = "keepButton";
            this.keepButton.Size = new System.Drawing.Size(81, 35);
            this.keepButton.TabIndex = 1;
            this.keepButton.Text = "Keep Score";
            this.keepButton.UseVisualStyleBackColor = false;
            this.keepButton.Click += new System.EventHandler(this.keepButton_Click);
            // 
            // newGameButton
            // 
            this.newGameButton.BackColor = System.Drawing.SystemColors.Control;
            this.newGameButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.newGameButton.FlatAppearance.BorderSize = 3;
            this.newGameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newGameButton.Location = new System.Drawing.Point(12, 234);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(81, 35);
            this.newGameButton.TabIndex = 2;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = false;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.SystemColors.Control;
            this.helpButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.helpButton.FlatAppearance.BorderSize = 3;
            this.helpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.helpButton.Location = new System.Drawing.Point(106, 234);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(81, 35);
            this.helpButton.TabIndex = 3;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.SystemColors.Control;
            this.quitButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.quitButton.FlatAppearance.BorderSize = 3;
            this.quitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.quitButton.Location = new System.Drawing.Point(61, 275);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(81, 35);
            this.quitButton.TabIndex = 4;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // turn1Label
            // 
            this.turn1Label.AutoSize = true;
            this.turn1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turn1Label.Location = new System.Drawing.Point(221, 113);
            this.turn1Label.Name = "turn1Label";
            this.turn1Label.Size = new System.Drawing.Size(54, 20);
            this.turn1Label.TabIndex = 3;
            this.turn1Label.Text = "Turn 1";
            // 
            // turn1ScoreLabel
            // 
            this.turn1ScoreLabel.BackColor = System.Drawing.SystemColors.Control;
            this.turn1ScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.turn1ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turn1ScoreLabel.Location = new System.Drawing.Point(281, 108);
            this.turn1ScoreLabel.Name = "turn1ScoreLabel";
            this.turn1ScoreLabel.Size = new System.Drawing.Size(100, 30);
            this.turn1ScoreLabel.TabIndex = 4;
            this.turn1ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // turn2Label
            // 
            this.turn2Label.AutoSize = true;
            this.turn2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turn2Label.Location = new System.Drawing.Point(221, 157);
            this.turn2Label.Name = "turn2Label";
            this.turn2Label.Size = new System.Drawing.Size(54, 20);
            this.turn2Label.TabIndex = 3;
            this.turn2Label.Text = "Turn 2";
            // 
            // turn2ScoreLabel
            // 
            this.turn2ScoreLabel.BackColor = System.Drawing.SystemColors.Control;
            this.turn2ScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.turn2ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turn2ScoreLabel.Location = new System.Drawing.Point(281, 152);
            this.turn2ScoreLabel.Name = "turn2ScoreLabel";
            this.turn2ScoreLabel.Size = new System.Drawing.Size(100, 30);
            this.turn2ScoreLabel.TabIndex = 4;
            this.turn2ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // turn3Label
            // 
            this.turn3Label.AutoSize = true;
            this.turn3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turn3Label.Location = new System.Drawing.Point(221, 199);
            this.turn3Label.Name = "turn3Label";
            this.turn3Label.Size = new System.Drawing.Size(54, 20);
            this.turn3Label.TabIndex = 3;
            this.turn3Label.Text = "Turn 3";
            // 
            // turn3ScoreLabel
            // 
            this.turn3ScoreLabel.BackColor = System.Drawing.SystemColors.Control;
            this.turn3ScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.turn3ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turn3ScoreLabel.Location = new System.Drawing.Point(281, 194);
            this.turn3ScoreLabel.Name = "turn3ScoreLabel";
            this.turn3ScoreLabel.Size = new System.Drawing.Size(100, 30);
            this.turn3ScoreLabel.TabIndex = 4;
            this.turn3ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // turn4Label
            // 
            this.turn4Label.AutoSize = true;
            this.turn4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turn4Label.Location = new System.Drawing.Point(221, 240);
            this.turn4Label.Name = "turn4Label";
            this.turn4Label.Size = new System.Drawing.Size(54, 20);
            this.turn4Label.TabIndex = 3;
            this.turn4Label.Text = "Turn 4";
            // 
            // turn4ScoreLabel
            // 
            this.turn4ScoreLabel.BackColor = System.Drawing.SystemColors.Control;
            this.turn4ScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.turn4ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turn4ScoreLabel.Location = new System.Drawing.Point(281, 235);
            this.turn4ScoreLabel.Name = "turn4ScoreLabel";
            this.turn4ScoreLabel.Size = new System.Drawing.Size(100, 30);
            this.turn4ScoreLabel.TabIndex = 4;
            this.turn4ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // turn5Label
            // 
            this.turn5Label.AutoSize = true;
            this.turn5Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turn5Label.Location = new System.Drawing.Point(221, 281);
            this.turn5Label.Name = "turn5Label";
            this.turn5Label.Size = new System.Drawing.Size(54, 20);
            this.turn5Label.TabIndex = 3;
            this.turn5Label.Text = "Turn 5";
            // 
            // turn5ScoreLabel
            // 
            this.turn5ScoreLabel.BackColor = System.Drawing.SystemColors.Control;
            this.turn5ScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.turn5ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turn5ScoreLabel.Location = new System.Drawing.Point(281, 276);
            this.turn5ScoreLabel.Name = "turn5ScoreLabel";
            this.turn5ScoreLabel.Size = new System.Drawing.Size(100, 30);
            this.turn5ScoreLabel.TabIndex = 4;
            this.turn5ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 321);
            this.Controls.Add(this.turn5ScoreLabel);
            this.Controls.Add(this.turn5Label);
            this.Controls.Add(this.turn4ScoreLabel);
            this.Controls.Add(this.turn4Label);
            this.Controls.Add(this.turn3ScoreLabel);
            this.Controls.Add(this.turn3Label);
            this.Controls.Add(this.turn2ScoreLabel);
            this.Controls.Add(this.turn2Label);
            this.Controls.Add(this.turn1ScoreLabel);
            this.Controls.Add(this.turn1Label);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.keepButton);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.totalScorelabel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameForm";
            this.Text = "The Game of Pig";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dicePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox dicePictureBox;
        private System.Windows.Forms.Label totalScorelabel;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Button keepButton;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label turn1Label;
        private System.Windows.Forms.Label turn1ScoreLabel;
        private System.Windows.Forms.Label turn2Label;
        private System.Windows.Forms.Label turn2ScoreLabel;
        private System.Windows.Forms.Label turn3Label;
        private System.Windows.Forms.Label turn3ScoreLabel;
        private System.Windows.Forms.Label turn4Label;
        private System.Windows.Forms.Label turn4ScoreLabel;
        private System.Windows.Forms.Label turn5Label;
        private System.Windows.Forms.Label turn5ScoreLabel;
    }
}

