using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projeto_sqlds
{
    public partial class Form1 : Form
    {
        SqlConnection sqlCon = null;

        private String strCon = "Data Source = LI03 - 13; Initial Catalog = ; User ID = sa; password=123456";

        private String strSql = "";

        SqlConnection objConect = null;

        SqlConnection objCommand = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbGrupoTime.Items.Add("GrupoA");
            cmbGrupoTime.Items.Add("GrupoB");
            cmbGrupoTime.Items.Add("GrupoC");
            cmbGrupoTime.Items.Add("GrupoD");


        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            strSql = "select * from " + cmbGrupoTime.SelectedItem + "";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            sqlCon.Open();

            SqlDataReader dr = comando.ExecuteReader();

            if (dr.HasRows == true)
            {
                dr.Read();

                listBox1.Items.Add(Convert.ToString(dr[""]));
            }
            else
            {
                MessageBox.Show("Registro não existe!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            txtCodigoTime.Clear();
            txtNomeTime.Clear();
            txtPaisTime.Clear();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            strSql = "insert into " + cmbGrupoTime.SelectedItem + " (codigo_time, nome_time, pais_time) values (@codigo_time, @nome_time, @pais_time)";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, strCon);

            comando.Parameters.Add("@codigo_time", SqlDbType.Int).Value = txtCodigoTime.Text;
            comando.Parameters.Add("@nome_time", SqlDbType.VarChar).Value = txtNomeTime.Text;
            comando.Parameters.Add("@pais_time", SqlDbType.VarChar).Value = txtPaisTime.Text;

            sqlCon.Open();

            comando.ExecuteNonQuery();

            MessageBox.Show("Time cadastrado com sucesso!");

            sqlCon.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            strSql = "update " + cmbGrupoTime.SelectedItem + " set codigo_time = @codigo_time, nome_time = @nome_time, pais_time = @pais_time";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, strCon);

            comando.Parameters.Add("@codigo_time", SqlDbType.Int).Value = txtCodigoTime.Text;
            comando.Parameters.Add("@nome_time", SqlDbType.VarChar).Value = txtNomeTime.Text;
            comando.Parameters.Add("@pais_time", SqlDbType.VarChar).Value = txtPaisTime.Text;

            sqlCon.Open();

            MessageBox.Show("Time alterado com sucesso!");

            sqlCon.Close();
        }
    }
}
