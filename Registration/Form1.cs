using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration
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

        private void button1_Click(object sender, EventArgs e)
        {
            Regex r = new Regex(@"^[A-Z]*$");
            AddStudent add = new AddStudent();
            add.id = Convert.ToInt32(textBox1.Text);
            add.Fname = textBox2.Text;
            add.Lname = textBox3.Text;
            add.Address = textBox4.Text;
            add.schoolyear = Convert.ToDateTime(textBox5.Text);

            if (radioButton1.Checked)
                add.gender = 'M';
            else
                add.gender = 'F';


            if (textBox1.Text.Length > 5 || textBox1.Text.Length < 5)
            {
                errorp1.SetError(textBox1, "Id digit must be 5!");
            }
            else if (!(r.IsMatch(textBox2.Text)))
            {
                errorp1.SetError(textBox2, "First Name must be written in block letters!");
            }
            else if (!(r.IsMatch(textBox3.Text)))
            {
                errorp1.SetError(textBox3, "Last Name must be written in block letters!");
            }
            else if (string.IsNullOrEmpty(textBox4.Text))
            {
                errorp1.SetError(textBox4, "Address is required!");
            }
            else
            {
                errorp1.Clear();
                MessageBox.Show(add.add());
            }
        }
    }
    
}
