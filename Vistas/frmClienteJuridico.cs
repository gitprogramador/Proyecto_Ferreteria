using DevExpress.XtraEditors;
using Proyecto_Ferreteria.base_datos_ferreteria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria.Vistas
{
    public partial class frmClienteJuridico : DevExpress.XtraEditors.XtraForm
    {
        public frmClienteJuridico()
        {
            InitializeComponent();
        }
        private void Limpiar() 
        {
            txtRUC.Clear();
            txtNombreEmpresa.Clear();
            txtRUC.Focus();

        }
        private void Campos(bool nuevo,bool guardar, bool actualizar,bool eliminar,bool cancelar,bool campos)
        {
            btnNuevo.Enabled = nuevo;
            btnGuardar.Enabled = guardar;
            btnActualizar.Enabled = actualizar;
            btnEliminar.Enabled = eliminar;
            btnCancelar.Enabled = cancelar;
            txtRUC.Enabled = campos;
            txtNombreEmpresa.Enabled = campos;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRUC.Text) || 
                string.IsNullOrEmpty(txtNombreEmpresa.Text) )
            {
                MessageBox.Show("Campos Obligatorios","Ferreteria",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Clientejuridico cj = new Clientejuridico(unitOfWork1);
            cj.NumeroRuc = txtRUC.Text;
            cj.NombreEmpresa = txtNombreEmpresa.Text;
            cj.Save();

            unitOfWork1.CommitChanges();
            MessageBox.Show("Exitoso", "Ferreteria",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            xpCollectionClienteJuridico.Reload();
            Limpiar();
            Campos(true, false, false, false, false, false);

        }

        private void gridViewClienteJuridico_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if(e.RowHandle >= 0)
            {
                txtRUC.Text = gridViewClienteJuridico.GetFocusedRowCellValue("NumeroRuc").ToString();
                txtNombreEmpresa.Text = gridViewClienteJuridico.GetFocusedRowCellValue("NombreEmpresa").ToString();
            }
            Campos(false,false,true,true,true,true);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            // Verifica si hay una fila seleccionada en el grid
            if (gridViewClienteJuridico.FocusedRowHandle >= 0)
            {
                // Obtener el usuario seleccionado
                string usuarioSeleccionado = gridViewClienteJuridico.GetRowCellValue(gridViewClienteJuridico.FocusedRowHandle, "NumeroRuc").ToString();

                // Validar que los campos de usuario y contraseña no estén vacíos
                if (string.IsNullOrEmpty(txtNombreEmpresa.Text) || string.IsNullOrEmpty(txtRUC.Text))
                {
                    MessageBox.Show("Campos Requeridos", "Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Buscar el usuario en la XPCollection de forma manual
                Clientejuridico usuarioAActualizar = null;

                foreach (Clientejuridico usuario in xpCollectionClienteJuridico)
                {
                    if (usuario.NumeroRuc == usuarioSeleccionado)
                    {
                        usuarioAActualizar = usuario;
                        break;
                    }
                }

                if (usuarioAActualizar != null)
                {
                    // Actualizar los valores del usuario con los valores de los controles
                    usuarioAActualizar.NombreEmpresa = txtNombreEmpresa.Text;

                    usuarioAActualizar.NumeroRuc = txtRUC.Text;

                    // Guardar los cambios en la base de datos
                    usuarioAActualizar.Save();
                    unitOfWork1.CommitChanges();

                    // Mostrar mensaje de éxito
                    MessageBox.Show("Actualizado con éxito", "Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Recargar los datos del grid
                    xpCollectionClienteJuridico.Reload();

                    // Limpiar los campos
                    Limpiar();
                    Campos(true, false, false, false, false, false);

                }
                else
                {
                    MessageBox.Show("Cliente no encontrado", "Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Si no hay ningún usuario seleccionado
                MessageBox.Show("Por favor, selecciona un registro para actualizar", "Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada en el grid
            if (gridViewClienteJuridico.FocusedRowHandle >= 0 && txtRUC.Text != "" && txtNombreEmpresa.Text != "" )
            {
                // Obtener el usuario seleccionado
                string usuarioSeleccionado = gridViewClienteJuridico.GetRowCellValue(gridViewClienteJuridico.FocusedRowHandle, "NumeroRuc").ToString();

                // Mostrar mensaje de confirmación
                DialogResult confirmacion = MessageBox.Show($"¿Estás seguro que deseas eliminar el usuario {usuarioSeleccionado}?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    // Buscar el usuario en la XPCollection de forma manual
                    Clientejuridico usuarioAEliminar = null;

                    foreach (Clientejuridico usuario in xpCollectionClienteJuridico)
                    {
                        if (usuario.NumeroRuc == usuarioSeleccionado)
                        {
                            usuarioAEliminar = usuario;
                            break;
                        }
                    }

                    if (usuarioAEliminar != null)
                    {
                        // Eliminar el usuario de la colección y la base de datos
                        usuarioAEliminar.Delete();
                        unitOfWork1.CommitChanges();

                        // Mostrar mensaje de éxito
                        MessageBox.Show("Eliminado con éxito", "Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Recargar los datos del grid
                        xpCollectionClienteJuridico.Reload();

                        // Limpiar los campos
                        Limpiar();
                        Campos(true, false, false, false, false, false);
                    }
                    else
                    {
                        MessageBox.Show("No encontrado", "Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Si no hay ningún usuario seleccionado
                MessageBox.Show("Por favor, selecciona un registro para eliminar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Campos(false,true,false,false,true,true);
        }

        private void frmClienteJuridico_Load(object sender, EventArgs e)
        {
            Campos(true, false, false, false, false,false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Campos(true, false, false, false, false, false);
            xpCollectionClienteJuridico.Reload();
        }
    }
}