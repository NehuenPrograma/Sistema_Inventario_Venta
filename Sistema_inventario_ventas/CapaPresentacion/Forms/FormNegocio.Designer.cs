
namespace CapaPresentacion.Forms
{
    partial class FormNegocio
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.lblRUC = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.btnAgregarLogo = new FontAwesome.Sharp.IconButton();
            this.btnAceptar = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNombre.Location = new System.Drawing.Point(319, 66);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre :";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNombre.Location = new System.Drawing.Point(381, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(94, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(89, 54);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(194, 194);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // txtRUC
            // 
            this.txtRUC.BackColor = System.Drawing.Color.Gainsboro;
            this.txtRUC.Location = new System.Drawing.Point(381, 134);
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(117, 20);
            this.txtRUC.TabIndex = 4;
            this.txtRUC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblRUC
            // 
            this.lblRUC.AutoSize = true;
            this.lblRUC.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblRUC.Location = new System.Drawing.Point(333, 137);
            this.lblRUC.Name = "lblRUC";
            this.lblRUC.Size = new System.Drawing.Size(38, 13);
            this.lblRUC.TabIndex = 3;
            this.lblRUC.Text = "CUIT :";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDireccion.Location = new System.Drawing.Point(381, 205);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(174, 20);
            this.txtDireccion.TabIndex = 6;
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDireccion.Location = new System.Drawing.Point(311, 208);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(58, 13);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Direccion :";
            // 
            // btnAgregarLogo
            // 
            this.btnAgregarLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(158)))), ((int)(((byte)(0)))));
            this.btnAgregarLogo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregarLogo.IconColor = System.Drawing.Color.Black;
            this.btnAgregarLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarLogo.Location = new System.Drawing.Point(89, 278);
            this.btnAgregarLogo.Name = "btnAgregarLogo";
            this.btnAgregarLogo.Size = new System.Drawing.Size(107, 23);
            this.btnAgregarLogo.TabIndex = 8;
            this.btnAgregarLogo.Text = "Agregar Logo";
            this.btnAgregarLogo.UseVisualStyleBackColor = true;
            this.btnAgregarLogo.Click += new System.EventHandler(this.btnAgregarLogo_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(158)))), ((int)(((byte)(0)))));
            this.btnAceptar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAceptar.IconColor = System.Drawing.Color.Black;
            this.btnAceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAceptar.Location = new System.Drawing.Point(381, 278);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbLogo);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.btnAgregarLogo);
            this.groupBox1.Controls.Add(this.lblDireccion);
            this.groupBox1.Controls.Add(this.txtRUC);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblRUC);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(60, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 333);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // FormNegocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(955, 512);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormNegocio";
            this.Text = "Negocio";
            this.Load += new System.EventHandler(this.FormNegocio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TextBox txtRUC;
        private System.Windows.Forms.Label lblRUC;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private FontAwesome.Sharp.IconButton btnAgregarLogo;
        private FontAwesome.Sharp.IconButton btnAceptar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}