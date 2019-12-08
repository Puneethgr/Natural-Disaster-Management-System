using System;
using Npgsql;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using NpgsqlTypes;
namespace disaster
{
    public partial class Form4 : Form
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
        public Form4()
        {
            InitializeComponent();
        }

        private void Select_disaster()
        {
            try
            {
                conn.Open();
                sql = @"SELECT disaster_id,dname from disaster";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvData.DataSource = null;
                dgvData.DataSource = dt;
                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error:" + ex.Message);
            }

        }

        private void Select_userid()
        {
            try
            {
                conn.Open();
                sql = @"SELECT user_id from user_login";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvData2.DataSource = null;
                dgvData2.DataSource = dt;
                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error:" + ex.Message);
            }

        }
        private void Form4_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
          
            Select_disaster();
            Select_userid();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           

        }

        public void button1_Click(object sender, EventArgs e) //register pressed
        {
            try
            {
                conn.Open();

                sql = @"select * from user_insert(:_user_id,:_user_name,:_user_password,:_phno,:_aadhar_no,:_disasters_id)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.Add(new NpgsqlParameter("_user_id", NpgsqlDbType.Integer));
                cmd.Parameters["_user_id"].Value = Convert.ToInt64(txtuid.Text);

                cmd.Parameters.AddWithValue("_user_name", txtname.Text);
                cmd.Parameters.AddWithValue("_user_password", txtpass.Text);
                cmd.Parameters.Add(new NpgsqlParameter("_phno", NpgsqlDbType.Bigint));
                cmd.Parameters["_phno"].Value = Convert.ToInt64(txtphno.Text);

                cmd.Parameters.Add(new NpgsqlParameter("_aadhar_no", NpgsqlDbType.Bigint));
                cmd.Parameters["_aadhar_no"].Value = Convert.ToInt64(txtano.Text);

                cmd.Parameters.Add(new NpgsqlParameter("_disasters_id", NpgsqlDbType.Integer));
                cmd.Parameters["_disasters_id"].Value = Convert.ToInt64(txtdid.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    conn.Close();
                    MessageBox.Show("Registered Successfully. Press OK...");
                    

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 obj = new Form2();
            obj.Show();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
         

        }

        private void dgvData2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
