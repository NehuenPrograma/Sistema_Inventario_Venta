
namespace CapaPresentacion.Forms
{
    partial class FormUsuarios
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
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.btnAgregarUsuario = new FontAwesome.Sharp.IconButton();
            this.btnModificarUsuario = new FontAwesome.Sharp.IconButton();
            this.btnEliminarUsuario = new FontAwesome.Sharp.IconButton();
            this.pnlInfoUsuario = new System.Windows.Forms.Panel();
            this.lblRolUsuario = new System.Windows.Forms.Label();
            this.lblClaveUsuario = new System.Windows.Forms.Label();
            this.lblCorreoUsuario = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblDocumentoUsuario = new System.Windows.Forms.Label();
            this.btnCancelarUsuario = new FontAwesome.Sharp.IconButton();
            this.btnAceptarUsuario = new FontAwesome.Sharp.IconButton();
            this.cboRolUsuario = new System.Windows.Forms.ComboBox();
            this.txtClaveUsuario = new System.Windows.Forms.TextBox();
            this.txtCorreoUsuario = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtDocumentoUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.pnlInfoUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUsuario.Location = new System.Drawing.Point(26, 69);
            this.dgvUsuario.MultiSelect = false;
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuario.Size = new System.Drawing.Size(577, 343);
            this.dgvUsuario.TabIndex = 0;
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBuscarUsuario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBuscarUsuario.Location = new System.Drawing.Point(95, 29);
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(168, 20);
            this.txtBuscarUsuario.TabIndex = 1;
            this.txtBuscarUsuario.TextChanged += new System.EventHandler(this.txtBuscarUsuario_TextChanged);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(221)))));
            this.btnAgregarUsuario.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregarUsuario.IconColor = System.Drawing.Color.Black;
            this.btnAgregarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(26, 445);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarUsuario.TabIndex = 3;
            this.btnAgregarUsuario.Text = "Agregar";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(221)))));
            this.btnModificarUsuario.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnModificarUsuario.IconColor = System.Drawing.Color.Black;
            this.btnModificarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificarUsuario.Location = new System.Drawing.Point(122, 445);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnModificarUsuario.TabIndex = 4;
            this.btnModificarUsuario.Text = "Modificar";
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnEliminarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(221)))));
            this.btnEliminarUsuario.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEliminarUsuario.IconColor = System.Drawing.Color.Black;
            this.btnEliminarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(215, 445);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarUsuario.TabIndex = 5;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // pnlInfoUsuario
            // 
            this.pnlInfoUsuario.Controls.Add(this.lblRolUsuario);
            this.pnlInfoUsuario.Controls.Add(this.lblClaveUsuario);
            this.pnlInfoUsuario.Controls.Add(this.lblCorreoUsuario);
            this.pnlInfoUsuario.Controls.Add(this.lblNombreUsuario);
            this.pnlInfoUsuario.Controls.Add(this.lblDocumentoUsuario);
            this.pnlInfoUsuario.Controls.Add(this.btnCancelarUsuario);
            this.pnlInfoUsuario.Controls.Add(this.btnAceptarUsuario);
            this.pnlInfoUsuario.Controls.Add(this.cboRolUsuario);
            this.pnlInfoUsuario.Controls.Add(this.txtClaveUsuario);
            this.pnlInfoUsuario.Controls.Add(this.txtCorreoUsuario);
            this.pnlInfoUsuario.Controls.Add(this.txtNombreUsuario);
            this.pnlInfoUsuario.Controls.Add(this.txtDocumentoUsuario);
            this.pnlInfoUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlInfoUsuario.Location = new System.Drawing.Point(669, 0);
            this.pnlInfoUsuario.Name = "pnlInfoUsuario";
            this.pnlInfoUsuario.Size = new System.Drawing.Size(286, 512);
            this.pnlInfoUsuario.TabIndex = 6;
            this.pnlInfoUsuario.Visible = false;
            // 
            // lblRolUsuario
            // 
            this.lblRolUsuario.AutoSize = true;
            this.lblRolUsuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblRolUsuario.Location = new System.Drawing.Point(38, 282);
            this.lblRolUsuario.Name = "lblRolUsuario";
            this.lblRolUsuario.Size = new System.Drawing.Size(29, 13);
            this.lblRolUsuario.TabIndex = 12;
            this.lblRolUsuario.Text = "Rol :";
            // 
            // lblClaveUsuario
            // 
            this.lblClaveUsuario.AutoSize = true;
            this.lblClaveUsuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblClaveUsuario.Location = new System.Drawing.Point(12, 226);
            this.lblClaveUsuario.Name = "lblClaveUsuario";
            this.lblClaveUsuario.Size = new System.Drawing.Size(67, 13);
            this.lblClaveUsuario.TabIndex = 11;
            this.lblClaveUsuario.Text = "Contraseña :";
            // 
            // lblCorreoUsuario
            // 
            this.lblCorreoUsuario.AutoSize = true;
            this.lblCorreoUsuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCorreoUsuario.Location = new System.Drawing.Point(38, 172);
            this.lblCorreoUsuario.Name = "lblCorreoUsuario";
            this.lblCorreoUsuario.Size = new System.Drawing.Size(38, 13);
            this.lblCorreoUsuario.TabIndex = 10;
            this.lblCorreoUsuario.Text = "Email :";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNombreUsuario.Location = new System.Drawing.Point(12, 113);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(98, 13);
            this.lblNombreUsuario.TabIndex = 9;
            this.lblNombreUsuario.Text = "Nombre y Apellido :";
            // 
            // lblDocumentoUsuario
            // 
            this.lblDocumentoUsuario.AutoSize = true;
            this.lblDocumentoUsuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDocumentoUsuario.Location = new System.Drawing.Point(12, 56);
            this.lblDocumentoUsuario.Name = "lblDocumentoUsuario";
            this.lblDocumentoUsuario.Size = new System.Drawing.Size(83, 13);
            this.lblDocumentoUsuario.TabIndex = 8;
            this.lblDocumentoUsuario.Text = "N° Documento :";
            // 
            // btnCancelarUsuario
            // 
            this.btnCancelarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnCancelarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(221)))));
            this.btnCancelarUsuario.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCancelarUsuario.IconColor = System.Drawing.Color.Black;
            this.btnCancelarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarUsuario.Location = new System.Drawing.Point(160, 385);
            this.btnCancelarUsuario.Name = "btnCancelarUsuario";
            this.btnCancelarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarUsuario.TabIndex = 12;
            this.btnCancelarUsuario.Text = "Cancelar";
            this.btnCancelarUsuario.UseVisualStyleBackColor = true;
            this.btnCancelarUsuario.Click += new System.EventHandler(this.btnCancelarUsuario_Click);
            // 
            // btnAceptarUsuario
            // 
            this.btnAceptarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(221)))));
            this.btnAceptarUsuario.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAceptarUsuario.IconColor = System.Drawing.Color.Black;
            this.btnAceptarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAceptarUsuario.Location = new System.Drawing.Point(42, 385);
            this.btnAceptarUsuario.Name = "btnAceptarUsuario";
            this.btnAceptarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarUsuario.TabIndex = 11;
            this.btnAceptarUsuario.Text = "Aceptar";
            this.btnAceptarUsuario.UseVisualStyleBackColor = true;
            this.btnAceptarUsuario.Click += new System.EventHandler(this.btnAceptarUsuario_Click);
            // 
            // cboRolUsuario
            // 
            this.cboRolUsuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboRolUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboRolUsuario.FormattingEnabled = true;
            this.cboRolUsuario.Location = new System.Drawing.Point(66, 300);
            this.cboRolUsuario.Name = "cboRolUsuario";
            this.cboRolUsuario.Size = new System.Drawing.Size(121, 21);
            this.cboRolUsuario.TabIndex = 10;
            // 
            // txtClaveUsuario
            // 
            this.txtClaveUsuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtClaveUsuario.Location = new System.Drawing.Point(66, 245);
            this.txtClaveUsuario.Name = "txtClaveUsuario";
            this.txtClaveUsuario.Size = new System.Drawing.Size(156, 20);
            this.txtClaveUsuario.TabIndex = 9;
            // 
            // txtCorreoUsuario
            // 
            this.txtCorreoUsuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCorreoUsuario.Location = new System.Drawing.Point(66, 188);
            this.txtCorreoUsuario.Name = "txtCorreoUsuario";
            this.txtCorreoUsuario.Size = new System.Drawing.Size(156, 20);
            this.txtCorreoUsuario.TabIndex = 8;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNombreUsuario.Location = new System.Drawing.Point(66, 134);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(156, 20);
            this.txtNombreUsuario.TabIndex = 7;
            // 
            // txtDocumentoUsuario
            // 
            this.txtDocumentoUsuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDocumentoUsuario.Location = new System.Drawing.Point(66, 79);
            this.txtDocumentoUsuario.Name = "txtDocumentoUsuario";
            this.txtDocumentoUsuario.Size = new System.Drawing.Size(156, 20);
            this.txtDocumentoUsuario.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(45, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Filtro :";
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(955, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlInfoUsuario);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnModificarUsuario);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.txtBuscarUsuario);
            this.Controls.Add(this.dgvUsuario);
            this.Name = "FormUsuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.pnlInfoUsuario.ResumeLayout(false);
            this.pnlInfoUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.TextBox txtBuscarUsuario;
        private FontAwesome.Sharp.IconButton btnAgregarUsuario;
        private FontAwesome.Sharp.IconButton btnModificarUsuario;
        private FontAwesome.Sharp.IconButton btnEliminarUsuario;
        private System.Windows.Forms.Panel pnlInfoUsuario;
        private System.Windows.Forms.Label lblClaveUsuario;
        private System.Windows.Forms.Label lblCorreoUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblDocumentoUsuario;
        private FontAwesome.Sharp.IconButton btnCancelarUsuario;
        private FontAwesome.Sharp.IconButton btnAceptarUsuario;
        private System.Windows.Forms.ComboBox cboRolUsuario;
        private System.Windows.Forms.TextBox txtClaveUsuario;
        private System.Windows.Forms.TextBox txtCorreoUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtDocumentoUsuario;
        private System.Windows.Forms.Label lblRolUsuario;
        private System.Windows.Forms.Label label1;
    }
}