namespace ProgramaCursos
{
    partial class FormCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCursos));
            System.Windows.Forms.Label idCursoLabel;
            System.Windows.Forms.Label nomeCursoLabel;
            System.Windows.Forms.Label descricaoLabel;
            this.database1DataSet1 = new ProgramaCursos.Database1DataSet();
            this.cursosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cursosTableAdapter1 = new ProgramaCursos.Database1DataSetTableAdapters.CursosTableAdapter();
            this.tableAdapterManager1 = new ProgramaCursos.Database1DataSetTableAdapters.TableAdapterManager();
            this.cursosBindingSource1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cursosBindingSource1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idCursoTextBox1 = new System.Windows.Forms.TextBox();
            this.txtNomeCurso = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            idCursoLabel = new System.Windows.Forms.Label();
            nomeCursoLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource1BindingNavigator)).BeginInit();
            this.cursosBindingSource1BindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cursosBindingSource1
            // 
            this.cursosBindingSource1.DataMember = "Cursos";
            this.cursosBindingSource1.DataSource = this.database1DataSet1;
            // 
            // cursosTableAdapter1
            // 
            this.cursosTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AlunosTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CursosTableAdapter = this.cursosTableAdapter1;
            this.tableAdapterManager1.InscricoesTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = ProgramaCursos.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cursosBindingSource1BindingNavigator
            // 
            this.cursosBindingSource1BindingNavigator.AddNewItem = this.toolStripButton5;
            this.cursosBindingSource1BindingNavigator.BindingSource = this.cursosBindingSource1;
            this.cursosBindingSource1BindingNavigator.CountItem = this.toolStripLabel1;
            this.cursosBindingSource1BindingNavigator.DeleteItem = this.toolStripButton6;
            this.cursosBindingSource1BindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cursosBindingSource1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cursosBindingSource1BindingNavigatorSaveItem});
            this.cursosBindingSource1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cursosBindingSource1BindingNavigator.MoveFirstItem = this.toolStripButton1;
            this.cursosBindingSource1BindingNavigator.MoveLastItem = this.toolStripButton4;
            this.cursosBindingSource1BindingNavigator.MoveNextItem = this.toolStripButton3;
            this.cursosBindingSource1BindingNavigator.MovePreviousItem = this.toolStripButton2;
            this.cursosBindingSource1BindingNavigator.Name = "cursosBindingSource1BindingNavigator";
            this.cursosBindingSource1BindingNavigator.PositionItem = this.toolStripTextBox1;
            this.cursosBindingSource1BindingNavigator.Size = new System.Drawing.Size(466, 35);
            this.cursosBindingSource1BindingNavigator.TabIndex = 0;
            this.cursosBindingSource1BindingNavigator.Text = "bindingNavigator1";
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
            // cursosBindingSource1BindingNavigatorSaveItem
            // 
            this.cursosBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cursosBindingSource1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cursosBindingSource1BindingNavigatorSaveItem.Image")));
            this.cursosBindingSource1BindingNavigatorSaveItem.Name = "cursosBindingSource1BindingNavigatorSaveItem";
            this.cursosBindingSource1BindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 30);
            this.cursosBindingSource1BindingNavigatorSaveItem.Text = "Salvar Dados";
            this.cursosBindingSource1BindingNavigatorSaveItem.Click += new System.EventHandler(this.cursosBindingSource1BindingNavigatorSaveItem_Click);
            // 
            // idCursoLabel
            // 
            idCursoLabel.AutoSize = true;
            idCursoLabel.Location = new System.Drawing.Point(239, 113);
            idCursoLabel.Name = "idCursoLabel";
            idCursoLabel.Size = new System.Drawing.Size(73, 20);
            idCursoLabel.TabIndex = 1;
            idCursoLabel.Text = "Id Curso:";
            // 
            // idCursoTextBox1
            // 
            this.idCursoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursosBindingSource1, "IdCurso", true));
            this.idCursoTextBox1.Location = new System.Drawing.Point(346, 110);
            this.idCursoTextBox1.Name = "idCursoTextBox1";
            this.idCursoTextBox1.Size = new System.Drawing.Size(100, 26);
            this.idCursoTextBox1.TabIndex = 2;
            // 
            // nomeCursoLabel
            // 
            nomeCursoLabel.AutoSize = true;
            nomeCursoLabel.Location = new System.Drawing.Point(239, 145);
            nomeCursoLabel.Name = "nomeCursoLabel";
            nomeCursoLabel.Size = new System.Drawing.Size(101, 20);
            nomeCursoLabel.TabIndex = 3;
            nomeCursoLabel.Text = "Nome Curso:";
            // 
            // txtNomeCurso
            // 
            this.txtNomeCurso.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursosBindingSource1, "NomeCurso", true));
            this.txtNomeCurso.Location = new System.Drawing.Point(346, 142);
            this.txtNomeCurso.Name = "txtNomeCurso";
            this.txtNomeCurso.Size = new System.Drawing.Size(100, 26);
            this.txtNomeCurso.TabIndex = 4;
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(239, 177);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(84, 20);
            descricaoLabel.TabIndex = 5;
            descricaoLabel.Text = "Descricao:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursosBindingSource1, "Descricao", true));
            this.txtDescricao.Location = new System.Drawing.Point(346, 174);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(100, 26);
            this.txtDescricao.TabIndex = 6;
            // 
            // FormCursos
            // 
            this.ClientSize = new System.Drawing.Size(466, 244);
            this.Controls.Add(idCursoLabel);
            this.Controls.Add(this.idCursoTextBox1);
            this.Controls.Add(nomeCursoLabel);
            this.Controls.Add(this.txtNomeCurso);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.cursosBindingSource1BindingNavigator);
            this.Name = "FormCursos";
            this.Load += new System.EventHandler(this.FormCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource1BindingNavigator)).EndInit();
            this.cursosBindingSource1BindingNavigator.ResumeLayout(false);
            this.cursosBindingSource1BindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProgramaCursos.Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource cursosBindingSource;
        private ProgramaCursos.Database1DataSetTableAdapters.CursosTableAdapter cursosTableAdapter;
        private ProgramaCursos.Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cursosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cursosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idCursoTextBox;
        private System.Windows.Forms.TextBox nomeCursoTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private ProgramaCursos.Database1DataSet database1DataSet1;
        private System.Windows.Forms.BindingSource cursosBindingSource1;
        private ProgramaCursos.Database1DataSetTableAdapters.CursosTableAdapter cursosTableAdapter1;
        private ProgramaCursos.Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingNavigator cursosBindingSource1BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cursosBindingSource1BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idCursoTextBox1;
        private System.Windows.Forms.TextBox txtNomeCurso;
        private System.Windows.Forms.TextBox txtDescricao;
    }
}