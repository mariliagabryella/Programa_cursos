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
        SqlConnection conn = new SqlConnection(
          @"Data Source=(localdb)\MSSQLLocalDB;
              AttachDbFilename=|DataDirectory|\Database1.mdf;
              Integrated Security=True");
        public ProgramaCursos()
        {
            InitializeComponent();
        }
        private void btnAlunos_Click(object sender, EventArgs e)
        {
            new FormAlunos().ShowDialog();
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            new FormCursos().ShowDialog();
        }

        private void btnInscricoes_Click(object sender, EventArgs e)
        {
            new FormInscricoes().ShowDialog();
        }
    }
}
    }
}
