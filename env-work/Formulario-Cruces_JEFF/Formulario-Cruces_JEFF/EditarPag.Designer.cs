
namespace Formulario_Cruces_JEFF
{
    partial class EditarPag
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
            this.btnEditar = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(534, 352);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 125;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // rtxtDemora
            // 
            this.rtxtDemora.Location = new System.Drawing.Point(878, 231);
            this.rtxtDemora.MaxLength = 120;
            this.rtxtDemora.Name = "rtxtDemora";
            this.rtxtDemora.Size = new System.Drawing.Size(347, 88);
            this.rtxtDemora.TabIndex = 124;
            this.rtxtDemora.Text = "";
            // 
            // lblDemora
            // 
            this.lblDemora.AutoSize = true;
            this.lblDemora.Location = new System.Drawing.Point(803, 251);
            this.lblDemora.Name = "lblDemora";
            this.lblDemora.Size = new System.Drawing.Size(44, 13);
            this.lblDemora.TabIndex = 123;
            this.lblDemora.Text = "Demora";
            // 
            // cboEstatusCobro
            // 
            this.cboEstatusCobro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstatusCobro.FormattingEnabled = true;
            this.cboEstatusCobro.Items.AddRange(new object[] {
            "PENDIENTE",
            "PAGADO"});
            this.cboEstatusCobro.Location = new System.Drawing.Point(161, 188);
            this.cboEstatusCobro.Name = "cboEstatusCobro";
            this.cboEstatusCobro.Size = new System.Drawing.Size(254, 24);
            this.cboEstatusCobro.TabIndex = 122;
            // 
            // cboAsignada
            // 
            this.cboAsignada.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAsignada.FormattingEnabled = true;
            this.cboAsignada.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cboAsignada.Location = new System.Drawing.Point(903, 19);
            this.cboAsignada.Name = "cboAsignada";
            this.cboAsignada.Size = new System.Drawing.Size(121, 24);
            this.cboAsignada.TabIndex = 121;
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
            this.cboUnidades.Location = new System.Drawing.Point(903, 67);
            this.cboUnidades.Name = "cboUnidades";
            this.cboUnidades.Size = new System.Drawing.Size(121, 24);
            this.cboUnidades.TabIndex = 120;
            // 
            // txtConductor
            // 
            this.txtConductor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConductor.Location = new System.Drawing.Point(903, 111);
            this.txtConductor.MaxLength = 45;
            this.txtConductor.Name = "txtConductor";
            this.txtConductor.Size = new System.Drawing.Size(174, 22);
            this.txtConductor.TabIndex = 119;
            // 
            // lblAsignada
            // 
            this.lblAsignada.AutoSize = true;
            this.lblAsignada.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignada.Location = new System.Drawing.Point(798, 22);
            this.lblAsignada.Name = "lblAsignada";
            this.lblAsignada.Size = new System.Drawing.Size(62, 16);
            this.lblAsignada.TabIndex = 118;
            this.lblAsignada.Text = "Asignada";
            // 
            // dtpFechaVencimientoPedimento
            // 
            this.dtpFechaVencimientoPedimento.CustomFormat = "MMMMdd, yyyy  |  hh:mm:ss tt";
            this.dtpFechaVencimientoPedimento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVencimientoPedimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaVencimientoPedimento.Location = new System.Drawing.Point(1078, 201);
            this.dtpFechaVencimientoPedimento.Name = "dtpFechaVencimientoPedimento";
            this.dtpFechaVencimientoPedimento.Size = new System.Drawing.Size(277, 22);
            this.dtpFechaVencimientoPedimento.TabIndex = 116;
            // 
            // lblFechaPagoVencimiento
            // 
            this.lblFechaPagoVencimiento.AutoSize = true;
            this.lblFechaPagoVencimiento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPagoVencimiento.Location = new System.Drawing.Point(800, 166);
            this.lblFechaPagoVencimiento.Name = "lblFechaPagoVencimiento";
            this.lblFechaPagoVencimiento.Size = new System.Drawing.Size(180, 16);
            this.lblFechaPagoVencimiento.TabIndex = 115;
            this.lblFechaPagoVencimiento.Text = "Fecha de Pago de Pedimento";
            // 
            // lblFechaVencimientoPedimento
            // 
            this.lblFechaVencimientoPedimento.AutoSize = true;
            this.lblFechaVencimientoPedimento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVencimientoPedimento.Location = new System.Drawing.Point(805, 204);
            this.lblFechaVencimientoPedimento.Name = "lblFechaVencimientoPedimento";
            this.lblFechaVencimientoPedimento.Size = new System.Drawing.Size(221, 16);
            this.lblFechaVencimientoPedimento.TabIndex = 117;
            this.lblFechaVencimientoPedimento.Text = "Fecha de Vencimiento de Pedimento";
            // 
            // dtpFechaPagoPedimento
            // 
            this.dtpFechaPagoPedimento.CustomFormat = "MMMMdd, yyyy  |  hh:mm:ss tt";
            this.dtpFechaPagoPedimento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaPagoPedimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaPagoPedimento.Location = new System.Drawing.Point(1046, 166);
            this.dtpFechaPagoPedimento.Name = "dtpFechaPagoPedimento";
            this.dtpFechaPagoPedimento.Size = new System.Drawing.Size(281, 22);
            this.dtpFechaPagoPedimento.TabIndex = 114;
            // 
            // lblConductor
            // 
            this.lblConductor.AutoSize = true;
            this.lblConductor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConductor.Location = new System.Drawing.Point(804, 113);
            this.lblConductor.Name = "lblConductor";
            this.lblConductor.Size = new System.Drawing.Size(67, 16);
            this.lblConductor.TabIndex = 113;
            this.lblConductor.Text = "Conductor";
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidad.Location = new System.Drawing.Point(804, 66);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(48, 16);
            this.lblUnidad.TabIndex = 112;
            this.lblUnidad.Text = "Unidad";
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(598, 263);
            this.txtCliente.MaxLength = 40;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(149, 22);
            this.txtCliente.TabIndex = 111;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(514, 262);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(48, 16);
            this.lblCliente.TabIndex = 109;
            this.lblCliente.Text = "Cliente";
            // 
            // txtIntermediario
            // 
            this.txtIntermediario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntermediario.Location = new System.Drawing.Point(598, 217);
            this.txtIntermediario.MaxLength = 45;
            this.txtIntermediario.Name = "txtIntermediario";
            this.txtIntermediario.Size = new System.Drawing.Size(149, 22);
            this.txtIntermediario.TabIndex = 110;
            // 
            // lblIntermediario
            // 
            this.lblIntermediario.AutoSize = true;
            this.lblIntermediario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntermediario.Location = new System.Drawing.Point(481, 217);
            this.lblIntermediario.Name = "lblIntermediario";
            this.lblIntermediario.Size = new System.Drawing.Size(82, 16);
            this.lblIntermediario.TabIndex = 108;
            this.lblIntermediario.Text = "Intermediario";
            // 
            // txtPrecioDolares
            // 
            this.txtPrecioDolares.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioDolares.Location = new System.Drawing.Point(598, 172);
            this.txtPrecioDolares.Name = "txtPrecioDolares";
            this.txtPrecioDolares.Size = new System.Drawing.Size(149, 22);
            this.txtPrecioDolares.TabIndex = 107;
            this.txtPrecioDolares.Text = "0";
            this.txtPrecioDolares.TextChanged += new System.EventHandler(this.txtPrecioDolares_TextChanged);
            // 
            // lblPrecioDolares
            // 
            this.lblPrecioDolares.AutoSize = true;
            this.lblPrecioDolares.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioDolares.Location = new System.Drawing.Point(471, 172);
            this.lblPrecioDolares.Name = "lblPrecioDolares";
            this.lblPrecioDolares.Size = new System.Drawing.Size(101, 16);
            this.lblPrecioDolares.TabIndex = 106;
            this.lblPrecioDolares.Text = "Precio (Dolares)";
            // 
            // txtPrecioPesos
            // 
            this.txtPrecioPesos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioPesos.Location = new System.Drawing.Point(598, 127);
            this.txtPrecioPesos.Name = "txtPrecioPesos";
            this.txtPrecioPesos.Size = new System.Drawing.Size(149, 22);
            this.txtPrecioPesos.TabIndex = 105;
            this.txtPrecioPesos.Text = "0";
            this.txtPrecioPesos.TextChanged += new System.EventHandler(this.txtPrecioPesos_TextChanged);
            // 
            // lblPrecioPesos
            // 
            this.lblPrecioPesos.AutoSize = true;
            this.lblPrecioPesos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioPesos.Location = new System.Drawing.Point(481, 127);
            this.lblPrecioPesos.Name = "lblPrecioPesos";
            this.lblPrecioPesos.Size = new System.Drawing.Size(94, 16);
            this.lblPrecioPesos.TabIndex = 104;
            this.lblPrecioPesos.Text = "Precio (Pesos)";
            // 
            // txtLugarDescarga
            // 
            this.txtLugarDescarga.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLugarDescarga.Location = new System.Drawing.Point(598, 82);
            this.txtLugarDescarga.MaxLength = 60;
            this.txtLugarDescarga.Name = "txtLugarDescarga";
            this.txtLugarDescarga.Size = new System.Drawing.Size(149, 22);
            this.txtLugarDescarga.TabIndex = 103;
            // 
            // lblLugarDescarga
            // 
            this.lblLugarDescarga.AutoSize = true;
            this.lblLugarDescarga.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugarDescarga.Location = new System.Drawing.Point(455, 85);
            this.lblLugarDescarga.Name = "lblLugarDescarga";
            this.lblLugarDescarga.Size = new System.Drawing.Size(117, 16);
            this.lblLugarDescarga.TabIndex = 102;
            this.lblLugarDescarga.Text = "Lugar de Descarga";
            // 
            // txtLugarCarga
            // 
            this.txtLugarCarga.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLugarCarga.Location = new System.Drawing.Point(598, 37);
            this.txtLugarCarga.MaxLength = 60;
            this.txtLugarCarga.Name = "txtLugarCarga";
            this.txtLugarCarga.Size = new System.Drawing.Size(149, 22);
            this.txtLugarCarga.TabIndex = 101;
            // 
            // lblLugarCarga
            // 
            this.lblLugarCarga.AutoSize = true;
            this.lblLugarCarga.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugarCarga.Location = new System.Drawing.Point(472, 37);
            this.lblLugarCarga.Name = "lblLugarCarga";
            this.lblLugarCarga.Size = new System.Drawing.Size(96, 16);
            this.lblLugarCarga.TabIndex = 100;
            this.lblLugarCarga.Text = "Lugar de Carga";
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.CalendarFont = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEntrega.CustomFormat = "MMMMdd, yyyy  |  hh:mm:ss tt";
            this.dtpFechaEntrega.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaEntrega.Location = new System.Drawing.Point(158, 269);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(289, 22);
            this.dtpFechaEntrega.TabIndex = 98;
            // 
            // lblFechaCarga
            // 
            this.lblFechaCarga.AutoSize = true;
            this.lblFechaCarga.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCarga.Location = new System.Drawing.Point(34, 231);
            this.lblFechaCarga.Name = "lblFechaCarga";
            this.lblFechaCarga.Size = new System.Drawing.Size(100, 16);
            this.lblFechaCarga.TabIndex = 97;
            this.lblFechaCarga.Text = "Fecha de Carga";
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEntrega.Location = new System.Drawing.Point(27, 269);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(111, 16);
            this.lblFechaEntrega.TabIndex = 99;
            this.lblFechaEntrega.Text = "Fecha de Entrega";
            // 
            // dtpFechaCarga
            // 
            this.dtpFechaCarga.CustomFormat = "MMMMdd, yyyy  |  hh:mm:ss tt";
            this.dtpFechaCarga.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCarga.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaCarga.Location = new System.Drawing.Point(158, 223);
            this.dtpFechaCarga.Name = "dtpFechaCarga";
            this.dtpFechaCarga.Size = new System.Drawing.Size(289, 22);
            this.dtpFechaCarga.TabIndex = 96;
            // 
            // txtTipoServicio
            // 
            this.txtTipoServicio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoServicio.Location = new System.Drawing.Point(158, 72);
            this.txtTipoServicio.MaxLength = 50;
            this.txtTipoServicio.Name = "txtTipoServicio";
            this.txtTipoServicio.Size = new System.Drawing.Size(218, 22);
            this.txtTipoServicio.TabIndex = 90;
            // 
            // lblTipoServicio
            // 
            this.lblTipoServicio.AutoSize = true;
            this.lblTipoServicio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoServicio.Location = new System.Drawing.Point(32, 75);
            this.lblTipoServicio.Name = "lblTipoServicio";
            this.lblTipoServicio.Size = new System.Drawing.Size(99, 16);
            this.lblTipoServicio.TabIndex = 89;
            this.lblTipoServicio.Text = "Tipo de Servicio";
            // 
            // lblRemision
            // 
            this.lblRemision.AutoSize = true;
            this.lblRemision.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemision.Location = new System.Drawing.Point(17, 151);
            this.lblRemision.Name = "lblRemision";
            this.lblRemision.Size = new System.Drawing.Size(118, 16);
            this.lblRemision.TabIndex = 93;
            this.lblRemision.Text = "Remision / Factura";
            // 
            // lblEstatusCobro
            // 
            this.lblEstatusCobro.AutoSize = true;
            this.lblEstatusCobro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatusCobro.Location = new System.Drawing.Point(25, 191);
            this.lblEstatusCobro.Name = "lblEstatusCobro";
            this.lblEstatusCobro.Size = new System.Drawing.Size(109, 16);
            this.lblEstatusCobro.TabIndex = 95;
            this.lblEstatusCobro.Text = "Estatus de Cobro";
            // 
            // txtCaja
            // 
            this.txtCaja.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaja.Location = new System.Drawing.Point(158, 110);
            this.txtCaja.MaxLength = 30;
            this.txtCaja.Name = "txtCaja";
            this.txtCaja.Size = new System.Drawing.Size(218, 22);
            this.txtCaja.TabIndex = 92;
            // 
            // txtCodigoCruce
            // 
            this.txtCodigoCruce.Enabled = false;
            this.txtCodigoCruce.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCruce.Location = new System.Drawing.Point(161, 32);
            this.txtCodigoCruce.Name = "txtCodigoCruce";
            this.txtCodigoCruce.ReadOnly = true;
            this.txtCodigoCruce.Size = new System.Drawing.Size(218, 22);
            this.txtCodigoCruce.TabIndex = 88;
            // 
            // lblCodigoCruce
            // 
            this.lblCodigoCruce.AutoSize = true;
            this.lblCodigoCruce.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCruce.Location = new System.Drawing.Point(27, 37);
            this.lblCodigoCruce.Name = "lblCodigoCruce";
            this.lblCodigoCruce.Size = new System.Drawing.Size(104, 16);
            this.lblCodigoCruce.TabIndex = 87;
            this.lblCodigoCruce.Text = "Codigo de Cruce";
            // 
            // lblCaja
            // 
            this.lblCaja.AutoSize = true;
            this.lblCaja.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaja.Location = new System.Drawing.Point(91, 113);
            this.lblCaja.Name = "lblCaja";
            this.lblCaja.Size = new System.Drawing.Size(34, 16);
            this.lblCaja.TabIndex = 91;
            this.lblCaja.Text = "Caja";
            // 
            // txtRemision
            // 
            this.txtRemision.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemision.Location = new System.Drawing.Point(158, 148);
            this.txtRemision.MaxLength = 45;
            this.txtRemision.Name = "txtRemision";
            this.txtRemision.Size = new System.Drawing.Size(218, 22);
            this.txtRemision.TabIndex = 94;
            // 
            // EditarPag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 401);
            this.Controls.Add(this.btnEditar);
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
            this.Name = "EditarPag";
            this.Text = "EditarPag";
            this.Load += new System.EventHandler(this.EditarPag_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
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
    }
}