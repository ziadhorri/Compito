namespace Compito
{
    partial class Main_Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            Main_Bg = new PictureBox();
            Main_Bar = new PictureBox();
            Btn_CreateChar = new Button();
            Btn_Intro = new Button();
            Btn_Exit = new Button();
            Btn_NewGame = new Button();
            Btn_LoadGame = new Button();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)Main_Bg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Main_Bar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // Main_Bg
            // 
            Main_Bg.Dock = DockStyle.Fill;
            Main_Bg.Image = Properties.Resources.PnlKMU4;
            Main_Bg.ImageLocation = "";
            Main_Bg.Location = new Point(0, 0);
            Main_Bg.Name = "Main_Bg";
            Main_Bg.Size = new Size(821, 502);
            Main_Bg.SizeMode = PictureBoxSizeMode.StretchImage;
            Main_Bg.TabIndex = 0;
            Main_Bg.TabStop = false;
            // 
            // Main_Bar
            // 
            Main_Bar.Image = Properties.Resources.Immagine_2025_01_05_165824;
            Main_Bar.ImageLocation = "";
            Main_Bar.Location = new Point(513, 31);
            Main_Bar.Name = "Main_Bar";
            Main_Bar.Size = new Size(216, 235);
            Main_Bar.TabIndex = 1;
            Main_Bar.TabStop = false;
            // 
            // Btn_CreateChar
            // 
            Btn_CreateChar.BackColor = Color.Transparent;
            Btn_CreateChar.BackgroundImage = Properties.Resources.Bg_choice;
            Btn_CreateChar.FlatAppearance.BorderSize = 0;
            Btn_CreateChar.FlatStyle = FlatStyle.Flat;
            Btn_CreateChar.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_CreateChar.ForeColor = Color.Gold;
            Btn_CreateChar.Location = new Point(529, 91);
            Btn_CreateChar.Name = "Btn_CreateChar";
            Btn_CreateChar.Size = new Size(185, 33);
            Btn_CreateChar.TabIndex = 2;
            Btn_CreateChar.Text = "NEW CHARACTER";
            Btn_CreateChar.UseVisualStyleBackColor = false;
            Btn_CreateChar.Click += Btn_CreateChar_Click;
            // 
            // Btn_Intro
            // 
            Btn_Intro.BackColor = Color.Transparent;
            Btn_Intro.BackgroundImage = Properties.Resources.Bg_choice;
            Btn_Intro.FlatAppearance.BorderSize = 0;
            Btn_Intro.FlatStyle = FlatStyle.Flat;
            Btn_Intro.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Intro.ForeColor = Color.Gold;
            Btn_Intro.Location = new Point(529, 51);
            Btn_Intro.Name = "Btn_Intro";
            Btn_Intro.Size = new Size(185, 34);
            Btn_Intro.TabIndex = 3;
            Btn_Intro.Text = "INTRO";
            Btn_Intro.UseVisualStyleBackColor = false;
            Btn_Intro.Click += Btn_Intro_Click;
            // 
            // Btn_Exit
            // 
            Btn_Exit.BackColor = Color.Transparent;
            Btn_Exit.BackgroundImage = Properties.Resources.Bg_choice;
            Btn_Exit.FlatAppearance.BorderSize = 0;
            Btn_Exit.FlatStyle = FlatStyle.Flat;
            Btn_Exit.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Exit.ForeColor = Color.Gold;
            Btn_Exit.Location = new Point(529, 214);
            Btn_Exit.Name = "Btn_Exit";
            Btn_Exit.Size = new Size(185, 33);
            Btn_Exit.TabIndex = 4;
            Btn_Exit.Text = "EXIT";
            Btn_Exit.UseVisualStyleBackColor = false;
            Btn_Exit.Click += Btn_Exit_Click;
            // 
            // Btn_NewGame
            // 
            Btn_NewGame.BackColor = Color.Transparent;
            Btn_NewGame.BackgroundImage = Properties.Resources.Bg_choice;
            Btn_NewGame.FlatAppearance.BorderSize = 0;
            Btn_NewGame.FlatStyle = FlatStyle.Flat;
            Btn_NewGame.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_NewGame.ForeColor = Color.Gold;
            Btn_NewGame.Location = new Point(529, 130);
            Btn_NewGame.Name = "Btn_NewGame";
            Btn_NewGame.Size = new Size(185, 33);
            Btn_NewGame.TabIndex = 5;
            Btn_NewGame.Text = "NEW GAME";
            Btn_NewGame.UseVisualStyleBackColor = false;
            // 
            // Btn_LoadGame
            // 
            Btn_LoadGame.BackColor = Color.Transparent;
            Btn_LoadGame.BackgroundImage = Properties.Resources.Bg_choice;
            Btn_LoadGame.FlatAppearance.BorderSize = 0;
            Btn_LoadGame.FlatStyle = FlatStyle.Flat;
            Btn_LoadGame.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_LoadGame.ForeColor = Color.Gold;
            Btn_LoadGame.Location = new Point(529, 175);
            Btn_LoadGame.Name = "Btn_LoadGame";
            Btn_LoadGame.Size = new Size(185, 33);
            Btn_LoadGame.TabIndex = 6;
            Btn_LoadGame.Text = "LOAD GAME";
            Btn_LoadGame.UseVisualStyleBackColor = false;
            Btn_LoadGame.Click += Btn_LoadGame_Click;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(12, 12);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(220, 108);
            axWindowsMediaPlayer1.TabIndex = 7;
            axWindowsMediaPlayer1.Visible = false;
            // 
            // Main_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 502);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(Btn_LoadGame);
            Controls.Add(Btn_NewGame);
            Controls.Add(Btn_Exit);
            Controls.Add(Btn_Intro);
            Controls.Add(Btn_CreateChar);
            Controls.Add(Main_Bar);
            Controls.Add(Main_Bg);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main_Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FALLOUT NEW ITIS";
            FormClosed += Main_Menu_FormClosed;
            ((System.ComponentModel.ISupportInitialize)Main_Bg).EndInit();
            ((System.ComponentModel.ISupportInitialize)Main_Bar).EndInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Main_Bg;
        private PictureBox Main_Bar;
        private Button Btn_CreateChar;
        private Button Btn_Intro;
        private Button Btn_Exit;
        private Button Btn_NewGame;
        private Button Btn_LoadGame;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}
