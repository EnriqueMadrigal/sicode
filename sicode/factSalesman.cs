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
    public partial class factSalesman : Form
    {

        private String curSalesman;
        public factSalesman()
        {
            InitializeComponent();
        }

        private void factSalesman_Load(object sender, EventArgs e)
        {

            DataTable curDataTable;

            DatosAspel Data1 = new DatosAspel();
            Data1.Connect();
            String query = "select STATUS,CVE_VEND,CAN_TOT, IMP_TOT4,CONDICION,IMPORTE,FOLIO,CONTADO  from FACTF01 where CVE_VEND='" + this.curSalesman + "'";

            curDataTable = Data1.LoadData(query);
            this.dataGridView1.DataSource = curDataTable;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;

        }

        public void setSalesman(String newSalesman)
        {
            this.curSalesman = newSalesman;

        }

    }
}
