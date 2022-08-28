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
    public partial class DetailPage : Form
    {
        public DetailPage(int id, string fname, string lname, string address, DateTime schoolyear, char gender )
        {
            InitializeComponent();
            lbl1.Text = id.ToString();
            lbl2.Text = fname;  
            lbl3.Text = lname;  
            lbl4.Text = address;
            lbl5.Text = schoolyear.ToString();  
            lbl6.Text = gender.ToString();  
        }

        private void DetailPage_Load(object sender, EventArgs e)
        {

        }
    }
}
