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
    public partial class mdi : Form
    {
        public mdi()
        {
            InitializeComponent();
        }

        private void mdi_Load(object sender, EventArgs e)
        {

        }

        private void cardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activescreen = ActiveMdiChild;
            if (activescreen != null)
            {
                activescreen.Close();
            }
            CardDisplay screen = new CardDisplay();
            screen.MdiParent = this;
            screen.Show();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activescreen = ActiveMdiChild;
            if (activescreen != null) 
            {
                activescreen.Close();
            }
            Form1 screen = new Form1();
            screen.MdiParent = this;
            screen.Show();
        }
    }
}
