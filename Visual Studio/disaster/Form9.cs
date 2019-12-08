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
    public partial class Form9 : Form
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
        public Form9()
        {
            InitializeComponent();
        }

       

        private void Select()
        {
            try
            {
                conn.Open();
                sql = @"SELECT * from officer_select()";
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

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) //insert data
        {
            try
            {
                conn.Open();

                sql = @"select * from officer_insert(:_officer_id,
			:_disasters_id,
			:_dname,
			:_oname,
			:_campaign_id,
			
			:_user_id)";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.Add(new NpgsqlParameter("_officer_id", NpgsqlDbType.Integer));
                cmd.Parameters["_officer_id"].Value = Convert.ToInt64(txtoid.Text);

                cmd.Parameters.Add(new NpgsqlParameter("_disasters_id", NpgsqlDbType.Integer));
                cmd.Parameters["_disasters_id"].Value = Convert.ToInt64(txtdid.Text);

                cmd.Parameters.AddWithValue("_dname", txtdname.Text);
                cmd.Parameters.AddWithValue("_oname", txtoname.Text);

                cmd.Parameters.Add(new NpgsqlParameter("_campaign_id", NpgsqlDbType.Integer));
                cmd.Parameters["_campaign_id"].Value = Convert.ToInt64(txtcid.Text);

                cmd.Parameters.Add(new NpgsqlParameter("_user_id", NpgsqlDbType.Integer));
                cmd.Parameters["_user_id"].Value = Convert.ToInt64(txtuid.Text);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    conn.Close();
                    MessageBox.Show("Inserted Successfully. Press OK...");
                    Select();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e) //delete data
        {
            
            try
            {
                conn.Open();
                sql = @"select * from officer_delete(:officer_id)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("officer_id", int.Parse(dgvData.Rows[rowIndex].Cells["_officer_id"].Value.ToString()));
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            Form6 obj = new Form6();
            obj.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            
                conn = new NpgsqlConnection(connstring);
                Select();

            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                rowIndex = e.RowIndex;
                txtoid.Text = dgvData.Rows[e.RowIndex].Cells["_officer_id"].Value.ToString();
                txtdid.Text = dgvData.Rows[e.RowIndex].Cells["_disasters_id"].Value.ToString();
                txtdname.Text = dgvData.Rows[e.RowIndex].Cells["_dname"].Value.ToString();
                txtoname.Text = dgvData.Rows[e.RowIndex].Cells["_oname"].Value.ToString();
                txtcid.Text = dgvData.Rows[e.RowIndex].Cells["_campaign_id"].Value.ToString();
                txtuid.Text = dgvData.Rows[e.RowIndex].Cells["_user_id"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from officer_update(
                :_officer_id,
	            :_disasters_id,
	            :_dname,
	            :_oname,
	            :_campaign_id,
	            :_user_id)";

               
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.Add(new NpgsqlParameter("_officer_id", NpgsqlDbType.Integer));
                cmd.Parameters["_officer_id"].Value = Convert.ToInt64(txtoid.Text);

                cmd.Parameters.Add(new NpgsqlParameter("_disasters_id", NpgsqlDbType.Integer));
                cmd.Parameters["_disasters_id"].Value = Convert.ToInt64(txtdid.Text);

                cmd.Parameters.AddWithValue("_dname", txtdname.Text);
                cmd.Parameters.AddWithValue("_oname", txtoname.Text);

                cmd.Parameters.Add(new NpgsqlParameter("_campaign_id", NpgsqlDbType.Integer));
                cmd.Parameters["_campaign_id"].Value = Convert.ToInt64(txtcid.Text);

                cmd.Parameters.Add(new NpgsqlParameter("_user_id", NpgsqlDbType.Integer));
                cmd.Parameters["_user_id"].Value = Convert.ToInt64(txtuid.Text);



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
