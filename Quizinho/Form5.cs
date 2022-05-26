using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quizinho
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            Jogador jg = new Jogador();

            if (rdbRooney.Checked)
            {
                jg.rooney = true;
            }
            else
            {
                jg.rooney = false;
            }

            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Jogador jg = new Jogador();

            jg.pontuacao -= 1;

            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }
    }
}
