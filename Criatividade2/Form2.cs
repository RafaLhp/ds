using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Criatividade2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Sorteio sor = new Sorteio();

            label1.Text = Sorteio.time1;
            label3.Text = Sorteio.time4;

            label5.Text = Sorteio.time2;
            label4.Text = Sorteio.time3;

            label8.Text = Sorteio.time5;
            label7.Text = Sorteio.time8;

            label11.Text = Sorteio.time6;
            label10.Text = Sorteio.time7;

            label14.Text = Sorteio.time9;
            label13.Text = Sorteio.time12;

            label17.Text = Sorteio.time10;
            label16.Text = Sorteio.time11;

            label20.Text = Sorteio.time13;
            label19.Text = Sorteio.time16;

            label23.Text = Sorteio.time14;
            label22.Text = Sorteio.time15;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
