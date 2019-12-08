using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace disaster
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
           
        }

        private void BTNCAMPAIGNS_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 obj = new Form7();
            obj.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 obj = new Form3();
            obj.Show();
        }

        private void BTNDISSASTER_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 obj = new Form8();
            obj.Show();
        }

        private void BTNOFFICER_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 obj = new Form9();
            obj.Show();
        }

        private void BTNDONATION_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 obj = new Form10();
            obj.Show();
        }

        private void BTNUSERS_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 obj = new Form11();
            obj.Show();

        }
    }
}
