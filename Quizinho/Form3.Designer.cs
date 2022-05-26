
namespace Quizinho
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.rdbNavas = new System.Windows.Forms.RadioButton();
            this.rdbUmititi = new System.Windows.Forms.RadioButton();
            this.rdbRony = new System.Windows.Forms.RadioButton();
            this.rdbRonaldinho = new System.Windows.Forms.RadioButton();
            this.rdbMaradona = new System.Windows.Forms.RadioButton();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Questão 3: Qual é esse jogador?";
            // 
            // rdbNavas
            // 
            this.rdbNavas.AutoSize = true;
            this.rdbNavas.Location = new System.Drawing.Point(11, 417);
            this.rdbNavas.Name = "rdbNavas";
            this.rdbNavas.Size = new System.Drawing.Size(57, 19);
            this.rdbNavas.TabIndex = 1;
            this.rdbNavas.TabStop = true;
            this.rdbNavas.Text = "Navas";
            this.rdbNavas.UseVisualStyleBackColor = true;
            // 
            // rdbUmititi
            // 
            this.rdbUmititi.AutoSize = true;
            this.rdbUmititi.Location = new System.Drawing.Point(11, 392);
            this.rdbUmititi.Name = "rdbUmititi";
            this.rdbUmititi.Size = new System.Drawing.Size(61, 19);
            this.rdbUmititi.TabIndex = 2;
            this.rdbUmititi.TabStop = true;
            this.rdbUmititi.Text = "Umititi";
            this.rdbUmititi.UseVisualStyleBackColor = true;
            // 
            // rdbRony
            // 
            this.rdbRony.AutoSize = true;
            this.rdbRony.Location = new System.Drawing.Point(12, 373);
            this.rdbRony.Name = "rdbRony";
            this.rdbRony.Size = new System.Drawing.Size(52, 19);
            this.rdbRony.TabIndex = 3;
            this.rdbRony.TabStop = true;
            this.rdbRony.Text = "Rony";
            this.rdbRony.UseVisualStyleBackColor = true;
            // 
            // rdbRonaldinho
            // 
            this.rdbRonaldinho.AutoSize = true;
            this.rdbRonaldinho.Location = new System.Drawing.Point(11, 348);
            this.rdbRonaldinho.Name = "rdbRonaldinho";
            this.rdbRonaldinho.Size = new System.Drawing.Size(86, 19);
            this.rdbRonaldinho.TabIndex = 4;
            this.rdbRonaldinho.TabStop = true;
            this.rdbRonaldinho.Text = "Ronaldinho";
            this.rdbRonaldinho.UseVisualStyleBackColor = true;
            // 
            // rdbMaradona
            // 
            this.rdbMaradona.AutoSize = true;
            this.rdbMaradona.Location = new System.Drawing.Point(12, 323);
            this.rdbMaradona.Name = "rdbMaradona";
            this.rdbMaradona.Size = new System.Drawing.Size(79, 19);
            this.rdbMaradona.TabIndex = 5;
            this.rdbMaradona.TabStop = true;
            this.rdbMaradona.Text = "Maradona";
            this.rdbMaradona.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(13, 467);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAvancar
            // 
            this.btnAvancar.Location = new System.Drawing.Point(272, 466);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(75, 23);
            this.btnAvancar.TabIndex = 7;
            this.btnAvancar.Text = "Avançar";
            this.btnAvancar.UseVisualStyleBackColor = true;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 503);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAvancar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.rdbMaradona);
            this.Controls.Add(this.rdbRonaldinho);
            this.Controls.Add(this.rdbRony);
            this.Controls.Add(this.rdbUmititi);
            this.Controls.Add(this.rdbNavas);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbNavas;
        private System.Windows.Forms.RadioButton rdbUmititi;
        private System.Windows.Forms.RadioButton rdbRony;
        private System.Windows.Forms.RadioButton rdbRonaldinho;
        private System.Windows.Forms.RadioButton rdbMaradona;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}