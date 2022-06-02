using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Criatividade2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void rdbGrupoA_CheckedChanged_1(object sender, EventArgs e)
        {
                cmbTimes.Items.Clear();
                cmbTimes.Items.Add("Palmeiras");
                cmbTimes.Items.Add("Emelec");
                cmbTimes.Items.Add("Deportivo Tachira");
                cmbTimes.Items.Add("Independiente Petrolero");
        }

        private void rdbGrupoD_CheckedChanged_1(object sender, EventArgs e)
        {
            cmbTimes.Items.Clear();
            cmbTimes.Items.Add("Atlético-MG");
            cmbTimes.Items.Add("Independiente del Valle");
            cmbTimes.Items.Add("Deportes Tolima");
            cmbTimes.Items.Add("América-MG");
        }

        private void rdbGrupoB_CheckedChanged(object sender, EventArgs e)
        {
            cmbTimes.Items.Clear();
            cmbTimes.Items.Add("Athletico-PR");
            cmbTimes.Items.Add("Libertad");
            cmbTimes.Items.Add("Caracas");
            cmbTimes.Items.Add("The Strongest");
        }

        private void rdbGrupoC_CheckedChanged_1(object sender, EventArgs e)
        {
            cmbTimes.Items.Clear();
            cmbTimes.Items.Add("Nacional");
            cmbTimes.Items.Add("Vélez");
            cmbTimes.Items.Add("RB Bragantino");
            cmbTimes.Items.Add("Estudiantes");
        }

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            Sorteio sor = new Sorteio();

            listBox1.Items.Add(Convert.ToString(cmbTimes.Text));
            //Sorteio.time1 = cmbTimes.Text;

            if (Sorteio.time1 == null)
            {
                Sorteio.time1 = cmbTimes.Text;
            }
            else if (Sorteio.time2 == null)
            {
                Sorteio.time2 = cmbTimes.Text;
            }
            else if(Sorteio.time3 == null)
            {
                Sorteio.time3 = cmbTimes.Text;
            }
            else if (Sorteio.time4 == null)
            {
                Sorteio.time4 = cmbTimes.Text;
            }
            else if (Sorteio.time5 == null)
            {
                Sorteio.time5 = cmbTimes.Text;
            }
            else if (Sorteio.time6 == null)
            {
                Sorteio.time6 = cmbTimes.Text;
            }
            else if (Sorteio.time7 == null)
            {
                Sorteio.time7 = cmbTimes.Text;
            }
            else if (Sorteio.time8 == null)
            {
                Sorteio.time8 = cmbTimes.Text;
            }
            else if (Sorteio.time9 == null)
            {
                Sorteio.time9 = cmbTimes.Text;
            }
            else if (Sorteio.time10 == null)
            {
                Sorteio.time10 = cmbTimes.Text;
            }
            else if (Sorteio.time11 == null)
            {
                Sorteio.time11 = cmbTimes.Text;
            }
            else if (Sorteio.time12 == null)
            {
                Sorteio.time12 = cmbTimes.Text;
            }
            else if (Sorteio.time13 == null)
            {
                Sorteio.time13 = cmbTimes.Text;
            }
            else if (Sorteio.time14 == null)
            {
                Sorteio.time14 = cmbTimes.Text;
            }
            else if (Sorteio.time15 == null)
            {
                Sorteio.time15 = cmbTimes.Text;
            }
            else if (Sorteio.time16 == null)
            {
                Sorteio.time16 = cmbTimes.Text;
            }
        }

        private void rdbGrupoE_CheckedChanged_1(object sender, EventArgs e)
        {
            cmbTimes.Items.Clear();
            cmbTimes.Items.Add("Boca Juniors");
            cmbTimes.Items.Add("Corinthians");
            cmbTimes.Items.Add("Deportivo Cali");
            cmbTimes.Items.Add("Always Ready");
        }

        private void rdbGrupoF_CheckedChanged_1(object sender, EventArgs e)
        {
            cmbTimes.Items.Clear();
            cmbTimes.Items.Add("River Plate");
            cmbTimes.Items.Add("Colo Colo");
            cmbTimes.Items.Add("Alianza Lima");
            cmbTimes.Items.Add("Fortaleza");
        }

        private void rdbGrupoG_CheckedChanged_1(object sender, EventArgs e)
        {
            cmbTimes.Items.Clear();
            cmbTimes.Items.Add("Peñarol");
            cmbTimes.Items.Add("Cerro Porteño");
            cmbTimes.Items.Add("Colón");
            cmbTimes.Items.Add("Olimpia");
        }

        private void rdbGrupoH_CheckedChanged_1(object sender, EventArgs e)
        {
            cmbTimes.Items.Clear();
            cmbTimes.Items.Add("Flamengo");
            cmbTimes.Items.Add("Univer. Católica");
            cmbTimes.Items.Add("Sporting Cristal");
            cmbTimes.Items.Add("Talleres");
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnIniciarSorteio_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
