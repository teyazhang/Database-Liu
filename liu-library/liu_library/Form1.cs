using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace liu_library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "liu_libraryDataSet.Фонд". При необходимости она может быть перемещена или удалена.
            this.фондTableAdapter.Fill(this.liu_libraryDataSet.Фонд);

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            фондTableAdapter.Update(liu_libraryDataSet);
        }

        

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                dataGridView1.Rows.RemoveAt(фондBindingSource.Position);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search sf = new Search();
            sf.Owner = this;
            sf.Show();
        }
    }


}
