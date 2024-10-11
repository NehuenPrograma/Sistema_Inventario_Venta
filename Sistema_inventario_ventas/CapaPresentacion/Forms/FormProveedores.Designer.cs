
namespace CapaPresentacion.Forms
{
    partial class FormProveedores
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
            this.lblClaveProveedor = new System.Windows.Forms.Label();
            this.lblCorreoProveedor = new System.Windows.Forms.Label();
            this.dgvProveedor = new System.Windows.Forms.DataGridView();
            this.lblNombreProveedor = new System.Windows.Forms.Label();
            this.pnlInfoProveedor = new System.Windows.Forms.Panel();
            this.lblDocumentoProveedor = new System.Windows.Forms.Label();
            this.btnCancelarProveedor = new FontAwesome.Sharp.IconButton();
            this.btnAceptarProveedor = new FontAwesome.Sharp.IconButton();
            this.txtTelProveedor = new System.Windows.Forms.TextBox();
            this.txtCorreoProveedor = new System.Windows.Forms.TextBox();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.txtDocumentoProveedor = new System.Windows.Forms.TextBox();
            this.btnEliminarProveedor = new FontAwesome.Sharp.IconButton();
            this.btnModificarProveedor = new FontAwesome.Sharp.IconButton();
            this.btnAgregarProveedor = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarProveedor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).BeginInit();
            this.pnlInfoProveedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClaveProveedor
            // 
            this.lblClaveProveedor.AutoSize = true;
            this.lblClaveProveedor.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblClaveProveedor.Location = new System.Drawing.Point(54, 274);
            this.lblClaveProveedor.Name = "lblClaveProveedor";
            this.lblClaveProveedor.Size = new System.Drawing.Size(28, 13);
            this.lblClaveProveedor.TabIndex = 11;
            this.lblClaveProveedor.Text = "Tel :";
            // 
            // lblCorreoProveedor
            // 
            this.lblCorreoProveedor.AutoSize = true;
            this.lblCorreoProveedor.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCorreoProveedor.Location = new System.Drawing.Point(54, 223);
            this.lblCorreoProveedor.Name = "lblCorreoProveedor";
            this.lblCorreoProveedor.Size = new System.Drawing.Size(38, 13);
            this.lblCorreoProveedor.TabIndex = 10;
            this.lblCorreoProveedor.Text = "Email :";
            // 
            // dgvProveedor
            // 
            this.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProveedor.Location = new System.Drawing.Point(26, 69);
            this.dgvProveedor.MultiSelect = false;
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedor.Size = new System.Drawing.Size(577, 343);
            this.dgvProveedor.TabIndex = 17;
            // 
            // lblNombreProveedor
            // 
            this.lblNombreProveedor.AutoSize = true;
            this.lblNombreProveedor.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNombreProveedor.Location = new System.Drawing.Point(32, 169);
            this.lblNombreProveedor.Name = "lblNombreProveedor";
            this.lblNombreProveedor.Size = new System.Drawing.Size(74, 13);
            this.lblNombreProveedor.TabIndex = 9;
            this.lblNombreProveedor.Text = "Razon social :";
            // 
            // pnlInfoProveedor
            // 
            this.pnlInfoProveedor.Controls.Add(this.lblClaveProveedor);
            this.pnlInfoProveedor.Controls.Add(this.lblCorreoProveedor);
            this.pnlInfoProveedor.Controls.Add(this.lblNombreProveedor);
            this.pnlInfoProveedor.Controls.Add(this.lblDocumentoProveedor);
            this.pnlInfoProveedor.Controls.Add(this.btnCancelarProveedor);
            this.pnlInfoProveedor.Controls.Add(this.btnAceptarProveedor);
            this.pnlInfoProveedor.Controls.Add(this.txtTelProveedor);
            this.pnlInfoProveedor.Controls.Add(this.txtCorreoProveedor);
            this.pnlInfoProveedor.Controls.Add(this.txtNombreProveedor);
            this.pnlInfoProveedor.Controls.Add(this.txtDocumentoProveedor);
            this.pnlInfoProveedor.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlInfoProveedor.Location = new System.Drawing.Point(669, 0);
            this.pnlInfoProveedor.Name = "pnlInfoProveedor";
            this.pnlInfoProveedor.Size = new System.Drawing.Size(286, 512);
            this.pnlInfoProveedor.TabIndex = 22;
            this.pnlInfoProveedor.Visible = false;
            // 
            // lblDocumentoProveedor
            // 
            this.lblDocumentoProveedor.AutoSize = true;
            this.lblDocumentoProveedor.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDocumentoProveedor.Location = new System.Drawing.Point(28, 109);
            this.lblDocumentoProveedor.Name = "lblDocumentoProveedor";
            this.lblDocumentoProveedor.Size = new System.Drawing.Size(83, 13);
            this.lblDocumentoProveedor.TabIndex = 8;
            this.lblDocumentoProveedor.Text = "N° Documento :";
            // 
            // btnCancelarProveedor
            // 
            this.btnCancelarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarProveedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnCancelarProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(113)))), ((int)(((byte)(186)))));
            this.btnCancelarProveedor.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCancelarProveedor.IconColor = System.Drawing.Color.Black;
            this.btnCancelarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarProveedor.Location = new System.Drawing.Point(172, 378);
            this.btnCancelarProveedor.Name = "btnCancelarProveedor";
            this.btnCancelarProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarProveedor.TabIndex = 12;
            this.btnCancelarProveedor.Text = "Cancelar";
            this.btnCancelarProveedor.UseVisualStyleBackColor = true;
            this.btnCancelarProveedor.Click += new System.EventHandler(this.btnCancelarProveedor_Click);
            // 
            // btnAceptarProveedor
            // 
            this.btnAceptarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptarProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(113)))), ((int)(((byte)(186)))));
            this.btnAceptarProveedor.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAceptarProveedor.IconColor = System.Drawing.Color.Black;
            this.btnAceptarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAceptarProveedor.Location = new System.Drawing.Point(54, 378);
            this.btnAceptarProveedor.Name = "btnAceptarProveedor";
            this.btnAceptarProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarProveedor.TabIndex = 11;
            this.btnAceptarProveedor.Text = "Aceptar";
            this.btnAceptarProveedor.UseVisualStyleBackColor = true;
            this.btnAceptarProveedor.Click += new System.EventHandler(this.btnAceptarProveedor_Click);
            // 
            // txtTelProveedor
            // 
            this.txtTelProveedor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTelProveedor.Location = new System.Drawing.Point(82, 293);
            this.txtTelProveedor.Name = "txtTelProveedor";
            this.txtTelProveedor.Size = new System.Drawing.Size(156, 20);
            this.txtTelProveedor.TabIndex = 9;
            // 
            // txtCorreoProveedor
            // 
            this.txtCorreoProveedor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCorreoProveedor.Location = new System.Drawing.Point(82, 239);
            this.txtCorreoProveedor.Name = "txtCorreoProveedor";
            this.txtCorreoProveedor.Size = new System.Drawing.Size(156, 20);
            this.txtCorreoProveedor.TabIndex = 8;
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNombreProveedor.Location = new System.Drawing.Point(82, 185);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(156, 20);
            this.txtNombreProveedor.TabIndex = 7;
            // 
            // txtDocumentoProveedor
            // 
            this.txtDocumentoProveedor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDocumentoProveedor.Location = new System.Drawing.Point(82, 132);
            this.txtDocumentoProveedor.Name = "txtDocumentoProveedor";
            this.txtDocumentoProveedor.Size = new System.Drawing.Size(156, 20);
            this.txtDocumentoProveedor.TabIndex = 6;
            // 
            // btnEliminarProveedor
            // 
            this.btnEliminarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarProveedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnEliminarProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(113)))), ((int)(((byte)(186)))));
            this.btnEliminarProveedor.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEliminarProveedor.IconColor = System.Drawing.Color.Black;
            this.btnEliminarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarProveedor.Location = new System.Drawing.Point(215, 445);
            this.btnEliminarProveedor.Name = "btnEliminarProveedor";
            this.btnEliminarProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarProveedor.TabIndex = 21;
            this.btnEliminarProveedor.Text = "Eliminar";
            this.btnEliminarProveedor.UseVisualStyleBackColor = true;
            this.btnEliminarProveedor.Click += new System.EventHandler(this.btnEliminarProveedor_Click);
            // 
            // btnModificarProveedor
            // 
            this.btnModificarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(113)))), ((int)(((byte)(186)))));
            this.btnModificarProveedor.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnModificarProveedor.IconColor = System.Drawing.Color.Black;
            this.btnModificarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificarProveedor.Location = new System.Drawing.Point(122, 445);
            this.btnModificarProveedor.Name = "btnModificarProveedor";
            this.btnModificarProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnModificarProveedor.TabIndex = 20;
            this.btnModificarProveedor.Text = "Modificar";
            this.btnModificarProveedor.UseVisualStyleBackColor = true;
            this.btnModificarProveedor.Click += new System.EventHandler(this.btnModificarProveedor_Click);
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(113)))), ((int)(((byte)(186)))));
            this.btnAgregarProveedor.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregarProveedor.IconColor = System.Drawing.Color.Black;
            this.btnAgregarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarProveedor.Location = new System.Drawing.Point(26, 445);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarProveedor.TabIndex = 19;
            this.btnAgregarProveedor.Text = "Agregar";
            this.btnAgregarProveedor.UseVisualStyleBackColor = true;
            this.btnAgregarProveedor.Click += new System.EventHandler(this.btnAgregarProveedor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(45, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Filtro :";
            // 
            // txtBuscarProveedor
            // 
            this.txtBuscarProveedor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBuscarProveedor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBuscarProveedor.Location = new System.Drawing.Point(95, 29);
            this.txtBuscarProveedor.Name = "txtBuscarProveedor";
            this.txtBuscarProveedor.Size = new System.Drawing.Size(168, 20);
            this.txtBuscarProveedor.TabIndex = 18;
            this.txtBuscarProveedor.TextChanged += new System.EventHandler(this.txtBuscarProveedor_TextChanged);
            // 
            // FormProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(955, 512);
            this.Controls.Add(this.dgvProveedor);
            this.Controls.Add(this.pnlInfoProveedor);
            this.Controls.Add(this.btnEliminarProveedor);
            this.Controls.Add(this.btnModificarProveedor);
            this.Controls.Add(this.btnAgregarProveedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarProveedor);
            this.Name = "FormProveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.FormProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).EndInit();
            this.pnlInfoProveedor.ResumeLayout(false);
            this.pnlInfoProveedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblClaveProveedor;
        private System.Windows.Forms.Label lblCorreoProveedor;
        private System.Windows.Forms.DataGridView dgvProveedor;
        private System.Windows.Forms.Label lblNombreProveedor;
        private System.Windows.Forms.Panel pnlInfoProveedor;
        private System.Windows.Forms.Label lblDocumentoProveedor;
        private FontAwesome.Sharp.IconButton btnCancelarProveedor;
        private FontAwesome.Sharp.IconButton btnAceptarProveedor;
        private System.Windows.Forms.TextBox txtTelProveedor;
        private System.Windows.Forms.TextBox txtCorreoProveedor;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.TextBox txtDocumentoProveedor;
        private FontAwesome.Sharp.IconButton btnEliminarProveedor;
        private FontAwesome.Sharp.IconButton btnModificarProveedor;
        private FontAwesome.Sharp.IconButton btnAgregarProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarProveedor;
    }
}