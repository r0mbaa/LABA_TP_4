using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba4
{
    public partial class Form1 : Form
    {
        public List<Division> divisions = new List<Division>();
        public List<Policeman> policemen = new List<Policeman>();
        public List<TrafficCop> trafficCops = new List<TrafficCop>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            task2 task2 = new task2(divisions, policemen, trafficCops);
            task2.Show();

            
        }
    }
}
