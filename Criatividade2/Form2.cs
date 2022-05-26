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
            Random randNum = new Random();

            for (int i = 0; i < 16; i++)
            {
                lstResultado.Items.Add(randNum.Next());
            }
        }
    }
}
