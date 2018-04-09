using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavValueCalculator
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String qty = richTextBox1.Text.Trim();


            Stopwatch stopwatch = new Stopwatch();

            // Begin timing.
            stopwatch.Start();

            DataTable dt = ReturnQueryResultDatatable(qty);

            // Stop timing.
            stopwatch.Stop();

            // Write result.
            MessageBox.Show( "Rows :"+dt.Rows.Count+" Fetch Time elapsed: {0}", stopwatch.Elapsed.ToString() );

            stopwatch.Reset();
            stopwatch.Start();
            int i = 0;
            foreach (DataRow drow in dt.Rows)
            {
                InsertSessionToODoo(drow);
                Debug.WriteLine(i + Environment.NewLine);
                i++;
            }
            stopwatch.Stop();

            // Write result.
            MessageBox.Show("Rows :" + dt.Rows.Count + " Insert Time elapsed: {0}", stopwatch.Elapsed.ToString());

        }












        public static DataTable ReturnQueryResultDatatable(String Qry)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection("Data Source=197.156.85.246;Initial Catalog=ZKTIME;User ID=sa;Password=admin_123"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = Qry;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        dt.Load(rdr);
                    }
                }
            }

            return dt;
        }



        public int InsertSessionToODoo(DataRow dataRow)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(@"insert into attendance_log (create_uid,create_date,write_uid,write_date,name,emp_code)
values(1,:create_date,1,:write_date,:name,:emp_code)RETURNING id");
            cmd.Parameters.AddWithValue("create_date",DateTime.Now);
            cmd.Parameters.AddWithValue("write_date", DateTime.Now);
            cmd.Parameters.AddWithValue("name", DateTime.Parse( dataRow["CHECKTIME"].ToString()));
            cmd.Parameters.AddWithValue("emp_code", dataRow["BADGENUMBER"].ToString());
       


            return InsertAndGetID(cmd);

        }


        public int InsertAndGetID(NpgsqlCommand cmd)
        {


            NpgsqlConnection conn = OpenConnection();
            conn.Open();
            cmd.Connection = conn;
            var newid = cmd.ExecuteScalar();
            conn.Close();
            return int.Parse(newid.ToString());
        }



        public NpgsqlConnection OpenConnection()
        {
            string connstring = String.Format("Server ={0};Port={1};" +
                      "User Id={2};Password={3};Database={4};",
                      "192.168.1.73", "5432", "odoo",
                     "at123", "atr-dec26");
            NpgsqlConnection conn = new NpgsqlConnection(connstring);


            return conn
            ;
        }







    }
}
