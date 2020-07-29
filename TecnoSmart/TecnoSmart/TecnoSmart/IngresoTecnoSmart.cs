using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace TecnoSmart
{
    public partial class IngresoTecnoSmart : Form
    {
        public IngresoTecnoSmart()
        {
            Conexion cn = new Conexion();

            InitializeComponent();
            #region CaragComboProducto
            cbox_Producto.ValueMember = "id";
            cbox_Producto.DisplayMember = "Nombre";
            cbox_Producto.DataSource = cn.CargarComboProducto();
            #endregion
        }

        private void cbox_Producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Conexion cn = new Conexion();
                lblIdPro.Text = cbox_Producto.SelectedValue.ToString();
                #region CargaComboxReparacion_Producto
                cbox_Reparacion.ValueMember = "id";
                cbox_Reparacion.DisplayMember = "Nombre";
                cbox_Reparacion.DataSource = cn.CargarComboReparacionProducto(Convert.ToInt32(cbox_Producto.SelectedValue));
                #endregion
            }
            catch (Exception ex)
            {

                lblMensaje.Text = ex.Message.ToString();
            }
        }

        private void cbox_Reparacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lblIdRep.Text = cbox_Producto.SelectedValue.ToString();
            }
            catch (Exception ex)
            {

                lblMensaje.Text = ex.Message.ToString();
            }
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            Menu M = new Menu();
            M.Show();
        }
    }
}
