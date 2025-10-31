using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaCursos
{
    public partial class ProgramaCursos : Form
    {
        public ProgramaCursos()
        {
            InitializeComponent();
        }
        private void btnAlunos_Click(object sender, EventArgs e)
        {
            

            // Cria uma instância do outro formulário
            FormAlunos formalunos = new FormAlunos();

            // Mostra o Form2
            formalunos.Show();

            // (Opcional) Esconde o Form1
            this.Hide();
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
           

            // Cria uma instância do outro formulário
            FormCursos formcursos = new FormCursos();

            // Mostra o Form2
            formcursos.Show();

            // (Opcional) Esconde o Form1
            this.Hide();
        }

        private void btnInscricoes_Click(object sender, EventArgs e)
        {

            // Cria uma instância do outro formulário
            FormInscricoes forminscricoes = new FormInscricoes();

            // Mostra o Form2
            forminscricoes.Show();

            // (Opcional) Esconde o Form1
            this.Hide();
        }

        private void alunosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alunosBindingSource.EndEdit();

        }

        private void ProgramaCursos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet.Alunos'. Você pode movê-la ou removê-la conforme necessário.
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet.Alunos'. Você pode movê-la ou removê-la conforme necessário.

        }
    }
}
   
