using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Ferreteria.Vistas
{
    public partial class frmUsuario : DevExpress.XtraEditors.XtraForm
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtPass.Clear();
            txtUsuario.Clear();
            txtUsuario.Focus();
        }
        private void Campos(bool nuevo, bool guardar, bool actualizar, bool eliminar, bool cancelar, bool campos)
        {
            btnNuevo.Enabled = nuevo;
            btnGuardar.Enabled = guardar;
            btnActualizar.Enabled = actualizar;
            btnEliminar.Enabled = eliminar;
            btnCancelar.Enabled = cancelar;
            txtUsuario.Enabled = campos;
            txtPass.Enabled = campos;
        }

        private void gridViewUsuarios_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Campos(false, true, false, false, true, true);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Campos(true, false, false, false, false, false);
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            Campos(true, false, false, false, false, false);
            xpCollectionUsuarios.Reload();
        }
    }
}