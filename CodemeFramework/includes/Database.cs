using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

/*
    DataClasses1DataContext db = new DataClasses1DataContext();

    var query = from c in db.users select c;

    string str = "";

    foreach (var q in query)
    {
        str += q.fullname;
    }

    textBox1.Text = str;
 */

namespace CodemeFramework.includes
{
    class Database
    {
        SqlConnection cnn;

        public bool connect()
        {
            bool result = false;
            string connetionString = null;
            //SqlConnection cnn ;
            connetionString = "Data Source=MINHTIEN-PC\\SQLEXPRESS;Initial Catalog=testapp;Integrated Security=True;Pooling=False";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }

            return result;
        }

        public void close()
        {
            cnn.Close();
        }

        public DataTable query(string sql)
        {
            /*
            foreach ( DataRow dr in table.Rows )
            {
                string name = dr["columnname"].ToString();
            }
            */

            DataTable table = new DataTable();

            var adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(sql, cnn);
            adapter.Fill(table);

            return table;
        }

        public static void insert()
        {

        }

        public static void remove()
        {

        }

        public static void update()
        {

        }

        public static void get()
        {

        }

    }
}
