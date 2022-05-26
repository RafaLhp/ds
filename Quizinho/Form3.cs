using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quizinho
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            Jogador jg = new Jogador();

            if (rdbMaradona.Checked)
            {
                jg.maradona = true;
            }
            else
            {
                jg.maradona = false;
            }

            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Jogador jg = new Jogador();

            jg.pontuacao -= 1;

            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
