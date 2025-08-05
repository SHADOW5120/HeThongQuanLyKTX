using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;

namespace HeThongQuanLyKTX.Database
{
    internal class DatabaseHelper
    {
        private string connStr = "Server=localhost;Port=3306;Database=oop;User ID=root;Password=12345;";

        // Lấy kết nối đến cơ sở dữ liệu
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connStr);
        }

        // Thực thi câu lệnh SQL (INSERT, UPDATE, DELETE)
        public void ExecuteQuery(string query)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }

        // Thực thi câu lệnh SELECT và trả về MySqlDataReader
        public MySqlDataReader ExecuteReader(string query)
        {
            MySqlConnection conn = GetConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            return cmd.ExecuteReader();  // Trả về MySqlDataReader để đọc dữ liệu
        }

        // Thực thi câu lệnh SQL có tham số (INSERT, UPDATE, DELETE)
        public void ExecuteQueryWithParameters(string query, List<MySqlParameter> parameters)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddRange(parameters.ToArray());
                cmd.ExecuteNonQuery();
            }
        }

        // Thực thi câu lệnh SELECT trả về DataTable
        public DataTable ExecuteQueryAndReturnDataTable(string query)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                da.Fill(dt);  // Lấp dữ liệu vào DataTable
            }
            return dt;
        }

        // Thực thi câu lệnh SELECT với tham số và trả về DataTable
        public DataTable ExecuteQueryWithParametersAndReturnDataTable(string query, List<MySqlParameter> parameters)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddRange(parameters.ToArray());
                da.SelectCommand = cmd;
                da.Fill(dt);
            }
            return dt;
        }

        // Thực thi một thủ tục lưu trữ và trả về DataTable
        public DataTable ExecuteStoredProcedure(string storedProcedureName, List<MySqlParameter> parameters)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(storedProcedureName, conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddRange(parameters.ToArray());
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        // Thực thi một thủ tục lưu trữ không có tham số
        public void ExecuteStoredProcedureWithoutParameters(string storedProcedureName)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(storedProcedureName, conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
            }
        }

        // Lấy giá trị ID mới sau khi thực hiện INSERT
        public int ExecuteQueryAndReturnIdentity(string query, List<MySqlParameter> parameters)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddRange(parameters.ToArray());
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }

        public void ExecuteQueryWithParametersUsingTransaction(string query, List<MySqlParameter> parameters, MySqlTransaction transaction)
        {
            using (MySqlCommand cmd = new MySqlCommand(query, transaction.Connection, transaction))
            {
                cmd.Parameters.AddRange(parameters.ToArray());
                cmd.ExecuteNonQuery();
            }
        }
    }
}
