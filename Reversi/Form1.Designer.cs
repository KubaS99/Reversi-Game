namespace Reversi
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.blackLabel = new System.Windows.Forms.Label();
            this.whiteLabel = new System.Windows.Forms.Label();
            this.turnLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.easyRadio = new System.Windows.Forms.RadioButton();
            this.difficultyBox = new System.Windows.Forms.GroupBox();
            this.hardRadio = new System.Windows.Forms.RadioButton();
            this.mediumRadio = new System.Windows.Forms.RadioButton();
            this.compRadio = new System.Windows.Forms.RadioButton();
            this.twoPlayerRadio = new System.Windows.Forms.RadioButton();
            this.gameModeBox = new System.Windows.Forms.GroupBox();
            this.playButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.soundPictureBox = new System.Windows.Forms.PictureBox();
            this.noSoundPictureBox = new System.Windows.Forms.PictureBox();
            this.menuButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.endLabel = new System.Windows.Forms.Label();
            this.blockPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.difficultyBox.SuspendLayout();
            this.gameModeBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soundPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noSoundPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(24, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // blackLabel
            // 
            this.blackLabel.BackColor = System.Drawing.Color.Transparent;
            this.blackLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackLabel.Location = new System.Drawing.Point(51, 20);
            this.blackLabel.Name = "blackLabel";
            this.blackLabel.Size = new System.Drawing.Size(77, 19);
            this.blackLabel.TabIndex = 1;
            this.blackLabel.Text = "Black: 2";
            this.blackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // whiteLabel
            // 
            this.whiteLabel.BackColor = System.Drawing.Color.Transparent;
            this.whiteLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.whiteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whiteLabel.Location = new System.Drawing.Point(307, 20);
            this.whiteLabel.Name = "whiteLabel";
            this.whiteLabel.Size = new System.Drawing.Size(79, 19);
            this.whiteLabel.TabIndex = 2;
            this.whiteLabel.Text = "White: 2 ";
            this.whiteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // turnLabel
            // 
            this.turnLabel.BackColor = System.Drawing.Color.Transparent;
            this.turnLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.turnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnLabel.Location = new System.Drawing.Point(149, 20);
            this.turnLabel.Name = "turnLabel";
            this.turnLabel.Size = new System.Drawing.Size(137, 19);
            this.turnLabel.TabIndex = 4;
            this.turnLabel.Text = "Black\'s turn";
            this.turnLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Reversi.Properties.Resources.geometry_background;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(448, 487);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.titleLabel.Location = new System.Drawing.Point(99, 50);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(244, 77);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "Reversi";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(10, 0);
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.MidnightBlue;
            this.linkLabel1.Location = new System.Drawing.Point(367, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(71, 19);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.Text = "About game";
            this.linkLabel1.UseCompatibleTextRendering = true;
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // easyRadio
            // 
            this.easyRadio.AutoSize = true;
            this.easyRadio.Location = new System.Drawing.Point(3, 33);
            this.easyRadio.Name = "easyRadio";
            this.easyRadio.Size = new System.Drawing.Size(83, 33);
            this.easyRadio.TabIndex = 8;
            this.easyRadio.Text = "Easy";
            this.easyRadio.UseVisualStyleBackColor = true;
            // 
            // difficultyBox
            // 
            this.difficultyBox.BackColor = System.Drawing.Color.Transparent;
            this.difficultyBox.Controls.Add(this.hardRadio);
            this.difficultyBox.Controls.Add(this.mediumRadio);
            this.difficultyBox.Controls.Add(this.easyRadio);
            this.difficultyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.difficultyBox.Location = new System.Drawing.Point(246, 151);
            this.difficultyBox.Name = "difficultyBox";
            this.difficultyBox.Size = new System.Drawing.Size(180, 159);
            this.difficultyBox.TabIndex = 9;
            this.difficultyBox.TabStop = false;
            this.difficultyBox.Text = "Difficulty:";
            // 
            // hardRadio
            // 
            this.hardRadio.AutoSize = true;
            this.hardRadio.Location = new System.Drawing.Point(3, 113);
            this.hardRadio.Name = "hardRadio";
            this.hardRadio.Size = new System.Drawing.Size(83, 33);
            this.hardRadio.TabIndex = 10;
            this.hardRadio.Text = "Hard";
            this.hardRadio.UseVisualStyleBackColor = true;
            // 
            // mediumRadio
            // 
            this.mediumRadio.AutoSize = true;
            this.mediumRadio.Checked = true;
            this.mediumRadio.Location = new System.Drawing.Point(3, 73);
            this.mediumRadio.Name = "mediumRadio";
            this.mediumRadio.Size = new System.Drawing.Size(118, 33);
            this.mediumRadio.TabIndex = 9;
            this.mediumRadio.TabStop = true;
            this.mediumRadio.Text = "Medium";
            this.mediumRadio.UseVisualStyleBackColor = true;
            // 
            // compRadio
            // 
            this.compRadio.AutoSize = true;
            this.compRadio.Checked = true;
            this.compRadio.Location = new System.Drawing.Point(6, 33);
            this.compRadio.Name = "compRadio";
            this.compRadio.Size = new System.Drawing.Size(137, 33);
            this.compRadio.TabIndex = 10;
            this.compRadio.TabStop = true;
            this.compRadio.Text = "Computer";
            this.compRadio.UseVisualStyleBackColor = true;
            // 
            // twoPlayerRadio
            // 
            this.twoPlayerRadio.AutoSize = true;
            this.twoPlayerRadio.Location = new System.Drawing.Point(6, 66);
            this.twoPlayerRadio.Name = "twoPlayerRadio";
            this.twoPlayerRadio.Size = new System.Drawing.Size(128, 33);
            this.twoPlayerRadio.TabIndex = 11;
            this.twoPlayerRadio.Text = "2 players";
            this.twoPlayerRadio.UseVisualStyleBackColor = true;
            // 
            // gameModeBox
            // 
            this.gameModeBox.BackColor = System.Drawing.Color.Transparent;
            this.gameModeBox.Controls.Add(this.compRadio);
            this.gameModeBox.Controls.Add(this.twoPlayerRadio);
            this.gameModeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameModeBox.Location = new System.Drawing.Point(24, 151);
            this.gameModeBox.Name = "gameModeBox";
            this.gameModeBox.Size = new System.Drawing.Size(192, 112);
            this.gameModeBox.TabIndex = 12;
            this.gameModeBox.TabStop = false;
            this.gameModeBox.Text = "Game mode:";
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.playButton.Location = new System.Drawing.Point(292, 389);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(156, 98);
            this.playButton.TabIndex = 14;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(0, 389);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(156, 98);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // soundPictureBox
            // 
            this.soundPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.soundPictureBox.BackgroundImage = global::Reversi.Properties.Resources.speaker;
            this.soundPictureBox.Location = new System.Drawing.Point(406, 23);
            this.soundPictureBox.Name = "soundPictureBox";
            this.soundPictureBox.Size = new System.Drawing.Size(20, 20);
            this.soundPictureBox.TabIndex = 16;
            this.soundPictureBox.TabStop = false;
            this.soundPictureBox.Click += new System.EventHandler(this.soundPictureBox_Click);
            // 
            // noSoundPictureBox
            // 
            this.noSoundPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.noSoundPictureBox.BackgroundImage = global::Reversi.Properties.Resources.noSpeaker;
            this.noSoundPictureBox.Location = new System.Drawing.Point(406, 23);
            this.noSoundPictureBox.Name = "noSoundPictureBox";
            this.noSoundPictureBox.Size = new System.Drawing.Size(20, 20);
            this.noSoundPictureBox.TabIndex = 17;
            this.noSoundPictureBox.TabStop = false;
            this.noSoundPictureBox.Visible = false;
            this.noSoundPictureBox.Click += new System.EventHandler(this.noSpeakerPictureBox_Click);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Transparent;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Location = new System.Drawing.Point(172, 452);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(104, 35);
            this.menuButton.TabIndex = 18;
            this.menuButton.Text = "Back to menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "save";
            this.saveFileDialog1.FileName = "reversi.save";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "save";
            this.openFileDialog1.FileName = "reversi.save";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Transparent;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(24, 452);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(104, 35);
            this.saveButton.TabIndex = 19;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.Color.Transparent;
            this.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButton.Location = new System.Drawing.Point(320, 452);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(104, 35);
            this.loadButton.TabIndex = 20;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // endLabel
            // 
            this.endLabel.BackColor = System.Drawing.Color.Transparent;
            this.endLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.endLabel.Location = new System.Drawing.Point(0, 151);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(448, 181);
            this.endLabel.TabIndex = 21;
            this.endLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.endLabel.Visible = false;
            // 
            // blockPictureBox
            // 
            this.blockPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.blockPictureBox.BackgroundImage = global::Reversi.Properties.Resources.block;
            this.blockPictureBox.Location = new System.Drawing.Point(5, 5);
            this.blockPictureBox.Name = "blockPictureBox";
            this.blockPictureBox.Size = new System.Drawing.Size(40, 40);
            this.blockPictureBox.TabIndex = 22;
            this.blockPictureBox.TabStop = false;
            this.blockPictureBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Reversi.Properties.Resources.geometry_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(448, 488);
            this.Controls.Add(this.blockPictureBox);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.noSoundPictureBox);
            this.Controls.Add(this.soundPictureBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.gameModeBox);
            this.Controls.Add(this.difficultyBox);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.turnLabel);
            this.Controls.Add(this.whiteLabel);
            this.Controls.Add(this.blackLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.loadButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Reversi 296745";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.difficultyBox.ResumeLayout(false);
            this.difficultyBox.PerformLayout();
            this.gameModeBox.ResumeLayout(false);
            this.gameModeBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soundPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noSoundPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label blackLabel;
        private System.Windows.Forms.Label whiteLabel;
        private System.Windows.Forms.Label turnLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.RadioButton easyRadio;
        private System.Windows.Forms.GroupBox difficultyBox;
        private System.Windows.Forms.RadioButton hardRadio;
        private System.Windows.Forms.RadioButton mediumRadio;
        private System.Windows.Forms.RadioButton compRadio;
        private System.Windows.Forms.RadioButton twoPlayerRadio;
        private System.Windows.Forms.GroupBox gameModeBox;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox soundPictureBox;
        private System.Windows.Forms.PictureBox noSoundPictureBox;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.PictureBox blockPictureBox;
    }
}

