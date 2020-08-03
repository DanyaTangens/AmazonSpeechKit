namespace AmazonSpeechKit
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.settingsGroup = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.voiceGroup = new System.Windows.Forms.GroupBox();
            this.femaleVoice = new System.Windows.Forms.RadioButton();
            this.maleVoice = new System.Windows.Forms.RadioButton();
            this.textGroup = new System.Windows.Forms.GroupBox();
            this.richText = new System.Windows.Forms.RichTextBox();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.settingsGroup.SuspendLayout();
            this.voiceGroup.SuspendLayout();
            this.textGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsGroup
            // 
            this.settingsGroup.Controls.Add(this.button1);
            this.settingsGroup.Controls.Add(this.voiceGroup);
            this.settingsGroup.Location = new System.Drawing.Point(266, 12);
            this.settingsGroup.Name = "settingsGroup";
            this.settingsGroup.Size = new System.Drawing.Size(266, 147);
            this.settingsGroup.TabIndex = 0;
            this.settingsGroup.TabStop = false;
            this.settingsGroup.Text = "Settings";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Go to sound";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // voiceGroup
            // 
            this.voiceGroup.Controls.Add(this.femaleVoice);
            this.voiceGroup.Controls.Add(this.maleVoice);
            this.voiceGroup.Location = new System.Drawing.Point(6, 19);
            this.voiceGroup.Name = "voiceGroup";
            this.voiceGroup.Size = new System.Drawing.Size(244, 64);
            this.voiceGroup.TabIndex = 0;
            this.voiceGroup.TabStop = false;
            this.voiceGroup.Text = "Voices";
            // 
            // femaleVoice
            // 
            this.femaleVoice.AutoSize = true;
            this.femaleVoice.Location = new System.Drawing.Point(155, 29);
            this.femaleVoice.Name = "femaleVoice";
            this.femaleVoice.Size = new System.Drawing.Size(64, 17);
            this.femaleVoice.TabIndex = 1;
            this.femaleVoice.Text = "Tatyana";
            this.femaleVoice.UseVisualStyleBackColor = true;
            this.femaleVoice.CheckedChanged += new System.EventHandler(this.femaleVoice_CheckedChanged);
            // 
            // maleVoice
            // 
            this.maleVoice.AutoSize = true;
            this.maleVoice.Checked = true;
            this.maleVoice.Location = new System.Drawing.Point(6, 29);
            this.maleVoice.Name = "maleVoice";
            this.maleVoice.Size = new System.Drawing.Size(55, 17);
            this.maleVoice.TabIndex = 0;
            this.maleVoice.TabStop = true;
            this.maleVoice.Text = "Maxim";
            this.maleVoice.UseVisualStyleBackColor = true;
            this.maleVoice.CheckedChanged += new System.EventHandler(this.maleVoice_CheckedChanged);
            // 
            // textGroup
            // 
            this.textGroup.Controls.Add(this.richText);
            this.textGroup.Location = new System.Drawing.Point(6, 12);
            this.textGroup.Name = "textGroup";
            this.textGroup.Size = new System.Drawing.Size(254, 147);
            this.textGroup.TabIndex = 1;
            this.textGroup.TabStop = false;
            this.textGroup.Text = "Enter your text...";
            // 
            // richText
            // 
            this.richText.Location = new System.Drawing.Point(6, 19);
            this.richText.MaxLength = 200;
            this.richText.Name = "richText";
            this.richText.Size = new System.Drawing.Size(242, 111);
            this.richText.TabIndex = 0;
            this.richText.Text = "";
            // 
            // saveFile
            // 
            this.saveFile.Filter = "\"Audio files(*.mp3)|*.mp3|All files(*.*)|*.*\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 183);
            this.Controls.Add(this.textGroup);
            this.Controls.Add(this.settingsGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AmazonPolly TTS";
            this.settingsGroup.ResumeLayout(false);
            this.voiceGroup.ResumeLayout(false);
            this.voiceGroup.PerformLayout();
            this.textGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox settingsGroup;
        private System.Windows.Forms.GroupBox voiceGroup;
        private System.Windows.Forms.RadioButton femaleVoice;
        private System.Windows.Forms.RadioButton maleVoice;
        private System.Windows.Forms.GroupBox textGroup;
        private System.Windows.Forms.RichTextBox richText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFile;
    }
}

