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
    public partial class facturas : Form
    {

        private DataTable curDataTable;
        private String curSalesMan = "";


        public facturas()
        {
            InitializeComponent();
        }

        private void facturas_Load(object sender, EventArgs e)
        {

            DatosAspel Data1 = new DatosAspel();
            Data1.Connect();

            this.curDataTable = Data1.LoadData("");

            DataGridViewColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "Nombre Completo";
            col1.Name = "Nombre";
            col1.Width = 220;

            this.dataGridView1.Columns.Insert(0, col1);


        }

        public void setSalesman(String newsalesman)
        {
            this.curSalesMan = newsalesman;
        }
    }
}
