
namespace CapaPresentacion.Forms
{
    partial class FormClientes
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
            this.lblClaveCliente = new System.Windows.Forms.Label();
            this.lblCorreoCliente = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblDocumentoCliente = new System.Windows.Forms.Label();
            this.btnCancelarCliente = new FontAwesome.Sharp.IconButton();
            this.btnAceptarCliente = new FontAwesome.Sharp.IconButton();
            this.txtTelCliente = new System.Windows.Forms.TextBox();
            this.txtCorreoCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtDocumentoCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlInfoCliente = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.btnEliminarCliente = new FontAwesome.Sharp.IconButton();
            this.btnModificarCliente = new FontAwesome.Sharp.IconButton();
            this.btnAgregarCliente = new FontAwesome.Sharp.IconButton();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.pnlInfoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClaveCliente
            // 
            this.lblClaveCliente.AutoSize = true;
            this.lblClaveCliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblClaveCliente.Location = new System.Drawing.Point(38, 273);
            this.lblClaveCliente.Name = "lblClaveCliente";
            this.lblClaveCliente.Size = new System.Drawing.Size(28, 13);
            this.lblClaveCliente.TabIndex = 11;
            this.lblClaveCliente.Text = "Tel :";
            // 
            // lblCorreoCliente
            // 
            this.lblCorreoCliente.AutoSize = true;
            this.lblCorreoCliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCorreoCliente.Location = new System.Drawing.Point(38, 222);
            this.lblCorreoCliente.Name = "lblCorreoCliente";
            this.lblCorreoCliente.Size = new System.Drawing.Size(38, 13);
            this.lblCorreoCliente.TabIndex = 10;
            this.lblCorreoCliente.Text = "Email :";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNombreCliente.Location = new System.Drawing.Point(16, 118);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(50, 13);
            this.lblNombreCliente.TabIndex = 9;
            this.lblNombreCliente.Text = "Nombre :";
            // 
            // lblDocumentoCliente
            // 
            this.lblDocumentoCliente.AutoSize = true;
            this.lblDocumentoCliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDocumentoCliente.Location = new System.Drawing.Point(12, 58);
            this.lblDocumentoCliente.Name = "lblDocumentoCliente";
            this.lblDocumentoCliente.Size = new System.Drawing.Size(83, 13);
            this.lblDocumentoCliente.TabIndex = 8;
            this.lblDocumentoCliente.Text = "N° Documento :";
            // 
            // btnCancelarCliente
            // 
            this.btnCancelarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnCancelarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.btnCancelarCliente.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCancelarCliente.IconColor = System.Drawing.Color.Black;
            this.btnCancelarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarCliente.Location = new System.Drawing.Point(160, 385);
            this.btnCancelarCliente.Name = "btnCancelarCliente";
            this.btnCancelarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCliente.TabIndex = 12;
            this.btnCancelarCliente.Text = "Cancelar";
            this.btnCancelarCliente.UseVisualStyleBackColor = true;
            this.btnCancelarCliente.Click += new System.EventHandler(this.btnCancelarCliente_Click);
            // 
            // btnAceptarCliente
            // 
            this.btnAceptarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.btnAceptarCliente.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAceptarCliente.IconColor = System.Drawing.Color.Black;
            this.btnAceptarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAceptarCliente.Location = new System.Drawing.Point(42, 385);
            this.btnAceptarCliente.Name = "btnAceptarCliente";
            this.btnAceptarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarCliente.TabIndex = 11;
            this.btnAceptarCliente.Text = "Aceptar";
            this.btnAceptarCliente.UseVisualStyleBackColor = true;
            this.btnAceptarCliente.Click += new System.EventHandler(this.btnAceptarCliente_Click);
            // 
            // txtTelCliente
            // 
            this.txtTelCliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTelCliente.Location = new System.Drawing.Point(66, 292);
            this.txtTelCliente.Name = "txtTelCliente";
            this.txtTelCliente.Size = new System.Drawing.Size(156, 20);
            this.txtTelCliente.TabIndex = 9;
            // 
            // txtCorreoCliente
            // 
            this.txtCorreoCliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCorreoCliente.Location = new System.Drawing.Point(66, 238);
            this.txtCorreoCliente.Name = "txtCorreoCliente";
            this.txtCorreoCliente.Size = new System.Drawing.Size(156, 20);
            this.txtCorreoCliente.TabIndex = 8;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNombreCliente.Location = new System.Drawing.Point(66, 134);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(156, 20);
            this.txtNombreCliente.TabIndex = 7;
            // 
            // txtDocumentoCliente
            // 
            this.txtDocumentoCliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDocumentoCliente.Location = new System.Drawing.Point(66, 81);
            this.txtDocumentoCliente.Name = "txtDocumentoCliente";
            this.txtDocumentoCliente.Size = new System.Drawing.Size(156, 20);
            this.txtDocumentoCliente.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(45, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Filtro :";
            // 
            // pnlInfoCliente
            // 
            this.pnlInfoCliente.Controls.Add(this.label2);
            this.pnlInfoCliente.Controls.Add(this.txtApellidoCliente);
            this.pnlInfoCliente.Controls.Add(this.lblClaveCliente);
            this.pnlInfoCliente.Controls.Add(this.lblCorreoCliente);
            this.pnlInfoCliente.Controls.Add(this.lblNombreCliente);
            this.pnlInfoCliente.Controls.Add(this.lblDocumentoCliente);
            this.pnlInfoCliente.Controls.Add(this.btnCancelarCliente);
            this.pnlInfoCliente.Controls.Add(this.btnAceptarCliente);
            this.pnlInfoCliente.Controls.Add(this.txtTelCliente);
            this.pnlInfoCliente.Controls.Add(this.txtCorreoCliente);
            this.pnlInfoCliente.Controls.Add(this.txtNombreCliente);
            this.pnlInfoCliente.Controls.Add(this.txtDocumentoCliente);
            this.pnlInfoCliente.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlInfoCliente.Location = new System.Drawing.Point(669, 0);
            this.pnlInfoCliente.Name = "pnlInfoCliente";
            this.pnlInfoCliente.Size = new System.Drawing.Size(286, 512);
            this.pnlInfoCliente.TabIndex = 15;
            this.pnlInfoCliente.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(16, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Apellido :";
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtApellidoCliente.Location = new System.Drawing.Point(66, 183);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(156, 20);
            this.txtApellidoCliente.TabIndex = 13;
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnEliminarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.btnEliminarCliente.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEliminarCliente.IconColor = System.Drawing.Color.Black;
            this.btnEliminarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarCliente.Location = new System.Drawing.Point(215, 445);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCliente.TabIndex = 14;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.btnModificarCliente.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnModificarCliente.IconColor = System.Drawing.Color.Black;
            this.btnModificarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificarCliente.Location = new System.Drawing.Point(122, 445);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnModificarCliente.TabIndex = 13;
            this.btnModificarCliente.Text = "Modificar";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.btnAgregarCliente.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregarCliente.IconColor = System.Drawing.Color.Black;
            this.btnAgregarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarCliente.Location = new System.Drawing.Point(26, 445);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCliente.TabIndex = 12;
            this.btnAgregarCliente.Text = "Agregar";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBuscarCliente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBuscarCliente.Location = new System.Drawing.Point(95, 29);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(168, 20);
            this.txtBuscarCliente.TabIndex = 11;
            this.txtBuscarCliente.TextChanged += new System.EventHandler(this.txtBuscarCliente_TextChanged);
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCliente.Location = new System.Drawing.Point(26, 69);
            this.dgvCliente.MultiSelect = false;
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(577, 343);
            this.dgvCliente.TabIndex = 10;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(955, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlInfoCliente);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.dgvCliente);
            this.Name = "FormClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.pnlInfoCliente.ResumeLayout(false);
            this.pnlInfoCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblClaveCliente;
        private System.Windows.Forms.Label lblCorreoCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblDocumentoCliente;
        private FontAwesome.Sharp.IconButton btnCancelarCliente;
        private FontAwesome.Sharp.IconButton btnAceptarCliente;
        private System.Windows.Forms.TextBox txtTelCliente;
        private System.Windows.Forms.TextBox txtCorreoCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtDocumentoCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlInfoCliente;
        private FontAwesome.Sharp.IconButton btnEliminarCliente;
        private FontAwesome.Sharp.IconButton btnModificarCliente;
        private FontAwesome.Sharp.IconButton btnAgregarCliente;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellidoCliente;
    }
}