using System;
using System.Windows.Forms;

namespace XOX_Oyunu
{
    public partial class Yeni_Oyun : Form
    {
        public Yeni_Oyun()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
