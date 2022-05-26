
namespace Quizinho
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnAvancar = new System.Windows.Forms.Button();
            this.rdbMessi = new System.Windows.Forms.RadioButton();
            this.rdbPogba = new System.Windows.Forms.RadioButton();
            this.rdbDudu = new System.Windows.Forms.RadioButton();
            this.rdbRivaldo = new System.Windows.Forms.RadioButton();
            this.rdbZico = new System.Windows.Forms.RadioButton();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAvancar
            // 
            this.btnAvancar.Location = new System.Drawing.Point(309, 420);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(75, 23);
            this.btnAvancar.TabIndex = 0;
            this.btnAvancar.Text = "Avançar";
            this.btnAvancar.UseVisualStyleBackColor = true;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // rdbMessi
            // 
            this.rdbMessi.AutoSize = true;
            this.rdbMessi.Location = new System.Drawing.Point(13, 373);
            this.rdbMessi.Name = "rdbMessi";
            this.rdbMessi.Size = new System.Drawing.Size(55, 19);
            this.rdbMessi.TabIndex = 1;
            this.rdbMessi.TabStop = true;
            this.rdbMessi.Text = "Messi";
            this.rdbMessi.UseVisualStyleBackColor = true;
            // 
            // rdbPogba
            // 
            this.rdbPogba.AutoSize = true;
            this.rdbPogba.Location = new System.Drawing.Point(13, 348);
            this.rdbPogba.Name = "rdbPogba";
            this.rdbPogba.Size = new System.Drawing.Size(59, 19);
            this.rdbPogba.TabIndex = 2;
            this.rdbPogba.TabStop = true;
            this.rdbPogba.Text = "Pogba";
            this.rdbPogba.UseVisualStyleBackColor = true;
            // 
            // rdbDudu
            // 
            this.rdbDudu.AutoSize = true;
            this.rdbDudu.Location = new System.Drawing.Point(13, 323);
            this.rdbDudu.Name = "rdbDudu";
            this.rdbDudu.Size = new System.Drawing.Size(54, 19);
            this.rdbDudu.TabIndex = 3;
            this.rdbDudu.TabStop = true;
            this.rdbDudu.Text = "Dudu";
            this.rdbDudu.UseVisualStyleBackColor = true;
            this.rdbDudu.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdbRivaldo
            // 
            this.rdbRivaldo.AutoSize = true;
            this.rdbRivaldo.Location = new System.Drawing.Point(13, 298);
            this.rdbRivaldo.Name = "rdbRivaldo";
            this.rdbRivaldo.Size = new System.Drawing.Size(64, 19);
            this.rdbRivaldo.TabIndex = 4;
            this.rdbRivaldo.TabStop = true;
            this.rdbRivaldo.Text = "Rivaldo";
            this.rdbRivaldo.UseVisualStyleBackColor = true;
            // 
            // rdbZico
            // 
            this.rdbZico.AutoSize = true;
            this.rdbZico.Location = new System.Drawing.Point(13, 273);
            this.rdbZico.Name = "rdbZico";
            this.rdbZico.Size = new System.Drawing.Size(48, 19);
            this.rdbZico.TabIndex = 5;
            this.rdbZico.TabStop = true;
            this.rdbZico.Text = "Zico";
            this.rdbZico.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(13, 420);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Questão  2:Quem é esse jogador?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 475);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.rdbZico);
            this.Controls.Add(this.rdbRivaldo);
            this.Controls.Add(this.rdbDudu);
            this.Controls.Add(this.rdbPogba);
            this.Controls.Add(this.rdbMessi);
            this.Controls.Add(this.btnAvancar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.RadioButton rdbMessi;
        private System.Windows.Forms.RadioButton rdbPogba;
        private System.Windows.Forms.RadioButton rdbDudu;
        private System.Windows.Forms.RadioButton rdbRivaldo;
        private System.Windows.Forms.RadioButton rdbZico;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}