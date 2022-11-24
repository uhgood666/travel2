using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void туризмBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.туризмBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.travelDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "travelDataSet.Туризм". При необходимости она может быть перемещена или удалена.
            this.туризмTableAdapter.Fill(this.travelDataSet.Туризм);

        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 s = new Form4();
            s.Show();
            this.Hide();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            туризмBindingSource.Filter = "КодМаршрута=\'" + toolStripTextBox1.Text + "\'";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            туризмBindingSource.Filter = null;
        }
    }
}
