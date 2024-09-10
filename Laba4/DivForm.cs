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
    public partial class DivForm : Form
    {
        private List<Division> divisions;

        public DivForm(List<Division> divisions)
        {
            InitializeComponent();
            this.divisions = divisions;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) &&
                !string.IsNullOrEmpty(textBox2.Text) &&
                !string.IsNullOrEmpty(textBox3.Text))
            {
                Division newDivision = new Division();

                newDivision.Name = textBox1.Text;
                newDivision.Description = textBox2.Text;
                try
                {
                    newDivision.NumberDivisions = int.Parse(textBox3.Text);
                    
                    divisions.Add(newDivision);

                    MessageBox.Show("Данные сохранены!");
                }
                catch
                {
                    MessageBox.Show("Не смогли преобразовать вашу строку в число!");
                }
            }
            else
            {
                MessageBox.Show("Введите данные!");
            }
        }
    }
}
