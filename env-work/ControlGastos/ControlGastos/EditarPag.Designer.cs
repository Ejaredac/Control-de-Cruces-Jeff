
namespace ControlGastos
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
            this.txtCodigoGasto = new System.Windows.Forms.TextBox();
            this.lblCodigoCruce = new System.Windows.Forms.Label();
            this.lblCaja = new System.Windows.Forms.Label();
            this.txtNoFactura = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(534, 352);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 125;
            this.btnEditar.Text = "EditarCruce";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // rtxtDemora
            // 
            this.rtxtDemora.Location = new System.Drawing.Point(693, 168);
            this.rtxtDemora.MaxLength = 120;
            this.rtxtDemora.Name = "rtxtDemora";
            this.rtxtDemora.Size = new System.Drawing.Size(233, 88);
            this.rtxtDemora.TabIndex = 143;
            this.rtxtDemora.Text = "";
            // 
            // lblDemora
            // 
            this.lblDemora.AutoSize = true;
            this.lblDemora.Location = new System.Drawing.Point(631, 187);
            this.lblDemora.Name = "lblDemora";
            this.lblDemora.Size = new System.Drawing.Size(44, 13);
            this.lblDemora.TabIndex = 142;
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
            this.cboUnidades.Location = new System.Drawing.Point(693, 125);
            this.cboUnidades.Name = "cboUnidades";
            this.cboUnidades.Size = new System.Drawing.Size(121, 24);
            this.cboUnidades.TabIndex = 141;
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidad.Location = new System.Drawing.Point(631, 133);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(47, 16);
            this.lblUnidad.TabIndex = 140;
            this.lblUnidad.Text = "Unidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(693, 88);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(149, 22);
            this.txtCantidad.TabIndex = 139;
            this.txtCantidad.Text = "0";
            // 
            // lblPrecioDolares
            // 
            this.lblPrecioDolares.AutoSize = true;
            this.lblPrecioDolares.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioDolares.Location = new System.Drawing.Point(620, 91);
            this.lblPrecioDolares.Name = "lblPrecioDolares";
            this.lblPrecioDolares.Size = new System.Drawing.Size(58, 16);
            this.lblPrecioDolares.TabIndex = 138;
            this.lblPrecioDolares.Text = "Cantidad";
            // 
            // txtImpuestos
            // 
            this.txtImpuestos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpuestos.Location = new System.Drawing.Point(693, 54);
            this.txtImpuestos.Name = "txtImpuestos";
            this.txtImpuestos.Size = new System.Drawing.Size(149, 22);
            this.txtImpuestos.TabIndex = 137;
            this.txtImpuestos.Text = "0";
            // 
            // lblPrecioPesos
            // 
            this.lblPrecioPesos.AutoSize = true;
            this.lblPrecioPesos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioPesos.Location = new System.Drawing.Point(611, 54);
            this.lblPrecioPesos.Name = "lblPrecioPesos";
            this.lblPrecioPesos.Size = new System.Drawing.Size(67, 16);
            this.lblPrecioPesos.TabIndex = 136;
            this.lblPrecioPesos.Text = "Impuestos";
            // 
            // lblFechaCarga
            // 
            this.lblFechaCarga.AutoSize = true;
            this.lblFechaCarga.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCarga.Location = new System.Drawing.Point(217, 212);
            this.lblFechaCarga.Name = "lblFechaCarga";
            this.lblFechaCarga.Size = new System.Drawing.Size(92, 16);
            this.lblFechaCarga.TabIndex = 135;
            this.lblFechaCarga.Text = "Fecha Compra";
            // 
            // dtpFechaCompra
            // 
            this.dtpFechaCompra.CustomFormat = "MMMM dd, yyyy  |  hh:mm:ss tt";
            this.dtpFechaCompra.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaCompra.Location = new System.Drawing.Point(323, 206);
            this.dtpFechaCompra.Name = "dtpFechaCompra";
            this.dtpFechaCompra.Size = new System.Drawing.Size(289, 22);
            this.dtpFechaCompra.TabIndex = 134;
            // 
            // txtTipoGasto
            // 
            this.txtTipoGasto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoGasto.Location = new System.Drawing.Point(323, 92);
            this.txtTipoGasto.MaxLength = 50;
            this.txtTipoGasto.Name = "txtTipoGasto";
            this.txtTipoGasto.Size = new System.Drawing.Size(218, 22);
            this.txtTipoGasto.TabIndex = 129;
            // 
            // lblTipoServicio
            // 
            this.lblTipoServicio.AutoSize = true;
            this.lblTipoServicio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoServicio.Location = new System.Drawing.Point(209, 92);
            this.lblTipoServicio.Name = "lblTipoServicio";
            this.lblTipoServicio.Size = new System.Drawing.Size(88, 16);
            this.lblTipoServicio.TabIndex = 128;
            this.lblTipoServicio.Text = "Tipo de Gasto";
            // 
            // lblRemision
            // 
            this.lblRemision.AutoSize = true;
            this.lblRemision.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemision.Location = new System.Drawing.Point(209, 168);
            this.lblRemision.Name = "lblRemision";
            this.lblRemision.Size = new System.Drawing.Size(100, 16);
            this.lblRemision.TabIndex = 132;
            this.lblRemision.Text = "Numero Factura";
            // 
            // txtGarantia
            // 
            this.txtGarantia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGarantia.Location = new System.Drawing.Point(323, 127);
            this.txtGarantia.MaxLength = 30;
            this.txtGarantia.Name = "txtGarantia";
            this.txtGarantia.Size = new System.Drawing.Size(218, 22);
            this.txtGarantia.TabIndex = 131;
            // 
            // txtCodigoGasto
            // 
            this.txtCodigoGasto.Enabled = false;
            this.txtCodigoGasto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoGasto.Location = new System.Drawing.Point(323, 54);
            this.txtCodigoGasto.Name = "txtCodigoGasto";
            this.txtCodigoGasto.ReadOnly = true;
            this.txtCodigoGasto.Size = new System.Drawing.Size(218, 22);
            this.txtCodigoGasto.TabIndex = 127;
            // 
            // lblCodigoCruce
            // 
            this.lblCodigoCruce.AutoSize = true;
            this.lblCodigoCruce.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCruce.Location = new System.Drawing.Point(209, 54);
            this.lblCodigoCruce.Name = "lblCodigoCruce";
            this.lblCodigoCruce.Size = new System.Drawing.Size(104, 16);
            this.lblCodigoCruce.TabIndex = 126;
            this.lblCodigoCruce.Text = "Codigo de Gasto";
            // 
            // lblCaja
            // 
            this.lblCaja.AutoSize = true;
            this.lblCaja.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaja.Location = new System.Drawing.Point(209, 130);
            this.lblCaja.Name = "lblCaja";
            this.lblCaja.Size = new System.Drawing.Size(56, 16);
            this.lblCaja.TabIndex = 130;
            this.lblCaja.Text = "Garantia";
            // 
            // txtNoFactura
            // 
            this.txtNoFactura.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoFactura.Location = new System.Drawing.Point(323, 165);
            this.txtNoFactura.MaxLength = 45;
            this.txtNoFactura.Name = "txtNoFactura";
            this.txtNoFactura.Size = new System.Drawing.Size(218, 22);
            this.txtNoFactura.TabIndex = 133;
            // 
            // EditarPag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1378, 401);
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
            this.Controls.Add(this.txtCodigoGasto);
            this.Controls.Add(this.lblCodigoCruce);
            this.Controls.Add(this.lblCaja);
            this.Controls.Add(this.txtNoFactura);
            this.Controls.Add(this.btnEditar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarPag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarPag";
            this.Load += new System.EventHandler(this.EditarPag_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
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
        private System.Windows.Forms.TextBox txtCodigoGasto;
        private System.Windows.Forms.Label lblCodigoCruce;
        private System.Windows.Forms.Label lblCaja;
        private System.Windows.Forms.TextBox txtNoFactura;
    }
}