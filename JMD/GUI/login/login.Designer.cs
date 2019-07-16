namespace JMD.GUI.login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtUserNameP = new MetroFramework.Controls.MetroTextBox();
            this.txtPasswordP = new MetroFramework.Controls.MetroTextBox();
            this.loginBtn = new MetroFramework.Controls.MetroButton();
            this.see = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtUserNameP
            // 
            // 
            // 
            // 
            this.txtUserNameP.CustomButton.Image = null;
            this.txtUserNameP.CustomButton.Location = new System.Drawing.Point(191, 1);
            this.txtUserNameP.CustomButton.Name = "";
            this.txtUserNameP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserNameP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserNameP.CustomButton.TabIndex = 1;
            this.txtUserNameP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserNameP.CustomButton.UseSelectable = true;
            this.txtUserNameP.CustomButton.Visible = false;
            this.txtUserNameP.Lines = new string[0];
            this.txtUserNameP.Location = new System.Drawing.Point(95, 83);
            this.txtUserNameP.MaxLength = 32767;
            this.txtUserNameP.Name = "txtUserNameP";
            this.txtUserNameP.PasswordChar = '\0';
            this.txtUserNameP.PromptText = "Enter Login User name...";
            this.txtUserNameP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserNameP.SelectedText = "";
            this.txtUserNameP.SelectionLength = 0;
            this.txtUserNameP.SelectionStart = 0;
            this.txtUserNameP.ShortcutsEnabled = true;
            this.txtUserNameP.Size = new System.Drawing.Size(213, 23);
            this.txtUserNameP.TabIndex = 0;
            this.txtUserNameP.UseSelectable = true;
            this.txtUserNameP.WaterMark = "Enter Login User name...";
            this.txtUserNameP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserNameP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPasswordP
            // 
            // 
            // 
            // 
            this.txtPasswordP.CustomButton.Image = null;
            this.txtPasswordP.CustomButton.Location = new System.Drawing.Point(191, 1);
            this.txtPasswordP.CustomButton.Name = "";
            this.txtPasswordP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPasswordP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPasswordP.CustomButton.TabIndex = 1;
            this.txtPasswordP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPasswordP.CustomButton.UseSelectable = true;
            this.txtPasswordP.CustomButton.Visible = false;
            this.txtPasswordP.Lines = new string[0];
            this.txtPasswordP.Location = new System.Drawing.Point(95, 112);
            this.txtPasswordP.MaxLength = 32767;
            this.txtPasswordP.Name = "txtPasswordP";
            this.txtPasswordP.PasswordChar = '\0';
            this.txtPasswordP.PromptText = "Enter Login Password...";
            this.txtPasswordP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPasswordP.SelectedText = "";
            this.txtPasswordP.SelectionLength = 0;
            this.txtPasswordP.SelectionStart = 0;
            this.txtPasswordP.ShortcutsEnabled = true;
            this.txtPasswordP.Size = new System.Drawing.Size(213, 23);
            this.txtPasswordP.TabIndex = 1;
            this.txtPasswordP.UseSelectable = true;
            this.txtPasswordP.WaterMark = "Enter Login Password...";
            this.txtPasswordP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPasswordP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Green;
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginBtn.Location = new System.Drawing.Point(208, 150);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(100, 30);
            this.loginBtn.Style = MetroFramework.MetroColorStyle.Orange;
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseCustomBackColor = true;
            this.loginBtn.UseCustomForeColor = true;
            this.loginBtn.UseSelectable = true;
            this.loginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // see
            // 
            this.see.Location = new System.Drawing.Point(314, 112);
            this.see.Name = "see";
            this.see.Size = new System.Drawing.Size(32, 23);
            this.see.TabIndex = 9;
            this.see.Text = "See";
            this.see.UseSelectable = true;
            this.see.Click += new System.EventHandler(this.See_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 248);
            this.Controls.Add(this.see);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.txtPasswordP);
            this.Controls.Add(this.txtUserNameP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "JDM login Form";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtUserNameP;
        private MetroFramework.Controls.MetroTextBox txtPasswordP;
        private MetroFramework.Controls.MetroButton loginBtn;
        private MetroFramework.Controls.MetroButton see;
    }
}