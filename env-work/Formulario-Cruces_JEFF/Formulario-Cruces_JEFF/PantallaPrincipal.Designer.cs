
namespace Formulario_Cruces_JEFF
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
            this.cboAsignada = new System.Windows.Forms.ComboBox();
            this.cboUnidades = new System.Windows.Forms.ComboBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtConductor = new System.Windows.Forms.TextBox();
            this.lblAsignada = new System.Windows.Forms.Label();
            this.dtpFechaVencimientoPedimento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaPagoVencimiento = new System.Windows.Forms.Label();
            this.lblFechaVencimientoPedimento = new System.Windows.Forms.Label();
            this.dtpFechaPagoPedimento = new System.Windows.Forms.DateTimePicker();
            this.lblConductor = new System.Windows.Forms.Label();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtIntermediario = new System.Windows.Forms.TextBox();
            this.lblIntermediario = new System.Windows.Forms.Label();
            this.txtPrecioDolares = new System.Windows.Forms.TextBox();
            this.lblPrecioDolares = new System.Windows.Forms.Label();
            this.txtPrecioPesos = new System.Windows.Forms.TextBox();
            this.lblPrecioPesos = new System.Windows.Forms.Label();
            this.txtLugarDescarga = new System.Windows.Forms.TextBox();
            this.lblLugarDescarga = new System.Windows.Forms.Label();
            this.txtLugarCarga = new System.Windows.Forms.TextBox();
            this.lblLugarCarga = new System.Windows.Forms.Label();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.lblFechaCarga = new System.Windows.Forms.Label();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.txtEstatusCobro = new System.Windows.Forms.TextBox();
            this.dtpFechaCarga = new System.Windows.Forms.DateTimePicker();
            this.txtTipoServicio = new System.Windows.Forms.TextBox();
            this.lblTipoServicio = new System.Windows.Forms.Label();
            this.lblRemision = new System.Windows.Forms.Label();
            this.lblEstatusCobro = new System.Windows.Forms.Label();
            this.txtCaja = new System.Windows.Forms.TextBox();
            this.txtCodigoCruce = new System.Windows.Forms.TextBox();
            this.lblCodigoCruce = new System.Windows.Forms.Label();
            this.lblCaja = new System.Windows.Forms.Label();
            this.txtRemision = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoYConexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conectarABaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.direccionYVistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obtenerDireccionDeEsteEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpTablaDeDatos = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.dtgTablaDatos = new System.Windows.Forms.DataGridView();
            this.colId_ControlCruces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigoCruce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstatusCobro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaCarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLugarCarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLugarDescarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioPesos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioDolares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIntermediario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConductor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaPagoPedimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaVencimientoPedimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAsignada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpCampoDatos.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grpTablaDeDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTablaDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCampoDatos
            // 
            this.grpCampoDatos.Controls.Add(this.cboAsignada);
            this.grpCampoDatos.Controls.Add(this.cboUnidades);
            this.grpCampoDatos.Controls.Add(this.btnEditar);
            this.grpCampoDatos.Controls.Add(this.btnEliminar);
            this.grpCampoDatos.Controls.Add(this.btnAgregar);
            this.grpCampoDatos.Controls.Add(this.txtConductor);
            this.grpCampoDatos.Controls.Add(this.lblAsignada);
            this.grpCampoDatos.Controls.Add(this.dtpFechaVencimientoPedimento);
            this.grpCampoDatos.Controls.Add(this.lblFechaPagoVencimiento);
            this.grpCampoDatos.Controls.Add(this.lblFechaVencimientoPedimento);
            this.grpCampoDatos.Controls.Add(this.dtpFechaPagoPedimento);
            this.grpCampoDatos.Controls.Add(this.lblConductor);
            this.grpCampoDatos.Controls.Add(this.lblUnidad);
            this.grpCampoDatos.Controls.Add(this.txtCliente);
            this.grpCampoDatos.Controls.Add(this.lblCliente);
            this.grpCampoDatos.Controls.Add(this.txtIntermediario);
            this.grpCampoDatos.Controls.Add(this.lblIntermediario);
            this.grpCampoDatos.Controls.Add(this.txtPrecioDolares);
            this.grpCampoDatos.Controls.Add(this.lblPrecioDolares);
            this.grpCampoDatos.Controls.Add(this.txtPrecioPesos);
            this.grpCampoDatos.Controls.Add(this.lblPrecioPesos);
            this.grpCampoDatos.Controls.Add(this.txtLugarDescarga);
            this.grpCampoDatos.Controls.Add(this.lblLugarDescarga);
            this.grpCampoDatos.Controls.Add(this.txtLugarCarga);
            this.grpCampoDatos.Controls.Add(this.lblLugarCarga);
            this.grpCampoDatos.Controls.Add(this.dtpFechaEntrega);
            this.grpCampoDatos.Controls.Add(this.lblFechaCarga);
            this.grpCampoDatos.Controls.Add(this.lblFechaEntrega);
            this.grpCampoDatos.Controls.Add(this.txtEstatusCobro);
            this.grpCampoDatos.Controls.Add(this.dtpFechaCarga);
            this.grpCampoDatos.Controls.Add(this.txtTipoServicio);
            this.grpCampoDatos.Controls.Add(this.lblTipoServicio);
            this.grpCampoDatos.Controls.Add(this.lblRemision);
            this.grpCampoDatos.Controls.Add(this.lblEstatusCobro);
            this.grpCampoDatos.Controls.Add(this.txtCaja);
            this.grpCampoDatos.Controls.Add(this.txtCodigoCruce);
            this.grpCampoDatos.Controls.Add(this.lblCodigoCruce);
            this.grpCampoDatos.Controls.Add(this.lblCaja);
            this.grpCampoDatos.Controls.Add(this.txtRemision);
            this.grpCampoDatos.Location = new System.Drawing.Point(12, 27);
            this.grpCampoDatos.Name = "grpCampoDatos";
            this.grpCampoDatos.Size = new System.Drawing.Size(1236, 337);
            this.grpCampoDatos.TabIndex = 0;
            this.grpCampoDatos.TabStop = false;
            this.grpCampoDatos.Text = "Campo de Datos";
            // 
            // cboAsignada
            // 
            this.cboAsignada.FormattingEnabled = true;
            this.cboAsignada.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cboAsignada.Location = new System.Drawing.Point(796, 35);
            this.cboAsignada.Name = "cboAsignada";
            this.cboAsignada.Size = new System.Drawing.Size(121, 21);
            this.cboAsignada.TabIndex = 43;
            // 
            // cboUnidades
            // 
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
            this.cboUnidades.Location = new System.Drawing.Point(796, 83);
            this.cboUnidades.Name = "cboUnidades";
            this.cboUnidades.Size = new System.Drawing.Size(121, 21);
            this.cboUnidades.TabIndex = 42;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(895, 285);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 41;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(796, 286);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 40;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(713, 287);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 39;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtConductor
            // 
            this.txtConductor.Location = new System.Drawing.Point(796, 127);
            this.txtConductor.Name = "txtConductor";
            this.txtConductor.Size = new System.Drawing.Size(100, 22);
            this.txtConductor.TabIndex = 37;
            // 
            // lblAsignada
            // 
            this.lblAsignada.AutoSize = true;
            this.lblAsignada.Location = new System.Drawing.Point(691, 38);
            this.lblAsignada.Name = "lblAsignada";
            this.lblAsignada.Size = new System.Drawing.Size(54, 13);
            this.lblAsignada.TabIndex = 34;
            this.lblAsignada.Text = "Asignada";
            // 
            // dtpFechaVencimientoPedimento
            // 
            this.dtpFechaVencimientoPedimento.CustomFormat = "MMMMdd, yyyy  |  hh:mm:ss tt";
            this.dtpFechaVencimientoPedimento.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVencimientoPedimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaVencimientoPedimento.Location = new System.Drawing.Point(895, 217);
            this.dtpFechaVencimientoPedimento.Name = "dtpFechaVencimientoPedimento";
            this.dtpFechaVencimientoPedimento.Size = new System.Drawing.Size(222, 21);
            this.dtpFechaVencimientoPedimento.TabIndex = 32;
            // 
            // lblFechaPagoVencimiento
            // 
            this.lblFechaPagoVencimiento.AutoSize = true;
            this.lblFechaPagoVencimiento.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPagoVencimiento.Location = new System.Drawing.Point(693, 182);
            this.lblFechaPagoVencimiento.Name = "lblFechaPagoVencimiento";
            this.lblFechaPagoVencimiento.Size = new System.Drawing.Size(155, 13);
            this.lblFechaPagoVencimiento.TabIndex = 31;
            this.lblFechaPagoVencimiento.Text = "Fecha de Pago de Pedimento";
            // 
            // lblFechaVencimientoPedimento
            // 
            this.lblFechaVencimientoPedimento.AutoSize = true;
            this.lblFechaVencimientoPedimento.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVencimientoPedimento.Location = new System.Drawing.Point(698, 220);
            this.lblFechaVencimientoPedimento.Name = "lblFechaVencimientoPedimento";
            this.lblFechaVencimientoPedimento.Size = new System.Drawing.Size(191, 13);
            this.lblFechaVencimientoPedimento.TabIndex = 33;
            this.lblFechaVencimientoPedimento.Text = "Fecha de Vencimiento de Pedimento";
            // 
            // dtpFechaPagoPedimento
            // 
            this.dtpFechaPagoPedimento.CustomFormat = "MMMMdd, yyyy  |  hh:mm:ss tt";
            this.dtpFechaPagoPedimento.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaPagoPedimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaPagoPedimento.Location = new System.Drawing.Point(895, 182);
            this.dtpFechaPagoPedimento.Name = "dtpFechaPagoPedimento";
            this.dtpFechaPagoPedimento.Size = new System.Drawing.Size(222, 21);
            this.dtpFechaPagoPedimento.TabIndex = 30;
            // 
            // lblConductor
            // 
            this.lblConductor.AutoSize = true;
            this.lblConductor.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConductor.Location = new System.Drawing.Point(697, 129);
            this.lblConductor.Name = "lblConductor";
            this.lblConductor.Size = new System.Drawing.Size(60, 13);
            this.lblConductor.TabIndex = 29;
            this.lblConductor.Text = "Conductor";
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidad.Location = new System.Drawing.Point(697, 82);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(44, 13);
            this.lblUnidad.TabIndex = 28;
            this.lblUnidad.Text = "Unidad";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(508, 263);
            this.txtCliente.MaxLength = 40;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(149, 22);
            this.txtCliente.TabIndex = 26;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(459, 265);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 25;
            this.lblCliente.Text = "Cliente";
            // 
            // txtIntermediario
            // 
            this.txtIntermediario.Location = new System.Drawing.Point(508, 217);
            this.txtIntermediario.MaxLength = 45;
            this.txtIntermediario.Name = "txtIntermediario";
            this.txtIntermediario.Size = new System.Drawing.Size(149, 22);
            this.txtIntermediario.TabIndex = 26;
            // 
            // lblIntermediario
            // 
            this.lblIntermediario.AutoSize = true;
            this.lblIntermediario.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntermediario.Location = new System.Drawing.Point(426, 220);
            this.lblIntermediario.Name = "lblIntermediario";
            this.lblIntermediario.Size = new System.Drawing.Size(76, 13);
            this.lblIntermediario.TabIndex = 25;
            this.lblIntermediario.Text = "Intermediario";
            // 
            // txtPrecioDolares
            // 
            this.txtPrecioDolares.Location = new System.Drawing.Point(508, 172);
            this.txtPrecioDolares.Name = "txtPrecioDolares";
            this.txtPrecioDolares.Size = new System.Drawing.Size(149, 22);
            this.txtPrecioDolares.TabIndex = 22;
            this.txtPrecioDolares.TextChanged += new System.EventHandler(this.txtPrecioDolares_TextChanged);
            // 
            // lblPrecioDolares
            // 
            this.lblPrecioDolares.AutoSize = true;
            this.lblPrecioDolares.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioDolares.Location = new System.Drawing.Point(416, 175);
            this.lblPrecioDolares.Name = "lblPrecioDolares";
            this.lblPrecioDolares.Size = new System.Drawing.Size(88, 13);
            this.lblPrecioDolares.TabIndex = 21;
            this.lblPrecioDolares.Text = "Precio (Dolares)";
            // 
            // txtPrecioPesos
            // 
            this.txtPrecioPesos.Location = new System.Drawing.Point(508, 127);
            this.txtPrecioPesos.Name = "txtPrecioPesos";
            this.txtPrecioPesos.Size = new System.Drawing.Size(149, 22);
            this.txtPrecioPesos.TabIndex = 20;
            this.txtPrecioPesos.TextChanged += new System.EventHandler(this.txtPrecioPesos_TextChanged);
            // 
            // lblPrecioPesos
            // 
            this.lblPrecioPesos.AutoSize = true;
            this.lblPrecioPesos.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioPesos.Location = new System.Drawing.Point(426, 130);
            this.lblPrecioPesos.Name = "lblPrecioPesos";
            this.lblPrecioPesos.Size = new System.Drawing.Size(78, 13);
            this.lblPrecioPesos.TabIndex = 19;
            this.lblPrecioPesos.Text = "Precio (Pesos)";
            // 
            // txtLugarDescarga
            // 
            this.txtLugarDescarga.Location = new System.Drawing.Point(508, 82);
            this.txtLugarDescarga.MaxLength = 60;
            this.txtLugarDescarga.Name = "txtLugarDescarga";
            this.txtLugarDescarga.Size = new System.Drawing.Size(149, 22);
            this.txtLugarDescarga.TabIndex = 18;
            // 
            // lblLugarDescarga
            // 
            this.lblLugarDescarga.AutoSize = true;
            this.lblLugarDescarga.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugarDescarga.Location = new System.Drawing.Point(400, 88);
            this.lblLugarDescarga.Name = "lblLugarDescarga";
            this.lblLugarDescarga.Size = new System.Drawing.Size(101, 13);
            this.lblLugarDescarga.TabIndex = 17;
            this.lblLugarDescarga.Text = "Lugar de Descarga";
            // 
            // txtLugarCarga
            // 
            this.txtLugarCarga.Location = new System.Drawing.Point(508, 37);
            this.txtLugarCarga.MaxLength = 60;
            this.txtLugarCarga.Name = "txtLugarCarga";
            this.txtLugarCarga.Size = new System.Drawing.Size(149, 22);
            this.txtLugarCarga.TabIndex = 16;
            // 
            // lblLugarCarga
            // 
            this.lblLugarCarga.AutoSize = true;
            this.lblLugarCarga.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugarCarga.Location = new System.Drawing.Point(417, 40);
            this.lblLugarCarga.Name = "lblLugarCarga";
            this.lblLugarCarga.Size = new System.Drawing.Size(84, 13);
            this.lblLugarCarga.TabIndex = 15;
            this.lblLugarCarga.Text = "Lugar de Carga";
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.CalendarFont = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEntrega.CustomFormat = "MMMMdd, yyyy  |  hh:mm:ss tt";
            this.dtpFechaEntrega.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaEntrega.Location = new System.Drawing.Point(132, 265);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(218, 21);
            this.dtpFechaEntrega.TabIndex = 13;
            // 
            // lblFechaCarga
            // 
            this.lblFechaCarga.AutoSize = true;
            this.lblFechaCarga.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCarga.Location = new System.Drawing.Point(40, 234);
            this.lblFechaCarga.Name = "lblFechaCarga";
            this.lblFechaCarga.Size = new System.Drawing.Size(85, 13);
            this.lblFechaCarga.TabIndex = 12;
            this.lblFechaCarga.Text = "Fecha de Carga";
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEntrega.Location = new System.Drawing.Point(33, 272);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(94, 13);
            this.lblFechaEntrega.TabIndex = 14;
            this.lblFechaEntrega.Text = "Fecha de Entrega";
            // 
            // txtEstatusCobro
            // 
            this.txtEstatusCobro.Location = new System.Drawing.Point(132, 189);
            this.txtEstatusCobro.MaxLength = 25;
            this.txtEstatusCobro.Name = "txtEstatusCobro";
            this.txtEstatusCobro.Size = new System.Drawing.Size(218, 22);
            this.txtEstatusCobro.TabIndex = 10;
            // 
            // dtpFechaCarga
            // 
            this.dtpFechaCarga.CustomFormat = "MMMMdd, yyyy  |  hh:mm:ss tt";
            this.dtpFechaCarga.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCarga.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaCarga.Location = new System.Drawing.Point(132, 227);
            this.dtpFechaCarga.Name = "dtpFechaCarga";
            this.dtpFechaCarga.Size = new System.Drawing.Size(218, 21);
            this.dtpFechaCarga.TabIndex = 11;
            // 
            // txtTipoServicio
            // 
            this.txtTipoServicio.Location = new System.Drawing.Point(132, 75);
            this.txtTipoServicio.MaxLength = 50;
            this.txtTipoServicio.Name = "txtTipoServicio";
            this.txtTipoServicio.Size = new System.Drawing.Size(218, 22);
            this.txtTipoServicio.TabIndex = 4;
            // 
            // lblTipoServicio
            // 
            this.lblTipoServicio.AutoSize = true;
            this.lblTipoServicio.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoServicio.Location = new System.Drawing.Point(38, 78);
            this.lblTipoServicio.Name = "lblTipoServicio";
            this.lblTipoServicio.Size = new System.Drawing.Size(89, 13);
            this.lblTipoServicio.TabIndex = 3;
            this.lblTipoServicio.Text = "Tipo de Servicio";
            // 
            // lblRemision
            // 
            this.lblRemision.AutoSize = true;
            this.lblRemision.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemision.Location = new System.Drawing.Point(72, 154);
            this.lblRemision.Name = "lblRemision";
            this.lblRemision.Size = new System.Drawing.Size(54, 13);
            this.lblRemision.TabIndex = 7;
            this.lblRemision.Text = "Remision";
            // 
            // lblEstatusCobro
            // 
            this.lblEstatusCobro.AutoSize = true;
            this.lblEstatusCobro.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatusCobro.Location = new System.Drawing.Point(31, 194);
            this.lblEstatusCobro.Name = "lblEstatusCobro";
            this.lblEstatusCobro.Size = new System.Drawing.Size(94, 13);
            this.lblEstatusCobro.TabIndex = 9;
            this.lblEstatusCobro.Text = "Estatus de Cobro";
            // 
            // txtCaja
            // 
            this.txtCaja.Location = new System.Drawing.Point(132, 113);
            this.txtCaja.MaxLength = 30;
            this.txtCaja.Name = "txtCaja";
            this.txtCaja.Size = new System.Drawing.Size(218, 22);
            this.txtCaja.TabIndex = 6;
            // 
            // txtCodigoCruce
            // 
            this.txtCodigoCruce.Enabled = false;
            this.txtCodigoCruce.Location = new System.Drawing.Point(132, 37);
            this.txtCodigoCruce.Name = "txtCodigoCruce";
            this.txtCodigoCruce.ReadOnly = true;
            this.txtCodigoCruce.Size = new System.Drawing.Size(218, 22);
            this.txtCodigoCruce.TabIndex = 1;
            // 
            // lblCodigoCruce
            // 
            this.lblCodigoCruce.AutoSize = true;
            this.lblCodigoCruce.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCruce.Location = new System.Drawing.Point(33, 40);
            this.lblCodigoCruce.Name = "lblCodigoCruce";
            this.lblCodigoCruce.Size = new System.Drawing.Size(92, 13);
            this.lblCodigoCruce.TabIndex = 0;
            this.lblCodigoCruce.Text = "Codigo de Cruce";
            // 
            // lblCaja
            // 
            this.lblCaja.AutoSize = true;
            this.lblCaja.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaja.Location = new System.Drawing.Point(97, 116);
            this.lblCaja.Name = "lblCaja";
            this.lblCaja.Size = new System.Drawing.Size(29, 13);
            this.lblCaja.TabIndex = 5;
            this.lblCaja.Text = "Caja";
            // 
            // txtRemision
            // 
            this.txtRemision.Location = new System.Drawing.Point(132, 151);
            this.txtRemision.MaxLength = 45;
            this.txtRemision.Name = "txtRemision";
            this.txtRemision.Size = new System.Drawing.Size(218, 22);
            this.txtRemision.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoYConexionToolStripMenuItem,
            this.direccionYVistaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2526, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoYConexionToolStripMenuItem
            // 
            this.archivoYConexionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearBaseDeDatosToolStripMenuItem,
            this.conectarABaseDeDatosToolStripMenuItem,
            this.eliminarBaseDeDatosToolStripMenuItem});
            this.archivoYConexionToolStripMenuItem.Name = "archivoYConexionToolStripMenuItem";
            this.archivoYConexionToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.archivoYConexionToolStripMenuItem.Text = "Archivo y Conexion";
            // 
            // crearBaseDeDatosToolStripMenuItem
            // 
            this.crearBaseDeDatosToolStripMenuItem.Name = "crearBaseDeDatosToolStripMenuItem";
            this.crearBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.crearBaseDeDatosToolStripMenuItem.Text = "Crear Base de Datos Local";
            this.crearBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.crearBaseDeDatosToolStripMenuItem_Click);
            // 
            // conectarABaseDeDatosToolStripMenuItem
            // 
            this.conectarABaseDeDatosToolStripMenuItem.Name = "conectarABaseDeDatosToolStripMenuItem";
            this.conectarABaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.conectarABaseDeDatosToolStripMenuItem.Text = "Conectar a Base de Datos Remota";
            this.conectarABaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.conectarABaseDeDatosToolStripMenuItem_Click);
            // 
            // eliminarBaseDeDatosToolStripMenuItem
            // 
            this.eliminarBaseDeDatosToolStripMenuItem.Name = "eliminarBaseDeDatosToolStripMenuItem";
            this.eliminarBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.eliminarBaseDeDatosToolStripMenuItem.Text = "Eliminar Base de Datos Local";
            this.eliminarBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.eliminarBaseDeDatosToolStripMenuItem_Click);
            // 
            // direccionYVistaToolStripMenuItem
            // 
            this.direccionYVistaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obtenerDireccionDeEsteEquipoToolStripMenuItem});
            this.direccionYVistaToolStripMenuItem.Name = "direccionYVistaToolStripMenuItem";
            this.direccionYVistaToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.direccionYVistaToolStripMenuItem.Text = "Direccion y Vista";
            // 
            // obtenerDireccionDeEsteEquipoToolStripMenuItem
            // 
            this.obtenerDireccionDeEsteEquipoToolStripMenuItem.Name = "obtenerDireccionDeEsteEquipoToolStripMenuItem";
            this.obtenerDireccionDeEsteEquipoToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.obtenerDireccionDeEsteEquipoToolStripMenuItem.Text = "Obtener direccion de este equipo";
            this.obtenerDireccionDeEsteEquipoToolStripMenuItem.Click += new System.EventHandler(this.obtenerDireccionDeEsteEquipoToolStripMenuItem_Click);
            // 
            // grpTablaDeDatos
            // 
            this.grpTablaDeDatos.Controls.Add(this.btnBuscar);
            this.grpTablaDeDatos.Controls.Add(this.txtBuscar);
            this.grpTablaDeDatos.Controls.Add(this.btnRecargar);
            this.grpTablaDeDatos.Controls.Add(this.dtgTablaDatos);
            this.grpTablaDeDatos.Location = new System.Drawing.Point(13, 383);
            this.grpTablaDeDatos.Name = "grpTablaDeDatos";
            this.grpTablaDeDatos.Size = new System.Drawing.Size(2352, 325);
            this.grpTablaDeDatos.TabIndex = 2;
            this.grpTablaDeDatos.TabStop = false;
            this.grpTablaDeDatos.Text = "Tabla de Información de Cruces";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(574, 45);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(42, 46);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(514, 22);
            this.txtBuscar.TabIndex = 2;
            // 
            // btnRecargar
            // 
            this.btnRecargar.Location = new System.Drawing.Point(1342, 46);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(75, 23);
            this.btnRecargar.TabIndex = 1;
            this.btnRecargar.Text = "Recargar";
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // dtgTablaDatos
            // 
            this.dtgTablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTablaDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId_ControlCruces,
            this.colCodigoCruce,
            this.colTipoServicio,
            this.colCliente,
            this.colCaja,
            this.colRemision,
            this.colEstatusCobro,
            this.colFechaCarga,
            this.colFechaEntrega,
            this.colLugarCarga,
            this.colLugarDescarga,
            this.colPrecioPesos,
            this.colPrecioDolares,
            this.colIntermediario,
            this.colUnidad,
            this.colConductor,
            this.colFechaPagoPedimento,
            this.colFechaVencimientoPedimento,
            this.colAsignada});
            this.dtgTablaDatos.Location = new System.Drawing.Point(6, 105);
            this.dtgTablaDatos.Name = "dtgTablaDatos";
            this.dtgTablaDatos.Size = new System.Drawing.Size(2140, 150);
            this.dtgTablaDatos.TabIndex = 0;
            this.dtgTablaDatos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgTablaDatos_CellMouseClick);
            // 
            // colId_ControlCruces
            // 
            this.colId_ControlCruces.Frozen = true;
            this.colId_ControlCruces.HeaderText = "ID - Control de Cruces";
            this.colId_ControlCruces.Name = "colId_ControlCruces";
            this.colId_ControlCruces.ReadOnly = true;
            // 
            // colCodigoCruce
            // 
            this.colCodigoCruce.Frozen = true;
            this.colCodigoCruce.HeaderText = "Codigo de Cruce";
            this.colCodigoCruce.Name = "colCodigoCruce";
            this.colCodigoCruce.ReadOnly = true;
            // 
            // colTipoServicio
            // 
            this.colTipoServicio.Frozen = true;
            this.colTipoServicio.HeaderText = "Tipo de Servicio";
            this.colTipoServicio.Name = "colTipoServicio";
            this.colTipoServicio.ReadOnly = true;
            // 
            // colCliente
            // 
            this.colCliente.Frozen = true;
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            // 
            // colCaja
            // 
            this.colCaja.Frozen = true;
            this.colCaja.HeaderText = "Caja";
            this.colCaja.Name = "colCaja";
            this.colCaja.ReadOnly = true;
            // 
            // colRemision
            // 
            this.colRemision.Frozen = true;
            this.colRemision.HeaderText = "Remision/Factura";
            this.colRemision.Name = "colRemision";
            this.colRemision.ReadOnly = true;
            // 
            // colEstatusCobro
            // 
            this.colEstatusCobro.Frozen = true;
            this.colEstatusCobro.HeaderText = "Estatus de Cobro";
            this.colEstatusCobro.Name = "colEstatusCobro";
            this.colEstatusCobro.ReadOnly = true;
            // 
            // colFechaCarga
            // 
            this.colFechaCarga.Frozen = true;
            this.colFechaCarga.HeaderText = "Fecha de Carga";
            this.colFechaCarga.Name = "colFechaCarga";
            this.colFechaCarga.ReadOnly = true;
            // 
            // colFechaEntrega
            // 
            this.colFechaEntrega.Frozen = true;
            this.colFechaEntrega.HeaderText = "Fecha de Entrega";
            this.colFechaEntrega.Name = "colFechaEntrega";
            this.colFechaEntrega.ReadOnly = true;
            // 
            // colLugarCarga
            // 
            this.colLugarCarga.Frozen = true;
            this.colLugarCarga.HeaderText = "Lugar de Carga";
            this.colLugarCarga.Name = "colLugarCarga";
            this.colLugarCarga.ReadOnly = true;
            // 
            // colLugarDescarga
            // 
            this.colLugarDescarga.Frozen = true;
            this.colLugarDescarga.HeaderText = "Lugar de Descarga";
            this.colLugarDescarga.Name = "colLugarDescarga";
            this.colLugarDescarga.ReadOnly = true;
            // 
            // colPrecioPesos
            // 
            this.colPrecioPesos.Frozen = true;
            this.colPrecioPesos.HeaderText = "Precio Pesos";
            this.colPrecioPesos.Name = "colPrecioPesos";
            this.colPrecioPesos.ReadOnly = true;
            // 
            // colPrecioDolares
            // 
            this.colPrecioDolares.Frozen = true;
            this.colPrecioDolares.HeaderText = "Precio (Dolares)";
            this.colPrecioDolares.Name = "colPrecioDolares";
            this.colPrecioDolares.ReadOnly = true;
            // 
            // colIntermediario
            // 
            this.colIntermediario.Frozen = true;
            this.colIntermediario.HeaderText = "Intermediario";
            this.colIntermediario.Name = "colIntermediario";
            this.colIntermediario.ReadOnly = true;
            // 
            // colUnidad
            // 
            this.colUnidad.Frozen = true;
            this.colUnidad.HeaderText = "Unidad";
            this.colUnidad.Name = "colUnidad";
            this.colUnidad.ReadOnly = true;
            // 
            // colConductor
            // 
            this.colConductor.Frozen = true;
            this.colConductor.HeaderText = "Conductor";
            this.colConductor.Name = "colConductor";
            this.colConductor.ReadOnly = true;
            // 
            // colFechaPagoPedimento
            // 
            this.colFechaPagoPedimento.Frozen = true;
            this.colFechaPagoPedimento.HeaderText = "Fecha de Pago de Pedimento";
            this.colFechaPagoPedimento.Name = "colFechaPagoPedimento";
            this.colFechaPagoPedimento.ReadOnly = true;
            // 
            // colFechaVencimientoPedimento
            // 
            this.colFechaVencimientoPedimento.Frozen = true;
            this.colFechaVencimientoPedimento.HeaderText = "Fecha de Vencimiento de Pedimento";
            this.colFechaVencimientoPedimento.Name = "colFechaVencimientoPedimento";
            this.colFechaVencimientoPedimento.ReadOnly = true;
            // 
            // colAsignada
            // 
            this.colAsignada.Frozen = true;
            this.colAsignada.HeaderText = "Asignada";
            this.colAsignada.Name = "colAsignada";
            this.colAsignada.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1254, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(2526, 720);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpTablaDeDatos);
            this.Controls.Add(this.grpCampoDatos);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla Principal | Control de Cruces - - Transporte de Carga Jeff | Tabla de Cr" +
    "uces";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PantallaPrincipal_Load);
            this.grpCampoDatos.ResumeLayout(false);
            this.grpCampoDatos.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpTablaDeDatos.ResumeLayout(false);
            this.grpTablaDeDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTablaDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCampoDatos;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.TextBox txtEstatusCobro;
        private System.Windows.Forms.TextBox txtTipoServicio;
        private System.Windows.Forms.DateTimePicker dtpFechaCarga;
        private System.Windows.Forms.Label lblTipoServicio;
        private System.Windows.Forms.Label lblRemision;
        private System.Windows.Forms.Label lblEstatusCobro;
        private System.Windows.Forms.TextBox txtCaja;
        private System.Windows.Forms.TextBox txtCodigoCruce;
        private System.Windows.Forms.Label lblCodigoCruce;
        private System.Windows.Forms.Label lblCaja;
        private System.Windows.Forms.TextBox txtRemision;
        private System.Windows.Forms.Label lblFechaCarga;
        private System.Windows.Forms.TextBox txtPrecioPesos;
        private System.Windows.Forms.Label lblPrecioPesos;
        private System.Windows.Forms.TextBox txtLugarDescarga;
        private System.Windows.Forms.Label lblLugarDescarga;
        private System.Windows.Forms.TextBox txtLugarCarga;
        private System.Windows.Forms.Label lblLugarCarga;
        private System.Windows.Forms.TextBox txtIntermediario;
        private System.Windows.Forms.Label lblIntermediario;
        private System.Windows.Forms.TextBox txtPrecioDolares;
        private System.Windows.Forms.Label lblPrecioDolares;
        private System.Windows.Forms.Label lblAsignada;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimientoPedimento;
        private System.Windows.Forms.Label lblFechaPagoVencimiento;
        private System.Windows.Forms.Label lblFechaVencimientoPedimento;
        private System.Windows.Forms.DateTimePicker dtpFechaPagoPedimento;
        private System.Windows.Forms.Label lblConductor;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoYConexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conectarABaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.TextBox txtConductor;
        private System.Windows.Forms.GroupBox grpTablaDeDatos;
        private System.Windows.Forms.DataGridView dtgTablaDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId_ControlCruces;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoCruce;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemision;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstatusCobro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaCarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLugarCarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLugarDescarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioPesos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioDolares;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIntermediario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConductor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaPagoPedimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaVencimientoPedimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAsignada;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cboUnidades;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboAsignada;
        private System.Windows.Forms.ToolStripMenuItem direccionYVistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obtenerDireccionDeEsteEquipoToolStripMenuItem;
    }
}

