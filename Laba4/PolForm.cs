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
    public partial class PolForm : Form
    {
        private List<Policeman> policemen;
        //private List<Division> divisions;
        public PolForm(List<Policeman> policemen, List<Division> divisions)
        {
            InitializeComponent();
            this.policemen = policemen; 
            //this.divisions = divisions;
            comboBox1.DataSource = divisions;
            comboBox1.DisplayMember = "Name";
        }

        private void PolForm_Load(object sender, EventArgs e)
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
                Policeman newPoliceman = new Policeman();
                newPoliceman.FirstName = textBox1.Text;
                newPoliceman.LastName = textBox2.Text;
                try
                {
                    newPoliceman.Age = int.Parse(textBox3.Text);
                    newPoliceman.IndividualNumber = int.Parse(textBox5.Text);
                    newPoliceman.Division = (Division)comboBox1.SelectedItem;
                    policemen.Add(newPoliceman);
                    
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
