using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quizinho
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Jogador jg = new Jogador();

            if (jg.rivaldo == 1)
            {
                lblRes1.Text = "Correto!";
                jg.pontuacao += 1;
            }
            else
            {
                lblRes1.Text = "Errado";
            }
            if (jg.zico == 1)
            {
                lblRes2.Text = "Correto!";
                jg.pontuacao += 1;
            }
            else
            {
                lblRes2.Text = "Errado";
            }
            if (jg.maradona == 1)
            {
                lblRes3.Text = "Correto!";
                jg.pontuacao += 1;
            }
            else
            {
                lblRes3.Text = "Errado";
            }
            if (jg.drogba == 1)
            {
                lblRes4.Text = "Correto!";
                jg.pontuacao += 1;
            }
            else
            {
                lblRes4.Text = "Errado";
            }
            if (jg.rooney == 1)
            {
                lblRes5.Text = "Correto!";
                jg.pontuacao += 1;
            }
            else
            {
                lblRes5.Text = "Errado";
            }

            lblPontuacao.Text = "PONTUAÇÃO: " + jg.pontuacao + "/5";
        }

        private void lblPontuacao_Click(object sender, EventArgs e)
        {
            
        }
    }
} 
