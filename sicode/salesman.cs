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

        private DataTable curDataTable;
        private String curSalesMan = "";

        public salesman()
        {
            InitializeComponent();
        }

        private void salesman_Load(object sender, EventArgs e)
        {
            //DataTable curDataTable;

            DatosAspel Data1 = new DatosAspel();
            Data1.Connect();

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



            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getCurrentValue();
            this.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        }

        public String getSalesMan()
        {
            return this.curSalesMan;
        }

    }
}
