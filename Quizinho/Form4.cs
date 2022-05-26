using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quizinho
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            Jogador jg = new Jogador();

            if (rdbDrogba.Checked)
            {
                jg.drogba = true;
            }
            else
            {
                jg.drogba = false;
            }

            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Jogador jg = new Jogador();

            jg.pontuacao -= 1;

            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }
}
