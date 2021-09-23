using System;
using System.Windows.Forms;

namespace XOX_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string _sıradaki = "X";
        int _puan = 0;
        int _puan1 = 0;
        void YeniOyun()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            _sıradaki = "X";
            _puan = 0;
            _puan1 = 0;

            label3.Text = _puan.ToString();
            label4.Text = _puan1.ToString();
        }
        void Kontrol()
        {
            if (button1.Text == "X" && button2.Text == "O" && button3.Text == "X")
            {
                if (_sıradaki == "X")
                {
                    _puan += 20;
                    label3.Text = _puan.ToString();
                }
                else
                {
                    _puan1 += 20;
                    label4.Text = _puan1.ToString();
                }
                if (MessageBox.Show("Tebrikler " + _sıradaki + " Oyuncusu Kazandı.") == DialogResult.OK)
                {
                    Yeni_Oyun a = new Yeni_Oyun();
                    a.Show();
                    YeniOyun();
                }
            }
            else if (button4.Text == "X" && button5.Text == "O" && button6.Text == "X")
            {
                if (_sıradaki == "X")
                {
                    _puan += 20;
                    label3.Text = _puan.ToString();
                }
                else
                {
                    _puan1 += 20;
                    label4.Text = _puan1.ToString();
                }
                if (MessageBox.Show("Tebrikler " + _sıradaki + " Oyuncusu Kazandı.") == DialogResult.OK)
                {
                    Yeni_Oyun a = new Yeni_Oyun();
                    a.Show();
                    YeniOyun();
                }
            }
            else if (button7.Text == "X" && button8.Text == "O" && button9.Text == "X")
            {
                if (_sıradaki == "X")
                {
                    _puan += 20;
                    label3.Text = _puan.ToString();
                }
                else
                {
                    _puan1 += 20;
                    label4.Text = _puan1.ToString();
                }
                if (MessageBox.Show("Tebrikler " + _sıradaki + " Oyuncusu Kazandı.") == DialogResult.OK)
                {
                    Yeni_Oyun a = new Yeni_Oyun();
                    a.Show();
                    YeniOyun();
                }
            }
            else if (button1.Text == "X" && button4.Text == "O" && button7.Text == "X")
            {
                if (_sıradaki == "X")
                {
                    _puan += 20;
                    label3.Text = _puan.ToString();
                }
                else
                {
                    _puan1 += 20;
                    label4.Text = _puan1.ToString();
                }
                if (MessageBox.Show("Tebrikler " + _sıradaki + " Oyuncusu Kazandı.") == DialogResult.OK)
                {
                    Yeni_Oyun a = new Yeni_Oyun();
                    a.Show();
                    YeniOyun();
                }
            }
            else if (button2.Text == "X" && button5.Text == "O" && button8.Text == "X")
            {
                if (_sıradaki == "X")
                {
                    _puan += 20;
                    label3.Text = _puan.ToString();
                }
                else
                {
                    _puan1 += 20;
                    label4.Text = _puan1.ToString();
                }
                if (MessageBox.Show("Tebrikler " + _sıradaki + " Oyuncusu Kazandı.") == DialogResult.OK)
                {
                    Yeni_Oyun a = new Yeni_Oyun();
                    a.Show();
                    YeniOyun();
                }
            }
            else if (button3.Text == "X" && button6.Text == "O" && button9.Text == "X")
            {
                if (_sıradaki == "X")
                {
                    _puan += 20;
                    label3.Text = _puan.ToString();
                }
                else
                {
                    _puan1 += 20;
                    label4.Text = _puan1.ToString();
                }
                if (MessageBox.Show("Tebrikler " + _sıradaki + " Oyuncusu Kazandı.") == DialogResult.OK)
                {
                    Yeni_Oyun a = new Yeni_Oyun();
                    a.Show();
                    YeniOyun();
                }
            }
            else if (button1.Text == "X" && button5.Text == "O" && button9.Text == "X")
            {
                if (_sıradaki == "X")
                {
                    _puan += 20;
                    label3.Text = _puan.ToString();
                }
                else
                {
                    _puan1 += 20;
                    label4.Text = _puan1.ToString();
                }
                if (MessageBox.Show("Tebrikler " + _sıradaki + " Oyuncusu Kazandı.") == DialogResult.OK)
                {
                    Yeni_Oyun a = new Yeni_Oyun();
                    a.Show();
                    YeniOyun();
                }
            }
            else if (button3.Text == "X" && button5.Text == "O" && button7.Text == "X")
            {
                if (_sıradaki == "X")
                {
                    _puan += 20;
                    label3.Text = _puan.ToString();
                }
                else
                {
                    _puan1 += 20;
                    label4.Text = _puan1.ToString();
                }
                if (MessageBox.Show("Tebrikler " + _sıradaki + " Oyuncusu Kazandı.") == DialogResult.OK)
                {
                    Yeni_Oyun a = new Yeni_Oyun();
                    a.Show();
                    YeniOyun();
                }
            }
            else
            {
                if (!button1.Enabled && !button2.Enabled && !button3.Enabled && !button4.Enabled && !button5.Enabled && !button6.Enabled && !button7.Enabled && !button8.Enabled && !button9.Enabled)
                {
                    if (MessageBox.Show("Berabere Kaldınız", "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        Yeni_Oyun a = new Yeni_Oyun();
                        a.Show();
                        YeniOyun();
                    }
                }
            }
        }
        void SıradaKimVar()
        {
            if (_sıradaki == "X")
            {
                _sıradaki = "O";
            }
            else
            {
                _sıradaki = "X";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = _sıradaki;
            button1.Enabled = false;
            Kontrol();
            SıradaKimVar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = _sıradaki;
            button2.Enabled = false;
            Kontrol();
            SıradaKimVar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = _sıradaki;
            button3.Enabled = false;
            Kontrol();
            SıradaKimVar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = _sıradaki;
            button4.Enabled = false;
            Kontrol();
            SıradaKimVar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = _sıradaki;
            button5.Enabled = false;
            Kontrol();
            SıradaKimVar();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = _sıradaki;
            button6.Enabled = false;
            Kontrol();
            SıradaKimVar();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = _sıradaki;
            button7.Enabled = false;
            Kontrol();
            SıradaKimVar();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = _sıradaki;
            button8.Enabled = false;
            Kontrol();
            SıradaKimVar();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = _sıradaki;
            button9.Enabled = false;
            Kontrol();
            SıradaKimVar();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = _puan.ToString();
            label4.Text = _puan1.ToString();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
