﻿
namespace Criatividade2
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnIniciarSorteio = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbGrupoH = new System.Windows.Forms.RadioButton();
            this.rdbGrupoG = new System.Windows.Forms.RadioButton();
            this.rdbGrupoF = new System.Windows.Forms.RadioButton();
            this.rdbGrupoE = new System.Windows.Forms.RadioButton();
            this.rdbGrupoA = new System.Windows.Forms.RadioButton();
            this.rdbGrupoD = new System.Windows.Forms.RadioButton();
            this.rdbGrupoB = new System.Windows.Forms.RadioButton();
            this.rdbGrupoC = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.cmbTimes = new System.Windows.Forms.ComboBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(341, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(43, 41);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // btnIniciarSorteio
            // 
            this.btnIniciarSorteio.Location = new System.Drawing.Point(285, 346);
            this.btnIniciarSorteio.Name = "btnIniciarSorteio";
            this.btnIniciarSorteio.Size = new System.Drawing.Size(99, 71);
            this.btnIniciarSorteio.TabIndex = 12;
            this.btnIniciarSorteio.Text = "Iniciar Sorteio";
            this.btnIniciarSorteio.UseVisualStyleBackColor = true;
            this.btnIniciarSorteio.Click += new System.EventHandler(this.btnIniciarSorteio_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbGrupoH);
            this.groupBox3.Controls.Add(this.rdbGrupoG);
            this.groupBox3.Controls.Add(this.rdbGrupoF);
            this.groupBox3.Controls.Add(this.rdbGrupoE);
            this.groupBox3.Controls.Add(this.rdbGrupoA);
            this.groupBox3.Controls.Add(this.rdbGrupoD);
            this.groupBox3.Controls.Add(this.rdbGrupoB);
            this.groupBox3.Controls.Add(this.rdbGrupoC);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 81);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Escolha o grupo";
            // 
            // rdbGrupoH
            // 
            this.rdbGrupoH.AutoSize = true;
            this.rdbGrupoH.Location = new System.Drawing.Point(230, 47);
            this.rdbGrupoH.Name = "rdbGrupoH";
            this.rdbGrupoH.Size = new System.Drawing.Size(70, 19);
            this.rdbGrupoH.TabIndex = 7;
            this.rdbGrupoH.TabStop = true;
            this.rdbGrupoH.Text = "Grupo H";
            this.rdbGrupoH.UseVisualStyleBackColor = true;
            this.rdbGrupoH.CheckedChanged += new System.EventHandler(this.rdbGrupoH_CheckedChanged_1);
            // 
            // rdbGrupoG
            // 
            this.rdbGrupoG.AutoSize = true;
            this.rdbGrupoG.Location = new System.Drawing.Point(155, 47);
            this.rdbGrupoG.Name = "rdbGrupoG";
            this.rdbGrupoG.Size = new System.Drawing.Size(69, 19);
            this.rdbGrupoG.TabIndex = 7;
            this.rdbGrupoG.TabStop = true;
            this.rdbGrupoG.Text = "Grupo G";
            this.rdbGrupoG.UseVisualStyleBackColor = true;
            this.rdbGrupoG.CheckedChanged += new System.EventHandler(this.rdbGrupoG_CheckedChanged_1);
            // 
            // rdbGrupoF
            // 
            this.rdbGrupoF.AutoSize = true;
            this.rdbGrupoF.Location = new System.Drawing.Point(81, 47);
            this.rdbGrupoF.Name = "rdbGrupoF";
            this.rdbGrupoF.Size = new System.Drawing.Size(67, 19);
            this.rdbGrupoF.TabIndex = 7;
            this.rdbGrupoF.TabStop = true;
            this.rdbGrupoF.Text = "Grupo F";
            this.rdbGrupoF.UseVisualStyleBackColor = true;
            this.rdbGrupoF.CheckedChanged += new System.EventHandler(this.rdbGrupoF_CheckedChanged_1);
            // 
            // rdbGrupoE
            // 
            this.rdbGrupoE.AutoSize = true;
            this.rdbGrupoE.Location = new System.Drawing.Point(6, 47);
            this.rdbGrupoE.Name = "rdbGrupoE";
            this.rdbGrupoE.Size = new System.Drawing.Size(67, 19);
            this.rdbGrupoE.TabIndex = 7;
            this.rdbGrupoE.TabStop = true;
            this.rdbGrupoE.Text = "Grupo E";
            this.rdbGrupoE.UseVisualStyleBackColor = true;
            this.rdbGrupoE.CheckedChanged += new System.EventHandler(this.rdbGrupoE_CheckedChanged_1);
            // 
            // rdbGrupoA
            // 
            this.rdbGrupoA.AutoSize = true;
            this.rdbGrupoA.Location = new System.Drawing.Point(6, 22);
            this.rdbGrupoA.Name = "rdbGrupoA";
            this.rdbGrupoA.Size = new System.Drawing.Size(69, 19);
            this.rdbGrupoA.TabIndex = 2;
            this.rdbGrupoA.TabStop = true;
            this.rdbGrupoA.Text = "Grupo A";
            this.rdbGrupoA.UseVisualStyleBackColor = true;
            this.rdbGrupoA.CheckedChanged += new System.EventHandler(this.rdbGrupoA_CheckedChanged_1);
            // 
            // rdbGrupoD
            // 
            this.rdbGrupoD.AutoSize = true;
            this.rdbGrupoD.Location = new System.Drawing.Point(230, 22);
            this.rdbGrupoD.Name = "rdbGrupoD";
            this.rdbGrupoD.Size = new System.Drawing.Size(69, 19);
            this.rdbGrupoD.TabIndex = 5;
            this.rdbGrupoD.TabStop = true;
            this.rdbGrupoD.Text = "Grupo D";
            this.rdbGrupoD.UseVisualStyleBackColor = true;
            this.rdbGrupoD.CheckedChanged += new System.EventHandler(this.rdbGrupoD_CheckedChanged_1);
            // 
            // rdbGrupoB
            // 
            this.rdbGrupoB.AutoSize = true;
            this.rdbGrupoB.Location = new System.Drawing.Point(81, 22);
            this.rdbGrupoB.Name = "rdbGrupoB";
            this.rdbGrupoB.Size = new System.Drawing.Size(68, 19);
            this.rdbGrupoB.TabIndex = 3;
            this.rdbGrupoB.TabStop = true;
            this.rdbGrupoB.Text = "Grupo B";
            this.rdbGrupoB.UseVisualStyleBackColor = true;
            this.rdbGrupoB.CheckedChanged += new System.EventHandler(this.rdbGrupoB_CheckedChanged);
            // 
            // rdbGrupoC
            // 
            this.rdbGrupoC.AutoSize = true;
            this.rdbGrupoC.Location = new System.Drawing.Point(155, 22);
            this.rdbGrupoC.Name = "rdbGrupoC";
            this.rdbGrupoC.Size = new System.Drawing.Size(69, 19);
            this.rdbGrupoC.TabIndex = 4;
            this.rdbGrupoC.TabStop = true;
            this.rdbGrupoC.Text = "Grupo C";
            this.rdbGrupoC.UseVisualStyleBackColor = true;
            this.rdbGrupoC.CheckedChanged += new System.EventHandler(this.rdbGrupoC_CheckedChanged_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLimpar);
            this.groupBox2.Controls.Add(this.btnRemover);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 257);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Times a serem sorteados (Máx.16): ";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(177, 227);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(84, 23);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar Tudo";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(6, 227);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 1;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(6, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(255, 199);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Controls.Add(this.cmbTimes);
            this.groupBox1.Location = new System.Drawing.Point(12, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 55);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha os times";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(186, 21);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click_1);
            // 
            // cmbTimes
            // 
            this.cmbTimes.FormattingEnabled = true;
            this.cmbTimes.Location = new System.Drawing.Point(6, 22);
            this.cmbTimes.Name = "cmbTimes";
            this.cmbTimes.Size = new System.Drawing.Size(170, 23);
            this.cmbTimes.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 427);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnIniciarSorteio);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnIniciarSorteio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbGrupoH;
        private System.Windows.Forms.RadioButton rdbGrupoG;
        private System.Windows.Forms.RadioButton rdbGrupoF;
        private System.Windows.Forms.RadioButton rdbGrupoE;
        private System.Windows.Forms.RadioButton rdbGrupoA;
        private System.Windows.Forms.RadioButton rdbGrupoD;
        private System.Windows.Forms.RadioButton rdbGrupoB;
        private System.Windows.Forms.RadioButton rdbGrupoC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ComboBox cmbTimes;
    }
}

