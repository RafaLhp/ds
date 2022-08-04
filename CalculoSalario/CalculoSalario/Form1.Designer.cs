namespace CalculoSalario
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdbGerente = new System.Windows.Forms.RadioButton();
            this.rdbVendedor = new System.Windows.Forms.RadioButton();
            this.rdbAtendente = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtSalarioFinal = new System.Windows.Forms.TextBox();
            this.txtValorBonificacao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnSalario = new System.Windows.Forms.Button();
            this.btnBonificacao = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbGerente
            // 
            this.rdbGerente.AutoSize = true;
            this.rdbGerente.Location = new System.Drawing.Point(6, 22);
            this.rdbGerente.Name = "rdbGerente";
            this.rdbGerente.Size = new System.Drawing.Size(66, 19);
            this.rdbGerente.TabIndex = 0;
            this.rdbGerente.TabStop = true;
            this.rdbGerente.Text = "Gerente";
            this.rdbGerente.UseVisualStyleBackColor = true;
            // 
            // rdbVendedor
            // 
            this.rdbVendedor.AutoSize = true;
            this.rdbVendedor.Location = new System.Drawing.Point(6, 47);
            this.rdbVendedor.Name = "rdbVendedor";
            this.rdbVendedor.Size = new System.Drawing.Size(75, 19);
            this.rdbVendedor.TabIndex = 1;
            this.rdbVendedor.TabStop = true;
            this.rdbVendedor.Text = "Vendedor";
            this.rdbVendedor.UseVisualStyleBackColor = true;
            // 
            // rdbAtendente
            // 
            this.rdbAtendente.AutoSize = true;
            this.rdbAtendente.Location = new System.Drawing.Point(6, 72);
            this.rdbAtendente.Name = "rdbAtendente";
            this.rdbAtendente.Size = new System.Drawing.Size(80, 19);
            this.rdbAtendente.TabIndex = 2;
            this.rdbAtendente.TabStop = true;
            this.rdbAtendente.Text = "Atendente";
            this.rdbAtendente.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cpf";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Salário base";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Salário final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Valor de bonificação";
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.Location = new System.Drawing.Point(128, 206);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.Size = new System.Drawing.Size(253, 23);
            this.txtSalarioBase.TabIndex = 9;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(128, 181);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(253, 23);
            this.txtCpf.TabIndex = 10;
            // 
            // txtSalarioFinal
            // 
            this.txtSalarioFinal.Location = new System.Drawing.Point(128, 232);
            this.txtSalarioFinal.Name = "txtSalarioFinal";
            this.txtSalarioFinal.Size = new System.Drawing.Size(253, 23);
            this.txtSalarioFinal.TabIndex = 11;
            // 
            // txtValorBonificacao
            // 
            this.txtValorBonificacao.Location = new System.Drawing.Point(128, 258);
            this.txtValorBonificacao.Name = "txtValorBonificacao";
            this.txtValorBonificacao.Size = new System.Drawing.Size(253, 23);
            this.txtValorBonificacao.TabIndex = 12;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(128, 155);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(253, 23);
            this.txtNome.TabIndex = 13;
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Location = new System.Drawing.Point(240, 32);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(141, 23);
            this.btnFuncionario.TabIndex = 14;
            this.btnFuncionario.Text = "Cadastrar funcionario";
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // btnSalario
            // 
            this.btnSalario.Location = new System.Drawing.Point(240, 61);
            this.btnSalario.Name = "btnSalario";
            this.btnSalario.Size = new System.Drawing.Size(141, 23);
            this.btnSalario.TabIndex = 15;
            this.btnSalario.Text = "Calcular salario";
            this.btnSalario.UseVisualStyleBackColor = true;
            // 
            // btnBonificacao
            // 
            this.btnBonificacao.Location = new System.Drawing.Point(240, 90);
            this.btnBonificacao.Name = "btnBonificacao";
            this.btnBonificacao.Size = new System.Drawing.Size(141, 23);
            this.btnBonificacao.TabIndex = 16;
            this.btnBonificacao.Text = "Calcular bonificação";
            this.btnBonificacao.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(240, 119);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Apresentar salario final";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbGerente);
            this.groupBox1.Controls.Add(this.rdbVendedor);
            this.groupBox1.Controls.Add(this.rdbAtendente);
            this.groupBox1.Location = new System.Drawing.Point(34, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 126);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 296);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnBonificacao);
            this.Controls.Add(this.btnSalario);
            this.Controls.Add(this.btnFuncionario);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtValorBonificacao);
            this.Controls.Add(this.txtSalarioFinal);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtSalarioBase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "/";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rdbGerente;
        private RadioButton rdbVendedor;
        private RadioButton rdbAtendente;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtSalarioBase;
        private TextBox txtCpf;
        private TextBox txtSalarioFinal;
        private TextBox txtValorBonificacao;
        private TextBox txtNome;
        private Button btnFuncionario;
        private Button btnSalario;
        private Button btnBonificacao;
        private Button button4;
        private GroupBox groupBox1;
    }
}