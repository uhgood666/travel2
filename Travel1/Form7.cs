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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void отдыхBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.отдыхBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.travelDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "travelDataSet.Отдых". При необходимости она может быть перемещена или удалена.
            this.отдыхTableAdapter.Fill(this.travelDataSet.Отдых);

        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 s = new Form4();
            s.Show();
            this.Hide();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            отдыхBindingSource.Filter = "КодМаршрута=\'" + toolStripTextBox1.Text + "\'";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            отдыхBindingSource.Filter = null;
        }
    }
}
