using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muabannhadat.DataP
{
    public class Dataprovider
    {
        static private Dataprovider instance;

        public static Dataprovider Instance
        {
            get { if (instance == null) instance = new Dataprovider(); return Dataprovider.instance; }
            private set { Dataprovider.instance = value; }
        }

        private Dataprovider() { }



        private string strcn = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=Muabannhadat;Integrated Security=True";

        public DataTable ExcuteQuery(string sql, object[] parameter = null)
        {
            DataTable table = new DataTable();

            using (SqlConnection connection = new SqlConnection(strcn))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);

                if (parameter != null)
                {
                    string[] listpara = sql.Split(' ');

                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);


                adapter.Fill(table);
                connection.Close();
            }

            return table;
        }

        public int ExcuteNonQuery(string sql, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(strcn))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);

                if (parameter != null)
                {
                    string[] listpara = sql.Split(' ');

                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }

        public object ExcuteScalar(string sql, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(strcn))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);

                if (parameter != null)
                {
                    string[] listpara = sql.Split(' ');

                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
    }
}
