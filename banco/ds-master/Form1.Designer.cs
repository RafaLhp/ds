
namespace ds2_banco
{
    partial class frmNovaconta
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
            this.gpbDadosCliente = new System.Windows.Forms.GroupBox();
            this.tbxCpf = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.tbxSobrenome = new System.Windows.Forms.TextBox();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.gpbDadosConta = new System.Windows.Forms.GroupBox();
            this.tbxSaldo = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.tbxLimite = new System.Windows.Forms.TextBox();
            this.lblLimite = new System.Windows.Forms.Label();
            this.tbxNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.gbxMovimentacao = new System.Windows.Forms.GroupBox();
            this.tbxValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.rbtDeposito = new System.Windows.Forms.RadioButton();
            this.rbtSaque = new System.Windows.Forms.RadioButton();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpbDadosCliente.SuspendLayout();
            this.gpbDadosConta.SuspendLayout();
            this.gbxMovimentacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDadosCliente
            // 
            this.gpbDadosCliente.Controls.Add(this.tbxCpf);
            this.gpbDadosCliente.Controls.Add(this.lblCpf);
            this.gpbDadosCliente.Controls.Add(this.tbxSobrenome);
            this.gpbDadosCliente.Controls.Add(this.lblSobrenome);
            this.gpbDadosCliente.Controls.Add(this.tbxNome);
            this.gpbDadosCliente.Controls.Add(this.lblNome);
            this.gpbDadosCliente.Location = new System.Drawing.Point(12, 12);
            this.gpbDadosCliente.Name = "gpbDadosCliente";
            this.gpbDadosCliente.Size = new System.Drawing.Size(264, 141);
            this.gpbDadosCliente.TabIndex = 0;
            this.gpbDadosCliente.TabStop = false;
            this.gpbDadosCliente.Text = "Dados do Cliente";
            // 
            // tbxCpf
            // 
            this.tbxCpf.Location = new System.Drawing.Point(43, 98);
            this.tbxCpf.Name = "tbxCpf";
            this.tbxCpf.Size = new System.Drawing.Size(215, 23);
            this.tbxCpf.TabIndex = 1;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(6, 101);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(31, 15);
            this.lblCpf.TabIndex = 4;
            this.lblCpf.Text = "CPF:";
            // 
            // tbxSobrenome
            // 
            this.tbxSobrenome.Location = new System.Drawing.Point(83, 64);
            this.tbxSobrenome.Name = "tbxSobrenome";
            this.tbxSobrenome.Size = new System.Drawing.Size(175, 23);
            this.tbxSobrenome.TabIndex = 3;
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Location = new System.Drawing.Point(6, 67);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(71, 15);
            this.lblSobrenome.TabIndex = 2;
            this.lblSobrenome.Text = "Sobrenome:";
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(55, 28);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(203, 23);
            this.tbxNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 31);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // gpbDadosConta
            // 
            this.gpbDadosConta.Controls.Add(this.tbxSaldo);
            this.gpbDadosConta.Controls.Add(this.lblSaldo);
            this.gpbDadosConta.Controls.Add(this.tbxLimite);
            this.gpbDadosConta.Controls.Add(this.lblLimite);
            this.gpbDadosConta.Controls.Add(this.tbxNumero);
            this.gpbDadosConta.Controls.Add(this.lblNumero);
            this.gpbDadosConta.Location = new System.Drawing.Point(12, 159);
            this.gpbDadosConta.Name = "gpbDadosConta";
            this.gpbDadosConta.Size = new System.Drawing.Size(264, 141);
            this.gpbDadosConta.TabIndex = 5;
            this.gpbDadosConta.TabStop = false;
            this.gpbDadosConta.Text = "Dados da Conta";
            // 
            // tbxSaldo
            // 
            this.tbxSaldo.Location = new System.Drawing.Point(51, 98);
            this.tbxSaldo.Name = "tbxSaldo";
            this.tbxSaldo.Size = new System.Drawing.Size(207, 23);
            this.tbxSaldo.TabIndex = 1;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(6, 101);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(39, 15);
            this.lblSaldo.TabIndex = 4;
            this.lblSaldo.Text = "Saldo:";
            // 
            // tbxLimite
            // 
            this.tbxLimite.Location = new System.Drawing.Point(55, 64);
            this.tbxLimite.Name = "tbxLimite";
            this.tbxLimite.Size = new System.Drawing.Size(203, 23);
            this.tbxLimite.TabIndex = 3;
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Location = new System.Drawing.Point(6, 67);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(43, 15);
            this.lblLimite.TabIndex = 2;
            this.lblLimite.Text = "Limite:";
            // 
            // tbxNumero
            // 
            this.tbxNumero.Location = new System.Drawing.Point(66, 28);
            this.tbxNumero.Name = "tbxNumero";
            this.tbxNumero.Size = new System.Drawing.Size(192, 23);
            this.tbxNumero.TabIndex = 1;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(6, 31);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(54, 15);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Número:";
            // 
            // gbxMovimentacao
            // 
            this.gbxMovimentacao.Controls.Add(this.tbxValor);
            this.gbxMovimentacao.Controls.Add(this.lblValor);
            this.gbxMovimentacao.Controls.Add(this.rbtDeposito);
            this.gbxMovimentacao.Controls.Add(this.rbtSaque);
            this.gbxMovimentacao.Controls.Add(this.lblOperacao);
            this.gbxMovimentacao.Location = new System.Drawing.Point(322, 79);
            this.gbxMovimentacao.Name = "gbxMovimentacao";
            this.gbxMovimentacao.Size = new System.Drawing.Size(216, 126);
            this.gbxMovimentacao.TabIndex = 6;
            this.gbxMovimentacao.TabStop = false;
            this.gbxMovimentacao.Text = "Movimentação";
            // 
            // tbxValor
            // 
            this.tbxValor.Location = new System.Drawing.Point(48, 77);
            this.tbxValor.Name = "tbxValor";
            this.tbxValor.Size = new System.Drawing.Size(162, 23);
            this.tbxValor.TabIndex = 7;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(6, 80);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(36, 15);
            this.lblValor.TabIndex = 7;
            this.lblValor.Text = "Valor:";
            // 
            // rbtDeposito
            // 
            this.rbtDeposito.AutoSize = true;
            this.rbtDeposito.Location = new System.Drawing.Point(71, 37);
            this.rbtDeposito.Name = "rbtDeposito";
            this.rbtDeposito.Size = new System.Drawing.Size(72, 19);
            this.rbtDeposito.TabIndex = 9;
            this.rbtDeposito.TabStop = true;
            this.rbtDeposito.Text = "Depósito";
            this.rbtDeposito.UseVisualStyleBackColor = true;
            // 
            // rbtSaque
            // 
            this.rbtSaque.AutoSize = true;
            this.rbtSaque.Location = new System.Drawing.Point(7, 38);
            this.rbtSaque.Name = "rbtSaque";
            this.rbtSaque.Size = new System.Drawing.Size(57, 19);
            this.rbtSaque.TabIndex = 8;
            this.rbtSaque.TabStop = true;
            this.rbtSaque.Text = "Saque";
            this.rbtSaque.UseVisualStyleBackColor = true;
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.Location = new System.Drawing.Point(6, 19);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(61, 15);
            this.lblOperacao.TabIndex = 7;
            this.lblOperacao.Text = "Operação:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(305, 260);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(104, 40);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar Movimentação";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(434, 260);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(104, 40);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(484, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(54, 23);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmNovaconta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 315);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.gbxMovimentacao);
            this.Controls.Add(this.gpbDadosConta);
            this.Controls.Add(this.gpbDadosCliente);
            this.Name = "frmNovaconta";
            this.Text = "Nova Conta";
            this.gpbDadosCliente.ResumeLayout(false);
            this.gpbDadosCliente.PerformLayout();
            this.gpbDadosConta.ResumeLayout(false);
            this.gpbDadosConta.PerformLayout();
            this.gbxMovimentacao.ResumeLayout(false);
            this.gbxMovimentacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDadosCliente;
        private System.Windows.Forms.TextBox tbxCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox tbxSobrenome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox gpbDadosConta;
        private System.Windows.Forms.TextBox tbxSaldo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox tbxLimite;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.TextBox tbxNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.GroupBox gbxMovimentacao;
        private System.Windows.Forms.TextBox tbxValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.RadioButton rbtDeposito;
        private System.Windows.Forms.RadioButton rbtSaque;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

