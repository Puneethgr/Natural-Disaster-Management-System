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
    public partial class Form2 : Form
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

        public Form2()
        {
            InitializeComponent();
        }

        //login button clicked
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(connstring);
                NpgsqlCommand SelectCommand = new NpgsqlCommand("SELECT * from user_login WHERE user_id='" + this.textBox1.Text + "' AND user_password='" + this.textBox2.Text + "'", conn);
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
                    Form5 obj = new Form5();
                    obj.Show();
                }
                else
                {
                    conn.Close();
                    label3.Show();
                }
            }
            catch(Exception ex)
            {
             
                MessageBox.Show("Some error occurred :" + ex);
            }
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        //user registration button
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 registrationobj = new Form4();
            registrationobj.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new Form1();
            obj.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
