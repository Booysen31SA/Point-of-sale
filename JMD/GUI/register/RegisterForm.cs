using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JMD.GUI.mainGUI;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Collections;
using JMD.GUI.functions;


namespace JMD
{
    public partial class RegisterForm : MetroFramework.Forms.MetroForm
    {

        String connectionString; // connection string
        SqlConnection connection; // connection
        UserName name = new UserName();
        UserDetailsFunctions uds = new UserDetailsFunctions();

        public RegisterForm()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["JMD.Properties.Settings.JMDDatabaseConnectionString"].ConnectionString;
            //connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database\\JMDDatabase.mdf;Integrated Security=True"; 
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
                        
           connectionStatus.Text = "Connected";
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                if(txtUserName.Text.Length < 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please Enter a valid user name");
                }
                else if(txtPassword.Text.Length < 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please Enter a valid password");
                }
                else if(txtName.Text.Length < 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please Enter a valid name");
                }
                else if(txtSurname.Text.Length < 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please Enter a valid Surname");
                }
                else if(txtPhoneNumber.Text.Length < 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please Enter a valid Phone number");
                }
                else
                {
                    if (name.checkUserName(txtUserName.Text) == true)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "User name Already Exist");
                    }
                    else if (uds.checkpn(txtPhoneNumber.Text) == true)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Phone Number Already Exist");
                    }
                    else
                    {
                        //insert
                        uds.insertU(txtUserName.Text, txtPassword.Text, txtName.Text, txtSurname.Text, txtPhoneNumber.Text);
                        JMDMain main = new JMDMain();
                        main.Show();
                        this.Dispose();

                    }
                }
               
            }
            catch (Exception err)
            {
                MetroFramework.MetroMessageBox.Show(this, " "+err);
            }

        }



        void Form_FormClosing(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            Environment.Exit(1);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
