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
    public partial class Form10 : Form
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
        public Form10()
        {
            InitializeComponent();
        }

        private void Select()
        {
            try
            {
                conn.Open();
                sql = @"SELECT * from donation_select()";
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
        private void Form10_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 o = new Form6();
            o.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                sql = @"select * from donation_insert(:_donation_id,
			:_donar_name,
			:_phno,
			:_amount_donated,
            :_disaster_id)";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.Add(new NpgsqlParameter("_donation_id", NpgsqlDbType.Integer));
                cmd.Parameters["_donation_id"].Value = Convert.ToInt64(txtdonationid.Text);

                cmd.Parameters.Add(new NpgsqlParameter("_disaster_id", NpgsqlDbType.Integer));
                cmd.Parameters["_disaster_id"].Value = Convert.ToInt64(txtdisasterid.Text);

                cmd.Parameters.AddWithValue("_donar_name", txtdname.Text);
               

                cmd.Parameters.Add(new NpgsqlParameter("_phno", NpgsqlDbType.Bigint));
                cmd.Parameters["_phno"].Value = Convert.ToInt64(txtphno.Text);

                cmd.Parameters.Add(new NpgsqlParameter("_amount_donated", NpgsqlDbType.Bigint));
                cmd.Parameters["_amount_donated"].Value = Convert.ToInt64(txtamt.Text);

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            try
            {
                conn.Open();
                sql = @"select * from donation_delete(:donation_id)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("donation_id", int.Parse(dgvData.Rows[rowIndex].Cells["_donation_id"].Value.ToString()));
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

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                rowIndex = e.RowIndex;
                txtdonationid.Text = dgvData.Rows[e.RowIndex].Cells["_donation_id"].Value.ToString();
                txtdname.Text = dgvData.Rows[e.RowIndex].Cells["_donar_name"].Value.ToString();
                txtphno.Text = dgvData.Rows[e.RowIndex].Cells["_phno"].Value.ToString();
                txtamt.Text = dgvData.Rows[e.RowIndex].Cells["_amount_donated"].Value.ToString();
                txtdisasterid.Text = dgvData.Rows[e.RowIndex].Cells["_disaster_id"].Value.ToString();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from donation_update(
                :_donation_id,
			    :_donar_name,
			    :_phno,
			    :_amount_donated,
                :_disaster_id)";

                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.Add(new NpgsqlParameter("_donation_id", NpgsqlDbType.Integer));
                cmd.Parameters["_donation_id"].Value = Convert.ToInt64(txtdonationid.Text);

                cmd.Parameters.Add(new NpgsqlParameter("_disaster_id", NpgsqlDbType.Integer));
                cmd.Parameters["_disaster_id"].Value = Convert.ToInt64(txtdisasterid.Text);

                cmd.Parameters.AddWithValue("_donar_name", txtdname.Text);


                cmd.Parameters.Add(new NpgsqlParameter("_phno", NpgsqlDbType.Bigint));
                cmd.Parameters["_phno"].Value = Convert.ToInt64(txtphno.Text);

                cmd.Parameters.Add(new NpgsqlParameter("_amount_donated", NpgsqlDbType.Bigint));
                cmd.Parameters["_amount_donated"].Value = Convert.ToInt64(txtamt.Text);


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
