namespace Csharpstringsassessment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnTune = new System.Windows.Forms.Button();
            this.btnLesson = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.tbxCharlie = new System.Windows.Forms.TextBox();
            this.tmrSoundStop = new System.Windows.Forms.Timer(this.components);
            this.tmrViolin1 = new System.Windows.Forms.Timer(this.components);
            this.tmrViolin2 = new System.Windows.Forms.Timer(this.components);
            this.tmrViolin3 = new System.Windows.Forms.Timer(this.components);
            this.tmrViolin4 = new System.Windows.Forms.Timer(this.components);
            this.tmrViolin5 = new System.Windows.Forms.Timer(this.components);
            this.tmrViolin6 = new System.Windows.Forms.Timer(this.components);
            this.tbxFinish = new System.Windows.Forms.TextBox();
            this.PbGoodbye = new System.Windows.Forms.PictureBox();
            this.pbCharlie = new System.Windows.Forms.PictureBox();
            this.tmrScreech = new System.Windows.Forms.Timer(this.components);
            this.lblCharlie = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblEnjoy = new System.Windows.Forms.Label();
            this.lblNotEnjoy = new System.Windows.Forms.Label();
            this.LblWin = new System.Windows.Forms.Label();
            this.lblLose = new System.Windows.Forms.Label();
            this.btnLessonLeft = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbGoodbye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCharlie)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTune
            // 
            this.btnTune.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTune.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTune.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTune.Location = new System.Drawing.Point(12, 12);
            this.btnTune.Name = "btnTune";
            this.btnTune.Size = new System.Drawing.Size(143, 83);
            this.btnTune.TabIndex = 0;
            this.btnTune.Text = "\"Tune Strings\"";
            this.btnTune.UseVisualStyleBackColor = false;
            this.btnTune.Click += new System.EventHandler(this.btnTune_Click);
            // 
            // btnLesson
            // 
            this.btnLesson.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLesson.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLesson.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLesson.Location = new System.Drawing.Point(12, 205);
            this.btnLesson.Name = "btnLesson";
            this.btnLesson.Size = new System.Drawing.Size(143, 83);
            this.btnLesson.TabIndex = 2;
            this.btnLesson.Text = "\"Take Lesson\"";
            this.btnLesson.UseVisualStyleBackColor = false;
            this.btnLesson.Visible = false;
            this.btnLesson.Click += new System.EventHandler(this.btnLesson_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSelect.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelect.Location = new System.Drawing.Point(12, 107);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(143, 83);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "\"Select Music\"";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Visible = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPlay.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlay.Location = new System.Drawing.Point(12, 328);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(143, 83);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "\"Play\"";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Visible = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // tbxCharlie
            // 
            this.tbxCharlie.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbxCharlie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharlie.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCharlie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbxCharlie.Location = new System.Drawing.Point(161, 69);
            this.tbxCharlie.Multiline = true;
            this.tbxCharlie.Name = "tbxCharlie";
            this.tbxCharlie.Size = new System.Drawing.Size(208, 191);
            this.tbxCharlie.TabIndex = 8;
            this.tbxCharlie.Text = "  ";
            this.tbxCharlie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tmrSoundStop
            // 
            this.tmrSoundStop.Interval = 4500;
            this.tmrSoundStop.Tick += new System.EventHandler(this.tmrSoundStop_Tick);
            // 
            // tmrViolin1
            // 
            this.tmrViolin1.Interval = 5000;
            this.tmrViolin1.Tick += new System.EventHandler(this.tmrViolin1_Tick);
            // 
            // tmrViolin2
            // 
            this.tmrViolin2.Interval = 6000;
            this.tmrViolin2.Tick += new System.EventHandler(this.tmrViolin2_Tick);
            // 
            // tmrViolin3
            // 
            this.tmrViolin3.Interval = 6000;
            this.tmrViolin3.Tick += new System.EventHandler(this.tmrViolin3_Tick);
            // 
            // tmrViolin4
            // 
            this.tmrViolin4.Interval = 4000;
            this.tmrViolin4.Tick += new System.EventHandler(this.tmrViolin4_Tick);
            // 
            // tmrViolin5
            // 
            this.tmrViolin5.Interval = 6000;
            this.tmrViolin5.Tick += new System.EventHandler(this.tmrViolin5_Tick);
            // 
            // tmrViolin6
            // 
            this.tmrViolin6.Interval = 6000;
            this.tmrViolin6.Tick += new System.EventHandler(this.tmrViolin6_Tick);
            // 
            // tbxFinish
            // 
            this.tbxFinish.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbxFinish.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxFinish.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFinish.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbxFinish.Location = new System.Drawing.Point(149, 101);
            this.tbxFinish.Multiline = true;
            this.tbxFinish.Name = "tbxFinish";
            this.tbxFinish.Size = new System.Drawing.Size(206, 106);
            this.tbxFinish.TabIndex = 9;
            this.tbxFinish.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxFinish.Visible = false;
            // 
            // PbGoodbye
            // 
            this.PbGoodbye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbGoodbye.Image = global::Csharpstringsassessment.Properties.Resources.ChaplinEdit;
            this.PbGoodbye.Location = new System.Drawing.Point(426, 28);
            this.PbGoodbye.Name = "PbGoodbye";
            this.PbGoodbye.Size = new System.Drawing.Size(317, 402);
            this.PbGoodbye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbGoodbye.TabIndex = 10;
            this.PbGoodbye.TabStop = false;
            this.PbGoodbye.Visible = false;
            // 
            // pbCharlie
            // 
            this.pbCharlie.BackColor = System.Drawing.SystemColors.Control;
            this.pbCharlie.Enabled = false;
            this.pbCharlie.Image = global::Csharpstringsassessment.Properties.Resources.playing_violin_animated_gif_2;
            this.pbCharlie.Location = new System.Drawing.Point(361, 12);
            this.pbCharlie.Name = "pbCharlie";
            this.pbCharlie.Size = new System.Drawing.Size(420, 427);
            this.pbCharlie.TabIndex = 1;
            this.pbCharlie.TabStop = false;
            // 
            // tmrScreech
            // 
            this.tmrScreech.Interval = 3000;
            this.tmrScreech.Tick += new System.EventHandler(this.tmrScreech_Tick);
            // 
            // lblCharlie
            // 
            this.lblCharlie.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharlie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCharlie.Location = new System.Drawing.Point(77, 98);
            this.lblCharlie.Name = "lblCharlie";
            this.lblCharlie.Size = new System.Drawing.Size(278, 183);
            this.lblCharlie.TabIndex = 11;
            this.lblCharlie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCharlie.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReset.Font = new System.Drawing.Font("Bookman Old Style", 14F);
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(112, 371);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(165, 102);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "\"Press to bring Charlie back for more practice.\"";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblEnjoy
            // 
            this.lblEnjoy.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEnjoy.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnjoy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEnjoy.Location = new System.Drawing.Point(466, 442);
            this.lblEnjoy.Name = "lblEnjoy";
            this.lblEnjoy.Size = new System.Drawing.Size(32, 31);
            this.lblEnjoy.TabIndex = 13;
            this.lblEnjoy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblEnjoy.Visible = false;
            // 
            // lblNotEnjoy
            // 
            this.lblNotEnjoy.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNotEnjoy.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotEnjoy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNotEnjoy.Location = new System.Drawing.Point(649, 445);
            this.lblNotEnjoy.Name = "lblNotEnjoy";
            this.lblNotEnjoy.Size = new System.Drawing.Size(35, 28);
            this.lblNotEnjoy.TabIndex = 14;
            this.lblNotEnjoy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNotEnjoy.Visible = false;
            // 
            // LblWin
            // 
            this.LblWin.AutoSize = true;
            this.LblWin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblWin.Location = new System.Drawing.Point(374, 445);
            this.LblWin.Name = "LblWin";
            this.LblWin.Size = new System.Drawing.Size(86, 13);
            this.LblWin.TabIndex = 15;
            this.LblWin.Text = "Enjoyed practice";
            this.LblWin.Visible = false;
            // 
            // lblLose
            // 
            this.lblLose.AutoSize = true;
            this.lblLose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLose.Location = new System.Drawing.Point(533, 445);
            this.lblLose.Name = "lblLose";
            this.lblLose.Size = new System.Drawing.Size(110, 13);
            this.lblLose.TabIndex = 16;
            this.lblLose.Text = "Did not enjoy practice";
            this.lblLose.Visible = false;
            // 
            // btnLessonLeft
            // 
            this.btnLessonLeft.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLessonLeft.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLessonLeft.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLessonLeft.Location = new System.Drawing.Point(12, 205);
            this.btnLessonLeft.Name = "btnLessonLeft";
            this.btnLessonLeft.Size = new System.Drawing.Size(137, 82);
            this.btnLessonLeft.TabIndex = 17;
            this.btnLessonLeft.Text = "\"One lesson left.\"";
            this.btnLessonLeft.UseVisualStyleBackColor = false;
            this.btnLessonLeft.Visible = false;
            this.btnLessonLeft.Click += new System.EventHandler(this.btnLessonLeft_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInstructions.Location = new System.Drawing.Point(12, 120);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(343, 248);
            this.lblInstructions.TabIndex = 18;
            this.lblInstructions.Text = resources.GetString("lblInstructions.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(783, 494);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnLessonLeft);
            this.Controls.Add(this.lblLose);
            this.Controls.Add(this.LblWin);
            this.Controls.Add(this.lblNotEnjoy);
            this.Controls.Add(this.lblEnjoy);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblCharlie);
            this.Controls.Add(this.tbxCharlie);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnLesson);
            this.Controls.Add(this.pbCharlie);
            this.Controls.Add(this.btnTune);
            this.Controls.Add(this.PbGoodbye);
            this.Controls.Add(this.tbxFinish);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PbGoodbye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCharlie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCharlie;
        private System.Windows.Forms.Button btnTune;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnLesson;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox tbxCharlie;
        private System.Windows.Forms.Timer tmrSoundStop;
        private System.Windows.Forms.Timer tmrViolin1;
        private System.Windows.Forms.Timer tmrViolin2;
        private System.Windows.Forms.Timer tmrViolin3;
        private System.Windows.Forms.Timer tmrViolin4;
        private System.Windows.Forms.Timer tmrViolin5;
        private System.Windows.Forms.Timer tmrViolin6;
        private System.Windows.Forms.TextBox tbxFinish;
        private System.Windows.Forms.PictureBox PbGoodbye;
        private System.Windows.Forms.Timer tmrScreech;
        public System.Windows.Forms.Label lblCharlie;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNotEnjoy;
        private System.Windows.Forms.Label lblEnjoy;
        private System.Windows.Forms.Label LblWin;
        private System.Windows.Forms.Label lblLose;
        private System.Windows.Forms.Button btnLessonLeft;
        private System.Windows.Forms.Label lblInstructions;
    }
}

