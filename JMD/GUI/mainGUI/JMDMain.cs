using JMD.GUI.userControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JMD.GUI.mainGUI
{
    public partial class JMDMain : MetroFramework.Forms.MetroForm
    {
        
        public JMDMain()
        {
            InitializeComponent();
        }

        private void BuyBtn_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(BuyUserControl.Instance))
            {
                ContentPanel.Controls.Add(BuyUserControl.Instance);
                BuyUserControl.Instance.Dock = DockStyle.Fill;
                BuyUserControl.Instance.BringToFront();
            }
            else
            {

                BuyUserControl.Instance.BringToFront();
            }
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(FoodUserControl.Instance))
            {
                ContentPanel.Controls.Add(FoodUserControl.Instance);
                FoodUserControl.Instance.Dock = DockStyle.Fill;
                FoodUserControl.Instance.BringToFront();
            }
            else
            {

                FoodUserControl.Instance.BringToFront();
            }
        }

     
        private void ViewOrders_Click(object sender, EventArgs e)
        {
            
                if (!ContentPanel.Controls.Contains(ViewOrdersUserControl.Instance))
            {
                ContentPanel.Controls.Add(ViewOrdersUserControl.Instance);
                ViewOrdersUserControl.Instance.Dock = DockStyle.Fill;
                ViewOrdersUserControl.Instance.BringToFront();
            }
            else
            {

                ViewOrdersUserControl.Instance.BringToFront();
            }
        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(InventoryUserControl.Instance))
            {
                ContentPanel.Controls.Add(InventoryUserControl.Instance);
                InventoryUserControl.Instance.Dock = DockStyle.Fill;
                InventoryUserControl.Instance.BringToFront();
            }
            else
            {

                InventoryUserControl.Instance.BringToFront();
            }
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Users.Instance))
            {
                ContentPanel.Controls.Add(Users.Instance);
                Users.Instance.Dock = DockStyle.Fill;
                Users.Instance.BringToFront();
            }
            else
            {

                Users.Instance.BringToFront();
            }
        }
    }
}
