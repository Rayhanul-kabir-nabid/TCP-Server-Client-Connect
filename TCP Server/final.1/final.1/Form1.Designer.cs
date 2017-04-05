namespace final._1
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
            this.button_ok = new MetroFramework.Controls.MetroButton();
            this.textbox_ip = new MetroFramework.Controls.MetroTextBox();
            this.textbox_port = new MetroFramework.Controls.MetroTextBox();
            this.text_box_clientlist = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.IP = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.button_start_server = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.textbox_noofclient = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(324, 322);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(57, 23);
            this.button_ok.TabIndex = 0;
            this.button_ok.Text = "OK";
            this.button_ok.UseSelectable = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // textbox_ip
            // 
            // 
            // 
            // 
            this.textbox_ip.CustomButton.Image = null;
            this.textbox_ip.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.textbox_ip.CustomButton.Name = "";
            this.textbox_ip.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textbox_ip.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_ip.CustomButton.TabIndex = 1;
            this.textbox_ip.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_ip.CustomButton.UseSelectable = true;
            this.textbox_ip.CustomButton.Visible = false;
            this.textbox_ip.Lines = new string[0];
            this.textbox_ip.Location = new System.Drawing.Point(215, 156);
            this.textbox_ip.MaxLength = 32767;
            this.textbox_ip.Name = "textbox_ip";
            this.textbox_ip.PasswordChar = '\0';
            this.textbox_ip.ReadOnly = true;
            this.textbox_ip.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_ip.SelectedText = "";
            this.textbox_ip.SelectionLength = 0;
            this.textbox_ip.SelectionStart = 0;
            this.textbox_ip.Size = new System.Drawing.Size(166, 23);
            this.textbox_ip.TabIndex = 1;
            this.textbox_ip.UseSelectable = true;
            this.textbox_ip.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_ip.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textbox_port
            // 
            // 
            // 
            // 
            this.textbox_port.CustomButton.Image = null;
            this.textbox_port.CustomButton.Location = new System.Drawing.Point(81, 1);
            this.textbox_port.CustomButton.Name = "";
            this.textbox_port.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textbox_port.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_port.CustomButton.TabIndex = 1;
            this.textbox_port.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_port.CustomButton.UseSelectable = true;
            this.textbox_port.CustomButton.Visible = false;
            this.textbox_port.Lines = new string[0];
            this.textbox_port.Location = new System.Drawing.Point(215, 231);
            this.textbox_port.MaxLength = 32767;
            this.textbox_port.Name = "textbox_port";
            this.textbox_port.PasswordChar = '\0';
            this.textbox_port.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_port.SelectedText = "";
            this.textbox_port.SelectionLength = 0;
            this.textbox_port.SelectionStart = 0;
            this.textbox_port.Size = new System.Drawing.Size(103, 23);
            this.textbox_port.TabIndex = 2;
            this.textbox_port.UseSelectable = true;
            this.textbox_port.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_port.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // text_box_clientlist
            // 
            // 
            // 
            // 
            this.text_box_clientlist.CustomButton.Image = null;
            this.text_box_clientlist.CustomButton.Location = new System.Drawing.Point(-209, 2);
            this.text_box_clientlist.CustomButton.Name = "";
            this.text_box_clientlist.CustomButton.Size = new System.Drawing.Size(391, 391);
            this.text_box_clientlist.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.text_box_clientlist.CustomButton.TabIndex = 1;
            this.text_box_clientlist.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.text_box_clientlist.CustomButton.UseSelectable = true;
            this.text_box_clientlist.CustomButton.Visible = false;
            this.text_box_clientlist.Lines = new string[0];
            this.text_box_clientlist.Location = new System.Drawing.Point(24, 116);
            this.text_box_clientlist.MaxLength = 32767;
            this.text_box_clientlist.Multiline = true;
            this.text_box_clientlist.Name = "text_box_clientlist";
            this.text_box_clientlist.PasswordChar = '\0';
            this.text_box_clientlist.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.text_box_clientlist.SelectedText = "";
            this.text_box_clientlist.SelectionLength = 0;
            this.text_box_clientlist.SelectionStart = 0;
            this.text_box_clientlist.Size = new System.Drawing.Size(185, 396);
            this.text_box_clientlist.TabIndex = 3;
            this.text_box_clientlist.UseSelectable = true;
            this.text_box_clientlist.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.text_box_clientlist.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(67, 84);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(61, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Client list";
            // 
            // IP
            // 
            this.IP.AutoSize = true;
            this.IP.Location = new System.Drawing.Point(215, 116);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(20, 19);
            this.IP.TabIndex = 5;
            this.IP.Text = "IP";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(215, 197);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(43, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "PORT";
            // 
            // button_start_server
            // 
            this.button_start_server.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start_server.Image = null;
            this.button_start_server.Location = new System.Drawing.Point(217, 385);
            this.button_start_server.Name = "button_start_server";
            this.button_start_server.Size = new System.Drawing.Size(164, 76);
            this.button_start_server.TabIndex = 7;
            this.button_start_server.Text = "Start Server";
            this.button_start_server.UseSelectable = true;
            this.button_start_server.UseVisualStyleBackColor = true;
            this.button_start_server.Click += new System.EventHandler(this.button_start_server_Click);
            // 
            // textbox_noofclient
            // 
            // 
            // 
            // 
            this.textbox_noofclient.CustomButton.Image = null;
            this.textbox_noofclient.CustomButton.Location = new System.Drawing.Point(79, 1);
            this.textbox_noofclient.CustomButton.Name = "";
            this.textbox_noofclient.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textbox_noofclient.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_noofclient.CustomButton.TabIndex = 1;
            this.textbox_noofclient.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_noofclient.CustomButton.UseSelectable = true;
            this.textbox_noofclient.CustomButton.Visible = false;
            this.textbox_noofclient.Lines = new string[0];
            this.textbox_noofclient.Location = new System.Drawing.Point(217, 322);
            this.textbox_noofclient.MaxLength = 32767;
            this.textbox_noofclient.Name = "textbox_noofclient";
            this.textbox_noofclient.PasswordChar = '\0';
            this.textbox_noofclient.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_noofclient.SelectedText = "";
            this.textbox_noofclient.SelectionLength = 0;
            this.textbox_noofclient.SelectionStart = 0;
            this.textbox_noofclient.Size = new System.Drawing.Size(101, 23);
            this.textbox_noofclient.TabIndex = 8;
            this.textbox_noofclient.UseSelectable = true;
            this.textbox_noofclient.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_noofclient.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(215, 279);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(80, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "No of Client";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 545);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.textbox_noofclient);
            this.Controls.Add(this.button_start_server);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.text_box_clientlist);
            this.Controls.Add(this.textbox_port);
            this.Controls.Add(this.textbox_ip);
            this.Controls.Add(this.button_ok);
            this.Name = "Form1";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton button_ok;
        private MetroFramework.Controls.MetroTextBox textbox_ip;
        private MetroFramework.Controls.MetroTextBox textbox_port;
        private MetroFramework.Controls.MetroTextBox text_box_clientlist;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel IP;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton button_start_server;
        private MetroFramework.Controls.MetroTextBox textbox_noofclient;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}

