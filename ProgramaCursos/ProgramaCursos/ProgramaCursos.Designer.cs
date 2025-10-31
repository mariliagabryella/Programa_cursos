namespace ProgramaCursos
{
    partial class ProgramaCursos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAlunos = new System.Windows.Forms.Button();
            this.btnCursos = new System.Windows.Forms.Button();
            this.btnInscricoes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlunos
            // 
            this.btnAlunos.Location = new System.Drawing.Point(614, 143);
            this.btnAlunos.Name = "btnAlunos";
            this.btnAlunos.Size = new System.Drawing.Size(75, 23);
            this.btnAlunos.TabIndex = 0;
            this.btnAlunos.Text = "button1";
            this.btnAlunos.UseVisualStyleBackColor = true;
            // 
            // btnCursos
            // 
            this.btnCursos.Location = new System.Drawing.Point(363, 143);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(75, 23);
            this.btnCursos.TabIndex = 1;
            this.btnCursos.Text = "button1";
            this.btnCursos.UseVisualStyleBackColor = true;
            this.btnCursos.Click += new System.EventHandler(this.btnCursos_Click_1);
            // 
            // btnInscricoes
            // 
            this.btnInscricoes.Location = new System.Drawing.Point(199, 143);
            this.btnInscricoes.Name = "btnInscricoes";
            this.btnInscricoes.Size = new System.Drawing.Size(75, 23);
            this.btnInscricoes.TabIndex = 2;
            this.btnInscricoes.Text = "button1";
            this.btnInscricoes.UseVisualStyleBackColor = true;
            // 
            // ProgramaCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInscricoes);
            this.Controls.Add(this.btnCursos);
            this.Controls.Add(this.btnAlunos);
            this.Name = "ProgramaCursos";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlunos;
        private System.Windows.Forms.Button btnCursos;
        private System.Windows.Forms.Button btnInscricoes;
    }
}

