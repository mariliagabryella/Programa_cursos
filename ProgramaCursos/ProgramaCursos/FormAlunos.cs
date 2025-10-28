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
            string query = "INSERT INTO Alunos (Nome, Email, DataNascimento) VALUES (@nome, @email, @data)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@data", dtpNascimento.Value);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Aluno cadastrado com sucesso!");
        }

        private void alunosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alunosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void alunosBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alunosBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.database1DataSet1);

        }

        private void FormAlunos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet1.Alunos'. Você pode movê-la ou removê-la conforme necessário.
            this.alunosTableAdapter1.Fill(this.database1DataSet1.Alunos);

        }
    }
}
