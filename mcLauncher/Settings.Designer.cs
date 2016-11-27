namespace craftersmine.MinecraftLauncher
{
    partial class Settings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lollipopLabel1 = new LollipopLabel();
            this.back = new System.Windows.Forms.PictureBox();
            this.lollipopLabel7 = new LollipopLabel();
            this.lollipopLabel6 = new LollipopLabel();
            this.lollipopLabel5 = new LollipopLabel();
            this.redownloadClient = new LollipopToggle();
            this.showTemplate = new LollipopButton();
            this.sendData = new LollipopToggle();
            this.javaPath = new LollipopFolderInPut();
            this.lollipopLabel4 = new LollipopLabel();
            this.lollipopLabel3 = new LollipopLabel();
            this.memory = new LollipopTextBox();
            this.lollipopLabel2 = new LollipopLabel();
            this.applyAndBack = new LollipopButton();
            this.apply = new LollipopButton();
            this.textChangerTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.lollipopLabel1);
            this.panel1.Controls.Add(this.back);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 42);
            this.panel1.TabIndex = 0;
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.White;
            this.lollipopLabel1.Location = new System.Drawing.Point(48, 11);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(81, 19);
            this.lollipopLabel1.TabIndex = 6;
            this.lollipopLabel1.Text = "Настройки";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.BackgroundImage = global::craftersmine.MinecraftLauncher.Properties.Resources.back;
            this.back.Location = new System.Drawing.Point(0, 0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(42, 42);
            this.back.TabIndex = 5;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // lollipopLabel7
            // 
            this.lollipopLabel7.AutoSize = true;
            this.lollipopLabel7.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel7.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.lollipopLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel7.Location = new System.Drawing.Point(319, 79);
            this.lollipopLabel7.Name = "lollipopLabel7";
            this.lollipopLabel7.Size = new System.Drawing.Size(30, 19);
            this.lollipopLabel7.TabIndex = 21;
            this.lollipopLabel7.Text = "МБ";
            // 
            // lollipopLabel6
            // 
            this.lollipopLabel6.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel6.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.lollipopLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel6.Location = new System.Drawing.Point(65, 263);
            this.lollipopLabel6.Name = "lollipopLabel6";
            this.lollipopLabel6.Size = new System.Drawing.Size(280, 40);
            this.lollipopLabel6.TabIndex = 20;
            this.lollipopLabel6.Text = "Перезакачать выбранный клиент";
            this.lollipopLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lollipopLabel5
            // 
            this.lollipopLabel5.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel5.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.lollipopLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel5.Location = new System.Drawing.Point(65, 303);
            this.lollipopLabel5.Name = "lollipopLabel5";
            this.lollipopLabel5.Size = new System.Drawing.Size(280, 40);
            this.lollipopLabel5.TabIndex = 19;
            this.lollipopLabel5.Text = "Отправлять анонимные данные диагностики при ошибке разработчику";
            this.lollipopLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // redownloadClient
            // 
            this.redownloadClient.AutoSize = true;
            this.redownloadClient.EllipseBorderColor = "#4CAF50";
            this.redownloadClient.EllipseColor = "#4CAF50";
            this.redownloadClient.Location = new System.Drawing.Point(12, 275);
            this.redownloadClient.Name = "redownloadClient";
            this.redownloadClient.Size = new System.Drawing.Size(47, 19);
            this.redownloadClient.TabIndex = 18;
            this.redownloadClient.UseVisualStyleBackColor = true;
            // 
            // showTemplate
            // 
            this.showTemplate.BackColor = System.Drawing.Color.Transparent;
            this.showTemplate.BGColor = "#4CAF50";
            this.showTemplate.FontColor = "#ffffff";
            this.showTemplate.Location = new System.Drawing.Point(12, 346);
            this.showTemplate.Name = "showTemplate";
            this.showTemplate.Size = new System.Drawing.Size(333, 29);
            this.showTemplate.TabIndex = 17;
            this.showTemplate.Text = "Посмотреть шаблон отправляемых данных";
            this.showTemplate.Click += new System.EventHandler(this.showTemplate_Click);
            // 
            // sendData
            // 
            this.sendData.AutoSize = true;
            this.sendData.EllipseBorderColor = "#4CAF50";
            this.sendData.EllipseColor = "#4CAF50";
            this.sendData.Location = new System.Drawing.Point(12, 315);
            this.sendData.Name = "sendData";
            this.sendData.Size = new System.Drawing.Size(47, 19);
            this.sendData.TabIndex = 15;
            this.sendData.UseVisualStyleBackColor = true;
            // 
            // javaPath
            // 
            this.javaPath.FocusedColor = "#4CAF50";
            this.javaPath.FontColor = "#999999";
            this.javaPath.IsEnabled = true;
            this.javaPath.Location = new System.Drawing.Point(12, 236);
            this.javaPath.MaxLength = 32767;
            this.javaPath.Name = "javaPath";
            this.javaPath.ReadOnly = false;
            this.javaPath.Size = new System.Drawing.Size(333, 24);
            this.javaPath.TabIndex = 14;
            this.javaPath.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.javaPath.UseSystemPasswordChar = false;
            // 
            // lollipopLabel4
            // 
            this.lollipopLabel4.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel4.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.lollipopLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel4.Location = new System.Drawing.Point(12, 174);
            this.lollipopLabel4.Name = "lollipopLabel4";
            this.lollipopLabel4.Size = new System.Drawing.Size(333, 59);
            this.lollipopLabel4.TabIndex = 13;
            this.lollipopLabel4.Text = "Свой путь до JavaVM папки bin (Если автоопределение не смогло определить JavaVM и" +
    "ли вас неустраивает определенная):";
            this.lollipopLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lollipopLabel3
            // 
            this.lollipopLabel3.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel3.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.lollipopLabel3.ForeColor = System.Drawing.Color.DimGray;
            this.lollipopLabel3.Location = new System.Drawing.Point(12, 101);
            this.lollipopLabel3.Name = "lollipopLabel3";
            this.lollipopLabel3.Size = new System.Drawing.Size(333, 58);
            this.lollipopLabel3.TabIndex = 12;
            this.lollipopLabel3.Text = "ВНИМАНИЕ! Не выделяйте больше половины физической памяти! Иначе JavaVM не сможет " +
    "запустить Minecraft";
            this.lollipopLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // memory
            // 
            this.memory.FocusedColor = "#4CAF50";
            this.memory.FontColor = "#999999";
            this.memory.IsEnabled = true;
            this.memory.Location = new System.Drawing.Point(12, 74);
            this.memory.MaxLength = 32767;
            this.memory.Multiline = false;
            this.memory.Name = "memory";
            this.memory.ReadOnly = false;
            this.memory.Size = new System.Drawing.Size(301, 24);
            this.memory.TabIndex = 11;
            this.memory.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.memory.UseSystemPasswordChar = false;
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.AutoSize = true;
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel2.Location = new System.Drawing.Point(12, 52);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(229, 19);
            this.lollipopLabel2.TabIndex = 10;
            this.lollipopLabel2.Text = "Количество выделенной памяти:";
            // 
            // applyAndBack
            // 
            this.applyAndBack.BackColor = System.Drawing.Color.Transparent;
            this.applyAndBack.BGColor = "#4CAF50";
            this.applyAndBack.FontColor = "#ffffff";
            this.applyAndBack.Location = new System.Drawing.Point(12, 472);
            this.applyAndBack.Name = "applyAndBack";
            this.applyAndBack.Size = new System.Drawing.Size(333, 29);
            this.applyAndBack.TabIndex = 9;
            this.applyAndBack.Text = "Применить настройки и перейти к авторизации";
            this.applyAndBack.Click += new System.EventHandler(this.applyAndBack_Click);
            // 
            // apply
            // 
            this.apply.BackColor = System.Drawing.Color.Transparent;
            this.apply.BGColor = "#4CAF50";
            this.apply.FontColor = "#ffffff";
            this.apply.Location = new System.Drawing.Point(12, 437);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(333, 29);
            this.apply.TabIndex = 8;
            this.apply.Text = "Применить настройки";
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // textChangerTimer
            // 
            this.textChangerTimer.Interval = 3000;
            this.textChangerTimer.Tick += new System.EventHandler(this.textChangerTimer_Tick);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(357, 513);
            this.Controls.Add(this.lollipopLabel7);
            this.Controls.Add(this.lollipopLabel6);
            this.Controls.Add(this.lollipopLabel5);
            this.Controls.Add(this.redownloadClient);
            this.Controls.Add(this.showTemplate);
            this.Controls.Add(this.sendData);
            this.Controls.Add(this.javaPath);
            this.Controls.Add(this.lollipopLabel4);
            this.Controls.Add(this.lollipopLabel3);
            this.Controls.Add(this.memory);
            this.Controls.Add(this.lollipopLabel2);
            this.Controls.Add(this.applyAndBack);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox back;
        private LollipopLabel lollipopLabel1;
        private LollipopButton apply;
        private LollipopButton applyAndBack;
        private LollipopLabel lollipopLabel2;
        private LollipopTextBox memory;
        private LollipopLabel lollipopLabel3;
        private LollipopLabel lollipopLabel4;
        private LollipopFolderInPut javaPath;
        private LollipopToggle sendData;
        private LollipopButton showTemplate;
        private LollipopToggle redownloadClient;
        private LollipopLabel lollipopLabel5;
        private LollipopLabel lollipopLabel6;
        private LollipopLabel lollipopLabel7;
        private System.Windows.Forms.Timer textChangerTimer;
    }
}

