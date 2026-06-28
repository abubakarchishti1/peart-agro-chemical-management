using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;

namespace PeartAgroChemicalsManagementSystem.DAL
{
    public class DBHelper
    {
        
        private static string connStr =
            "Server=localhost;Database=PeartAgroDB;Uid=root;Pwd=chishti123;";

        
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connStr);
        }

        public static DataTable ExecuteQuery(string query,
                                             MySqlParameter[] prms = null)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection con = GetConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    if (prms != null)
                        cmd.Parameters.AddRange(prms);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    con.Open();
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Query Error: " + ex.Message);
            }
            return dt;
        }

        

        public static int ExecuteNonQuery(string query,
                                          MySqlParameter[] prms = null)
        {
            try
            {
                using (MySqlConnection con = GetConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    if (prms != null)
                        cmd.Parameters.AddRange(prms);
                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("NonQuery Error: " + ex.Message);
            }
        }

       
        public static object ExecuteScalar(string query,
                                           MySqlParameter[] prms = null)
        {
            try
            {
                using (MySqlConnection con = GetConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    if (prms != null)
                        cmd.Parameters.AddRange(prms);
                    con.Open();
                    return cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Scalar Error: " + ex.Message);
            }
        }

        
        public static bool TestConnection()
        {
            try
            {
                using (MySqlConnection con = GetConnection())
                {
                    con.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}