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
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            salesman NewSales = new salesman();
            NewSales.ShowDialog();
            String curSalesman = NewSales.getSalesMan();

            factSalesman facturas = new factSalesman();
            facturas.setSalesman(curSalesman);
            facturas.ShowDialog();



        }

        private void mainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
