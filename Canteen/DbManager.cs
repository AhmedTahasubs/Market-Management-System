using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace CanteenDataBase
{
    public class DbManager
    {
        SqlConnection conn;
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adapter;
        public DbManager()
        {
            conn = new SqlConnection("Data Source=HAMMAD\\MSSQLSERVER01;Initial Catalog=CanteenDB;Integrated Security=True;Trust Server Certificate=True");
            cmd = new SqlCommand("", conn);
        }
        // Data Table
        public DataTable GetDataTable(string query)
        {
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Clear();
            cmd.CommandText = query;
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public DataTable GetDataTable(string query, Dictionary<string, object> parameters = null)
        {
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Clear();
            cmd.CommandText = query;
            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    cmd.Parameters.AddWithValue(param.Key, param.Value);
                }
            }
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        // Execute Non Query
        public int ExecuteNonQuery(string query)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = query;
            if (conn.State == ConnectionState.Closed)
                conn?.Open();
            int result = cmd.ExecuteNonQuery();
            conn?.Close();
            return result;
        }
        public int ExecuteNonQuery(string query, Dictionary<string, object> parameters = null)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = query;
            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    cmd.Parameters.AddWithValue(param.Key, param.Value);
                }
            }
            if (conn?.State == ConnectionState.Closed)
                conn?.Open();
            int result = cmd.ExecuteNonQuery();
            conn?.Close();
            return result;
        }
        // Execute Scalar
        public object ExecuteScalar(string query)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = query;
            if (conn?.State == ConnectionState.Closed)
                conn?.Open();
            object result = cmd.ExecuteScalar();
            conn?.Close();
            return result;
        }
        public object ExecuteScalar(string query, Dictionary<string, object> parameters = null)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = query;
            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    cmd.Parameters.AddWithValue(param.Key, param.Value);
                }
            }
            if (conn?.State == ConnectionState.Closed)
                conn?.Open();
            object result = cmd.ExecuteScalar();
            conn?.Close();
            return result;
        }
    }
}
