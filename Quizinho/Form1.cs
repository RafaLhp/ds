using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizinho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            Jogador jg = new Jogador();

            if (rdbRivaldo.Checked)
            {
                jg.rivaldo = 1;
            }
            else
            {
                jg.rivaldo = 0;
            }

            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        public class Jogador
        {
            
        }
    }
}
