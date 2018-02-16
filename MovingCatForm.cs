using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingCatFinnD
{
    public partial class frmMovingCat : Form
    {
        public frmMovingCat()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            //this closes the program//
            this.Close();
        }

        private void mniCat1_Click(object sender, EventArgs e)
        {
            //this changes the cat picture//
            this.picCat.Image = Properties.Resources.cat1;
        }

        private void mniCat2_Click(object sender, EventArgs e)
        {
            //this also changes the cat image//
            this.picCat.Image = Properties.Resources.cat2;
        }
    }
}
