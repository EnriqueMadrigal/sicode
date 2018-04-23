using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;


namespace sicode
{
    class DatosAspel
    {

        private string connectionString = "DSN=Glinsa32;Uid=SYSDBA;Pwd=masterkey";
        private OdbcConnection curConnection;

        public DatosAspel()
        {

            this.curConnection = new OdbcConnection(this.connectionString);

        }


        public bool Connect()
        {
            try
            {
                this.curConnection.Open();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Exception: Connect");
                return false;
            }



            return true;
        }



        private OdbcConnection GetConnection()
        {

            if (this.curConnection.State != ConnectionState.Open)
            {
                Connect();
            }

            return this.curConnection;
        }


        public DataTable LoadData(string tableString)
        {

            try
            {
                DataTable ds = new DataTable("Nombres");
                OdbcCommand com = new OdbcCommand();

                com.Connection = GetConnection();
                com.CommandText = tableString;
                OdbcDataAdapter  adapt = new OdbcDataAdapter();
                adapt.SelectCommand = com;
                adapt.Fill(ds);
                //this.curConnection.Close();
                return ds;

            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Exception: LoadData");
                return null;
            }





        }






    }
}
