namespace liu_library
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодКнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеКнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.авторКнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаИзданияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фондBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.liu_libraryDataSet = new liu_library.liu_libraryDataSet();
            this.фондTableAdapter = new liu_library.liu_libraryDataSetTableAdapters.ФондTableAdapter();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фондBindingSource)).BeginInit();
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
            this.кодКнигиDataGridViewTextBoxColumn,
            this.названиеКнигиDataGridViewTextBoxColumn,
            this.авторКнигиDataGridViewTextBoxColumn,
            this.датаИзданияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.фондBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.Location = new System.Drawing.Point(-13, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 200;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(1200, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодКнигиDataGridViewTextBoxColumn
            // 
            this.кодКнигиDataGridViewTextBoxColumn.DataPropertyName = "Код книги";
            this.кодКнигиDataGridViewTextBoxColumn.HeaderText = "Код книги";
            this.кодКнигиDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.кодКнигиDataGridViewTextBoxColumn.Name = "кодКнигиDataGridViewTextBoxColumn";
            this.кодКнигиDataGridViewTextBoxColumn.Width = 150;
            // 
            // названиеКнигиDataGridViewTextBoxColumn
            // 
            this.названиеКнигиDataGridViewTextBoxColumn.DataPropertyName = "Название книги";
            this.названиеКнигиDataGridViewTextBoxColumn.HeaderText = "Название книги";
            this.названиеКнигиDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.названиеКнигиDataGridViewTextBoxColumn.Name = "названиеКнигиDataGridViewTextBoxColumn";
            this.названиеКнигиDataGridViewTextBoxColumn.Width = 150;
            // 
            // авторКнигиDataGridViewTextBoxColumn
            // 
            this.авторКнигиDataGridViewTextBoxColumn.DataPropertyName = "Автор книги";
            this.авторКнигиDataGridViewTextBoxColumn.HeaderText = "Автор книги";
            this.авторКнигиDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.авторКнигиDataGridViewTextBoxColumn.Name = "авторКнигиDataGridViewTextBoxColumn";
            this.авторКнигиDataGridViewTextBoxColumn.Width = 150;
            // 
            // датаИзданияDataGridViewTextBoxColumn
            // 
            this.датаИзданияDataGridViewTextBoxColumn.DataPropertyName = "Дата издания";
            this.датаИзданияDataGridViewTextBoxColumn.HeaderText = "Дата издания";
            this.датаИзданияDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.датаИзданияDataGridViewTextBoxColumn.Name = "датаИзданияDataGridViewTextBoxColumn";
            this.датаИзданияDataGridViewTextBoxColumn.Width = 150;
            // 
            // фондBindingSource
            // 
            this.фондBindingSource.DataMember = "Фонд";
            this.фондBindingSource.DataSource = this.liu_libraryDataSet;
            // 
            // liu_libraryDataSet
            // 
            this.liu_libraryDataSet.DataSetName = "liu_libraryDataSet";
            this.liu_libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // фондTableAdapter
            // 
            this.фондTableAdapter.ClearBeforeFill = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(12, 328);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(405, 36);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Регистрация книги";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Bauhaus 93", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(484, 328);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(255, 36);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Удалить книгу";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bauhaus 93", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(405, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Регистрация книг";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фондBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liu_libraryDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private liu_libraryDataSet liu_libraryDataSet;
        private System.Windows.Forms.BindingSource фондBindingSource;
        private liu_libraryDataSetTableAdapters.ФондTableAdapter фондTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКнигиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеКнигиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn авторКнигиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаИзданияDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}

