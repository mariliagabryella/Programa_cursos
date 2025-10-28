namespace ProgramaCursos
{
    partial class FormInscricoes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInscricoes));
            System.Windows.Forms.Label idInscricaoLabel;
            System.Windows.Forms.Label idAlunoLabel;
            System.Windows.Forms.Label idCursoLabel;
            System.Windows.Forms.Label dataInscricaoLabel;
            this.database1DataSet1 = new ProgramaCursos.Database1DataSet();
            this.inscricoesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inscricoesTableAdapter1 = new ProgramaCursos.Database1DataSetTableAdapters.InscricoesTableAdapter();
            this.tableAdapterManager1 = new ProgramaCursos.Database1DataSetTableAdapters.TableAdapterManager();
            this.inscricoesBindingSource1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.inscricoesBindingSource1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idInscricaoTextBox1 = new System.Windows.Forms.TextBox();
            this.cboAlunos = new System.Windows.Forms.TextBox();
            this.cboCursos = new System.Windows.Forms.TextBox();
            this.dataInscricaoDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            idInscricaoLabel = new System.Windows.Forms.Label();
            idAlunoLabel = new System.Windows.Forms.Label();
            idCursoLabel = new System.Windows.Forms.Label();
            dataInscricaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscricoesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscricoesBindingSource1BindingNavigator)).BeginInit();
            this.inscricoesBindingSource1BindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inscricoesBindingSource1
            // 
            this.inscricoesBindingSource1.DataMember = "Inscricoes";
            this.inscricoesBindingSource1.DataSource = this.database1DataSet1;
            // 
            // inscricoesTableAdapter1
            // 
            this.inscricoesTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AlunosTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CursosTableAdapter = null;
            this.tableAdapterManager1.InscricoesTableAdapter = this.inscricoesTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = ProgramaCursos.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // inscricoesBindingSource1BindingNavigator
            // 
            this.inscricoesBindingSource1BindingNavigator.AddNewItem = this.toolStripButton5;
            this.inscricoesBindingSource1BindingNavigator.BindingSource = this.inscricoesBindingSource1;
            this.inscricoesBindingSource1BindingNavigator.CountItem = this.toolStripLabel1;
            this.inscricoesBindingSource1BindingNavigator.DeleteItem = this.toolStripButton6;
            this.inscricoesBindingSource1BindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.inscricoesBindingSource1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.toolStripButton5,
            this.toolStripButton6,
            this.inscricoesBindingSource1BindingNavigatorSaveItem});
            this.inscricoesBindingSource1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.inscricoesBindingSource1BindingNavigator.MoveFirstItem = this.toolStripButton1;
            this.inscricoesBindingSource1BindingNavigator.MoveLastItem = this.toolStripButton4;
            this.inscricoesBindingSource1BindingNavigator.MoveNextItem = this.toolStripButton3;
            this.inscricoesBindingSource1BindingNavigator.MovePreviousItem = this.toolStripButton2;
            this.inscricoesBindingSource1BindingNavigator.Name = "inscricoesBindingSource1BindingNavigator";
            this.inscricoesBindingSource1BindingNavigator.PositionItem = this.toolStripTextBox1;
            this.inscricoesBindingSource1BindingNavigator.Size = new System.Drawing.Size(555, 35);
            this.inscricoesBindingSource1BindingNavigator.TabIndex = 0;
            this.inscricoesBindingSource1BindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "bindingNavigatorMoveFirstItem";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(34, 30);
            this.toolStripButton1.Text = "Mover primeiro";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "bindingNavigatorMovePreviousItem";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(34, 30);
            this.toolStripButton2.Text = "Mover anterior";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "bindingNavigatorSeparator";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Posição";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "bindingNavigatorPositionItem";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 31);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Posição actual";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "bindingNavigatorCountItem";
            this.toolStripLabel1.Size = new System.Drawing.Size(57, 30);
            this.toolStripLabel1.Text = "de {0}";
            this.toolStripLabel1.ToolTipText = "Número total de itens";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "bindingNavigatorSeparator";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "bindingNavigatorMoveNextItem";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(34, 30);
            this.toolStripButton3.Text = "Mover seguinte";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "bindingNavigatorMoveLastItem";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(34, 30);
            this.toolStripButton4.Text = "Mover último";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "bindingNavigatorSeparator";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "bindingNavigatorAddNewItem";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(34, 30);
            this.toolStripButton5.Text = "Adicionar novo";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "bindingNavigatorDeleteItem";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(34, 30);
            this.toolStripButton6.Text = "Eliminar";
            // 
            // inscricoesBindingSource1BindingNavigatorSaveItem
            // 
            this.inscricoesBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.inscricoesBindingSource1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("inscricoesBindingSource1BindingNavigatorSaveItem.Image")));
            this.inscricoesBindingSource1BindingNavigatorSaveItem.Name = "inscricoesBindingSource1BindingNavigatorSaveItem";
            this.inscricoesBindingSource1BindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 30);
            this.inscricoesBindingSource1BindingNavigatorSaveItem.Text = "Salvar Dados";
            this.inscricoesBindingSource1BindingNavigatorSaveItem.Click += new System.EventHandler(this.inscricoesBindingSource1BindingNavigatorSaveItem_Click);
            // 
            // idInscricaoLabel
            // 
            idInscricaoLabel.AutoSize = true;
            idInscricaoLabel.Location = new System.Drawing.Point(213, 163);
            idInscricaoLabel.Name = "idInscricaoLabel";
            idInscricaoLabel.Size = new System.Drawing.Size(95, 20);
            idInscricaoLabel.TabIndex = 1;
            idInscricaoLabel.Text = "Id Inscricao:";
            // 
            // idInscricaoTextBox1
            // 
            this.idInscricaoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscricoesBindingSource1, "IdInscricao", true));
            this.idInscricaoTextBox1.Location = new System.Drawing.Point(335, 160);
            this.idInscricaoTextBox1.Name = "idInscricaoTextBox1";
            this.idInscricaoTextBox1.Size = new System.Drawing.Size(200, 26);
            this.idInscricaoTextBox1.TabIndex = 2;
            // 
            // idAlunoLabel
            // 
            idAlunoLabel.AutoSize = true;
            idAlunoLabel.Location = new System.Drawing.Point(213, 195);
            idAlunoLabel.Name = "idAlunoLabel";
            idAlunoLabel.Size = new System.Drawing.Size(72, 20);
            idAlunoLabel.TabIndex = 3;
            idAlunoLabel.Text = "Id Aluno:";
            // 
            // cboAlunos
            // 
            this.cboAlunos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscricoesBindingSource1, "IdAluno", true));
            this.cboAlunos.Location = new System.Drawing.Point(335, 192);
            this.cboAlunos.Name = "cboAlunos";
            this.cboAlunos.Size = new System.Drawing.Size(200, 26);
            this.cboAlunos.TabIndex = 4;
            this.cboAlunos.TextChanged += new System.EventHandler(this.cboAluno_TextChanged);
            // 
            // idCursoLabel
            // 
            idCursoLabel.AutoSize = true;
            idCursoLabel.Location = new System.Drawing.Point(213, 227);
            idCursoLabel.Name = "idCursoLabel";
            idCursoLabel.Size = new System.Drawing.Size(73, 20);
            idCursoLabel.TabIndex = 5;
            idCursoLabel.Text = "Id Curso:";
            // 
            // cboCursos
            // 
            this.cboCursos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscricoesBindingSource1, "IdCurso", true));
            this.cboCursos.Location = new System.Drawing.Point(335, 224);
            this.cboCursos.Name = "cboCursos";
            this.cboCursos.Size = new System.Drawing.Size(200, 26);
            this.cboCursos.TabIndex = 6;
            // 
            // dataInscricaoLabel
            // 
            dataInscricaoLabel.AutoSize = true;
            dataInscricaoLabel.Location = new System.Drawing.Point(213, 260);
            dataInscricaoLabel.Name = "dataInscricaoLabel";
            dataInscricaoLabel.Size = new System.Drawing.Size(116, 20);
            dataInscricaoLabel.TabIndex = 7;
            dataInscricaoLabel.Text = "Data Inscricao:";
            // 
            // dataInscricaoDateTimePicker1
            // 
            this.dataInscricaoDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inscricoesBindingSource1, "DataInscricao", true));
            this.dataInscricaoDateTimePicker1.Location = new System.Drawing.Point(335, 256);
            this.dataInscricaoDateTimePicker1.Name = "dataInscricaoDateTimePicker1";
            this.dataInscricaoDateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dataInscricaoDateTimePicker1.TabIndex = 8;
            // 
            // FormInscricoes
            // 
            this.ClientSize = new System.Drawing.Size(555, 302);
            this.Controls.Add(idInscricaoLabel);
            this.Controls.Add(this.idInscricaoTextBox1);
            this.Controls.Add(idAlunoLabel);
            this.Controls.Add(this.cboAlunos);
            this.Controls.Add(idCursoLabel);
            this.Controls.Add(this.cboCursos);
            this.Controls.Add(dataInscricaoLabel);
            this.Controls.Add(this.dataInscricaoDateTimePicker1);
            this.Controls.Add(this.inscricoesBindingSource1BindingNavigator);
            this.Name = "FormInscricoes";
            this.Load += new System.EventHandler(this.FormInscricoes_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscricoesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscricoesBindingSource1BindingNavigator)).EndInit();
            this.inscricoesBindingSource1BindingNavigator.ResumeLayout(false);
            this.inscricoesBindingSource1BindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProgramaCursos.Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource inscricoesBindingSource;
        private ProgramaCursos.Database1DataSetTableAdapters.InscricoesTableAdapter inscricoesTableAdapter;
        private ProgramaCursos.Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator inscricoesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton inscricoesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idInscricaoTextBox;
        private System.Windows.Forms.TextBox idAlunoTextBox;
        private System.Windows.Forms.TextBox idCursoTextBox;
        private System.Windows.Forms.DateTimePicker dataInscricaoDateTimePicker;
        private ProgramaCursos.Database1DataSet database1DataSet1;
        private System.Windows.Forms.BindingSource inscricoesBindingSource1;
        private ProgramaCursos.Database1DataSetTableAdapters.InscricoesTableAdapter inscricoesTableAdapter1;
        private ProgramaCursos.Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingNavigator inscricoesBindingSource1BindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton inscricoesBindingSource1BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idInscricaoTextBox1;
        private System.Windows.Forms.TextBox cboAlunos;
        private System.Windows.Forms.TextBox cboCursos;
        private System.Windows.Forms.DateTimePicker dataInscricaoDateTimePicker1;
    }
}