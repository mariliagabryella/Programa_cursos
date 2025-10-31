namespace ProgramaCursos
{
    partial class FormAlunos
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
            System.Windows.Forms.Label idAlunoLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label dataNascimentoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlunos));
            this.alunosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.alunosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alunosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.alunosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.alunosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idAlunoTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.dataNascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.alunosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            idAlunoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            dataNascimentoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingNavigator)).BeginInit();
            this.alunosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // idAlunoLabel
            // 
            idAlunoLabel.AutoSize = true;
            idAlunoLabel.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.alunosBindingSource3, "IdAluno", true));
            idAlunoLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunosBindingSource3, "Nome", true));
            idAlunoLabel.Location = new System.Drawing.Point(239, 159);
            idAlunoLabel.Name = "idAlunoLabel";
            idAlunoLabel.Size = new System.Drawing.Size(72, 20);
            idAlunoLabel.TabIndex = 1;
            idAlunoLabel.Text = "Id Aluno:";
            // 
            // alunosBindingSource2
            // 
            this.alunosBindingSource2.DataMember = "Alunos";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.alunosBindingSource3, "IdAluno", true));
            nomeLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunosBindingSource3, "Nome", true));
            nomeLabel.Location = new System.Drawing.Point(239, 191);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(55, 20);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.alunosBindingSource3, "IdAluno", true));
            emailLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunosBindingSource3, "Nome", true));
            emailLabel.Location = new System.Drawing.Point(239, 223);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(52, 20);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email:";
            // 
            // dataNascimentoLabel
            // 
            dataNascimentoLabel.AutoSize = true;
            dataNascimentoLabel.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.alunosBindingSource3, "IdAluno", true));
            dataNascimentoLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunosBindingSource3, "Nome", true));
            dataNascimentoLabel.Location = new System.Drawing.Point(239, 256);
            dataNascimentoLabel.Name = "dataNascimentoLabel";
            dataNascimentoLabel.Size = new System.Drawing.Size(136, 20);
            dataNascimentoLabel.TabIndex = 7;
            dataNascimentoLabel.Text = "Data Nascimento:";
            // 
            // alunosBindingSource
            // 
            this.alunosBindingSource.DataMember = "Alunos";
            // 
            // alunosBindingNavigator
            // 
            this.alunosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.alunosBindingNavigator.BindingSource = this.alunosBindingSource;
            this.alunosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.alunosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.alunosBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.alunosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.alunosBindingNavigatorSaveItem});
            this.alunosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.alunosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.alunosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.alunosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.alunosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.alunosBindingNavigator.Name = "alunosBindingNavigator";
            this.alunosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.alunosBindingNavigator.Size = new System.Drawing.Size(800, 33);
            this.alunosBindingNavigator.TabIndex = 0;
            this.alunosBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(57, 28);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
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
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // alunosBindingNavigatorSaveItem
            // 
            this.alunosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alunosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("alunosBindingNavigatorSaveItem.Image")));
            this.alunosBindingNavigatorSaveItem.Name = "alunosBindingNavigatorSaveItem";
            this.alunosBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.alunosBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.alunosBindingNavigatorSaveItem.Click += new System.EventHandler(this.alunosBindingNavigatorSaveItem_Click_1);
            // 
            // alunosBindingSource1
            // 
            this.alunosBindingSource1.DataMember = "Alunos";
            // 
            // idAlunoTextBox
            // 
            this.idAlunoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.alunosBindingSource3, "IdAluno", true));
            this.idAlunoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunosBindingSource3, "Nome", true));
            this.idAlunoTextBox.Location = new System.Drawing.Point(381, 156);
            this.idAlunoTextBox.Name = "idAlunoTextBox";
            this.idAlunoTextBox.Size = new System.Drawing.Size(200, 26);
            this.idAlunoTextBox.TabIndex = 2;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.alunosBindingSource3, "IdAluno", true));
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunosBindingSource3, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(381, 188);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(200, 26);
            this.nomeTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.alunosBindingSource3, "IdAluno", true));
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunosBindingSource3, "Nome", true));
            this.emailTextBox.Location = new System.Drawing.Point(381, 220);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 26);
            this.emailTextBox.TabIndex = 6;
            // 
            // dataNascimentoDateTimePicker
            // 
            this.dataNascimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.alunosBindingSource1, "DataNascimento", true));
            this.dataNascimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.alunosBindingSource3, "IdAluno", true));
            this.dataNascimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunosBindingSource3, "Nome", true));
            this.dataNascimentoDateTimePicker.Location = new System.Drawing.Point(381, 252);
            this.dataNascimentoDateTimePicker.Name = "dataNascimentoDateTimePicker";
            this.dataNascimentoDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.dataNascimentoDateTimePicker.TabIndex = 8;
            // 
            // database1DataSet
            // 
            // 
            // alunosBindingSource3
            // 
            this.alunosBindingSource3.DataMember = "Alunos";
            // 
            // alunosTableAdapter
            // 
            // 
            // FormAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(idAlunoLabel);
            this.Controls.Add(this.idAlunoTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(dataNascimentoLabel);
            this.Controls.Add(this.dataNascimentoDateTimePicker);
            this.Controls.Add(this.alunosBindingNavigator);
            this.Name = "FormAlunos";
            this.Text = "FormAlunos";
            this.Load += new System.EventHandler(this.FormAlunos_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingNavigator)).EndInit();
            this.alunosBindingNavigator.ResumeLayout(false);
            this.alunosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource alunosBindingSource;
        private System.Windows.Forms.BindingNavigator alunosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton alunosBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource alunosBindingSource1;
        private System.Windows.Forms.TextBox idAlunoTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.DateTimePicker dataNascimentoDateTimePicker;
        private System.Windows.Forms.BindingSource alunosBindingSource2;
        private System.Windows.Forms.BindingSource alunosBindingSource3;
    }
}