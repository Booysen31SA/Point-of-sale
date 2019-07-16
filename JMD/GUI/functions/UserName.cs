using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace JMD.GUI.functions
{
    class UserName
    {
        String connectionString = ConfigurationManager.ConnectionStrings["JMD.Properties.Settings.JMDDatabaseConnectionString"].ConnectionString; // connection string
        SqlConnection connection; // connection
        
           
        public bool checkEmptyTable()
        {
            
            try
            {
                connection = new SqlConnection(connectionString);
                SqlDataReader dr;
                connection.Open();

                SqlCommand cmd = new SqlCommand("checkEmptyTable", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();
                dr.Read();

                int result = int.Parse(dr[0].ToString());

                if (result == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
                
            }
            finally
            {
                connection.Close();
            }
            
            
        }
        public bool checkUserName(String userName)
        {
            Boolean value = false;
            try
            {
                String query = "SELECT userName FROM UserDetail WHERE userName = '" + userName + "'";

                connection = new SqlConnection(connectionString);
                SqlDataReader dr;
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);
                dr = cmd.ExecuteReader();

                dr.Read();
                if (dr[0].ToString().Equals(userName))
                {
                    value = true;
                }

            }
#pragma warning disable CS0168 // The variable 'err' is declared but never used
            catch (Exception err)
#pragma warning restore CS0168 // The variable 'err' is declared but never used
            {

            }

            connection.Close();
            return value;
        }

        public bool checkPassword(String userName, String passsword)
        {
            Boolean value = false;
            try
            {
                String query = "SELECT userPassword FROM UserDetail WHERE userName = '" + userName + "'";

                connection = new SqlConnection(connectionString);
                SqlDataReader dr;
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);
                dr = cmd.ExecuteReader();

                dr.Read();
                if (dr[0].ToString().Equals(passsword))
                {
                    value = true;
                }

            }
#pragma warning disable CS0168 // The variable 'err' is declared but never used
            catch (Exception err)
#pragma warning restore CS0168 // The variable 'err' is declared but never used
            {

            }

            connection.Close();
            return value;
        }
    }
}
