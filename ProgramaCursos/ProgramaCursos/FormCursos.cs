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
    public partial class FormCursos : Form
    {
        SqlConnection conn = new SqlConnection(
          @"Data Source=(localdb)\MSSQLLocalDB;
              AttachDbFilename=|DataDirectory|\Database1.mdf;
              Integrated Security=True");
        public FormCursos()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Cursos (NomeCurso, Descricao) VALUES (@nome, @desc)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nome", txtNomeCurso.Text);
            cmd.Parameters.AddWithValue("@desc", txtDescricao.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Curso cadastrado com sucesso!");
        }

        private void cursosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cursosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void cursosBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cursosBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.database1DataSet1);

        }

       
    }
}
