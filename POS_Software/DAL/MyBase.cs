using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace DAL
{
    public class MyBase
    {
        public string Search { get; set; }
        protected string error;
        public string Error
        {
            get
            {
                return error;
            }
        }
        protected SqlCommand MyCommand { get; set; }
        protected SqlDataReader MyReader { get; set; }
        
        protected SqlConnection CN = new SqlConnection(ConfigurationManager.ConnectionStrings["POSDB"].ConnectionString);
        protected bool Connection()
        {
            try
            {
                CN.Open();
                return true;
            }
            catch(Exception ex)
            {
                error = ex.Message;
            }
            return false;
        }
        protected SqlCommand CommandBuilder(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CN;
            cmd.CommandText = sql;
            return cmd;
        }
        protected bool ExecuteNQ(SqlCommand cmd)
        {
            if (!Connection())
                return false;
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return false;
        }
        protected SqlDataReader ExecuteReader(SqlCommand cmd)
        {
            if (!Connection())
                return null;

            return cmd.ExecuteReader();            
        }
        protected DataSet ExecuteDataSet(string sql)
        {
            if (!Connection())
                return null;
            SqlDataAdapter da = new SqlDataAdapter(CommandBuilder(sql));
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        protected DataSet ExecuteDataSet(SqlCommand cmd)
        {
            if (!Connection())
                return null;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds;
        }
    }
}