
namespace ControlGastos
{
    partial class ContrasenaPag
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
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.btnContrasenaAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Location = new System.Drawing.Point(12, 79);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(61, 13);
            this.lblContrasena.TabIndex = 0;
            this.lblContrasena.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(95, 71);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(204, 20);
            this.txtContrasena.TabIndex = 1;
            // 
            // btnContrasenaAceptar
            // 
            this.btnContrasenaAceptar.Location = new System.Drawing.Point(133, 125);
            this.btnContrasenaAceptar.Name = "btnContrasenaAceptar";
            this.btnContrasenaAceptar.Size = new System.Drawing.Size(110, 23);
            this.btnContrasenaAceptar.TabIndex = 2;
            this.btnContrasenaAceptar.Text = "Ingresar Contraseña";
            this.btnContrasenaAceptar.UseVisualStyleBackColor = true;
            this.btnContrasenaAceptar.Click += new System.EventHandler(this.btnContrasenaAceptar_Click);
            // 
            // ContrasenaPag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 196);
            this.Controls.Add(this.btnContrasenaAceptar);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.lblContrasena);
            this.Name = "ContrasenaPag";
            this.Text = "Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnContrasenaAceptar;
    }
}