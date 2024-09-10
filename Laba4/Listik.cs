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
    public partial class Listik : Form
    {
        private List<Division> divisions;
        private List<Policeman> policemen;
        private List<TrafficCop> trafficCops;
        public Listik(List<Division> divisions, List<Policeman> policemen, List<TrafficCop> trafficCops)
        {
            InitializeComponent();
            this.divisions = divisions;
            this.policemen = policemen;
            this.trafficCops = trafficCops;
            listBox1.DataSource = divisions;
            listBox1.DisplayMember = "Name";
            listBox2.DataSource = policemen;
            listBox3.DataSource = trafficCops;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
