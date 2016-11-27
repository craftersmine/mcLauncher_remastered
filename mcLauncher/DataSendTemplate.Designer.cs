namespace craftersmine.MinecraftLauncher
{
    partial class DataSendTemplate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataSendTemplate));
            this.lollipopButton2 = new LollipopButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lollipopButton2
            // 
            this.lollipopButton2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopButton2.BGColor = "#4CAF50";
            this.lollipopButton2.FontColor = "#ffffff";
            this.lollipopButton2.Location = new System.Drawing.Point(461, 470);
            this.lollipopButton2.Name = "lollipopButton2";
            this.lollipopButton2.Size = new System.Drawing.Size(218, 29);
            this.lollipopButton2.TabIndex = 18;
            this.lollipopButton2.Text = "Закрыть";
            this.lollipopButton2.Click += new System.EventHandler(this.lollipopButton2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(692, 464);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // DataSendTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 505);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lollipopButton2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataSendTemplate";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Шаблон отправки данных";
            this.ResumeLayout(false);

        }

        #endregion

        private LollipopButton lollipopButton2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}