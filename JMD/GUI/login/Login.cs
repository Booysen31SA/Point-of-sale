using System;
using JMD.GUI.functions;
using JMD.GUI.mainGUI;

namespace JMD.GUI.login
{
    
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        UserName checkName = new UserName();
        public Login()
        {
            InitializeComponent();
        }

        private void See_Click(object sender, EventArgs e)
        {
            if (txtPasswordP.PasswordChar == '*')
            {
                txtPasswordP.PasswordChar = '\0';
                
            }
            else
            {
                txtPasswordP.PasswordChar = '*';
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(txtUserNameP.Text.Length < 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Enter Valid User Name");
            }else if(txtPasswordP.Text.Length < 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Enter valid Password");
            }
            else
            {
                if(checkName.checkUserName(txtUserNameP.Text) == true && checkName.checkPassword(txtUserNameP.Text, txtPasswordP.Text) == true)
                    {
                    JMDMain main = new JMDMain();
                    main.Show();
                    this.Dispose();
                }
            }
        }


    }
}
