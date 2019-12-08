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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void BTNDISSASTER_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form14 obj = new Form14();
            obj.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 obj = new Form12();
            obj.Show();
        }

        private void BTNCAMPAIGNS_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Form15 obj = new Form15();
            obj.Show();
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }
    }
}
