namespace liu_library
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодЧитателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерБилетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.читателиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.liu_libraryDataSet = new liu_library.liu_libraryDataSet();
            this.читателиTableAdapter = new liu_library.liu_libraryDataSetTableAdapters.ЧитателиTableAdapter();
            this.SaveReaderButton = new System.Windows.Forms.Button();
            this.DeleteReaderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.читателиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liu_libraryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодЧитателяDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.номерБилетаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.читателиBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(24, 28);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1200, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодЧитателяDataGridViewTextBoxColumn
            // 
            this.кодЧитателяDataGridViewTextBoxColumn.DataPropertyName = "Код читателя";
            this.кодЧитателяDataGridViewTextBoxColumn.HeaderText = "Код читателя";
            this.кодЧитателяDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.кодЧитателяDataGridViewTextBoxColumn.Name = "кодЧитателяDataGridViewTextBoxColumn";
            this.кодЧитателяDataGridViewTextBoxColumn.Width = 150;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.Width = 150;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.Width = 150;
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            this.отчествоDataGridViewTextBoxColumn.Width = 150;
            // 
            // номерБилетаDataGridViewTextBoxColumn
            // 
            this.номерБилетаDataGridViewTextBoxColumn.DataPropertyName = "Номер билета";
            this.номерБилетаDataGridViewTextBoxColumn.HeaderText = "Номер билета";
            this.номерБилетаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.номерБилетаDataGridViewTextBoxColumn.Name = "номерБилетаDataGridViewTextBoxColumn";
            this.номерБилетаDataGridViewTextBoxColumn.Width = 150;
            // 
            // читателиBindingSource
            // 
            this.читателиBindingSource.DataMember = "Читатели";
            this.читателиBindingSource.DataSource = this.liu_libraryDataSet;
            // 
            // liu_libraryDataSet
            // 
            this.liu_libraryDataSet.DataSetName = "liu_libraryDataSet";
            this.liu_libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // читателиTableAdapter
            // 
            this.читателиTableAdapter.ClearBeforeFill = true;
            // 
            // SaveReaderButton
            // 
            this.SaveReaderButton.Location = new System.Drawing.Point(24, 345);
            this.SaveReaderButton.Name = "SaveReaderButton";
            this.SaveReaderButton.Size = new System.Drawing.Size(485, 28);
            this.SaveReaderButton.TabIndex = 1;
            this.SaveReaderButton.Text = "Регистрация читателя";
            this.SaveReaderButton.UseVisualStyleBackColor = true;
            this.SaveReaderButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteReaderButton
            // 
            this.DeleteReaderButton.Location = new System.Drawing.Point(584, 345);
            this.DeleteReaderButton.Name = "DeleteReaderButton";
            this.DeleteReaderButton.Size = new System.Drawing.Size(280, 28);
            this.DeleteReaderButton.TabIndex = 2;
            this.DeleteReaderButton.Text = "Удалить читателя";
            this.DeleteReaderButton.UseVisualStyleBackColor = true;
            this.DeleteReaderButton.Click += new System.EventHandler(this.DeleteReaderButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 450);
            this.Controls.Add(this.DeleteReaderButton);
            this.Controls.Add(this.SaveReaderButton);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Регистрация читателя";
            this.Load += new System.EventHandler(this.AddReader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.читателиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liu_libraryDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private liu_libraryDataSet liu_libraryDataSet;
        private System.Windows.Forms.BindingSource читателиBindingSource;
        private liu_libraryDataSetTableAdapters.ЧитателиTableAdapter читателиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодЧитателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерБилетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button SaveReaderButton;
        private System.Windows.Forms.Button DeleteReaderButton;
    }
}