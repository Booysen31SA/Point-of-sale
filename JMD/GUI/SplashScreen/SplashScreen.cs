using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JMD.GUI.functions;
using JMD.GUI.login;

namespace JMD.GUI.SplashScreen
{
    public partial class SplashScreen : Form
    {
        private bool var = false;
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
            loadBar.Width += 5;
            
            if (loadBar.Width == 200)
            {
                varCheckAt200();
                
            }
            else if(loadBar.Width >= 400)
            {
               
                if(var == false)
                {
                    timer1.Stop();
                    RegisterForm rg = new RegisterForm();
                    rg.Show();
                    this.Hide();
                }else
                {
                    timer1.Stop();
                    Login lg = new Login();
                    lg.Show();
                    this.Hide();
                }
            }
        }
        public bool varCheckAt200()
        {
            UserName tc = new UserName();

            var = tc.checkEmptyTable();
            return var;
        }

        
        
    }
}
