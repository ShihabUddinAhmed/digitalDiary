﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace digitalDiary
{
    class DataAccess : IDisposable
    {
        SqlConnection connection;
        SqlCommand command;

        public SqlConnection Connection { get => connection; }

        public DataAccess()
        {
            try
            {
                this.connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Diary"].ConnectionString);
                this.connection.Open();
            }
            catch (Exception e)
            {

            }

        }



        public SqlDataReader GetData(string sql)
        {
            this.command = new SqlCommand(sql, this.Connection);
            SqlDataReader reader = this.command.ExecuteReader();
            //this.connection.Close();
            return reader;
        }



        public int ExecuteQuery(string sql)
        {
            this.command = new SqlCommand(sql, this.Connection);
            int result = this.command.ExecuteNonQuery();
            this.Connection.Close();
            return result;
        }
        public int ExecuteQuery(SqlCommand command)
        {
            this.command = command;
            int result = this.command.ExecuteNonQuery();
            this.Connection.Close();
            return result;
        }
        public void CloseConnection()
        {
            this.Connection.Close();
        }
        public void Dispose()
        {
            this.Connection.Close();
        }
    }
}