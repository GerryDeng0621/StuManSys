using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace StuManSys
{
    class Opreate
    {
        public SqlConnection conn()							
        {
            string con = "data source=.\\sqlexpress;initial catalog=StuDB;integrated security=sspi;";

            SqlConnection conn = new SqlConnection(con);			
            return conn;									
        }
        public bool OPSQL(string SQLcmd)	
        {
            SqlConnection con = conn();						
            con.Open();									
            SqlCommand cmd = new SqlCommand(SQLcmd, con);	
            bool succ = true;								
            try
            {
                cmd.ExecuteNonQuery();						
            }
            catch (Exception e)								
            {
                MessageBox.Show("错误！");				
                succ = false;									
            }
            return succ;									
        }

        public string FiledValue(string sqlcmd)					
        {
            string count = "";
            SqlConnection con = conn();						
            con.Open();									
            SqlCommand cmd = new SqlCommand(sqlcmd, con);
            try
            {
                SqlDataReader rs = cmd.ExecuteReader();			
                if (rs.Read())								
                {
                    count = rs[0].ToString();					
                }
            }
            catch (Exception e)								
            {
                MessageBox.Show("错误！");				
            }
            return count;									
        }
        public DataTable GetDataTable(String str, String TableName)	
        {
            DataSet ds = new DataSet();						
            SqlDataAdapter da = new SqlDataAdapter(str, conn());	
            try
            {
                da.Fill(ds, TableName);						
                return ds.Tables[0];							
            }
            catch
            {
                return new DataTable();						
            }
        }
    }
}
