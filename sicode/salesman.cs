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

<<<<<<< HEAD
        private String curSalesMan;
=======
        private DataTable curDataTable;
        private String curSalesMan = "";
>>>>>>> 77815da93d65f8068ca2f2c906973a365157e00f

        public salesman()
        {
            InitializeComponent();
        }

        private void salesman_Load(object sender, EventArgs e)
        {
            //DataTable curDataTable;

            DatosAspel Data1 = new DatosAspel();
            Data1.Connect();

<<<<<<< HEAD
            curDataTable = Data1.LoadData("select CVE_VEND, NOMBRE from VEND01");
           // this.dataGridView1.DataSource = curDataTable;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;

            DataGridViewColumn col1 = new DataGridViewColumn();
            col1.Width = 250;
            col1.HeaderText = "Nombre";
            this.dataGridView1.Columns.Add(col1);
                
                
                



=======
            this.curDataTable = Data1.LoadData("select NOMBRE,CVE_VEND from VEND01");

            DataGridViewColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "Nombre Completo";
            col1.Name = "Nombre";
            col1.Width = 220;
  
            this.dataGridView1.Columns.Insert(0, col1);

            DataGridViewColumn col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Clave";
            col2.Name = "Clave";
            col2.Width = 20;
            col2.Visible = false;

            this.dataGridView1.Columns.Insert(1, col2);


            //this.dataGridView1.DataSource = curDataTable;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;


            foreach (DataRow row in curDataTable.Rows) {
                String curName = row[0].ToString();
                String curClave = row[1].ToString();


                DataGridViewRow newrow = new DataGridViewRow();
                newrow.CreateCells(this.dataGridView1);

                newrow.Cells[0].Value = curName;
                newrow.Cells[1].Value = curClave;

                this.dataGridView1.Rows.Add(newrow);


            }



            
>>>>>>> 77815da93d65f8068ca2f2c906973a365157e00f
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getCurrentValue();
            this.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

<<<<<<< HEAD

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
=======
            getCurrentValue();
            this.Close();
            
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            getCurrentValue();
            this.Close();
        }


        private String getCurrentValue()
        {
            String curSalesMan = "";
            DataGridViewCell curCell = dataGridView1.CurrentCell;
            int curRow = curCell.RowIndex;

            DataGridViewRow selectedRow = dataGridView1.Rows[curRow];
            DataGridViewCell selectedCel = selectedRow.Cells[1];

            curSalesMan = selectedCel.Value.ToString().Trim();
            return curSalesMan;

>>>>>>> 77815da93d65f8068ca2f2c906973a365157e00f
        }

        public String getSalesMan()
        {
            return this.curSalesMan;
        }
<<<<<<< HEAD
=======

>>>>>>> 77815da93d65f8068ca2f2c906973a365157e00f
    }
}
