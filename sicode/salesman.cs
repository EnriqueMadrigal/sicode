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
        public salesman()
        {
            InitializeComponent();
        }

        private void salesman_Load(object sender, EventArgs e)
        {
            DataTable curDataTable;

            DatosAspel Data1 = new DatosAspel();
            Data1.Connect();

            curDataTable = Data1.LoadData("select NOMBRE, CORREOE from VEND01");
            this.dataGridView1.DataSource = curDataTable;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
