
namespace ControlGastos
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.rtxtDemora = new System.Windows.Forms.RichTextBox();
            this.lblDemora = new System.Windows.Forms.Label();
            this.cboUnidades = new System.Windows.Forms.ComboBox();
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
            this.lblCaja = new System.Windows.Forms.Label();
            this.txtNoFactura = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            // rtxtDemora
            // 
            this.rtxtDemora.Location = new System.Drawing.Point(731, 171);
            this.rtxtDemora.MaxLength = 120;
            this.rtxtDemora.Name = "rtxtDemora";
            this.rtxtDemora.Size = new System.Drawing.Size(233, 88);
            this.rtxtDemora.TabIndex = 161;
            this.rtxtDemora.Text = "";
            // 
            // lblDemora
            // 
            this.lblDemora.AutoSize = true;
            this.lblDemora.Location = new System.Drawing.Point(669, 190);
            this.lblDemora.Name = "lblDemora";
            this.lblDemora.Size = new System.Drawing.Size(44, 13);
            this.lblDemora.TabIndex = 160;
            this.lblDemora.Text = "Demora";
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
            this.cboUnidades.Location = new System.Drawing.Point(731, 128);
            this.cboUnidades.Name = "cboUnidades";
            this.cboUnidades.Size = new System.Drawing.Size(121, 24);
            this.cboUnidades.TabIndex = 159;
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidad.Location = new System.Drawing.Point(669, 136);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(47, 16);
            this.lblUnidad.TabIndex = 158;
            this.lblUnidad.Text = "Unidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(731, 91);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(149, 22);
            this.txtCantidad.TabIndex = 157;
            this.txtCantidad.Text = "0";
            // 
            // lblPrecioDolares
            // 
            this.lblPrecioDolares.AutoSize = true;
            this.lblPrecioDolares.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioDolares.Location = new System.Drawing.Point(658, 94);
            this.lblPrecioDolares.Name = "lblPrecioDolares";
            this.lblPrecioDolares.Size = new System.Drawing.Size(58, 16);
            this.lblPrecioDolares.TabIndex = 156;
            this.lblPrecioDolares.Text = "Cantidad";
            // 
            // txtImpuestos
            // 
            this.txtImpuestos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpuestos.Location = new System.Drawing.Point(731, 57);
            this.txtImpuestos.Name = "txtImpuestos";
            this.txtImpuestos.Size = new System.Drawing.Size(149, 22);
            this.txtImpuestos.TabIndex = 155;
            this.txtImpuestos.Text = "0";
            // 
            // lblPrecioPesos
            // 
            this.lblPrecioPesos.AutoSize = true;
            this.lblPrecioPesos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioPesos.Location = new System.Drawing.Point(649, 57);
            this.lblPrecioPesos.Name = "lblPrecioPesos";
            this.lblPrecioPesos.Size = new System.Drawing.Size(67, 16);
            this.lblPrecioPesos.TabIndex = 154;
            this.lblPrecioPesos.Text = "Impuestos";
            // 
            // lblFechaCarga
            // 
            this.lblFechaCarga.AutoSize = true;
            this.lblFechaCarga.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCarga.Location = new System.Drawing.Point(255, 215);
            this.lblFechaCarga.Name = "lblFechaCarga";
            this.lblFechaCarga.Size = new System.Drawing.Size(92, 16);
            this.lblFechaCarga.TabIndex = 153;
            this.lblFechaCarga.Text = "Fecha Compra";
            // 
            // dtpFechaCompra
            // 
            this.dtpFechaCompra.CustomFormat = "MMMM dd, yyyy  |  hh:mm:ss tt";
            this.dtpFechaCompra.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaCompra.Location = new System.Drawing.Point(361, 209);
            this.dtpFechaCompra.Name = "dtpFechaCompra";
            this.dtpFechaCompra.Size = new System.Drawing.Size(289, 22);
            this.dtpFechaCompra.TabIndex = 152;
            // 
            // txtTipoGasto
            // 
            this.txtTipoGasto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoGasto.Location = new System.Drawing.Point(361, 95);
            this.txtTipoGasto.MaxLength = 50;
            this.txtTipoGasto.Name = "txtTipoGasto";
            this.txtTipoGasto.Size = new System.Drawing.Size(218, 22);
            this.txtTipoGasto.TabIndex = 147;
            // 
            // lblTipoServicio
            // 
            this.lblTipoServicio.AutoSize = true;
            this.lblTipoServicio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoServicio.Location = new System.Drawing.Point(247, 95);
            this.lblTipoServicio.Name = "lblTipoServicio";
            this.lblTipoServicio.Size = new System.Drawing.Size(88, 16);
            this.lblTipoServicio.TabIndex = 146;
            this.lblTipoServicio.Text = "Tipo de Gasto";
            // 
            // lblRemision
            // 
            this.lblRemision.AutoSize = true;
            this.lblRemision.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemision.Location = new System.Drawing.Point(247, 171);
            this.lblRemision.Name = "lblRemision";
            this.lblRemision.Size = new System.Drawing.Size(100, 16);
            this.lblRemision.TabIndex = 150;
            this.lblRemision.Text = "Numero Factura";
            // 
            // txtGarantia
            // 
            this.txtGarantia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGarantia.Location = new System.Drawing.Point(361, 130);
            this.txtGarantia.MaxLength = 30;
            this.txtGarantia.Name = "txtGarantia";
            this.txtGarantia.Size = new System.Drawing.Size(218, 22);
            this.txtGarantia.TabIndex = 149;
            // 
            // lblCaja
            // 
            this.lblCaja.AutoSize = true;
            this.lblCaja.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaja.Location = new System.Drawing.Point(247, 133);
            this.lblCaja.Name = "lblCaja";
            this.lblCaja.Size = new System.Drawing.Size(56, 16);
            this.lblCaja.TabIndex = 148;
            this.lblCaja.Text = "Garantia";
            // 
            // txtNoFactura
            // 
            this.txtNoFactura.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoFactura.Location = new System.Drawing.Point(361, 168);
            this.txtNoFactura.MaxLength = 45;
            this.txtNoFactura.Name = "txtNoFactura";
            this.txtNoFactura.Size = new System.Drawing.Size(218, 22);
            this.txtNoFactura.TabIndex = 151;
            // 
            // AgregarPag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1380, 472);
            this.Controls.Add(this.rtxtDemora);
            this.Controls.Add(this.lblDemora);
            this.Controls.Add(this.cboUnidades);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblPrecioDolares);
            this.Controls.Add(this.txtImpuestos);
            this.Controls.Add(this.lblPrecioPesos);
            this.Controls.Add(this.lblFechaCarga);
            this.Controls.Add(this.dtpFechaCompra);
            this.Controls.Add(this.txtTipoGasto);
            this.Controls.Add(this.lblTipoServicio);
            this.Controls.Add(this.lblRemision);
            this.Controls.Add(this.txtGarantia);
            this.Controls.Add(this.lblCaja);
            this.Controls.Add(this.txtNoFactura);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarPag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarPag";
            this.Load += new System.EventHandler(this.AgregarPag_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RichTextBox rtxtDemora;
        private System.Windows.Forms.Label lblDemora;
        private System.Windows.Forms.ComboBox cboUnidades;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblPrecioDolares;
        private System.Windows.Forms.TextBox txtImpuestos;
        private System.Windows.Forms.Label lblPrecioPesos;
        private System.Windows.Forms.Label lblFechaCarga;
        private System.Windows.Forms.DateTimePicker dtpFechaCompra;
        private System.Windows.Forms.TextBox txtTipoGasto;
        private System.Windows.Forms.Label lblTipoServicio;
        private System.Windows.Forms.Label lblRemision;
        private System.Windows.Forms.TextBox txtGarantia;
        private System.Windows.Forms.Label lblCaja;
        private System.Windows.Forms.TextBox txtNoFactura;
    }
}