
namespace Quizinho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rdbRonaldo = new System.Windows.Forms.RadioButton();
            this.rdbRivaldo = new System.Windows.Forms.RadioButton();
            this.rdbMaldini = new System.Windows.Forms.RadioButton();
            this.rdbPele = new System.Windows.Forms.RadioButton();
            this.rdbMaradona = new System.Windows.Forms.RadioButton();
            this.lblQuestao1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAvancar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbRonaldo
            // 
            this.rdbRonaldo.AutoSize = true;
            this.rdbRonaldo.Location = new System.Drawing.Point(23, 336);
            this.rdbRonaldo.Name = "rdbRonaldo";
            this.rdbRonaldo.Size = new System.Drawing.Size(69, 19);
            this.rdbRonaldo.TabIndex = 0;
            this.rdbRonaldo.TabStop = true;
            this.rdbRonaldo.Text = "Ronaldo";
            this.rdbRonaldo.UseVisualStyleBackColor = true;
            // 
            // rdbRivaldo
            // 
            this.rdbRivaldo.AutoSize = true;
            this.rdbRivaldo.Location = new System.Drawing.Point(23, 361);
            this.rdbRivaldo.Name = "rdbRivaldo";
            this.rdbRivaldo.Size = new System.Drawing.Size(64, 19);
            this.rdbRivaldo.TabIndex = 1;
            this.rdbRivaldo.TabStop = true;
            this.rdbRivaldo.Text = "Rivaldo";
            this.rdbRivaldo.UseVisualStyleBackColor = true;
            // 
            // rdbMaldini
            // 
            this.rdbMaldini.AutoSize = true;
            this.rdbMaldini.Location = new System.Drawing.Point(23, 411);
            this.rdbMaldini.Name = "rdbMaldini";
            this.rdbMaldini.Size = new System.Drawing.Size(65, 19);
            this.rdbMaldini.TabIndex = 2;
            this.rdbMaldini.TabStop = true;
            this.rdbMaldini.Text = "Maldini";
            this.rdbMaldini.UseVisualStyleBackColor = true;
            // 
            // rdbPele
            // 
            this.rdbPele.AutoSize = true;
            this.rdbPele.Location = new System.Drawing.Point(23, 311);
            this.rdbPele.Name = "rdbPele";
            this.rdbPele.Size = new System.Drawing.Size(47, 19);
            this.rdbPele.TabIndex = 3;
            this.rdbPele.TabStop = true;
            this.rdbPele.Text = "Pelé";
            this.rdbPele.UseVisualStyleBackColor = true;
            // 
            // rdbMaradona
            // 
            this.rdbMaradona.AutoSize = true;
            this.rdbMaradona.Location = new System.Drawing.Point(23, 386);
            this.rdbMaradona.Name = "rdbMaradona";
            this.rdbMaradona.Size = new System.Drawing.Size(79, 19);
            this.rdbMaradona.TabIndex = 4;
            this.rdbMaradona.TabStop = true;
            this.rdbMaradona.Text = "Maradona";
            this.rdbMaradona.UseVisualStyleBackColor = true;
            // 
            // lblQuestao1
            // 
            this.lblQuestao1.AutoSize = true;
            this.lblQuestao1.Location = new System.Drawing.Point(12, 9);
            this.lblQuestao1.Name = "lblQuestao1";
            this.lblQuestao1.Size = new System.Drawing.Size(63, 15);
            this.lblQuestao1.TabIndex = 5;
            this.lblQuestao1.Text = "Questão 1:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quem é esse jogador ?";
            // 
            // btnAvancar
            // 
            this.btnAvancar.Location = new System.Drawing.Point(273, 435);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(75, 23);
            this.btnAvancar.TabIndex = 8;
            this.btnAvancar.Text = "Avançar";
            this.btnAvancar.UseVisualStyleBackColor = true;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 481);
            this.Controls.Add(this.btnAvancar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblQuestao1);
            this.Controls.Add(this.rdbMaradona);
            this.Controls.Add(this.rdbPele);
            this.Controls.Add(this.rdbMaldini);
            this.Controls.Add(this.rdbRivaldo);
            this.Controls.Add(this.rdbRonaldo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbRonaldo;
        private System.Windows.Forms.RadioButton rdbRivaldo;
        private System.Windows.Forms.RadioButton rdbMaldini;
        private System.Windows.Forms.RadioButton rdbPele;
        private System.Windows.Forms.RadioButton rdbMaradona;
        private System.Windows.Forms.Label lblQuestao1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAvancar;
    }
}

