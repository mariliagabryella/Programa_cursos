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
            this.inscricoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inscricoesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.inscricoesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idInscricaoTextBox = new System.Windows.Forms.TextBox();
            this.idAlunoTextBox = new System.Windows.Forms.TextBox();
            this.idCursoTextBox = new System.Windows.Forms.TextBox();
            this.dataInscricaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            idInscricaoLabel = new System.Windows.Forms.Label();
            idAlunoLabel = new System.Windows.Forms.Label();
            idCursoLabel = new System.Windows.Forms.Label();
            dataInscricaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inscricoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscricoesBindingNavigator)).BeginInit();
            this.inscricoesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            // 
            // inscricoesBindingSource
            // 
            this.inscricoesBindingSource.DataMember = "Inscricoes";
            // 
            // inscricoesTableAdapter
            // 
            // 
            // tableAdapterManager
            // 
        
            // inscricoesBindingNavigator
            // 
            this.inscricoesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.inscricoesBindingNavigator.BindingSource = this.inscricoesBindingSource;
            this.inscricoesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.inscricoesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.inscricoesBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.inscricoesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.inscricoesBindingNavigatorSaveItem});
            this.inscricoesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.inscricoesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.inscricoesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.inscricoesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.inscricoesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.inscricoesBindingNavigator.Name = "inscricoesBindingNavigator";
            this.inscricoesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.inscricoesBindingNavigator.Size = new System.Drawing.Size(800, 33);
            this.inscricoesBindingNavigator.TabIndex = 0;
            this.inscricoesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 20);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 20);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(57, 25);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Mover seguinte";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // inscricoesBindingNavigatorSaveItem
            // 
            this.inscricoesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.inscricoesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("inscricoesBindingNavigatorSaveItem.Image")));
            this.inscricoesBindingNavigatorSaveItem.Name = "inscricoesBindingNavigatorSaveItem";
            this.inscricoesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.inscricoesBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.inscricoesBindingNavigatorSaveItem.Click += new System.EventHandler(this.inscricoesBindingNavigatorSaveItem_Click);
            // 
            // idInscricaoLabel
            // 
            idInscricaoLabel.AutoSize = true;
            idInscricaoLabel.Location = new System.Drawing.Point(248, 142);
            idInscricaoLabel.Name = "idInscricaoLabel";
            idInscricaoLabel.Size = new System.Drawing.Size(95, 20);
            idInscricaoLabel.TabIndex = 1;
            idInscricaoLabel.Text = "Id Inscricao:";
            // 
            // idInscricaoTextBox
            // 
            this.idInscricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscricoesBindingSource, "IdInscricao", true));
            this.idInscricaoTextBox.Location = new System.Drawing.Point(370, 139);
            this.idInscricaoTextBox.Name = "idInscricaoTextBox";
            this.idInscricaoTextBox.Size = new System.Drawing.Size(200, 26);
            this.idInscricaoTextBox.TabIndex = 2;
            // 
            // idAlunoLabel
            // 
            idAlunoLabel.AutoSize = true;
            idAlunoLabel.Location = new System.Drawing.Point(248, 174);
            idAlunoLabel.Name = "idAlunoLabel";
            idAlunoLabel.Size = new System.Drawing.Size(72, 20);
            idAlunoLabel.TabIndex = 3;
            idAlunoLabel.Text = "Id Aluno:";
            // 
            // idAlunoTextBox
            // 
            this.idAlunoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscricoesBindingSource, "IdAluno", true));
            this.idAlunoTextBox.Location = new System.Drawing.Point(370, 171);
            this.idAlunoTextBox.Name = "idAlunoTextBox";
            this.idAlunoTextBox.Size = new System.Drawing.Size(200, 26);
            this.idAlunoTextBox.TabIndex = 4;
            // 
            // idCursoLabel
            // 
            idCursoLabel.AutoSize = true;
            idCursoLabel.Location = new System.Drawing.Point(248, 206);
            idCursoLabel.Name = "idCursoLabel";
            idCursoLabel.Size = new System.Drawing.Size(73, 20);
            idCursoLabel.TabIndex = 5;
            idCursoLabel.Text = "Id Curso:";
            // 
            // idCursoTextBox
            // 
            this.idCursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscricoesBindingSource, "IdCurso", true));
            this.idCursoTextBox.Location = new System.Drawing.Point(370, 203);
            this.idCursoTextBox.Name = "idCursoTextBox";
            this.idCursoTextBox.Size = new System.Drawing.Size(200, 26);
            this.idCursoTextBox.TabIndex = 6;
            // 
            // dataInscricaoLabel
            // 
            dataInscricaoLabel.AutoSize = true;
            dataInscricaoLabel.Location = new System.Drawing.Point(248, 239);
            dataInscricaoLabel.Name = "dataInscricaoLabel";
            dataInscricaoLabel.Size = new System.Drawing.Size(116, 20);
            dataInscricaoLabel.TabIndex = 7;
            dataInscricaoLabel.Text = "Data Inscricao:";
            // 
            // dataInscricaoDateTimePicker
            // 
            this.dataInscricaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inscricoesBindingSource, "DataInscricao", true));
            this.dataInscricaoDateTimePicker.Location = new System.Drawing.Point(370, 235);
            this.dataInscricaoDateTimePicker.Name = "dataInscricaoDateTimePicker";
            this.dataInscricaoDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.dataInscricaoDateTimePicker.TabIndex = 8;
            // 
            // FormInscricoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(idInscricaoLabel);
            this.Controls.Add(this.idInscricaoTextBox);
            this.Controls.Add(idAlunoLabel);
            this.Controls.Add(this.idAlunoTextBox);
            this.Controls.Add(idCursoLabel);
            this.Controls.Add(this.idCursoTextBox);
            this.Controls.Add(dataInscricaoLabel);
            this.Controls.Add(this.dataInscricaoDateTimePicker);
            this.Controls.Add(this.inscricoesBindingNavigator);
            this.Name = "FormInscricoes";
            this.Text = "FornInscricoes";
            this.Load += new System.EventHandler(this.FormInscricoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inscricoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscricoesBindingNavigator)).EndInit();
            this.inscricoesBindingNavigator.ResumeLayout(false);
            this.inscricoesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource inscricoesBindingSource;
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
    }
}