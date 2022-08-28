using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration
{
    public partial class CardDisplay : Form
    {
        public CardDisplay()
        {
            InitializeComponent();
        }

        private void CardDisplay_Load(object sender, EventArgs e)
        {
            foreach (var item in AddStudent.get()) 
            {
              CardControl c = new CardControl();
                c._lab1 = item.id;
                c._lab2 = item.Fname;
                c._lab3 = item.Lname;
                c._lab4 = item.Address;
                c._lab5 = item.schoolyear;
                c._lab6 = item.gender;
                flp1.Controls.Add(c);
                c.Click += (object o, EventArgs e2) =>
                {
                    DetailPage d = new DetailPage(item.id, item.Fname, item.Lname, item.Address, item.schoolyear, item.gender);
                    d.Show();
                };
            } 
        }
    }
}
