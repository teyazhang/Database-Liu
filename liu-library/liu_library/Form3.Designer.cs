namespace liu_library
{
    partial class Form3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодВыдачиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодКнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодЧитателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВыдачиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВозвратаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.выдачаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.liu_libraryDataSet = new liu_library.liu_libraryDataSet();
            this.выдачаTableAdapter = new liu_library.liu_libraryDataSetTableAdapters.ВыдачаTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выдачаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liu_libraryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодВыдачиDataGridViewTextBoxColumn,
            this.кодКнигиDataGridViewTextBoxColumn,
            this.кодЧитателяDataGridViewTextBoxColumn,
            this.датаВыдачиDataGridViewTextBoxColumn,
            this.датаВозвратаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.выдачаBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(13, 22);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1200, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодВыдачиDataGridViewTextBoxColumn
            // 
            this.кодВыдачиDataGridViewTextBoxColumn.DataPropertyName = "Код выдачи";
            this.кодВыдачиDataGridViewTextBoxColumn.HeaderText = "Код выдачи";
            this.кодВыдачиDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.кодВыдачиDataGridViewTextBoxColumn.Name = "кодВыдачиDataGridViewTextBoxColumn";
            this.кодВыдачиDataGridViewTextBoxColumn.Width = 150;
            // 
            // кодКнигиDataGridViewTextBoxColumn
            // 
            this.кодКнигиDataGridViewTextBoxColumn.DataPropertyName = "Код книги";
            this.кодКнигиDataGridViewTextBoxColumn.HeaderText = "Код книги";
            this.кодКнигиDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.кодКнигиDataGridViewTextBoxColumn.Name = "кодКнигиDataGridViewTextBoxColumn";
            this.кодКнигиDataGridViewTextBoxColumn.Width = 150;
            // 
            // кодЧитателяDataGridViewTextBoxColumn
            // 
            this.кодЧитателяDataGridViewTextBoxColumn.DataPropertyName = "Код читателя";
            this.кодЧитателяDataGridViewTextBoxColumn.HeaderText = "Код читателя";
            this.кодЧитателяDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.кодЧитателяDataGridViewTextBoxColumn.Name = "кодЧитателяDataGridViewTextBoxColumn";
            this.кодЧитателяDataGridViewTextBoxColumn.Width = 150;
            // 
            // датаВыдачиDataGridViewTextBoxColumn
            // 
            this.датаВыдачиDataGridViewTextBoxColumn.DataPropertyName = "Дата выдачи";
            this.датаВыдачиDataGridViewTextBoxColumn.HeaderText = "Дата выдачи";
            this.датаВыдачиDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.датаВыдачиDataGridViewTextBoxColumn.Name = "датаВыдачиDataGridViewTextBoxColumn";
            this.датаВыдачиDataGridViewTextBoxColumn.Width = 150;
            // 
            // датаВозвратаDataGridViewTextBoxColumn
            // 
            this.датаВозвратаDataGridViewTextBoxColumn.DataPropertyName = "Дата возврата";
            this.датаВозвратаDataGridViewTextBoxColumn.HeaderText = "Дата возврата";
            this.датаВозвратаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.датаВозвратаDataGridViewTextBoxColumn.Name = "датаВозвратаDataGridViewTextBoxColumn";
            this.датаВозвратаDataGridViewTextBoxColumn.Width = 150;
            // 
            // выдачаBindingSource
            // 
            this.выдачаBindingSource.DataMember = "Выдача";
            this.выдачаBindingSource.DataSource = this.liu_libraryDataSet;
            // 
            // liu_libraryDataSet
            // 
            this.liu_libraryDataSet.DataSetName = "liu_libraryDataSet";
            this.liu_libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // выдачаTableAdapter
            // 
            this.выдачаTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(13, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(306, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить выдачу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(334, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(385, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить выдачу ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация выдача";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выдачаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liu_libraryDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private liu_libraryDataSet liu_libraryDataSet;
        private System.Windows.Forms.BindingSource выдачаBindingSource;
        private liu_libraryDataSetTableAdapters.ВыдачаTableAdapter выдачаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодВыдачиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКнигиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодЧитателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВыдачиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВозвратаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}