using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JMD.GUI.functions
{
    
    class InventoryFunctions
    {
        private String connectionString; // connection string
        private SqlConnection connection; // connection

        //=============================================================================
        //                                  INSERT
        //=============================================================================
        public void InsertPass(String itemName, int quantity)
        {
            Insert(itemName, quantity);
        }
        private void Insert(String itemName, int quantity)
        {
            connectionString = ConfigurationManager.ConnectionStrings["JMD.Properties.Settings.JMDDatabaseConnectionString"].ConnectionString;

            connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("InsertInventory", connection);

            cmd.CommandType = CommandType.StoredProcedure;
           
            cmd.Parameters.AddWithValue("@ItemName", itemName);
            cmd.Parameters.AddWithValue("@ItemQuantity", quantity);
            


            connection.Open();
            try
            {
                cmd.ExecuteNonQuery();
                

            }
            catch (SqlException er)
            {
                MessageBox.Show(er + "");

            }
            catch (Exception err)
            {
                MessageBox.Show(" " + err, "Error");
            }
            connection.Close();
        }
        //=============================================================================
        //                                  Delete
        //=============================================================================
        public void DeletePass(int ItemID)
        {
            Delete(ItemID);
        }
        private void Delete(int ItemID)
        {
            connectionString = ConfigurationManager.ConnectionStrings["JMD.Properties.Settings.JMDDatabaseConnectionString"].ConnectionString;

            connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("DeleteInventory", connection);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ItemID", ItemID);



            connection.Open();
            try
            {
                cmd.ExecuteNonQuery();


            }
            catch (SqlException er)
            {
                MessageBox.Show("Delete Error");

            }
            catch (Exception err)
            {
                MessageBox.Show(" " + err, "Error");
            }
            connection.Close();
        }
        //=============================================================================
        //                                  UPDATE
        //=============================================================================
        public void UpdatePass(int ItemID, int Quantity)
        {
            update(ItemID, Quantity);
        }
        private void update(int ItemID, int Quantity)
        {
            connectionString = ConfigurationManager.ConnectionStrings["JMD.Properties.Settings.JMDDatabaseConnectionString"].ConnectionString;

            connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("UpdateInventory", connection);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ItemID", ItemID);
            cmd.Parameters.AddWithValue("@ItemQuantity", Quantity);


            connection.Open();
            try
            {
                cmd.ExecuteNonQuery();


            }
            catch (SqlException er)
            {
                MessageBox.Show(er + "");

            }
            catch (Exception err)
            {
                MessageBox.Show(" " + err, "Error");
            }
            connection.Close();
        }
    }
}
