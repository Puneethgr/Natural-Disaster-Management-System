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
    public partial class Form8 : Form
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

        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            Select();

        }
        private void Select()
        {
            try
            {
                conn.Open();
                sql = @"SELECT * from disaster_select()";
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
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 obj = new Form6();
            obj.Show();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                sql = @"select * from disaster_insert(:_disaster_id,
	        :_dname,
			:_dlocation,
			:_total_loss,
            :_disasterdate,
			:_area_affected)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.Add(new NpgsqlParameter("_disaster_id", NpgsqlDbType.Integer));
                cmd.Parameters["_disaster_id"].Value = Convert.ToInt64(txtdid.Text);

                cmd.Parameters.AddWithValue("_dname", txtname.Text);
                cmd.Parameters.AddWithValue("_dlocation", txtloc.Text);

                cmd.Parameters.Add(new NpgsqlParameter("_total_loss", NpgsqlDbType.Bigint));
                cmd.Parameters["_total_loss"].Value = Convert.ToInt64(txtloss.Text);;

                cmd.Parameters.Add(new NpgsqlParameter("_disasterdate", NpgsqlDbType.Date));
                cmd.Parameters["_disasterdate"].Value = Convert.ToDateTime(txtdate.Text);

                cmd.Parameters.AddWithValue("_area_affected", txtarea.Text);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    conn.Close();
                    Select();
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

        private void BTNDELETE_Click(object sender, EventArgs e)
        {
           
            try
            {
                conn.Open();
                sql = @"select * from disaster_delete(:disaster_id)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("disaster_id", int.Parse(dgvData.Rows[rowIndex].Cells["_disaster_id"].Value.ToString()));
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

        private void button2_Click(object sender, EventArgs e) //update
        {
            try
            {
                conn.Open();
                sql = @"select * from disaster_update(:_disaster_id,
        :_dname,
		:_dlocation,
		:_total_loss,
		:_area_affected)";

                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.Add(new NpgsqlParameter("_disaster_id", NpgsqlDbType.Integer));
                cmd.Parameters["_disaster_id"].Value = Convert.ToInt64(txtdid.Text);

                cmd.Parameters.AddWithValue("_dname", txtname.Text);

                cmd.Parameters.AddWithValue("_dlocation", txtloc.Text);

                cmd.Parameters.Add(new NpgsqlParameter("_total_loss", NpgsqlDbType.Bigint));
                cmd.Parameters["_total_loss"].Value = Convert.ToInt64(txtloss.Text); ;

                cmd.Parameters.AddWithValue("_area_affected", txtarea.Text);


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

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
                txtdid.Text = dgvData.Rows[e.RowIndex].Cells["_disaster_id"].Value.ToString();
                txtname.Text = dgvData.Rows[e.RowIndex].Cells["_dname"].Value.ToString();
                txtloc.Text = dgvData.Rows[e.RowIndex].Cells["_dlocation"].Value.ToString();
                txtloss.Text = dgvData.Rows[e.RowIndex].Cells["_total_loss"].Value.ToString();
                txtdate.Text = dgvData.Rows[e.RowIndex].Cells["_disasterdate"].Value.ToString();
                txtarea.Text = dgvData.Rows[e.RowIndex].Cells["_area_affected"].Value.ToString();
            }
        }
    }
}
