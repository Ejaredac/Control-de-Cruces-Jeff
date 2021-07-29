
namespace Formulario_Cruces_JEFF
{
    partial class ConexionRemotaFormulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConexionRemotaFormulario));
            this.lblBDA = new System.Windows.Forms.Label();
            this.lblPuerto = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.lblServidor = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtBDA = new System.Windows.Forms.TextBox();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtServidorRuta = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblIndicacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBDA
            // 
            this.lblBDA.AutoSize = true;
            this.lblBDA.Location = new System.Drawing.Point(53, 31);
            this.lblBDA.Name = "lblBDA";
            this.lblBDA.Size = new System.Drawing.Size(170, 13);
            this.lblBDA.TabIndex = 0;
            this.lblBDA.Text = "Base de Datos (Nombre Esquema)";
            // 
            // lblPuerto
            // 
            this.lblPuerto.AutoSize = true;
            this.lblPuerto.Location = new System.Drawing.Point(53, 62);
            this.lblPuerto.Name = "lblPuerto";
            this.lblPuerto.Size = new System.Drawing.Size(38, 13);
            this.lblPuerto.TabIndex = 0;
            this.lblPuerto.Text = "Puerto";
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Location = new System.Drawing.Point(53, 94);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(61, 13);
            this.lblContrasena.TabIndex = 0;
            this.lblContrasena.Text = "Contraseña";
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Location = new System.Drawing.Point(53, 160);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(78, 13);
            this.lblServidor.TabIndex = 0;
            this.lblServidor.Text = "Servidor (Ruta)";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(53, 127);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtBDA
            // 
            this.txtBDA.Location = new System.Drawing.Point(242, 31);
            this.txtBDA.Name = "txtBDA";
            this.txtBDA.Size = new System.Drawing.Size(124, 20);
            this.txtBDA.TabIndex = 1;
            this.txtBDA.Text = "crucesjeffbd";
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(125, 59);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(124, 20);
            this.txtPuerto.TabIndex = 1;
            this.txtPuerto.Text = "3306";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(125, 91);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(124, 20);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.Text = "INseCt0z26";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(115, 124);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '*';
            this.txtUsuario.Size = new System.Drawing.Size(124, 20);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "Nano_Excalibur";
            // 
            // txtServidorRuta
            // 
            this.txtServidorRuta.Location = new System.Drawing.Point(152, 157);
            this.txtServidorRuta.Name = "txtServidorRuta";
            this.txtServidorRuta.Size = new System.Drawing.Size(124, 20);
            this.txtServidorRuta.TabIndex = 1;
            this.txtServidorRuta.Text = "192.168.0.18";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(56, 243);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(201, 243);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(264, 199);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(62, 13);
            this.lblIP.TabIndex = 3;
            this.lblIP.Text = "IP ACTUAL";
            // 
            // lblIndicacion
            // 
            this.lblIndicacion.AutoSize = true;
            this.lblIndicacion.Location = new System.Drawing.Point(130, 199);
            this.lblIndicacion.Name = "lblIndicacion";
            this.lblIndicacion.Size = new System.Drawing.Size(128, 13);
            this.lblIndicacion.TabIndex = 4;
            this.lblIndicacion.Text = "Direccion de este equipo:";
            // 
            // ConexionRemotaFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 299);
            this.Controls.Add(this.lblIndicacion);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtServidorRuta);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.txtBDA);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblServidor);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.lblPuerto);
            this.Controls.Add(this.lblBDA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConexionRemotaFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conexion remota";
            this.Load += new System.EventHandler(this.ConexionRemotaFormulario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBDA;
        private System.Windows.Forms.Label lblPuerto;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtBDA;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtServidorRuta;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblIndicacion;
    }
}