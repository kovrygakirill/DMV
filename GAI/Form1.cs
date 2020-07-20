using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employy form = new Employy();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Model form = new Model();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Owner form = new Owner();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PlaceBuy form = new PlaceBuy();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List_Automobile form = new List_Automobile();
            form.ShowDialog();
        }
    }
}
