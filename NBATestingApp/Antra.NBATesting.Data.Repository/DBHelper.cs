using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Configuration;

namespace Antra.NBATestingApp.Data.Repository
{
    class DBHelper
    {
        public SqlConnection GetConnection()
        {
            string con = new ConfigurationBuilder().AddJsonFile("appSetting.json").Build().GetConnectionString("NBAPlayerDB");
            return new SqlConnection(con);
        }
        public string ConnectionString
        { 
            get
            {
                return new ConfigurationBuilder().AddJsonFile("appSetting.json").Build().GetConnectionString("NBAPlayerDB");
            }
        }
        public int Execute(string sqlcommand, Dictionary<string, object> parameters)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand();
            try
            {
                con.Open();
                cmd.CommandText = sqlcommand;
                if (parameters != null)
                {
                    foreach (var item in parameters)
                    {
                        cmd.Parameters.AddWithValue(item.Key, item.Value);
                    }
                }
                cmd.Connection = con;
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                con.Close();
                con.Dispose();
                cmd.Dispose();
            }
            return 0;
        }
        public DataTable Query(string sqlCommand, Dictionary<string, object> parameters, 
                                CommandType cmdType=CommandType.Text)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.CommandType = cmdType;
                cmd.CommandText = sqlCommand;
                if (parameters!=null)
                {
                    foreach (var item in parameters)
                    {
                        cmd.Parameters.AddWithValue(item.Key, item.Value);
                    }
                }
                con.Open();
                cmd.Connection = con;
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                return dt;
            }
            catch (Exception ex)
            {
            }
            finally
            {
                con.Close();
                con.Dispose();
                cmd.Dispose();
            }
            return null;
        }
    }
}
