
namespace ControlGastos
{
    partial class PantallaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipal));
            this.grpCampoDatos = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rtxtDemora = new System.Windows.Forms.RichTextBox();
            this.lblDemora = new System.Windows.Forms.Label();
            this.btnVaciarCampos = new System.Windows.Forms.Button();
            this.cboUnidades = new System.Windows.Forms.ComboBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblPrecioDolares = new System.Windows.Forms.Label();
            this.txtImpuestos = new System.Windows.Forms.TextBox();
            this.lblPrecioPesos = new System.Windows.Forms.Label();
            this.lblFechaCarga = new System.Windows.Forms.Label();
            this.dtpFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.txtTipoGasto = new System.Windows.Forms.TextBox();
            this.lblTipoServicio = new System.Windows.Forms.Label();
            this.lblRemision = new System.Windows.Forms.Label();
            this.txtGarantia = new System.Windows.Forms.TextBox();
            this.txtCodigoGasto = new System.Windows.Forms.TextBox();
            this.lblCodigoCruce = new System.Windows.Forms.Label();
            this.lblCaja = new System.Windows.Forms.Label();
            this.txtNoFactura = new System.Windows.Forms.TextBox();
            this.mstMenu = new System.Windows.Forms.MenuStrip();
            this.archivoYConexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirColumnaDemoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conectarABaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.direccionYVistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obtenerDireccionDeEsteEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarReporteAExcelxlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.dtgTablaDatos = new System.Windows.Forms.DataGridView();
            this.pnlPanelInferior = new System.Windows.Forms.Panel();
            this.pnlSuperiorBotones = new System.Windows.Forms.Panel();
            this.btnOrdenarFechaCarga = new System.Windows.Forms.Button();
            this.colId_ControlGastos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGastos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoGasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImpuestos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumeroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGarantia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDemora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpCampoDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mstMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTablaDatos)).BeginInit();
            this.pnlPanelInferior.SuspendLayout();
            this.pnlSuperiorBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCampoDatos
            // 
            this.grpCampoDatos.Controls.Add(this.pictureBox1);
            this.grpCampoDatos.Controls.Add(this.rtxtDemora);
            this.grpCampoDatos.Controls.Add(this.lblDemora);
            this.grpCampoDatos.Controls.Add(this.btnVaciarCampos);
            this.grpCampoDatos.Controls.Add(this.cboUnidades);
            this.grpCampoDatos.Controls.Add(this.btnEditar);
            this.grpCampoDatos.Controls.Add(this.btnEliminar);
            this.grpCampoDatos.Controls.Add(this.btnAgregar);
            this.grpCampoDatos.Controls.Add(this.lblUnidad);
            this.grpCampoDatos.Controls.Add(this.txtCantidad);
            this.grpCampoDatos.Controls.Add(this.lblPrecioDolares);
            this.grpCampoDatos.Controls.Add(this.txtImpuestos);
            this.grpCampoDatos.Controls.Add(this.lblPrecioPesos);
            this.grpCampoDatos.Controls.Add(this.lblFechaCarga);
            this.grpCampoDatos.Controls.Add(this.dtpFechaCompra);
            this.grpCampoDatos.Controls.Add(this.txtTipoGasto);
            this.grpCampoDatos.Controls.Add(this.lblTipoServicio);
            this.grpCampoDatos.Controls.Add(this.lblRemision);
            this.grpCampoDatos.Controls.Add(this.txtGarantia);
            this.grpCampoDatos.Controls.Add(this.txtCodigoGasto);
            this.grpCampoDatos.Controls.Add(this.lblCodigoCruce);
            this.grpCampoDatos.Controls.Add(this.lblCaja);
            this.grpCampoDatos.Controls.Add(this.txtNoFactura);
            this.grpCampoDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpCampoDatos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCampoDatos.ForeColor = System.Drawing.Color.Black;
            this.grpCampoDatos.Location = new System.Drawing.Point(0, 24);
            this.grpCampoDatos.Name = "grpCampoDatos";
            this.grpCampoDatos.Size = new System.Drawing.Size(1408, 337);
            this.grpCampoDatos.TabIndex = 0;
            this.grpCampoDatos.TabStop = false;
            this.grpCampoDatos.Text = "Campo de Datos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1060, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // rtxtDemora
            // 
            this.rtxtDemora.Location = new System.Drawing.Point(524, 154);
            this.rtxtDemora.MaxLength = 120;
            this.rtxtDemora.Name = "rtxtDemora";
            this.rtxtDemora.ReadOnly = true;
            this.rtxtDemora.Size = new System.Drawing.Size(233, 88);
            this.rtxtDemora.TabIndex = 47;
            this.rtxtDemora.Text = "";
            // 
            // lblDemora
            // 
            this.lblDemora.AutoSize = true;
            this.lblDemora.Location = new System.Drawing.Point(462, 173);
            this.lblDemora.Name = "lblDemora";
            this.lblDemora.Size = new System.Drawing.Size(52, 16);
            this.lblDemora.TabIndex = 46;
            this.lblDemora.Text = "Demora";
            // 
            // btnVaciarCampos
            // 
            this.btnVaciarCampos.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVaciarCampos.ForeColor = System.Drawing.Color.Black;
            this.btnVaciarCampos.Location = new System.Drawing.Point(1100, 236);
            this.btnVaciarCampos.Name = "btnVaciarCampos";
            this.btnVaciarCampos.Size = new System.Drawing.Size(124, 33);
            this.btnVaciarCampos.TabIndex = 45;
            this.btnVaciarCampos.Text = "Vaciar Campos";
            this.btnVaciarCampos.UseVisualStyleBackColor = false;
            this.btnVaciarCampos.Click += new System.EventHandler(this.btnVaciarCampos_Click);
            // 
            // cboUnidades
            // 
            this.cboUnidades.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnidades.FormattingEnabled = true;
            this.cboUnidades.Items.AddRange(new object[] {
            "001",
            "002",
            "003",
            "004",
            "005",
            "006",
            "007",
            "008",
            "009",
            "010",
            "011",
            "012",
            "013",
            "014"});
            this.cboUnidades.Location = new System.Drawing.Point(524, 111);
            this.cboUnidades.Name = "cboUnidades";
            this.cboUnidades.Size = new System.Drawing.Size(121, 24);
            this.cboUnidades.TabIndex = 42;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(1188, 275);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(86, 39);
            this.btnEditar.TabIndex = 41;
            this.btnEditar.Text = "EditarCruce";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(1230, 237);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(81, 32);
            this.btnEliminar.TabIndex = 40;
            this.btnEliminar.Text = "EliminarCruce";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(1100, 275);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(82, 39);
            this.btnAgregar.TabIndex = 39;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidad.Location = new System.Drawing.Point(462, 119);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(47, 16);
            this.lblUnidad.TabIndex = 28;
            this.lblUnidad.Text = "Unidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(524, 74);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(149, 22);
            this.txtCantidad.TabIndex = 22;
            this.txtCantidad.Text = "0";
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtPrecioDolares_TextChanged);
            // 
            // lblPrecioDolares
            // 
            this.lblPrecioDolares.AutoSize = true;
            this.lblPrecioDolares.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioDolares.Location = new System.Drawing.Point(451, 77);
            this.lblPrecioDolares.Name = "lblPrecioDolares";
            this.lblPrecioDolares.Size = new System.Drawing.Size(58, 16);
            this.lblPrecioDolares.TabIndex = 21;
            this.lblPrecioDolares.Text = "Cantidad";
            // 
            // txtImpuestos
            // 
            this.txtImpuestos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpuestos.Location = new System.Drawing.Point(524, 40);
            this.txtImpuestos.Name = "txtImpuestos";
            this.txtImpuestos.ReadOnly = true;
            this.txtImpuestos.Size = new System.Drawing.Size(149, 22);
            this.txtImpuestos.TabIndex = 20;
            this.txtImpuestos.Text = "0";
            this.txtImpuestos.TextChanged += new System.EventHandler(this.txtPrecioPesos_TextChanged);
            // 
            // lblPrecioPesos
            // 
            this.lblPrecioPesos.AutoSize = true;
            this.lblPrecioPesos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioPesos.Location = new System.Drawing.Point(442, 40);
            this.lblPrecioPesos.Name = "lblPrecioPesos";
            this.lblPrecioPesos.Size = new System.Drawing.Size(67, 16);
            this.lblPrecioPesos.TabIndex = 19;
            this.lblPrecioPesos.Text = "Impuestos";
            // 
            // lblFechaCarga
            // 
            this.lblFechaCarga.AutoSize = true;
            this.lblFechaCarga.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCarga.Location = new System.Drawing.Point(48, 198);
            this.lblFechaCarga.Name = "lblFechaCarga";
            this.lblFechaCarga.Size = new System.Drawing.Size(92, 16);
            this.lblFechaCarga.TabIndex = 12;
            this.lblFechaCarga.Text = "Fecha Compra";
            // 
            // dtpFechaCompra
            // 
            this.dtpFechaCompra.CustomFormat = "MMMM dd, yyyy  |  hh:mm:ss tt";
            this.dtpFechaCompra.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaCompra.Location = new System.Drawing.Point(154, 192);
            this.dtpFechaCompra.Name = "dtpFechaCompra";
            this.dtpFechaCompra.Size = new System.Drawing.Size(289, 22);
            this.dtpFechaCompra.TabIndex = 11;
            // 
            // txtTipoGasto
            // 
            this.txtTipoGasto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoGasto.Location = new System.Drawing.Point(154, 78);
            this.txtTipoGasto.MaxLength = 50;
            this.txtTipoGasto.Name = "txtTipoGasto";
            this.txtTipoGasto.ReadOnly = true;
            this.txtTipoGasto.Size = new System.Drawing.Size(218, 22);
            this.txtTipoGasto.TabIndex = 4;
            // 
            // lblTipoServicio
            // 
            this.lblTipoServicio.AutoSize = true;
            this.lblTipoServicio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoServicio.Location = new System.Drawing.Point(40, 78);
            this.lblTipoServicio.Name = "lblTipoServicio";
            this.lblTipoServicio.Size = new System.Drawing.Size(88, 16);
            this.lblTipoServicio.TabIndex = 3;
            this.lblTipoServicio.Text = "Tipo de Gasto";
            // 
            // lblRemision
            // 
            this.lblRemision.AutoSize = true;
            this.lblRemision.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemision.Location = new System.Drawing.Point(40, 154);
            this.lblRemision.Name = "lblRemision";
            this.lblRemision.Size = new System.Drawing.Size(100, 16);
            this.lblRemision.TabIndex = 7;
            this.lblRemision.Text = "Numero Factura";
            // 
            // txtGarantia
            // 
            this.txtGarantia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGarantia.Location = new System.Drawing.Point(154, 113);
            this.txtGarantia.MaxLength = 30;
            this.txtGarantia.Name = "txtGarantia";
            this.txtGarantia.ReadOnly = true;
            this.txtGarantia.Size = new System.Drawing.Size(218, 22);
            this.txtGarantia.TabIndex = 6;
            // 
            // txtCodigoGasto
            // 
            this.txtCodigoGasto.Enabled = false;
            this.txtCodigoGasto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoGasto.Location = new System.Drawing.Point(154, 40);
            this.txtCodigoGasto.Name = "txtCodigoGasto";
            this.txtCodigoGasto.ReadOnly = true;
            this.txtCodigoGasto.Size = new System.Drawing.Size(218, 22);
            this.txtCodigoGasto.TabIndex = 1;
            // 
            // lblCodigoCruce
            // 
            this.lblCodigoCruce.AutoSize = true;
            this.lblCodigoCruce.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCruce.Location = new System.Drawing.Point(40, 40);
            this.lblCodigoCruce.Name = "lblCodigoCruce";
            this.lblCodigoCruce.Size = new System.Drawing.Size(104, 16);
            this.lblCodigoCruce.TabIndex = 0;
            this.lblCodigoCruce.Text = "Codigo de Gasto";
            this.lblCodigoCruce.Click += new System.EventHandler(this.lblCodigoCruce_Click);
            // 
            // lblCaja
            // 
            this.lblCaja.AutoSize = true;
            this.lblCaja.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaja.Location = new System.Drawing.Point(40, 116);
            this.lblCaja.Name = "lblCaja";
            this.lblCaja.Size = new System.Drawing.Size(56, 16);
            this.lblCaja.TabIndex = 5;
            this.lblCaja.Text = "Garantia";
            // 
            // txtNoFactura
            // 
            this.txtNoFactura.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoFactura.Location = new System.Drawing.Point(154, 151);
            this.txtNoFactura.MaxLength = 45;
            this.txtNoFactura.Name = "txtNoFactura";
            this.txtNoFactura.ReadOnly = true;
            this.txtNoFactura.Size = new System.Drawing.Size(218, 22);
            this.txtNoFactura.TabIndex = 8;
            // 
            // mstMenu
            // 
            this.mstMenu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoYConexionToolStripMenuItem,
            this.direccionYVistaToolStripMenuItem,
            this.reporteToolStripMenuItem});
            this.mstMenu.Location = new System.Drawing.Point(0, 0);
            this.mstMenu.Name = "mstMenu";
            this.mstMenu.Size = new System.Drawing.Size(1408, 24);
            this.mstMenu.TabIndex = 1;
            this.mstMenu.Text = "menuStrip1";
            // 
            // archivoYConexionToolStripMenuItem
            // 
            this.archivoYConexionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearBaseDeDatosToolStripMenuItem,
            this.conectarABaseDeDatosToolStripMenuItem,
            this.eliminarBaseDeDatosToolStripMenuItem});
            this.archivoYConexionToolStripMenuItem.Name = "archivoYConexionToolStripMenuItem";
            this.archivoYConexionToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.archivoYConexionToolStripMenuItem.Text = "Archivo y Conexion";
            // 
            // crearBaseDeDatosToolStripMenuItem
            // 
            this.crearBaseDeDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirColumnaDemoraToolStripMenuItem});
            this.crearBaseDeDatosToolStripMenuItem.Name = "crearBaseDeDatosToolStripMenuItem";
            this.crearBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.crearBaseDeDatosToolStripMenuItem.Text = "Crear Base de Datos Local";
            this.crearBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.crearBaseDeDatosToolStripMenuItem_Click);
            // 
            // añadirColumnaDemoraToolStripMenuItem
            // 
            this.añadirColumnaDemoraToolStripMenuItem.Name = "añadirColumnaDemoraToolStripMenuItem";
            this.añadirColumnaDemoraToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.añadirColumnaDemoraToolStripMenuItem.Text = "Añadir columna Demora";
            this.añadirColumnaDemoraToolStripMenuItem.Click += new System.EventHandler(this.añadirColumnaDemoraToolStripMenuItem_Click);
            // 
            // conectarABaseDeDatosToolStripMenuItem
            // 
            this.conectarABaseDeDatosToolStripMenuItem.Name = "conectarABaseDeDatosToolStripMenuItem";
            this.conectarABaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.conectarABaseDeDatosToolStripMenuItem.Text = "Conectar a Base de Datos Remota";
            this.conectarABaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.conectarABaseDeDatosToolStripMenuItem_Click);
            // 
            // eliminarBaseDeDatosToolStripMenuItem
            // 
            this.eliminarBaseDeDatosToolStripMenuItem.Name = "eliminarBaseDeDatosToolStripMenuItem";
            this.eliminarBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.eliminarBaseDeDatosToolStripMenuItem.Text = "EliminarCruce Base de Datos Local";
            this.eliminarBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.eliminarBaseDeDatosToolStripMenuItem_Click);
            // 
            // direccionYVistaToolStripMenuItem
            // 
            this.direccionYVistaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obtenerDireccionDeEsteEquipoToolStripMenuItem});
            this.direccionYVistaToolStripMenuItem.Name = "direccionYVistaToolStripMenuItem";
            this.direccionYVistaToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.direccionYVistaToolStripMenuItem.Text = "Direccion y Vista";
            // 
            // obtenerDireccionDeEsteEquipoToolStripMenuItem
            // 
            this.obtenerDireccionDeEsteEquipoToolStripMenuItem.Name = "obtenerDireccionDeEsteEquipoToolStripMenuItem";
            this.obtenerDireccionDeEsteEquipoToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.obtenerDireccionDeEsteEquipoToolStripMenuItem.Text = "Obtener direccion de este equipo";
            this.obtenerDireccionDeEsteEquipoToolStripMenuItem.Click += new System.EventHandler(this.obtenerDireccionDeEsteEquipoToolStripMenuItem_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarReporteAExcelxlsToolStripMenuItem});
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.reporteToolStripMenuItem.Text = "Reporte";
            // 
            // exportarReporteAExcelxlsToolStripMenuItem
            // 
            this.exportarReporteAExcelxlsToolStripMenuItem.Name = "exportarReporteAExcelxlsToolStripMenuItem";
            this.exportarReporteAExcelxlsToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.exportarReporteAExcelxlsToolStripMenuItem.Text = "Exportar Reporte a Excel (xlsx)";
            this.exportarReporteAExcelxlsToolStripMenuItem.Click += new System.EventHandler(this.exportarReporteAExcelxlsToolStripMenuItem_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(3, 14);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(175, 30);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnRecargar
            // 
            this.btnRecargar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRecargar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecargar.Location = new System.Drawing.Point(184, 14);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(102, 30);
            this.btnRecargar.TabIndex = 1;
            this.btnRecargar.Text = "Recargar";
            this.btnRecargar.UseVisualStyleBackColor = false;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // dtgTablaDatos
            // 
            this.dtgTablaDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgTablaDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgTablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTablaDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId_ControlGastos,
            this.colGastos,
            this.colTipoGasto,
            this.colCantidad,
            this.colImpuestos,
            this.colNumeroFactura,
            this.colFechaCompra,
            this.colGarantia,
            this.colDemora,
            this.colUnidad});
            this.dtgTablaDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgTablaDatos.Location = new System.Drawing.Point(0, 55);
            this.dtgTablaDatos.Margin = new System.Windows.Forms.Padding(10);
            this.dtgTablaDatos.Name = "dtgTablaDatos";
            this.dtgTablaDatos.Size = new System.Drawing.Size(1406, 390);
            this.dtgTablaDatos.TabIndex = 0;
            this.dtgTablaDatos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgTablaDatos_CellMouseClick);
            // 
            // pnlPanelInferior
            // 
            this.pnlPanelInferior.AllowDrop = true;
            this.pnlPanelInferior.AutoScroll = true;
            this.pnlPanelInferior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPanelInferior.Controls.Add(this.dtgTablaDatos);
            this.pnlPanelInferior.Controls.Add(this.pnlSuperiorBotones);
            this.pnlPanelInferior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPanelInferior.Location = new System.Drawing.Point(0, 361);
            this.pnlPanelInferior.Name = "pnlPanelInferior";
            this.pnlPanelInferior.Size = new System.Drawing.Size(1408, 447);
            this.pnlPanelInferior.TabIndex = 6;
            // 
            // pnlSuperiorBotones
            // 
            this.pnlSuperiorBotones.Controls.Add(this.btnBuscar);
            this.pnlSuperiorBotones.Controls.Add(this.btnOrdenarFechaCarga);
            this.pnlSuperiorBotones.Controls.Add(this.btnRecargar);
            this.pnlSuperiorBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperiorBotones.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperiorBotones.Name = "pnlSuperiorBotones";
            this.pnlSuperiorBotones.Size = new System.Drawing.Size(1406, 55);
            this.pnlSuperiorBotones.TabIndex = 1;
            // 
            // btnOrdenarFechaCarga
            // 
            this.btnOrdenarFechaCarga.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnOrdenarFechaCarga.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenarFechaCarga.Location = new System.Drawing.Point(292, 14);
            this.btnOrdenarFechaCarga.Name = "btnOrdenarFechaCarga";
            this.btnOrdenarFechaCarga.Size = new System.Drawing.Size(184, 30);
            this.btnOrdenarFechaCarga.TabIndex = 5;
            this.btnOrdenarFechaCarga.Text = "Ordenar por Fecha de Carga";
            this.btnOrdenarFechaCarga.UseVisualStyleBackColor = false;
            this.btnOrdenarFechaCarga.Click += new System.EventHandler(this.btnOrdenarFechaCarga_Click);
            // 
            // colId_ControlGastos
            // 
            this.colId_ControlGastos.HeaderText = "ID - Control de Gastos";
            this.colId_ControlGastos.Name = "colId_ControlGastos";
            this.colId_ControlGastos.ReadOnly = true;
            this.colId_ControlGastos.Width = 109;
            // 
            // colGastos
            // 
            this.colGastos.HeaderText = "Gastos";
            this.colGastos.Name = "colGastos";
            this.colGastos.ReadOnly = true;
            this.colGastos.Width = 74;
            // 
            // colTipoGasto
            // 
            this.colTipoGasto.HeaderText = "Tipo de Gasto";
            this.colTipoGasto.Name = "colTipoGasto";
            this.colTipoGasto.ReadOnly = true;
            this.colTipoGasto.Width = 104;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 83;
            // 
            // colImpuestos
            // 
            this.colImpuestos.HeaderText = "Impuestos";
            this.colImpuestos.Name = "colImpuestos";
            this.colImpuestos.Width = 92;
            // 
            // colNumeroFactura
            // 
            this.colNumeroFactura.HeaderText = "Numero Factura";
            this.colNumeroFactura.Name = "colNumeroFactura";
            this.colNumeroFactura.ReadOnly = true;
            this.colNumeroFactura.Width = 115;
            // 
            // colFechaCompra
            // 
            this.colFechaCompra.HeaderText = "Fecha Compra";
            this.colFechaCompra.Name = "colFechaCompra";
            this.colFechaCompra.ReadOnly = true;
            this.colFechaCompra.Width = 107;
            // 
            // colGarantia
            // 
            this.colGarantia.HeaderText = "Garantia";
            this.colGarantia.Name = "colGarantia";
            this.colGarantia.ReadOnly = true;
            this.colGarantia.Width = 81;
            // 
            // colDemora
            // 
            this.colDemora.HeaderText = "Demora";
            this.colDemora.Name = "colDemora";
            this.colDemora.ReadOnly = true;
            this.colDemora.Width = 77;
            // 
            // colUnidad
            // 
            this.colUnidad.HeaderText = "Unidad";
            this.colUnidad.Name = "colUnidad";
            this.colUnidad.ReadOnly = true;
            this.colUnidad.Width = 72;
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1408, 808);
            this.Controls.Add(this.pnlPanelInferior);
            this.Controls.Add(this.grpCampoDatos);
            this.Controls.Add(this.mstMenu);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "PantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla Principal | Control de Cruces - - Transporte de Carga Jeff | Tabla de Cr" +
    "uces";
            this.Load += new System.EventHandler(this.PantallaPrincipal_Load);
            this.grpCampoDatos.ResumeLayout(false);
            this.grpCampoDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mstMenu.ResumeLayout(false);
            this.mstMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTablaDatos)).EndInit();
            this.pnlPanelInferior.ResumeLayout(false);
            this.pnlSuperiorBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCampoDatos;
        private System.Windows.Forms.TextBox txtTipoGasto;
        private System.Windows.Forms.DateTimePicker dtpFechaCompra;
        private System.Windows.Forms.Label lblTipoServicio;
        private System.Windows.Forms.Label lblRemision;
        private System.Windows.Forms.TextBox txtGarantia;
        private System.Windows.Forms.TextBox txtCodigoGasto;
        private System.Windows.Forms.Label lblCodigoCruce;
        private System.Windows.Forms.Label lblCaja;
        private System.Windows.Forms.TextBox txtNoFactura;
        private System.Windows.Forms.Label lblFechaCarga;
        private System.Windows.Forms.TextBox txtImpuestos;
        private System.Windows.Forms.Label lblPrecioPesos;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblPrecioDolares;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.MenuStrip mstMenu;
        private System.Windows.Forms.ToolStripMenuItem archivoYConexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conectarABaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.DataGridView dtgTablaDatos;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cboUnidades;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem direccionYVistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obtenerDireccionDeEsteEquipoToolStripMenuItem;
        private System.Windows.Forms.Button btnVaciarCampos;
        private System.Windows.Forms.ToolStripMenuItem añadirColumnaDemoraToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtxtDemora;
        private System.Windows.Forms.Label lblDemora;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarReporteAExcelxlsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlPanelInferior;
        private System.Windows.Forms.Panel pnlSuperiorBotones;
        private System.Windows.Forms.Button btnOrdenarFechaCarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId_ControlGastos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGastos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoGasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImpuestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGarantia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDemora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnidad;
    }
}

