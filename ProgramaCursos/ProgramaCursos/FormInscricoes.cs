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
    public partial class FormInscricoes : Form
    {
        SqlConnection conn = new SqlConnection(
          @"Data Source=(localdb)\MSSQLLocalDB;
              AttachDbFilename=|DataDirectory|\Database1.mdf;
              Integrated Security=True");
        public FormInscricoes()
        {
            InitializeComponent();
        }

        private void FormInscricoes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet.Inscricoes'. Você pode movê-la ou removê-la conforme necessário.
            this.inscricoesTableAdapter.Fill(this.database1DataSet.Inscricoes);
            // Carregar Alunos
            SqlDataAdapter daAlunos = new SqlDataAdapter("SELECT IdAluno, Nome FROM Alunos", conn);
            DataTable dtAlunos = new DataTable();
            daAlunos.Fill(dtAlunos);
            cboAlunos.DataSource = dtAlunos;
            cboAlunos.DisplayMember = "Nome";
            cboAlunos.ValueMember = "IdAluno";

            // Carregar Cursos
            SqlDataAdapter daCursos = new SqlDataAdapter("SELECT IdCurso, NomeCurso FROM Cursos", conn);
            DataTable dtCursos = new DataTable();
            daCursos.Fill(dtCursos);
            cboCursos.DataSource = dtCursos;
            cboCursos.DisplayMember = "NomeCurso";
            cboCursos.ValueMember = "IdCurso";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Inscricoes (IdAluno, IdCurso) VALUES (@aluno, @curso)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@aluno", cboAlunos.SelectedValue);
            cmd.Parameters.AddWithValue("@curso", cboCursos.SelectedValue);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Inscrição registrada com sucesso!");
        }

        private void inscricoesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inscricoesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void inscricoesBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inscricoesBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.database1DataSet1);

        }

        private void FormInscricoes_Load_1(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet1.Inscricoes'. Você pode movê-la ou removê-la conforme necessário.
            this.inscricoesTableAdapter1.Fill(this.database1DataSet1.Inscricoes);

        }

    
    }
}
    

