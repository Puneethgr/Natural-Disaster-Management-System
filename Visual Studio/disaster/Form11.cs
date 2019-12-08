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

    
    public partial class Form11 : Form
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
        private void Form11_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            Select();

        }

        private void Select()
        {
            try {
                conn.Open();
                sql = @"SELECT * from user_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvData.DataSource = null;
                dgvData.DataSource = dt;
                conn.Close();
                
            }
            catch(Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error:" + ex.Message);
            }
            
        }
        public Form11()
        {
            InitializeComponent();
        }

        private void BTNADD_Click(object sender, EventArgs e)
        {
            
            try
            {
                conn.Open();
         
                sql = @"select * from user_insert(:_user_id,:_user_name,:_user_password,:_phno,:_aadhar_no,:_disasters_id)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.Add(new NpgsqlParameter("_user_id", NpgsqlDbType.Integer));
                cmd.Parameters["_user_id"].Value = Convert.ToInt64(textuid.Text);
                
                cmd.Parameters.AddWithValue("_user_name", textBox4.Text);
                cmd.Parameters.AddWithValue("_user_password", textBox2.Text);
                cmd.Parameters.Add(new NpgsqlParameter("_phno", NpgsqlDbType.Bigint));
                cmd.Parameters["_phno"].Value = Convert.ToInt64(textBox5.Text);
               
                cmd.Parameters.Add(new NpgsqlParameter("_aadhar_no", NpgsqlDbType.Bigint));
                cmd.Parameters["_aadhar_no"].Value = Convert.ToInt64(textBox3.Text);

                cmd.Parameters.Add(new NpgsqlParameter("_disasters_id", NpgsqlDbType.Integer));
                cmd.Parameters["_disasters_id"].Value = Convert.ToInt64(textBox6.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    conn.Close();
                    MessageBox.Show("Inserted Successfully. Press OK...");
                    Select();

                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex);
                conn.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 obj = new Form6();
            obj.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
                textuid.Text = dgvData.Rows[e.RowIndex].Cells["_user_id"].Value.ToString();
                textBox4.Text = dgvData.Rows[e.RowIndex].Cells["_user_name"].Value.ToString();
                textBox2.Text = dgvData.Rows[e.RowIndex].Cells["_user_password"].Value.ToString();
                textBox5.Text = dgvData.Rows[e.RowIndex].Cells["_phno"].Value.ToString();
                textBox3.Text = dgvData.Rows[e.RowIndex].Cells["_aadhar_no"].Value.ToString();
                textBox6.Text = dgvData.Rows[e.RowIndex].Cells["_disasters_id"].Value.ToString();
            }
        }

        private void textuid_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

       
     
        private void BTNDELETE_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0)
            {
                MessageBox.Show("Please choose student to delete");
                return;
            }
            try
            {
                conn.Open();
                sql = @"select * from user_delete(:user_id)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("user_id", int.Parse(dgvData.Rows[rowIndex].Cells["_user_id"].Value.ToString()));
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    conn.Close();
                    MessageBox.Show("Deletion successful");
                    rowIndex = -1;
                    Select();
                    
                }
                
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Deleted fail. Error:" + ex.Message);
            }
        }

      

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNNUMBERUPDATE_Click(object sender, EventArgs e)
        {
        }

        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            
            try
            {
                conn.Open();
                sql = @"select * from user_update(:_user_id,:_user_name, :_user_password, :_phno, :_aadhar_no, :_disasters_id)";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.Add(new NpgsqlParameter("_user_id", NpgsqlDbType.Integer));
                cmd.Parameters["_user_id"].Value = Convert.ToInt64(textuid.Text);

                cmd.Parameters.AddWithValue("_user_name", textBox4.Text);
                cmd.Parameters.AddWithValue("_user_password", textBox2.Text);
                cmd.Parameters.Add(new NpgsqlParameter("_phno", NpgsqlDbType.Bigint));
                cmd.Parameters["_phno"].Value = Convert.ToInt64(textBox5.Text);

                cmd.Parameters.Add(new NpgsqlParameter("_aadhar_no", NpgsqlDbType.Bigint));
                cmd.Parameters["_aadhar_no"].Value = Convert.ToInt64(textBox3.Text);

                cmd.Parameters.Add(new NpgsqlParameter("_disasters_id", NpgsqlDbType.Integer));
                cmd.Parameters["_disasters_id"].Value = Convert.ToInt64(textBox6.Text);


                
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    Select();
                    MessageBox.Show("Updated successfully");
                    Select();
                }
                else
                {
                    MessageBox.Show("Updated failed");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Updation failed. Error:" + ex.Message);
            }
        }
    }
}
