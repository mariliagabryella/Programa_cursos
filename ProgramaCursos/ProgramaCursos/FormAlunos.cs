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
    public partial class FormAlunos : Form
    {
        SqlConnection conn = new SqlConnection(
          @"Data Source=(localdb)\MSSQLLocalDB;
              AttachDbFilename=|DataDirectory|\Database1.mdf;
              Integrated Security=True");
        public FormAlunos()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
           
         
        }

        private void alunosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alunosBindingSource.EndEdit();
            
        }

        private void alunosBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            
        }

        private void FormAlunos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet1.Alunos'. Você pode movê-la ou removê-la conforme necessário.
            
        }

        private void alunosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.alunosBindingSource.EndEdit();

        }

        private void FormAlunos_Load_1(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet.Alunos'. Você pode movê-la ou removê-la conforme necessário.
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet.Alunos'. Você pode movê-la ou removê-la conforme necessário.

        }
    }
}
