namespace craftersmine.MinecraftLauncher
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.clientsBox = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.settingsBtn = new System.Windows.Forms.PictureBox();
            this.contBtn = new LollipopButton();
            this.cancelBtn = new LollipopButton();
            this.filecounter = new LollipopLabel();
            this.filesizeLabel = new LollipopLabel();
            this.progress = new LollipopProgressBar();
            this.status = new LollipopLabel();
            this.register = new LollipopButton();
            this.siteBtn = new LollipopButton();
            this.auth = new LollipopButton();
            this.lollipopLabel2 = new LollipopLabel();
            this.rememberPass = new LollipopCheckBox();
            this.passwordBox = new LollipopTextBox();
            this.loginBox = new LollipopTextBox();
            this.launchTitle = new LollipopLabel();
            this.verLnch = new LollipopLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // clientsBox
            // 
            this.clientsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.clientsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientsBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientsBox.ForeColor = System.Drawing.Color.White;
            this.clientsBox.FormattingEnabled = true;
            this.clientsBox.Location = new System.Drawing.Point(14, 240);
            this.clientsBox.Name = "clientsBox";
            this.clientsBox.Size = new System.Drawing.Size(331, 21);
            this.clientsBox.TabIndex = 6;
            this.clientsBox.SelectedValueChanged += new System.EventHandler(this.clientsBox_SelectedValueChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::craftersmine.MinecraftLauncher.Properties.Resources.password;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(12, 139);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::craftersmine.MinecraftLauncher.Properties.Resources.user;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.launchTitle);
            this.panel1.Controls.Add(this.settingsBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 42);
            this.panel1.TabIndex = 0;
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.settingsBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingsBtn.BackgroundImage")));
            this.settingsBtn.Location = new System.Drawing.Point(315, 0);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(42, 42);
            this.settingsBtn.TabIndex = 5;
            this.settingsBtn.TabStop = false;
            this.settingsBtn.Click += new System.EventHandler(this.settings_Click);
            // 
            // contBtn
            // 
            this.contBtn.BackColor = System.Drawing.Color.Transparent;
            this.contBtn.BGColor = "#00e676";
            this.contBtn.FontColor = "#ffffff";
            this.contBtn.Location = new System.Drawing.Point(14, 440);
            this.contBtn.Name = "contBtn";
            this.contBtn.Size = new System.Drawing.Size(213, 29);
            this.contBtn.TabIndex = 16;
            this.contBtn.Text = "Продолжить";
            this.contBtn.Visible = false;
            this.contBtn.Click += new System.EventHandler(this.contBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.BGColor = "#4CAF50";
            this.cancelBtn.FontColor = "#ffffff";
            this.cancelBtn.Location = new System.Drawing.Point(233, 440);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(112, 29);
            this.cancelBtn.TabIndex = 15;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.Visible = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // filecounter
            // 
            this.filecounter.BackColor = System.Drawing.Color.Transparent;
            this.filecounter.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.filecounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.filecounter.Location = new System.Drawing.Point(245, 438);
            this.filecounter.Name = "filecounter";
            this.filecounter.Size = new System.Drawing.Size(100, 23);
            this.filecounter.TabIndex = 14;
            this.filecounter.Text = "{flCounter}";
            this.filecounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.filecounter.Visible = false;
            // 
            // filesizeLabel
            // 
            this.filesizeLabel.AutoSize = true;
            this.filesizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.filesizeLabel.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.filesizeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.filesizeLabel.Location = new System.Drawing.Point(12, 440);
            this.filesizeLabel.Name = "filesizeLabel";
            this.filesizeLabel.Size = new System.Drawing.Size(55, 19);
            this.filesizeLabel.TabIndex = 13;
            this.filesizeLabel.Text = "{flSize}";
            this.filesizeLabel.Visible = false;
            // 
            // progress
            // 
            this.progress.BGColor = "#4CAF50";
            this.progress.Location = new System.Drawing.Point(14, 462);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(331, 4);
            this.progress.TabIndex = 12;
            this.progress.Value = 0;
            this.progress.Visible = false;
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.status.Location = new System.Drawing.Point(12, 356);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(333, 81);
            this.status.TabIndex = 11;
            this.status.Text = "{status}";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.status.Visible = false;
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.Transparent;
            this.register.BGColor = "#00e676";
            this.register.FontColor = "#ffffff";
            this.register.Location = new System.Drawing.Point(14, 315);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(331, 29);
            this.register.TabIndex = 10;
            this.register.Text = "Зарегистрироваться";
            // 
            // siteBtn
            // 
            this.siteBtn.BackColor = System.Drawing.Color.Transparent;
            this.siteBtn.BGColor = "#00e676";
            this.siteBtn.FontColor = "#ffffff";
            this.siteBtn.Location = new System.Drawing.Point(14, 472);
            this.siteBtn.Name = "siteBtn";
            this.siteBtn.Size = new System.Drawing.Size(331, 29);
            this.siteBtn.TabIndex = 9;
            this.siteBtn.Text = "Сайт Проекта";
            // 
            // auth
            // 
            this.auth.BackColor = System.Drawing.Color.Transparent;
            this.auth.BGColor = "#4CAF50";
            this.auth.Enabled = false;
            this.auth.FontColor = "#ffffff";
            this.auth.Location = new System.Drawing.Point(14, 280);
            this.auth.Name = "auth";
            this.auth.Size = new System.Drawing.Size(331, 29);
            this.auth.TabIndex = 8;
            this.auth.Text = "Авторизоваться";
            this.auth.Click += new System.EventHandler(this.auth_Click);
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.AutoSize = true;
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel2.Location = new System.Drawing.Point(12, 218);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(60, 19);
            this.lollipopLabel2.TabIndex = 7;
            this.lollipopLabel2.Text = "Клиент:";
            // 
            // rememberPass
            // 
            this.rememberPass.AutoSize = true;
            this.rememberPass.CheckColor = "#4CAF50";
            this.rememberPass.Location = new System.Drawing.Point(14, 164);
            this.rememberPass.Name = "rememberPass";
            this.rememberPass.Size = new System.Drawing.Size(146, 20);
            this.rememberPass.TabIndex = 5;
            this.rememberPass.Text = "Запомнить пароль";
            this.rememberPass.UseVisualStyleBackColor = true;
            // 
            // passwordBox
            // 
            this.passwordBox.FocusedColor = "#4CAF50";
            this.passwordBox.FontColor = "#999999";
            this.passwordBox.IsEnabled = true;
            this.passwordBox.Location = new System.Drawing.Point(35, 134);
            this.passwordBox.MaxLength = 32767;
            this.passwordBox.Multiline = false;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.ReadOnly = false;
            this.passwordBox.Size = new System.Drawing.Size(310, 24);
            this.passwordBox.TabIndex = 4;
            this.passwordBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // loginBox
            // 
            this.loginBox.FocusedColor = "#4CAF50";
            this.loginBox.FontColor = "#999999";
            this.loginBox.IsEnabled = true;
            this.loginBox.Location = new System.Drawing.Point(35, 104);
            this.loginBox.MaxLength = 32767;
            this.loginBox.Multiline = false;
            this.loginBox.Name = "loginBox";
            this.loginBox.ReadOnly = false;
            this.loginBox.Size = new System.Drawing.Size(310, 24);
            this.loginBox.TabIndex = 2;
            this.loginBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.loginBox.UseSystemPasswordChar = false;
            this.loginBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginBox_KeyPress);
            this.loginBox.Leave += new System.EventHandler(this.loginBox_Leave);
            // 
            // launchTitle
            // 
            this.launchTitle.AutoSize = true;
            this.launchTitle.BackColor = System.Drawing.Color.Transparent;
            this.launchTitle.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.launchTitle.ForeColor = System.Drawing.Color.White;
            this.launchTitle.Location = new System.Drawing.Point(10, 11);
            this.launchTitle.Name = "launchTitle";
            this.launchTitle.Size = new System.Drawing.Size(96, 19);
            this.launchTitle.TabIndex = 6;
            this.launchTitle.Text = "LauncherTitle";
            // 
            // verLnch
            // 
            this.verLnch.AutoSize = true;
            this.verLnch.BackColor = System.Drawing.Color.Transparent;
            this.verLnch.Font = new System.Drawing.Font("Roboto Medium", 8F);
            this.verLnch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.verLnch.Location = new System.Drawing.Point(0, 498);
            this.verLnch.Name = "verLnch";
            this.verLnch.Size = new System.Drawing.Size(31, 15);
            this.verLnch.TabIndex = 17;
            this.verLnch.Text = "{ver}";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(357, 513);
            this.Controls.Add(this.contBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.filecounter);
            this.Controls.Add(this.filesizeLabel);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.status);
            this.Controls.Add(this.register);
            this.Controls.Add(this.siteBtn);
            this.Controls.Add(this.auth);
            this.Controls.Add(this.lollipopLabel2);
            this.Controls.Add(this.clientsBox);
            this.Controls.Add(this.rememberPass);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.verLnch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private LollipopTextBox loginBox;
        private LollipopTextBox passwordBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox settingsBtn;
        private LollipopLabel launchTitle;
        private LollipopCheckBox rememberPass;
        private System.Windows.Forms.ComboBox clientsBox;
        private LollipopLabel lollipopLabel2;
        private LollipopButton auth;
        private LollipopButton siteBtn;
        private LollipopButton register;
        private LollipopLabel status;
        private LollipopProgressBar progress;
        private LollipopLabel filesizeLabel;
        private LollipopLabel filecounter;
        private LollipopButton cancelBtn;
        private LollipopButton contBtn;
        private LollipopLabel verLnch;
    }
}

