
namespace Quizinho
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.rdbMessi = new System.Windows.Forms.RadioButton();
            this.rdbRonaldinho = new System.Windows.Forms.RadioButton();
            this.rdbRooney = new System.Windows.Forms.RadioButton();
            this.rdbUmititi = new System.Windows.Forms.RadioButton();
            this.rdbDida = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 255);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnAvancar
            // 
            this.btnAvancar.Location = new System.Drawing.Point(262, 461);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(75, 23);
            this.btnAvancar.TabIndex = 16;
            this.btnAvancar.Text = "Avançar";
            this.btnAvancar.UseVisualStyleBackColor = true;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(25, 461);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 15;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // rdbMessi
            // 
            this.rdbMessi.AutoSize = true;
            this.rdbMessi.Location = new System.Drawing.Point(24, 316);
            this.rdbMessi.Name = "rdbMessi";
            this.rdbMessi.Size = new System.Drawing.Size(55, 19);
            this.rdbMessi.TabIndex = 14;
            this.rdbMessi.TabStop = true;
            this.rdbMessi.Text = "Messi";
            this.rdbMessi.UseVisualStyleBackColor = true;
            // 
            // rdbRonaldinho
            // 
            this.rdbRonaldinho.AutoSize = true;
            this.rdbRonaldinho.Location = new System.Drawing.Point(23, 341);
            this.rdbRonaldinho.Name = "rdbRonaldinho";
            this.rdbRonaldinho.Size = new System.Drawing.Size(86, 19);
            this.rdbRonaldinho.TabIndex = 13;
            this.rdbRonaldinho.TabStop = true;
            this.rdbRonaldinho.Text = "Ronaldinho";
            this.rdbRonaldinho.UseVisualStyleBackColor = true;
            // 
            // rdbRooney
            // 
            this.rdbRooney.AutoSize = true;
            this.rdbRooney.Location = new System.Drawing.Point(24, 366);
            this.rdbRooney.Name = "rdbRooney";
            this.rdbRooney.Size = new System.Drawing.Size(65, 19);
            this.rdbRooney.TabIndex = 12;
            this.rdbRooney.TabStop = true;
            this.rdbRooney.Text = "Rooney";
            this.rdbRooney.UseVisualStyleBackColor = true;
            // 
            // rdbUmititi
            // 
            this.rdbUmititi.AutoSize = true;
            this.rdbUmititi.Location = new System.Drawing.Point(23, 385);
            this.rdbUmititi.Name = "rdbUmititi";
            this.rdbUmititi.Size = new System.Drawing.Size(61, 19);
            this.rdbUmititi.TabIndex = 11;
            this.rdbUmititi.TabStop = true;
            this.rdbUmititi.Text = "Umititi";
            this.rdbUmititi.UseVisualStyleBackColor = true;
            // 
            // rdbDida
            // 
            this.rdbDida.AutoSize = true;
            this.rdbDida.Location = new System.Drawing.Point(23, 410);
            this.rdbDida.Name = "rdbDida";
            this.rdbDida.Size = new System.Drawing.Size(49, 19);
            this.rdbDida.TabIndex = 10;
            this.rdbDida.TabStop = true;
            this.rdbDida.Text = "Dida";
            this.rdbDida.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Questão 5: Qual é esse jogador?";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 504);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAvancar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.rdbMessi);
            this.Controls.Add(this.rdbRonaldinho);
            this.Controls.Add(this.rdbRooney);
            this.Controls.Add(this.rdbUmititi);
            this.Controls.Add(this.rdbDida);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.RadioButton rdbMessi;
        private System.Windows.Forms.RadioButton rdbRonaldinho;
        private System.Windows.Forms.RadioButton rdbRooney;
        private System.Windows.Forms.RadioButton rdbUmititi;
        private System.Windows.Forms.RadioButton rdbDida;
        private System.Windows.Forms.Label label1;
    }
}