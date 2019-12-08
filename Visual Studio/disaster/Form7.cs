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


    public partial class Form7 : Form
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
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            Select();

        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
                txtcid.Text = dgvData.Rows[e.RowIndex].Cells["_campaign_id"].Value.ToString();
                txtcname.Text = dgvData.Rows[e.RowIndex].Cells["_cname"].Value.ToString();
                txtloc.Text = dgvData.Rows[e.RowIndex].Cells["_clocation"].Value.ToString();
     
               
            }
        }

        private void Select()
        {
            try
            {
                conn.Open();
                sql = @"SELECT * from campaign_select()";
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 obj = new Form6();
            obj.Show();
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                sql = @"select * from campaign_insert(:_campaign_id,:_cname,:_clocation,:_cdate)";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.Add(new NpgsqlParameter("_campaign_id", NpgsqlDbType.Integer));
                cmd.Parameters["_campaign_id"].Value = Convert.ToInt64(txtcid.Text);

                cmd.Parameters.AddWithValue("_cname", txtcname.Text);

                cmd.Parameters.AddWithValue("_clocation", txtloc.Text);

                cmd.Parameters.Add(new NpgsqlParameter("_cdate", NpgsqlDbType.Date));
                cmd.Parameters["_cdate"].Value = Convert.ToDateTime(txtdate.Text);




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


        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
         
            try
            {
                conn.Open();
                sql = @"select * from campaign_delete(:campaign_id)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("campaign_id", int.Parse(dgvData.Rows[rowIndex].Cells["_campaign_id"].Value.ToString()));
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from campaign_update(:_campaign_id,  
	:_cname,
	:_clocation)";
           
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.Add(new NpgsqlParameter("_campaign_id", NpgsqlDbType.Integer));
                cmd.Parameters["_campaign_id"].Value = Convert.ToInt64(txtcid.Text);

                cmd.Parameters.AddWithValue("_cname", txtcname.Text);

                cmd.Parameters.AddWithValue("_clocation", txtloc.Text);




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
