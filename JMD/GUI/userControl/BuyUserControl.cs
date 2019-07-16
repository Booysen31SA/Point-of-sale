using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using JMD.GUI;
using JMD.GUI.functions;

namespace JMD
{
    public partial class BuyUserControl : UserControl
    {
        private static BuyUserControl _instance;
        String connectionString; // connection string
        SqlConnection connection; // connection
        buyUserControlFunctions bucf = new buyUserControlFunctions();

        private int orderNumber = 0;

        public static BuyUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BuyUserControl();
                }
                return _instance;
            }
        }
        public BuyUserControl()
        {
            InitializeComponent();
            maxMrderNumber();
        }

        private void BuyUserControl_Load(object sender, EventArgs e)
        {
            connectionString = ConfigurationManager.ConnectionStrings["JMD.Properties.Settings.JMDDatabaseConnectionString"].ConnectionString;
            
            clearBtn();
        }

       

        public void clearBtn()
        {
            metroButton1.Text = " ";
            metroButton2.Text = " ";
            metroButton3.Text = " ";
            metroButton4.Text = " ";
            metroButton5.Text = " ";
            metroButton6.Text = " ";
            metroButton7.Text = " ";
            metroButton8.Text = " ";
            metroButton9.Text = " ";
            metroButton10.Text = " ";
            metroButton11.Text = " ";
            metroButton12.Text = " ";
            metroButton13.Text = " ";
            metroButton14.Text = " ";
            metroButton15.Text = " ";
            metroButton16.Text = " ";
            metroButton17.Text = " ";
            metroButton18.Text = " ";
            metroButton19.Text = " ";
            metroButton20.Text = " ";
            metroButton21.Text = " ";
            metroButton22.Text = " ";
            metroButton23.Text = " ";
            metroButton24.Text = " ";
            metroButton25.Text = " ";
            metroButton26.Text = " ";
            metroButton27.Text = " ";
            metroButton28.Text = " ";
            metroButton29.Text = " ";
            metroButton30.Text = " ";
            metroButton31.Text = " ";
            metroButton32.Text = " ";
            metroButton33.Text = " ";
            metroButton34.Text = " ";
            metroButton35.Text = " ";
            metroButton36.Text = " ";
            metroButton37.Text = " ";
            metroButton38.Text = " ";
            metroButton39.Text = " ";
            metroButton40.Text = " ";
            metroButton41.Text = " ";
            metroButton42.Text = " ";
            metroButton43.Text = " ";
            metroButton44.Text = " ";
            metroButton45.Text = " ";
            metroButton46.Text = " ";
            metroButton47.Text = " ";
            metroButton48.Text = " ";
            FillBtn();
        }


        public void FillBtn()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("refreshFood", connection);

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                connection.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(this, "Error" + e);
                }
                connection.Close();

                try
                {
                    
                    metroButton1.Text = DS.Tables[0].Rows[0]["FoodName"].ToString();
                    metroButton2.Text = DS.Tables[0].Rows[1]["FoodName"].ToString();
                    metroButton3.Text = DS.Tables[0].Rows[2]["FoodName"].ToString();
                    metroButton4.Text = DS.Tables[0].Rows[3]["FoodName"].ToString();
                    metroButton5.Text = DS.Tables[0].Rows[4]["FoodName"].ToString();
                    metroButton6.Text = DS.Tables[0].Rows[5]["FoodName"].ToString();
                    metroButton7.Text = DS.Tables[0].Rows[6]["FoodName"].ToString();
                    metroButton8.Text = DS.Tables[0].Rows[7]["FoodName"].ToString();
                    metroButton9.Text = DS.Tables[0].Rows[8]["FoodName"].ToString();
                    metroButton10.Text = DS.Tables[0].Rows[9]["FoodName"].ToString();
                    metroButton11.Text = DS.Tables[0].Rows[10]["FoodName"].ToString();
                    metroButton12.Text = DS.Tables[0].Rows[11]["FoodName"].ToString();
                    metroButton13.Text = DS.Tables[0].Rows[12]["FoodName"].ToString();
                    metroButton14.Text = DS.Tables[0].Rows[13]["FoodName"].ToString();
                    metroButton15.Text = DS.Tables[0].Rows[14]["FoodName"].ToString();
                    metroButton16.Text = DS.Tables[0].Rows[15]["FoodName"].ToString();
                    metroButton17.Text = DS.Tables[0].Rows[16]["FoodName"].ToString();
                    metroButton18.Text = DS.Tables[0].Rows[17]["FoodName"].ToString();
                    metroButton19.Text = DS.Tables[0].Rows[18]["FoodName"].ToString();
                    metroButton20.Text = DS.Tables[0].Rows[19]["FoodName"].ToString();
                    metroButton21.Text = DS.Tables[0].Rows[20]["FoodName"].ToString();
                    metroButton22.Text = DS.Tables[0].Rows[21]["FoodName"].ToString();
                    metroButton23.Text = DS.Tables[0].Rows[22]["FoodName"].ToString();
                    metroButton24.Text = DS.Tables[0].Rows[23]["FoodName"].ToString();
                    metroButton25.Text = DS.Tables[0].Rows[24]["FoodName"].ToString();
                    metroButton26.Text = DS.Tables[0].Rows[25]["FoodName"].ToString();
                    metroButton27.Text = DS.Tables[0].Rows[26]["FoodName"].ToString();
                    metroButton28.Text = DS.Tables[0].Rows[27]["FoodName"].ToString();
                    metroButton29.Text = DS.Tables[0].Rows[28]["FoodName"].ToString();
                    metroButton30.Text = DS.Tables[0].Rows[29]["FoodName"].ToString();
                    metroButton31.Text = DS.Tables[0].Rows[30]["FoodName"].ToString();
                    metroButton32.Text = DS.Tables[0].Rows[31]["FoodName"].ToString();
                    metroButton33.Text = DS.Tables[0].Rows[32]["FoodName"].ToString();
                    metroButton34.Text = DS.Tables[0].Rows[33]["FoodName"].ToString();
                    metroButton35.Text = DS.Tables[0].Rows[34]["FoodName"].ToString();
                    metroButton36.Text = DS.Tables[0].Rows[35]["FoodName"].ToString();
                    metroButton37.Text = DS.Tables[0].Rows[36]["FoodName"].ToString();
                    metroButton38.Text = DS.Tables[0].Rows[37]["FoodName"].ToString();
                    metroButton39.Text = DS.Tables[0].Rows[38]["FoodName"].ToString();
                    metroButton40.Text = DS.Tables[0].Rows[39]["FoodName"].ToString();
                    metroButton41.Text = DS.Tables[0].Rows[40]["FoodName"].ToString();
                    metroButton42.Text = DS.Tables[0].Rows[41]["FoodName"].ToString();
                    metroButton43.Text = DS.Tables[0].Rows[42]["FoodName"].ToString();
                    metroButton44.Text = DS.Tables[0].Rows[43]["FoodName"].ToString();
                    metroButton45.Text = DS.Tables[0].Rows[44]["FoodName"].ToString();
                    metroButton46.Text = DS.Tables[0].Rows[45]["FoodName"].ToString();
                    metroButton47.Text = DS.Tables[0].Rows[46]["FoodName"].ToString();
                    metroButton48.Text = DS.Tables[0].Rows[47]["FoodName"].ToString();
                }
                catch(Exception e)
                {

                }

            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Error" + e);
            }
        }

        private void function(String btnName)
        {
            int price = bucf.price(btnName);
            String input = "0";
            input = Microsoft.VisualBasic.Interaction.InputBox("Item Name : " + btnName +
                                                                      "\nPrice          : R" + price + " each" +
                                                                       "\nEnter Quantity below and press next",
                                                                       "Quantity",
                                                                       "0",
                                                                       -1, -1);
            int listSize;
            bool success = int.TryParse(input, out listSize);
            if (success)
            {
                bucf.insertOrder(btnName, Convert.ToInt32(input), price, orderNumber);
                refresh();
            }
        }

       public void maxMrderNumber()
        {
            orderNumber = bucf.highestNumber();
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton3_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton4_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton5_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton6_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton7_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton8_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton9_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton10_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton11_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton12_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton13_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton14_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton15_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton16_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton17_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton18_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton19_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton20_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton21_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton22_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton23_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton24_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton25_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton26_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton27_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton28_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton29_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton30_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton31_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton32_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton33_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton34_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton35_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton36_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton37_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton38_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton39_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton40_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton41_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton42_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton43_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton44_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton45_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton46_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton47_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }

        private void MetroButton48_Click(object sender, EventArgs e)
        {
            String btnName = (sender as Button).Text;
            if (!btnName.Equals(" "))
            {
                function(btnName);
            }
        }
      
       
        

        public void refresh()
        {

            try
            {
                FillBtn();
                connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("refreshOrder", connection);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@orderNumber", orderNumber);

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                connection.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(this, "Error" + e);
                }
                connection.Close();

                dataGridView1.DataSource = DS.Tables[0];
                //MAX = DS.Tables[0].Select("Id is not null").Length;
                orderNumtxt.Text = orderNumber.ToString();
                grandTotal.Text = "R"+bucf.gTotal(orderNumber).ToString()+" DUE";


                //insertStatus.Text = "Space Available - " + (48 - MAX).ToString();

            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Error" + e);
            }
            
        }

        private void MetroButton49_Click(object sender, EventArgs e)
        {
            orderNumber++;
            refresh();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (remove.Text.Length < 1)
            {
                MessageBox.Show("Please Enter Order  ID", "Invalid");
            }
            else
            {
                bucf.removeOrderID(Convert.ToInt32(remove.Text));
                refresh();
            }
        }

        //=============================================================================
        //                               KEY PRESSED ACTIONS
        //=============================================================================
        private void Remove_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}



