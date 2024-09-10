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
    public partial class TrafficCopForm : Form
    {
        private List<TrafficCop> trafficCopList;
        public TrafficCopForm(List<TrafficCop> trafficCopList, List<Division> divisions)
        {
            InitializeComponent();
            this.trafficCopList = trafficCopList;
            comboBox1.DataSource = divisions;
            comboBox1.DisplayMember = "Name";

        }

        private void TrafficCopForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) &&
               !string.IsNullOrEmpty(textBox2.Text) &&
               !string.IsNullOrEmpty(textBox3.Text) &&
               !string.IsNullOrEmpty(textBox5.Text) &&
               !string.IsNullOrEmpty(comboBox1.Text))
            {
                TrafficCop trafficCop = new TrafficCop();
                trafficCop.FirstName = textBox1.Text;
                trafficCop.LastName = textBox2.Text;
                

                
                try
                {
                    trafficCop.Age = int.Parse(textBox3.Text);
                    trafficCop.IndividualNumber = int.Parse(textBox5.Text);
                    trafficCop.Division = (Division)comboBox1.SelectedItem;
                    trafficCopList.Add(trafficCop);
                }
                catch
                {
                    MessageBox.Show("Введите правильные данные!");
                }

            }
            else
            {
                MessageBox.Show("Введите данные!");
            }
        }
    }
}
