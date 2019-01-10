using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Form
{
    class DbConnection
    {
        public SqlConnection conn = new SqlConnection(@"Server=TAHA-MURTAZA\SQLEXPRESS  ;Initial Catalog=IHSAAS Trust Fund;Integrated Security=true");
        public SqlCommand cmd = new SqlCommand();

        public DbConnection()
        { }

        public void Update(string query)
        {
            conn.Open();
            cmd.CommandText = query;
            cmd.Connection = conn;  
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Inserts(string query)
        {
            conn.Open();
            cmd.CommandText = query;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable Select(string query)
        {
            conn.Open();
            cmd.CommandText = query;
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;


        }

        public bool CheckIfExists(string query)
        {
            bool exists = false;
            if (query != "")
            {
                conn.Open();
                cmd.CommandText = query;
                cmd.Connection = conn;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    exists = true;
                }
                else
                {
                    exists = false;
                }



                reader.Close();
                reader.Dispose();


                conn.Close();
            }

            return exists;

        }
    }

}
