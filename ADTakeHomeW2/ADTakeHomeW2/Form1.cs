using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADTakeHomeW2
{
    public partial class Form1 : Form
    {
        string age;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (Convert.ToInt32(kotak2.Text) >= 18)
            {
                age = "You are an adult";
            }
            else
            {
                age = "You are a minor";
            }
            MessageBox.Show("Name : " + kotak1.Text + "\nEmail : " + kotak3.Text + "\nPhone Number : " + kotak4.Text + "\n" + age, "Biodata", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            kotak1.Clear();
            kotak2.Clear();
            kotak3.Clear();
            kotak4.Clear();
        }
    }
}
