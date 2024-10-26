
namespace CapaPresentacion.Forms
{
    partial class FormDetalleCompra
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
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.cboFiltro = new System.Windows.Forms.ComboBox();
            this.gbInformacionCompra = new System.Windows.Forms.GroupBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtTipoDocumento = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.gbInformacionProveedor = new System.Windows.Forms.GroupBox();
            this.lblNumBoleta = new System.Windows.Forms.Label();
            this.lblNombreProveedor = new System.Windows.Forms.Label();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.txtNumeroCompra = new System.Windows.Forms.TextBox();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.txtNumDocProveedor = new System.Windows.Forms.TextBox();
            this.dgvDetalleCompra = new System.Windows.Forms.DataGridView();
            this.txtTotalCompra = new System.Windows.Forms.TextBox();
            this.btnDescargarPDF = new FontAwesome.Sharp.IconButton();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.btnNuevaCompra = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.gbInformacionCompra.SuspendLayout();
            this.gbInformacionProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(36)))), ((int)(((byte)(191)))));
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 15;
            this.btnBuscar.Location = new System.Drawing.Point(304, 29);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(33, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtFiltro
            // 
            this.txtFiltro.BackColor = System.Drawing.Color.Gainsboro;
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(166, 31);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(128, 20);
            this.txtFiltro.TabIndex = 9;
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPor.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblBuscarPor.Location = new System.Drawing.Point(21, 16);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(64, 13);
            this.lblBuscarPor.TabIndex = 8;
            this.lblBuscarPor.Text = "Buscar por :";
            // 
            // cboFiltro
            // 
            this.cboFiltro.BackColor = System.Drawing.Color.Gainsboro;
            this.cboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFiltro.FormattingEnabled = true;
            this.cboFiltro.Location = new System.Drawing.Point(23, 31);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(130, 21);
            this.cboFiltro.TabIndex = 11;
            // 
            // gbInformacionCompra
            // 
            this.gbInformacionCompra.Controls.Add(this.lblUsuario);
            this.gbInformacionCompra.Controls.Add(this.lblTipoDoc);
            this.gbInformacionCompra.Controls.Add(this.lblFecha);
            this.gbInformacionCompra.Controls.Add(this.txtUsuario);
            this.gbInformacionCompra.Controls.Add(this.txtTipoDocumento);
            this.gbInformacionCompra.Controls.Add(this.txtFecha);
            this.gbInformacionCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionCompra.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbInformacionCompra.Location = new System.Drawing.Point(24, 72);
            this.gbInformacionCompra.Name = "gbInformacionCompra";
            this.gbInformacionCompra.Size = new System.Drawing.Size(455, 80);
            this.gbInformacionCompra.TabIndex = 12;
            this.gbInformacionCompra.TabStop = false;
            this.gbInformacionCompra.Text = "Información Compra";
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
            // 
            // gbInformacionProveedor
            // 
            this.gbInformacionProveedor.Controls.Add(this.lblNumBoleta);
            this.gbInformacionProveedor.Controls.Add(this.lblNombreProveedor);
            this.gbInformacionProveedor.Controls.Add(this.lblNumeroDocumento);
            this.gbInformacionProveedor.Controls.Add(this.txtNumeroCompra);
            this.gbInformacionProveedor.Controls.Add(this.txtNombreProveedor);
            this.gbInformacionProveedor.Controls.Add(this.txtNumDocProveedor);
            this.gbInformacionProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionProveedor.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbInformacionProveedor.Location = new System.Drawing.Point(488, 72);
            this.gbInformacionProveedor.Name = "gbInformacionProveedor";
            this.gbInformacionProveedor.Size = new System.Drawing.Size(465, 80);
            this.gbInformacionProveedor.TabIndex = 13;
            this.gbInformacionProveedor.TabStop = false;
            this.gbInformacionProveedor.Text = "Información Proveedor";
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
            // lblNombreProveedor
            // 
            this.lblNombreProveedor.AutoSize = true;
            this.lblNombreProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProveedor.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNombreProveedor.Location = new System.Drawing.Point(168, 22);
            this.lblNombreProveedor.Name = "lblNombreProveedor";
            this.lblNombreProveedor.Size = new System.Drawing.Size(76, 13);
            this.lblNombreProveedor.TabIndex = 14;
            this.lblNombreProveedor.Text = "Razón Social :";
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
            // 
            // dgvDetalleCompra
            // 
            this.dgvDetalleCompra.AllowUserToAddRows = false;
            this.dgvDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvDetalleCompra.Location = new System.Drawing.Point(24, 158);
            this.dgvDetalleCompra.Name = "dgvDetalleCompra";
            this.dgvDetalleCompra.ReadOnly = true;
            this.dgvDetalleCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleCompra.Size = new System.Drawing.Size(772, 321);
            this.dgvDetalleCompra.TabIndex = 14;
            // 
            // txtTotalCompra
            // 
            this.txtTotalCompra.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTotalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCompra.Location = new System.Drawing.Point(815, 215);
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.ReadOnly = true;
            this.txtTotalCompra.Size = new System.Drawing.Size(107, 20);
            this.txtTotalCompra.TabIndex = 18;
            this.txtTotalCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDescargarPDF
            // 
            this.btnDescargarPDF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(36)))), ((int)(((byte)(191)))));
            this.btnDescargarPDF.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            this.btnDescargarPDF.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnDescargarPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDescargarPDF.IconSize = 17;
            this.btnDescargarPDF.Location = new System.Drawing.Point(807, 324);
            this.btnDescargarPDF.Name = "btnDescargarPDF";
            this.btnDescargarPDF.Size = new System.Drawing.Size(129, 35);
            this.btnDescargarPDF.TabIndex = 17;
            this.btnDescargarPDF.Text = "Descargar PDF";
            this.btnDescargarPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDescargarPDF.UseVisualStyleBackColor = true;
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotal.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblMontoTotal.Location = new System.Drawing.Point(833, 196);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(70, 13);
            this.lblMontoTotal.TabIndex = 16;
            this.lblMontoTotal.Text = "Monto Total :";
            // 
            // btnNuevaCompra
            // 
            this.btnNuevaCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(36)))), ((int)(((byte)(191)))));
            this.btnNuevaCompra.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            this.btnNuevaCompra.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnNuevaCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevaCompra.IconSize = 17;
            this.btnNuevaCompra.Location = new System.Drawing.Point(807, 439);
            this.btnNuevaCompra.Name = "btnNuevaCompra";
            this.btnNuevaCompra.Size = new System.Drawing.Size(129, 35);
            this.btnNuevaCompra.TabIndex = 19;
            this.btnNuevaCompra.Text = "Nueva Compra";
            this.btnNuevaCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNuevaCompra.UseVisualStyleBackColor = true;
            this.btnNuevaCompra.Click += new System.EventHandler(this.btnNuevaCompra_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(36)))), ((int)(((byte)(191)))));
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 15;
            this.btnLimpiar.Location = new System.Drawing.Point(343, 29);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(33, 23);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // FormDetalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(955, 512);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnNuevaCompra);
            this.Controls.Add(this.txtTotalCompra);
            this.Controls.Add(this.btnDescargarPDF);
            this.Controls.Add(this.lblMontoTotal);
            this.Controls.Add(this.dgvDetalleCompra);
            this.Controls.Add(this.gbInformacionProveedor);
            this.Controls.Add(this.gbInformacionCompra);
            this.Controls.Add(this.cboFiltro);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblBuscarPor);
            this.Name = "FormDetalleCompra";
            this.Text = "Historial de compras";
            this.gbInformacionCompra.ResumeLayout(false);
            this.gbInformacionCompra.PerformLayout();
            this.gbInformacionProveedor.ResumeLayout(false);
            this.gbInformacionProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.ComboBox cboFiltro;
        private System.Windows.Forms.GroupBox gbInformacionCompra;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtTipoDocumento;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.GroupBox gbInformacionProveedor;
        private System.Windows.Forms.Label lblNombreProveedor;
        private System.Windows.Forms.Label lblNumeroDocumento;
        private System.Windows.Forms.TextBox txtNumeroCompra;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.TextBox txtNumDocProveedor;
        private System.Windows.Forms.Label lblNumBoleta;
        private System.Windows.Forms.DataGridView dgvDetalleCompra;
        private System.Windows.Forms.TextBox txtTotalCompra;
        private FontAwesome.Sharp.IconButton btnDescargarPDF;
        private System.Windows.Forms.Label lblMontoTotal;
        private FontAwesome.Sharp.IconButton btnNuevaCompra;
        private FontAwesome.Sharp.IconButton btnLimpiar;
    }
}