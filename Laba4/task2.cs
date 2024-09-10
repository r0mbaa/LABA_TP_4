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
    public partial class task2 : Form
    {
        private List<Division> divisions;
        private List<Policeman> policemen;
        private List<TrafficCop> trafficCops;
        public task2(List<Division> divisions, List<Policeman> policemen, List<TrafficCop> trafficCops)
        {
            InitializeComponent();
            this.divisions = divisions;
            this.policemen = policemen;
            this.trafficCops = trafficCops;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DivForm divForm = new DivForm(divisions);
            divForm.Show();
        }

        private void task2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Listik listik = new Listik(divisions, policemen, trafficCops);
            listik.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PolForm polForm = new PolForm(policemen , divisions);
            polForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TrafficCopForm trafficCopForm = new TrafficCopForm(trafficCops, divisions);
            trafficCopForm.Show();
        }
    }
}
