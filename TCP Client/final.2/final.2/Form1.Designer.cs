namespace final._2
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
            this.textbox_ip = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.textbox_port = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.button_connect = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.SuspendLayout();
            // 
            // textbox_ip
            // 
            // 
            // 
            // 
            this.textbox_ip.CustomButton.Image = null;
            this.textbox_ip.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.textbox_ip.CustomButton.Name = "";
            this.textbox_ip.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textbox_ip.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_ip.CustomButton.TabIndex = 1;
            this.textbox_ip.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_ip.CustomButton.UseSelectable = true;
            this.textbox_ip.CustomButton.Visible = false;
            this.textbox_ip.Lines = new string[0];
            this.textbox_ip.Location = new System.Drawing.Point(60, 131);
            this.textbox_ip.MaxLength = 32767;
            this.textbox_ip.Name = "textbox_ip";
            this.textbox_ip.PasswordChar = '\0';
            this.textbox_ip.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_ip.SelectedText = "";
            this.textbox_ip.SelectionLength = 0;
            this.textbox_ip.SelectionStart = 0;
            this.textbox_ip.Size = new System.Drawing.Size(156, 23);
            this.textbox_ip.TabIndex = 0;
            this.textbox_ip.UseSelectable = true;
            this.textbox_ip.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_ip.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(60, 99);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(20, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "IP";
            // 
            // textbox_port
            // 
            // 
            // 
            // 
            this.textbox_port.CustomButton.Image = null;
            this.textbox_port.CustomButton.Location = new System.Drawing.Point(60, 1);
            this.textbox_port.CustomButton.Name = "";
            this.textbox_port.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textbox_port.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_port.CustomButton.TabIndex = 1;
            this.textbox_port.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_port.CustomButton.UseSelectable = true;
            this.textbox_port.CustomButton.Visible = false;
            this.textbox_port.Lines = new string[0];
            this.textbox_port.Location = new System.Drawing.Point(316, 131);
            this.textbox_port.MaxLength = 32767;
            this.textbox_port.Name = "textbox_port";
            this.textbox_port.PasswordChar = '\0';
            this.textbox_port.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_port.SelectedText = "";
            this.textbox_port.SelectionLength = 0;
            this.textbox_port.SelectionStart = 0;
            this.textbox_port.Size = new System.Drawing.Size(82, 23);
            this.textbox_port.TabIndex = 2;
            this.textbox_port.UseSelectable = true;
            this.textbox_port.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_port.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(316, 99);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(43, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "PORT";
            // 
            // button_connect
            // 
            this.button_connect.Image = null;
            this.button_connect.Location = new System.Drawing.Point(166, 219);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(193, 62);
            this.button_connect.TabIndex = 4;
            this.button_connect.Text = "CONNECT";
            this.button_connect.UseSelectable = true;
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 545);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.textbox_port);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.textbox_ip);
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox textbox_ip;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox textbox_port;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton button_connect;
    }
}

