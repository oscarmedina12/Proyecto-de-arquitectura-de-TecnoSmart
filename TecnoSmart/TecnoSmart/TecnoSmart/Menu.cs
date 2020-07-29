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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_form_lista_clienteServicio_Click(object sender, EventArgs e)
        {
            ListarTecnoSmart LCS = new ListarTecnoSmart();
            LCS.Show();
        }

        private void btn_form_actualiza_entregaServicio_Click(object sender, EventArgs e)
        {
            ActualizarTecnoSmart AES = new ActualizarTecnoSmart();
            AES.Show();
        }

        private void btn_agregar_nuevo_servicio_Click(object sender, EventArgs e)
        {
            AgregarNuevoServicioRep ANSR = new AgregarNuevoServicioRep();
            ANSR.Show();
        }
    }
}
