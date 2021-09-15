
namespace Formulario_Cruces_JEFF
{
    partial class AgregarPag
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
            this.rtxtDemora = new System.Windows.Forms.RichTextBox();
            this.lblDemora = new System.Windows.Forms.Label();
            this.cboEstatusCobro = new System.Windows.Forms.ComboBox();
            this.cboAsignada = new System.Windows.Forms.ComboBox();
            this.cboUnidades = new System.Windows.Forms.ComboBox();
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxtDemora
            // 
            this.rtxtDemora.Location = new System.Drawing.Point(877, 254);
            this.rtxtDemora.MaxLength = 120;
            this.rtxtDemora.Name = "rtxtDemora";
            this.rtxtDemora.Size = new System.Drawing.Size(347, 88);
            this.rtxtDemora.TabIndex = 85;
            this.rtxtDemora.Text = "";
            // 
            // lblDemora
            // 
            this.lblDemora.AutoSize = true;
            this.lblDemora.Location = new System.Drawing.Point(802, 274);
            this.lblDemora.Name = "lblDemora";
            this.lblDemora.Size = new System.Drawing.Size(44, 13);
            this.lblDemora.TabIndex = 84;
            this.lblDemora.Text = "Demora";
            // 
            // cboEstatusCobro
            // 
            this.cboEstatusCobro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstatusCobro.FormattingEnabled = true;
            this.cboEstatusCobro.Items.AddRange(new object[] {
            "PENDIENTE",
            "PAGADO"});
            this.cboEstatusCobro.Location = new System.Drawing.Point(160, 211);
            this.cboEstatusCobro.Name = "cboEstatusCobro";
            this.cboEstatusCobro.Size = new System.Drawing.Size(254, 24);
            this.cboEstatusCobro.TabIndex = 83;
            // 
            // cboAsignada
            // 
            this.cboAsignada.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAsignada.FormattingEnabled = true;
            this.cboAsignada.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cboAsignada.Location = new System.Drawing.Point(902, 42);
            this.cboAsignada.Name = "cboAsignada";
            this.cboAsignada.Size = new System.Drawing.Size(121, 24);
            this.cboAsignada.TabIndex = 82;
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
            this.cboUnidades.Location = new System.Drawing.Point(902, 90);
            this.cboUnidades.Name = "cboUnidades";
            this.cboUnidades.Size = new System.Drawing.Size(121, 24);
            this.cboUnidades.TabIndex = 81;
            // 
            // txtConductor
            // 
            this.txtConductor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtConductor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtConductor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConductor.Location = new System.Drawing.Point(902, 134);
            this.txtConductor.MaxLength = 45;
            this.txtConductor.Name = "txtConductor";
            this.txtConductor.Size = new System.Drawing.Size(174, 22);
            this.txtConductor.TabIndex = 80;
            // 
            // lblAsignada
            // 
            this.lblAsignada.AutoSize = true;
            this.lblAsignada.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignada.Location = new System.Drawing.Point(797, 45);
            this.lblAsignada.Name = "lblAsignada";
            this.lblAsignada.Size = new System.Drawing.Size(62, 16);
            this.lblAsignada.TabIndex = 79;
            this.lblAsignada.Text = "Asignada";
            // 
            // dtpFechaVencimientoPedimento
            // 
            this.dtpFechaVencimientoPedimento.CustomFormat = "MMMMdd, yyyy  |  hh:mm:ss tt";
            this.dtpFechaVencimientoPedimento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVencimientoPedimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaVencimientoPedimento.Location = new System.Drawing.Point(1077, 224);
            this.dtpFechaVencimientoPedimento.Name = "dtpFechaVencimientoPedimento";
            this.dtpFechaVencimientoPedimento.Size = new System.Drawing.Size(277, 22);
            this.dtpFechaVencimientoPedimento.TabIndex = 77;
            this.dtpFechaVencimientoPedimento.Value = new System.DateTime(2021, 7, 29, 13, 23, 23, 0);
            // 
            // lblFechaPagoVencimiento
            // 
            this.lblFechaPagoVencimiento.AutoSize = true;
            this.lblFechaPagoVencimiento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPagoVencimiento.Location = new System.Drawing.Point(799, 189);
            this.lblFechaPagoVencimiento.Name = "lblFechaPagoVencimiento";
            this.lblFechaPagoVencimiento.Size = new System.Drawing.Size(180, 16);
            this.lblFechaPagoVencimiento.TabIndex = 76;
            this.lblFechaPagoVencimiento.Text = "Fecha de Pago de Pedimento";
            // 
            // lblFechaVencimientoPedimento
            // 
            this.lblFechaVencimientoPedimento.AutoSize = true;
            this.lblFechaVencimientoPedimento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVencimientoPedimento.Location = new System.Drawing.Point(804, 227);
            this.lblFechaVencimientoPedimento.Name = "lblFechaVencimientoPedimento";
            this.lblFechaVencimientoPedimento.Size = new System.Drawing.Size(221, 16);
            this.lblFechaVencimientoPedimento.TabIndex = 78;
            this.lblFechaVencimientoPedimento.Text = "Fecha de Vencimiento de Pedimento";
            // 
            // dtpFechaPagoPedimento
            // 
            this.dtpFechaPagoPedimento.CustomFormat = "MMMMdd, yyyy  |  hh:mm:ss tt";
            this.dtpFechaPagoPedimento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaPagoPedimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaPagoPedimento.Location = new System.Drawing.Point(1045, 189);
            this.dtpFechaPagoPedimento.Name = "dtpFechaPagoPedimento";
            this.dtpFechaPagoPedimento.Size = new System.Drawing.Size(281, 22);
            this.dtpFechaPagoPedimento.TabIndex = 75;
            this.dtpFechaPagoPedimento.Value = new System.DateTime(2021, 7, 29, 13, 23, 29, 0);
            // 
            // lblConductor
            // 
            this.lblConductor.AutoSize = true;
            this.lblConductor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConductor.Location = new System.Drawing.Point(803, 136);
            this.lblConductor.Name = "lblConductor";
            this.lblConductor.Size = new System.Drawing.Size(67, 16);
            this.lblConductor.TabIndex = 74;
            this.lblConductor.Text = "Conductor";
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidad.Location = new System.Drawing.Point(803, 89);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(48, 16);
            this.lblUnidad.TabIndex = 73;
            this.lblUnidad.Text = "Unidad";
            // 
            // txtCliente
            // 
            this.txtCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(597, 286);
            this.txtCliente.MaxLength = 40;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(149, 22);
            this.txtCliente.TabIndex = 72;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(513, 285);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(48, 16);
            this.lblCliente.TabIndex = 70;
            this.lblCliente.Text = "Cliente";
            // 
            // txtIntermediario
            // 
            this.txtIntermediario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtIntermediario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtIntermediario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntermediario.Location = new System.Drawing.Point(597, 240);
            this.txtIntermediario.MaxLength = 45;
            this.txtIntermediario.Name = "txtIntermediario";
            this.txtIntermediario.Size = new System.Drawing.Size(149, 22);
            this.txtIntermediario.TabIndex = 71;
            // 
            // lblIntermediario
            // 
            this.lblIntermediario.AutoSize = true;
            this.lblIntermediario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntermediario.Location = new System.Drawing.Point(480, 240);
            this.lblIntermediario.Name = "lblIntermediario";
            this.lblIntermediario.Size = new System.Drawing.Size(82, 16);
            this.lblIntermediario.TabIndex = 69;
            this.lblIntermediario.Text = "Intermediario";
            // 
            // txtPrecioDolares
            // 
            this.txtPrecioDolares.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioDolares.Location = new System.Drawing.Point(597, 195);
            this.txtPrecioDolares.Name = "txtPrecioDolares";
            this.txtPrecioDolares.Size = new System.Drawing.Size(149, 22);
            this.txtPrecioDolares.TabIndex = 68;
            this.txtPrecioDolares.Text = "0";
            this.txtPrecioDolares.TextChanged += new System.EventHandler(this.txtPrecioDolares_TextChanged);
            // 
            // lblPrecioDolares
            // 
            this.lblPrecioDolares.AutoSize = true;
            this.lblPrecioDolares.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioDolares.Location = new System.Drawing.Point(470, 195);
            this.lblPrecioDolares.Name = "lblPrecioDolares";
            this.lblPrecioDolares.Size = new System.Drawing.Size(101, 16);
            this.lblPrecioDolares.TabIndex = 67;
            this.lblPrecioDolares.Text = "Precio (Dolares)";
            // 
            // txtPrecioPesos
            // 
            this.txtPrecioPesos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioPesos.Location = new System.Drawing.Point(597, 150);
            this.txtPrecioPesos.Name = "txtPrecioPesos";
            this.txtPrecioPesos.Size = new System.Drawing.Size(149, 22);
            this.txtPrecioPesos.TabIndex = 66;
            this.txtPrecioPesos.Text = "0";
            this.txtPrecioPesos.TextChanged += new System.EventHandler(this.txtPrecioPesos_TextChanged);
            // 
            // lblPrecioPesos
            // 
            this.lblPrecioPesos.AutoSize = true;
            this.lblPrecioPesos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioPesos.Location = new System.Drawing.Point(480, 150);
            this.lblPrecioPesos.Name = "lblPrecioPesos";
            this.lblPrecioPesos.Size = new System.Drawing.Size(94, 16);
            this.lblPrecioPesos.TabIndex = 65;
            this.lblPrecioPesos.Text = "Precio (Pesos)";
            // 
            // txtLugarDescarga
            // 
            this.txtLugarDescarga.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLugarDescarga.Location = new System.Drawing.Point(597, 105);
            this.txtLugarDescarga.MaxLength = 60;
            this.txtLugarDescarga.Name = "txtLugarDescarga";
            this.txtLugarDescarga.Size = new System.Drawing.Size(149, 22);
            this.txtLugarDescarga.TabIndex = 64;
            // 
            // lblLugarDescarga
            // 
            this.lblLugarDescarga.AutoSize = true;
            this.lblLugarDescarga.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugarDescarga.Location = new System.Drawing.Point(454, 108);
            this.lblLugarDescarga.Name = "lblLugarDescarga";
            this.lblLugarDescarga.Size = new System.Drawing.Size(117, 16);
            this.lblLugarDescarga.TabIndex = 63;
            this.lblLugarDescarga.Text = "Lugar de Descarga";
            // 
            // txtLugarCarga
            // 
            this.txtLugarCarga.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLugarCarga.Location = new System.Drawing.Point(597, 60);
            this.txtLugarCarga.MaxLength = 60;
            this.txtLugarCarga.Name = "txtLugarCarga";
            this.txtLugarCarga.Size = new System.Drawing.Size(149, 22);
            this.txtLugarCarga.TabIndex = 62;
            // 
            // lblLugarCarga
            // 
            this.lblLugarCarga.AutoSize = true;
            this.lblLugarCarga.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugarCarga.Location = new System.Drawing.Point(471, 60);
            this.lblLugarCarga.Name = "lblLugarCarga";
            this.lblLugarCarga.Size = new System.Drawing.Size(96, 16);
            this.lblLugarCarga.TabIndex = 61;
            this.lblLugarCarga.Text = "Lugar de Carga";
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.CalendarFont = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEntrega.CustomFormat = "MMMMdd, yyyy  |  hh:mm:ss tt";
            this.dtpFechaEntrega.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaEntrega.Location = new System.Drawing.Point(157, 292);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(289, 22);
            this.dtpFechaEntrega.TabIndex = 59;
            this.dtpFechaEntrega.Value = new System.DateTime(2021, 7, 29, 13, 23, 13, 0);
            // 
            // lblFechaCarga
            // 
            this.lblFechaCarga.AutoSize = true;
            this.lblFechaCarga.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCarga.Location = new System.Drawing.Point(33, 254);
            this.lblFechaCarga.Name = "lblFechaCarga";
            this.lblFechaCarga.Size = new System.Drawing.Size(100, 16);
            this.lblFechaCarga.TabIndex = 58;
            this.lblFechaCarga.Text = "Fecha de Carga";
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEntrega.Location = new System.Drawing.Point(26, 292);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(111, 16);
            this.lblFechaEntrega.TabIndex = 60;
            this.lblFechaEntrega.Text = "Fecha de Entrega";
            // 
            // dtpFechaCarga
            // 
            this.dtpFechaCarga.CustomFormat = "MMMMdd, yyyy  |  hh:mm:ss tt";
            this.dtpFechaCarga.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCarga.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaCarga.Location = new System.Drawing.Point(157, 246);
            this.dtpFechaCarga.Name = "dtpFechaCarga";
            this.dtpFechaCarga.Size = new System.Drawing.Size(289, 22);
            this.dtpFechaCarga.TabIndex = 57;
            this.dtpFechaCarga.Value = new System.DateTime(2021, 7, 29, 13, 22, 48, 0);
            // 
            // txtTipoServicio
            // 
            this.txtTipoServicio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoServicio.Location = new System.Drawing.Point(157, 95);
            this.txtTipoServicio.MaxLength = 50;
            this.txtTipoServicio.Name = "txtTipoServicio";
            this.txtTipoServicio.Size = new System.Drawing.Size(218, 22);
            this.txtTipoServicio.TabIndex = 51;
            // 
            // lblTipoServicio
            // 
            this.lblTipoServicio.AutoSize = true;
            this.lblTipoServicio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoServicio.Location = new System.Drawing.Point(31, 98);
            this.lblTipoServicio.Name = "lblTipoServicio";
            this.lblTipoServicio.Size = new System.Drawing.Size(99, 16);
            this.lblTipoServicio.TabIndex = 50;
            this.lblTipoServicio.Text = "Tipo de Servicio";
            // 
            // lblRemision
            // 
            this.lblRemision.AutoSize = true;
            this.lblRemision.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemision.Location = new System.Drawing.Point(16, 174);
            this.lblRemision.Name = "lblRemision";
            this.lblRemision.Size = new System.Drawing.Size(118, 16);
            this.lblRemision.TabIndex = 54;
            this.lblRemision.Text = "Remision / Factura";
            // 
            // lblEstatusCobro
            // 
            this.lblEstatusCobro.AutoSize = true;
            this.lblEstatusCobro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatusCobro.Location = new System.Drawing.Point(24, 214);
            this.lblEstatusCobro.Name = "lblEstatusCobro";
            this.lblEstatusCobro.Size = new System.Drawing.Size(109, 16);
            this.lblEstatusCobro.TabIndex = 56;
            this.lblEstatusCobro.Text = "Estatus de Cobro";
            // 
            // txtCaja
            // 
            this.txtCaja.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaja.Location = new System.Drawing.Point(157, 133);
            this.txtCaja.MaxLength = 30;
            this.txtCaja.Name = "txtCaja";
            this.txtCaja.Size = new System.Drawing.Size(218, 22);
            this.txtCaja.TabIndex = 53;
            // 
            // txtCodigoCruce
            // 
            this.txtCodigoCruce.Enabled = false;
            this.txtCodigoCruce.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCruce.Location = new System.Drawing.Point(160, 55);
            this.txtCodigoCruce.Name = "txtCodigoCruce";
            this.txtCodigoCruce.ReadOnly = true;
            this.txtCodigoCruce.Size = new System.Drawing.Size(218, 22);
            this.txtCodigoCruce.TabIndex = 49;
            // 
            // lblCodigoCruce
            // 
            this.lblCodigoCruce.AutoSize = true;
            this.lblCodigoCruce.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCruce.Location = new System.Drawing.Point(26, 60);
            this.lblCodigoCruce.Name = "lblCodigoCruce";
            this.lblCodigoCruce.Size = new System.Drawing.Size(104, 16);
            this.lblCodigoCruce.TabIndex = 48;
            this.lblCodigoCruce.Text = "Codigo de Cruce";
            // 
            // lblCaja
            // 
            this.lblCaja.AutoSize = true;
            this.lblCaja.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaja.Location = new System.Drawing.Point(90, 136);
            this.lblCaja.Name = "lblCaja";
            this.lblCaja.Size = new System.Drawing.Size(34, 16);
            this.lblCaja.TabIndex = 52;
            this.lblCaja.Text = "Caja";
            // 
            // txtRemision
            // 
            this.txtRemision.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemision.Location = new System.Drawing.Point(157, 171);
            this.txtRemision.MaxLength = 45;
            this.txtRemision.Name = "txtRemision";
            this.txtRemision.Size = new System.Drawing.Size(218, 22);
            this.txtRemision.TabIndex = 55;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(533, 375);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 86;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // AgregarPag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1380, 472);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.rtxtDemora);
            this.Controls.Add(this.lblDemora);
            this.Controls.Add(this.cboEstatusCobro);
            this.Controls.Add(this.cboAsignada);
            this.Controls.Add(this.cboUnidades);
            this.Controls.Add(this.txtConductor);
            this.Controls.Add(this.lblAsignada);
            this.Controls.Add(this.dtpFechaVencimientoPedimento);
            this.Controls.Add(this.lblFechaPagoVencimiento);
            this.Controls.Add(this.lblFechaVencimientoPedimento);
            this.Controls.Add(this.dtpFechaPagoPedimento);
            this.Controls.Add(this.lblConductor);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtIntermediario);
            this.Controls.Add(this.lblIntermediario);
            this.Controls.Add(this.txtPrecioDolares);
            this.Controls.Add(this.lblPrecioDolares);
            this.Controls.Add(this.txtPrecioPesos);
            this.Controls.Add(this.lblPrecioPesos);
            this.Controls.Add(this.txtLugarDescarga);
            this.Controls.Add(this.lblLugarDescarga);
            this.Controls.Add(this.txtLugarCarga);
            this.Controls.Add(this.lblLugarCarga);
            this.Controls.Add(this.dtpFechaEntrega);
            this.Controls.Add(this.lblFechaCarga);
            this.Controls.Add(this.lblFechaEntrega);
            this.Controls.Add(this.dtpFechaCarga);
            this.Controls.Add(this.txtTipoServicio);
            this.Controls.Add(this.lblTipoServicio);
            this.Controls.Add(this.lblRemision);
            this.Controls.Add(this.lblEstatusCobro);
            this.Controls.Add(this.txtCaja);
            this.Controls.Add(this.txtCodigoCruce);
            this.Controls.Add(this.lblCodigoCruce);
            this.Controls.Add(this.lblCaja);
            this.Controls.Add(this.txtRemision);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarPag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarPag";
            this.Load += new System.EventHandler(this.AgregarPag_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtDemora;
        private System.Windows.Forms.Label lblDemora;
        private System.Windows.Forms.ComboBox cboEstatusCobro;
        private System.Windows.Forms.ComboBox cboAsignada;
        private System.Windows.Forms.ComboBox cboUnidades;
        private System.Windows.Forms.TextBox txtConductor;
        private System.Windows.Forms.Label lblAsignada;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimientoPedimento;
        private System.Windows.Forms.Label lblFechaPagoVencimiento;
        private System.Windows.Forms.Label lblFechaVencimientoPedimento;
        private System.Windows.Forms.DateTimePicker dtpFechaPagoPedimento;
        private System.Windows.Forms.Label lblConductor;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtIntermediario;
        private System.Windows.Forms.Label lblIntermediario;
        private System.Windows.Forms.TextBox txtPrecioDolares;
        private System.Windows.Forms.Label lblPrecioDolares;
        private System.Windows.Forms.TextBox txtPrecioPesos;
        private System.Windows.Forms.Label lblPrecioPesos;
        private System.Windows.Forms.TextBox txtLugarDescarga;
        private System.Windows.Forms.Label lblLugarDescarga;
        private System.Windows.Forms.TextBox txtLugarCarga;
        private System.Windows.Forms.Label lblLugarCarga;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.Label lblFechaCarga;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.DateTimePicker dtpFechaCarga;
        private System.Windows.Forms.TextBox txtTipoServicio;
        private System.Windows.Forms.Label lblTipoServicio;
        private System.Windows.Forms.Label lblRemision;
        private System.Windows.Forms.Label lblEstatusCobro;
        private System.Windows.Forms.TextBox txtCaja;
        private System.Windows.Forms.TextBox txtCodigoCruce;
        private System.Windows.Forms.Label lblCodigoCruce;
        private System.Windows.Forms.Label lblCaja;
        private System.Windows.Forms.TextBox txtRemision;
        private System.Windows.Forms.Button btnAgregar;
    }
}