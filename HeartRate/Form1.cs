using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeartRate
{
    public partial class Form1 : Form
    {
        Heart heart;
        public Form1()
        {
            InitializeComponent();
            heart = new Heart();
        }

        private void HeartHit() => RateLabel.Text = heart.Hit().ToString();

        private void Hit_button_Click(object sender, EventArgs e)
        {
            HeartHit();
        }

        private void Hit_button_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                HeartHit();
        }
    }
}
