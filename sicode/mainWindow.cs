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
<<<<<<< HEAD
            String curSalesman = NewSales.getSalesMan();

            factSalesman facturas = new factSalesman();
            facturas.setSalesman(curSalesman);
            facturas.ShowDialog();



        }

        private void mainWindow_Load(object sender, EventArgs e)
        {
=======
            String curSalesMan = NewSales.getSalesMan();



>>>>>>> 77815da93d65f8068ca2f2c906973a365157e00f

        }
    }
}
