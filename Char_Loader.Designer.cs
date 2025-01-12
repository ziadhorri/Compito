namespace Compito
{
    partial class Char_Loader
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
            Bg_charSelection = new PictureBox();
            selectedChar = new PictureBox();
            Btn_back = new Button();
            Btn_take = new Button();
            Btn_create = new Button();
            Btn_arrowL = new Button();
            Btn_arrowR = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)Bg_charSelection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)selectedChar).BeginInit();
            SuspendLayout();
            // 
            // Bg_charSelection
            // 
            Bg_charSelection.Dock = DockStyle.Fill;
            Bg_charSelection.Image = Properties.Resources.Bg_CharSelect;
            Bg_charSelection.Location = new Point(0, 0);
            Bg_charSelection.Name = "Bg_charSelection";
            Bg_charSelection.Size = new Size(800, 600);
            Bg_charSelection.SizeMode = PictureBoxSizeMode.AutoSize;
            Bg_charSelection.TabIndex = 0;
            Bg_charSelection.TabStop = false;
            // 
            // selectedChar
            // 
            selectedChar.Image = Properties.Resources.Natalia;
            selectedChar.Location = new Point(51, 42);
            selectedChar.Name = "selectedChar";
            selectedChar.Size = new Size(695, 299);
            selectedChar.SizeMode = PictureBoxSizeMode.StretchImage;
            selectedChar.TabIndex = 1;
            selectedChar.TabStop = false;
            // 
            // Btn_back
            // 
            Btn_back.BackgroundImage = Properties.Resources.Btn_Back;
            Btn_back.FlatAppearance.BorderSize = 0;
            Btn_back.FlatStyle = FlatStyle.Flat;
            Btn_back.Location = new Point(525, 524);
            Btn_back.Name = "Btn_back";
            Btn_back.Size = new Size(154, 23);
            Btn_back.TabIndex = 2;
            Btn_back.UseVisualStyleBackColor = true;
            Btn_back.Click += Btn_back_Click;
            // 
            // Btn_take
            // 
            Btn_take.BackgroundImage = Properties.Resources.Btb_Take;
            Btn_take.FlatAppearance.BorderSize = 0;
            Btn_take.FlatStyle = FlatStyle.Flat;
            Btn_take.Location = new Point(113, 397);
            Btn_take.Name = "Btn_take";
            Btn_take.Size = new Size(151, 23);
            Btn_take.TabIndex = 3;
            Btn_take.UseVisualStyleBackColor = true;
            Btn_take.Click += Btn_take_Click;
            // 
            // Btn_create
            // 
            Btn_create.BackgroundImage = Properties.Resources.Btn_Create;
            Btn_create.FlatAppearance.BorderSize = 0;
            Btn_create.FlatStyle = FlatStyle.Flat;
            Btn_create.Location = new Point(113, 524);
            Btn_create.Name = "Btn_create";
            Btn_create.Size = new Size(154, 23);
            Btn_create.TabIndex = 4;
            Btn_create.UseVisualStyleBackColor = true;
            Btn_create.Click += Btn_create_Click;
            // 
            // Btn_arrowL
            // 
            Btn_arrowL.BackgroundImage = Properties.Resources.Btn_ArrowL;
            Btn_arrowL.FlatAppearance.BorderSize = 0;
            Btn_arrowL.FlatStyle = FlatStyle.Flat;
            Btn_arrowL.Location = new Point(361, 406);
            Btn_arrowL.Name = "Btn_arrowL";
            Btn_arrowL.Size = new Size(30, 24);
            Btn_arrowL.TabIndex = 5;
            Btn_arrowL.UseVisualStyleBackColor = true;
            Btn_arrowL.Click += Btn_arrowL_Click;
            // 
            // Btn_arrowR
            // 
            Btn_arrowR.BackgroundImage = Properties.Resources.Btn_ArrowR;
            Btn_arrowR.FlatAppearance.BorderSize = 0;
            Btn_arrowR.FlatStyle = FlatStyle.Flat;
            Btn_arrowR.Location = new Point(412, 406);
            Btn_arrowR.Name = "Btn_arrowR";
            Btn_arrowR.Size = new Size(30, 24);
            Btn_arrowR.TabIndex = 6;
            Btn_arrowR.UseVisualStyleBackColor = true;
            Btn_arrowR.Click += Btn_arrowR_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Char_Loader
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 600);
            Controls.Add(Btn_arrowR);
            Controls.Add(Btn_arrowL);
            Controls.Add(Btn_create);
            Controls.Add(Btn_take);
            Controls.Add(Btn_back);
            Controls.Add(selectedChar);
            Controls.Add(Bg_charSelection);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Char_Loader";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Character Selection";
            ((System.ComponentModel.ISupportInitialize)Bg_charSelection).EndInit();
            ((System.ComponentModel.ISupportInitialize)selectedChar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Bg_charSelection;
        private PictureBox selectedChar;
        private Button Btn_back;
        private Button Btn_take;
        private Button Btn_create;
        private Button Btn_arrowL;
        private Button Btn_arrowR;
        private OpenFileDialog openFileDialog1;
    }
}