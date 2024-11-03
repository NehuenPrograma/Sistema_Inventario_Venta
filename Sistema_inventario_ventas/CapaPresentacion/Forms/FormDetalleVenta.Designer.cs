
namespace CapaPresentacion.Forms
{
    partial class FormDetalleVenta
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
            this.lblNumBoleta = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.txtNumeroCompra = new System.Windows.Forms.TextBox();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.txtNumDocProveedor = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.gbInformacionCliente = new System.Windows.Forms.GroupBox();
            this.gbInformacionVenta = new System.Windows.Forms.GroupBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtTipoDocumento = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.btnNuevaCompra = new FontAwesome.Sharp.IconButton();
            this.txtTotalCompra = new System.Windows.Forms.TextBox();
            this.btnDescargarPDF = new FontAwesome.Sharp.IconButton();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.gbInformacionCliente.SuspendLayout();
            this.gbInformacionVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumBoleta
            // 
            this.lblNumBoleta.AutoSize = true;
            this.lblNumBoleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumBoleta.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNumBoleta.Location = new System.Drawing.Point(316, 22);
            this.lblNumBoleta.Name = "lblNumBoleta";
            this.lblNumBoleta.Size = new System.Drawing.Size(89, 13);
            this.lblNumBoleta.TabIndex = 15;
            this.lblNumBoleta.Text = "Número Compra :";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNombreCliente.Location = new System.Drawing.Point(168, 22);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(76, 13);
            this.lblNombreCliente.TabIndex = 14;
            this.lblNombreCliente.Text = "Razón Social :";
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDocumento.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNumeroDocumento.Location = new System.Drawing.Point(20, 22);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(108, 13);
            this.lblNumeroDocumento.TabIndex = 13;
            this.lblNumeroDocumento.Text = "Número Documento :";
            // 
            // txtNumeroCompra
            // 
            this.txtNumeroCompra.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNumeroCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCompra.Location = new System.Drawing.Point(316, 38);
            this.txtNumeroCompra.Name = "txtNumeroCompra";
            this.txtNumeroCompra.ReadOnly = true;
            this.txtNumeroCompra.Size = new System.Drawing.Size(96, 20);
            this.txtNumeroCompra.TabIndex = 12;
            this.txtNumeroCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNombreProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProveedor.Location = new System.Drawing.Point(168, 38);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.ReadOnly = true;
            this.txtNombreProveedor.Size = new System.Drawing.Size(128, 20);
            this.txtNombreProveedor.TabIndex = 11;
            this.txtNombreProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumDocProveedor
            // 
            this.txtNumDocProveedor.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNumDocProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumDocProveedor.Location = new System.Drawing.Point(20, 38);
            this.txtNumDocProveedor.Name = "txtNumDocProveedor";
            this.txtNumDocProveedor.ReadOnly = true;
            this.txtNumDocProveedor.Size = new System.Drawing.Size(128, 20);
            this.txtNumDocProveedor.TabIndex = 10;
            this.txtNumDocProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUsuario.Location = new System.Drawing.Point(311, 22);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(49, 13);
            this.lblUsuario.TabIndex = 15;
            this.lblUsuario.Text = "Usuario :";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDoc.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTipoDoc.Location = new System.Drawing.Point(163, 22);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(92, 13);
            this.lblTipoDoc.TabIndex = 14;
            this.lblTipoDoc.Text = "Tipo Documento :";
            // 
            // gbInformacionCliente
            // 
            this.gbInformacionCliente.Controls.Add(this.lblNumBoleta);
            this.gbInformacionCliente.Controls.Add(this.lblNombreCliente);
            this.gbInformacionCliente.Controls.Add(this.lblNumeroDocumento);
            this.gbInformacionCliente.Controls.Add(this.txtNumeroCompra);
            this.gbInformacionCliente.Controls.Add(this.txtNombreProveedor);
            this.gbInformacionCliente.Controls.Add(this.txtNumDocProveedor);
            this.gbInformacionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionCliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbInformacionCliente.Location = new System.Drawing.Point(477, 24);
            this.gbInformacionCliente.Name = "gbInformacionCliente";
            this.gbInformacionCliente.Size = new System.Drawing.Size(465, 80);
            this.gbInformacionCliente.TabIndex = 22;
            this.gbInformacionCliente.TabStop = false;
            this.gbInformacionCliente.Text = "Información Cliente";
            // 
            // gbInformacionVenta
            // 
            this.gbInformacionVenta.Controls.Add(this.lblUsuario);
            this.gbInformacionVenta.Controls.Add(this.lblTipoDoc);
            this.gbInformacionVenta.Controls.Add(this.lblFecha);
            this.gbInformacionVenta.Controls.Add(this.txtUsuario);
            this.gbInformacionVenta.Controls.Add(this.txtTipoDocumento);
            this.gbInformacionVenta.Controls.Add(this.txtFecha);
            this.gbInformacionVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionVenta.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbInformacionVenta.Location = new System.Drawing.Point(13, 24);
            this.gbInformacionVenta.Name = "gbInformacionVenta";
            this.gbInformacionVenta.Size = new System.Drawing.Size(455, 80);
            this.gbInformacionVenta.TabIndex = 21;
            this.gbInformacionVenta.TabStop = false;
            this.gbInformacionVenta.Text = "Información Venta";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFecha.Location = new System.Drawing.Point(15, 22);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(43, 13);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "Fecha :";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(311, 38);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(128, 20);
            this.txtUsuario.TabIndex = 12;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTipoDocumento
            // 
            this.txtTipoDocumento.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoDocumento.Location = new System.Drawing.Point(163, 38);
            this.txtTipoDocumento.Name = "txtTipoDocumento";
            this.txtTipoDocumento.ReadOnly = true;
            this.txtTipoDocumento.Size = new System.Drawing.Size(128, 20);
            this.txtTipoDocumento.TabIndex = 11;
            this.txtTipoDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.Color.Gainsboro;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(15, 38);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(128, 20);
            this.txtFecha.TabIndex = 10;
            this.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnNuevaCompra
            // 
            this.btnNuevaCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(123)))), ((int)(((byte)(19)))));
            this.btnNuevaCompra.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            this.btnNuevaCompra.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(156)))), ((int)(((byte)(24)))));
            this.btnNuevaCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevaCompra.IconSize = 17;
            this.btnNuevaCompra.Location = new System.Drawing.Point(796, 448);
            this.btnNuevaCompra.Name = "btnNuevaCompra";
            this.btnNuevaCompra.Size = new System.Drawing.Size(129, 35);
            this.btnNuevaCompra.TabIndex = 27;
            this.btnNuevaCompra.Text = "  Nueva Venta";
            this.btnNuevaCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNuevaCompra.UseVisualStyleBackColor = true;
            // 
            // txtTotalCompra
            // 
            this.txtTotalCompra.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTotalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCompra.Location = new System.Drawing.Point(804, 262);
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.ReadOnly = true;
            this.txtTotalCompra.Size = new System.Drawing.Size(107, 20);
            this.txtTotalCompra.TabIndex = 26;
            this.txtTotalCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDescargarPDF
            // 
            this.btnDescargarPDF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(123)))), ((int)(((byte)(19)))));
            this.btnDescargarPDF.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            this.btnDescargarPDF.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(156)))), ((int)(((byte)(24)))));
            this.btnDescargarPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDescargarPDF.IconSize = 17;
            this.btnDescargarPDF.Location = new System.Drawing.Point(796, 333);
            this.btnDescargarPDF.Name = "btnDescargarPDF";
            this.btnDescargarPDF.Size = new System.Drawing.Size(129, 35);
            this.btnDescargarPDF.TabIndex = 25;
            this.btnDescargarPDF.Text = "Descargar PDF";
            this.btnDescargarPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDescargarPDF.UseVisualStyleBackColor = true;
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotal.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblMontoTotal.Location = new System.Drawing.Point(822, 243);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(70, 13);
            this.lblMontoTotal.TabIndex = 24;
            this.lblMontoTotal.Text = "Monto Total :";
            // 
            // dgvDetalleVenta
            // 
            this.dgvDetalleVenta.AllowUserToAddRows = false;
            this.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvDetalleVenta.Location = new System.Drawing.Point(13, 110);
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.ReadOnly = true;
            this.dgvDetalleVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleVenta.Size = new System.Drawing.Size(772, 378);
            this.dgvDetalleVenta.TabIndex = 23;
            // 
            // btnBuscar
            // 
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(123)))), ((int)(((byte)(19)))));
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(156)))), ((int)(((byte)(24)))));
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 15;
            this.btnBuscar.Location = new System.Drawing.Point(796, 140);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(129, 38);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "   Buscar Venta";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // FormDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(955, 512);
            this.Controls.Add(this.gbInformacionCliente);
            this.Controls.Add(this.gbInformacionVenta);
            this.Controls.Add(this.btnNuevaCompra);
            this.Controls.Add(this.txtTotalCompra);
            this.Controls.Add(this.btnDescargarPDF);
            this.Controls.Add(this.lblMontoTotal);
            this.Controls.Add(this.dgvDetalleVenta);
            this.Controls.Add(this.btnBuscar);
            this.Name = "FormDetalleVenta";
            this.Text = "FormDetalleVenta";
            this.gbInformacionCliente.ResumeLayout(false);
            this.gbInformacionCliente.PerformLayout();
            this.gbInformacionVenta.ResumeLayout(false);
            this.gbInformacionVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumBoleta;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblNumeroDocumento;
        private System.Windows.Forms.TextBox txtNumeroCompra;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.TextBox txtNumDocProveedor;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.GroupBox gbInformacionCliente;
        private System.Windows.Forms.GroupBox gbInformacionVenta;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtTipoDocumento;
        private System.Windows.Forms.TextBox txtFecha;
        private FontAwesome.Sharp.IconButton btnNuevaCompra;
        private System.Windows.Forms.TextBox txtTotalCompra;
        private FontAwesome.Sharp.IconButton btnDescargarPDF;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.DataGridView dgvDetalleVenta;
        private FontAwesome.Sharp.IconButton btnBuscar;
    }
}