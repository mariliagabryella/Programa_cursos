using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaCursos
{
    public partial class FormInscricoes : Form
    {
        public FormInscricoes()
        {
            InitializeComponent();
        }

        private void FormInscricoes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet.Inscricoes'. Você pode movê-la ou removê-la conforme necessário.

        }

        private void inscricoesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inscricoesBindingSource.EndEdit();

        }
    }
}
