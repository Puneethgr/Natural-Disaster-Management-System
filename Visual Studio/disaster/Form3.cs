using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;

namespace disaster
{
    public partial class Form3 : Form
    {
        //Connect PostgreSQL to Visual Studio
        //Enter your postgresql database details - userid, password and database name
        private string connstring = String.Format("Server={0};Port={1};" +
         "User Id={2};Password={3};Database={4};",
         "localhost", 5432, "yourpostgresuserid", "yourpostgrespassword", "yourdatabasename");


        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        private int rowIndex = -1;
        private DataGridView r;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        // login button clicked
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(connstring);
                NpgsqlCommand SelectCommand = new NpgsqlCommand("SELECT * from admin_login WHERE admin_id='" + this.textBox1.Text + "' AND password='" + this.textBox2.Text + "'", conn);
                conn.Open();
                NpgsqlDataReader myReader = SelectCommand.ExecuteReader();


                int count = 0;

                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    conn.Close();
                    MessageBox.Show("Logging in.. Press OK.");
                    this.Hide();
                    Form6 obj = new Form6();
                    obj.Show();
                }
                else
                {
                    conn.Close();
                    label3.Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Some error occurred :" + ex);
            }
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new Form1();
            obj.Show();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
