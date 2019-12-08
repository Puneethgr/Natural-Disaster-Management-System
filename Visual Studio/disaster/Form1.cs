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

namespace disaster
{
    public partial class Form1 : Form
    {
      

        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

           
        }

        //user login button
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 userobj = new Form2();
            this.Hide();
            userobj.Show();

        }


        //admin login button
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 adminobj = new Form3();
            this.Hide();
            adminobj.Show();
        }

        //officer login button
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form12 officerobj = new Form12();
            this.Hide();
            officerobj.Show();
        }
    }
}
