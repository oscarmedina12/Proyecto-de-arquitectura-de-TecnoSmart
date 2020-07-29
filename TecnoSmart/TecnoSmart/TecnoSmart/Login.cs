using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TecnoSmart
{
    public partial class Login : Form
    {
        int count = 0;

        public Login()
        {
            InitializeComponent();
        }

        private void btn_Ingreso_Login_Click(object sender, EventArgs e)
        {
            if (txt_administrador.Text == "")
            {
                MessageBox.Show("Ingrese el administrador");
            }
            else if (txt_contraseña.Text == "")
            {
                MessageBox.Show("Ingrese la contraseña");
            }
            else
            {

                try
                {
                    if (txt_administrador.Text == "admin" && txt_contraseña.Text == "admin")
                    {
                        MessageBox.Show("BIEVENIDO:" + txt_administrador.Text);

                        IngresoTecnoSmart ITS = new IngresoTecnoSmart();
                        ITS.Show();
                    }
                    else
                    {
                        MessageBox.Show("Ups! te equivocaste de clave");

                        count += 1;

                        txt_administrador.Text = "";
                        txt_contraseña.Text = "";

                        if (count > 2)
                        {
                            MessageBox.Show("Comuniquese con el administrador");

                        }
                    }

                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }
    }
}
