using System.Drawing;
using System.Windows.Forms;

namespace Ferreteria.Vistas
{
    partial class frmClienteJuridico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClienteJuridico));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControlClienteJuridico = new DevExpress.XtraGrid.GridControl();
            this.xpCollectionClienteJuridico = new DevExpress.Xpo.XPCollection(this.components);
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork(this.components);
            this.gridViewClienteJuridico = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdClienteJuridico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroRuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtRUC = new DevExpress.XtraEditors.TextEdit();
            this.txtNombreEmpresa = new DevExpress.XtraEditors.TextEdit();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnActualizar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlClienteJuridico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionClienteJuridico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClienteJuridico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRUC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreEmpresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControlClienteJuridico);
            this.layoutControl1.Controls.Add(this.txtRUC);
            this.layoutControl1.Controls.Add(this.txtNombreEmpresa);
            this.layoutControl1.Controls.Add(this.btnGuardar);
            this.layoutControl1.Controls.Add(this.btnActualizar);
            this.layoutControl1.Controls.Add(this.btnEliminar);
            this.layoutControl1.Controls.Add(this.btnNuevo);
            this.layoutControl1.Controls.Add(this.btnCancelar);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(924, 124, 975, 600);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(834, 493);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControlClienteJuridico
            // 
            this.gridControlClienteJuridico.DataSource = this.xpCollectionClienteJuridico;
            this.gridControlClienteJuridico.Location = new System.Drawing.Point(12, 112);
            this.gridControlClienteJuridico.MainView = this.gridViewClienteJuridico;
            this.gridControlClienteJuridico.Name = "gridControlClienteJuridico";
            this.gridControlClienteJuridico.Size = new System.Drawing.Size(810, 369);
            this.gridControlClienteJuridico.TabIndex = 6;
            this.gridControlClienteJuridico.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewClienteJuridico});
            // 
            // xpCollectionClienteJuridico
            // 
            this.xpCollectionClienteJuridico.ObjectType = typeof(Proyecto_Ferreteria.base_datos_ferreteria.Clientejuridico);
            this.xpCollectionClienteJuridico.Session = this.unitOfWork1;
            // 
            // gridViewClienteJuridico
            // 
            this.gridViewClienteJuridico.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdClienteJuridico,
            this.colNumeroRuc,
            this.colNombreEmpresa});
            this.gridViewClienteJuridico.GridControl = this.gridControlClienteJuridico;
            this.gridViewClienteJuridico.Name = "gridViewClienteJuridico";
            this.gridViewClienteJuridico.OptionsBehavior.Editable = false;
            this.gridViewClienteJuridico.OptionsView.ShowDetailButtons = false;
            this.gridViewClienteJuridico.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewClienteJuridico_RowClick);
            // 
            // colIdClienteJuridico
            // 
            this.colIdClienteJuridico.FieldName = "IdClienteJuridico";
            this.colIdClienteJuridico.MinWidth = 30;
            this.colIdClienteJuridico.Name = "colIdClienteJuridico";
            this.colIdClienteJuridico.Width = 112;
            // 
            // colNumeroRuc
            // 
            this.colNumeroRuc.Caption = "RUC";
            this.colNumeroRuc.FieldName = "NumeroRuc";
            this.colNumeroRuc.MinWidth = 30;
            this.colNumeroRuc.Name = "colNumeroRuc";
            this.colNumeroRuc.Visible = true;
            this.colNumeroRuc.VisibleIndex = 0;
            this.colNumeroRuc.Width = 112;
            // 
            // colNombreEmpresa
            // 
            this.colNombreEmpresa.Caption = "Empresa";
            this.colNombreEmpresa.FieldName = "NombreEmpresa";
            this.colNombreEmpresa.MinWidth = 30;
            this.colNombreEmpresa.Name = "colNombreEmpresa";
            this.colNombreEmpresa.Visible = true;
            this.colNombreEmpresa.VisibleIndex = 1;
            this.colNombreEmpresa.Width = 112;
            // 
            // txtRUC
            // 
            this.txtRUC.Location = new System.Drawing.Point(192, 12);
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(630, 26);
            this.txtRUC.StyleController = this.layoutControl1;
            this.txtRUC.TabIndex = 0;
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.Location = new System.Drawing.Point(192, 42);
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.Size = new System.Drawing.Size(630, 26);
            this.txtNombreEmpresa.StyleController = this.layoutControl1;
            this.txtNombreEmpresa.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(175, 72);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(159, 36);
            this.btnGuardar.StyleController = this.layoutControl1;
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.ImageOptions.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(338, 72);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(159, 36);
            this.btnActualizar.StyleController = this.layoutControl1;
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(501, 72);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(158, 36);
            this.btnEliminar.StyleController = this.layoutControl1;
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(834, 493);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtRUC;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(814, 30);
            this.layoutControlItem1.Text = "RUC:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(168, 19);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtNombreEmpresa;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(814, 30);
            this.layoutControlItem2.Text = "Nombre de la Empresa:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(168, 19);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnGuardar;
            this.layoutControlItem3.Location = new System.Drawing.Point(163, 60);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(163, 40);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnActualizar;
            this.layoutControlItem4.Location = new System.Drawing.Point(326, 60);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(163, 40);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnEliminar;
            this.layoutControlItem5.Location = new System.Drawing.Point(489, 60);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(162, 40);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.gridControlClienteJuridico;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 100);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(814, 373);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(12, 72);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(159, 36);
            this.btnNuevo.StyleController = this.layoutControl1;
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnNuevo;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 60);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(163, 40);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(663, 72);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(159, 36);
            this.btnCancelar.StyleController = this.layoutControl1;
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnCancelar;
            this.layoutControlItem8.Location = new System.Drawing.Point(651, 60);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(163, 40);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // frmClienteJuridico
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 493);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmClienteJuridico";
            this.Text = "Registro de Cliente Juridico";
            this.Load += new System.EventHandler(this.frmClienteJuridico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlClienteJuridico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionClienteJuridico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClienteJuridico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRUC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreEmpresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtRUC;
        private DevExpress.XtraEditors.TextEdit txtNombreEmpresa;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnActualizar;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.GridControl gridControlClienteJuridico;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewClienteJuridico;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.Xpo.XPCollection xpCollectionClienteJuridico;
        private DevExpress.XtraGrid.Columns.GridColumn colIdClienteJuridico;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroRuc;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreEmpresa;
        private DevExpress.XtraEditors.SimpleButton btnNuevo;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}