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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String curPasword = userpass_textBox.Text;
            String curUser = user_textBox.Text;

            if (curUser == "admin" && curPasword == "admin")
            {

                mainWindow mainForm = new mainWindow();
                this.Hide();
                mainForm.ShowDialog();
                this.Close();

               
            }

            else {
                string message = "El nombre de usuario o contraseña, son invalidas. Favor de verificar.";
                string caption = "Aviso";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons);
            }


        }
    }
}
