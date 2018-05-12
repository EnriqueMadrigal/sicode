using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sicode
{
    public partial class salesman : Form
    {

        private String curSalesMan;

        public salesman()
        {
            InitializeComponent();
        }

        private void salesman_Load(object sender, EventArgs e)
        {
            DataTable curDataTable;

            DatosAspel Data1 = new DatosAspel();
            Data1.Connect();

            curDataTable = Data1.LoadData("select CVE_VEND, NOMBRE from VEND01");
           // this.dataGridView1.DataSource = curDataTable;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;

            DataGridViewColumn col1 = new DataGridViewColumn();
            col1.Width = 250;
            col1.HeaderText = "Nombre";
            this.dataGridView1.Columns.Add(col1);
                
                
                



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            DataGridViewCell curcell = dataGridView1.CurrentCell;
            int curRow = curcell.RowIndex;

            //  if (rows.Count < 1) return;

            DataGridViewRow selectedRow = dataGridView1.Rows[curRow];
            DataGridViewCell curCell = selectedRow.Cells[0];

            MessageBox.Show(curCell.Value.ToString());

            //  this.curValue = ((DataRowView)dataGrid.SelectedItem).Row[1].ToString();
            //  this.curId = (int)((DataRowView)dataGrid.SelectedItem).Row[0];

            this.curSalesMan = curCell.Value.ToString().Trim();
            this.Close();

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewCell curcell = dataGridView1.CurrentCell;
            int curRow = curcell.RowIndex;

            //  if (rows.Count < 1) return;

            DataGridViewRow selectedRow = dataGridView1.Rows[curRow];
            DataGridViewCell curCell = selectedRow.Cells[0];

            MessageBox.Show(curCell.Value.ToString().Trim());

            //  this.curValue = ((DataRowView)dataGrid.SelectedItem).Row[1].ToString();
            //  this.curId = (int)((DataRowView)dataGrid.SelectedItem).Row[0];

            this.curSalesMan = curCell.Value.ToString().Trim();
            this.Close();
        }

        public String getSalesMan()
        {
            return this.curSalesMan;
        }
    }
}
