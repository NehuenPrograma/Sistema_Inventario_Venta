﻿
namespace CapaPresentacion.Forms
{
    partial class FormInventario
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
            this.pnlInfoProducto = new System.Windows.Forms.Panel();
            this.nudStockProducto = new System.Windows.Forms.NumericUpDown();
            this.nudPrecioVentaProducto = new System.Windows.Forms.NumericUpDown();
            this.nudPrecioCompraProducto = new System.Windows.Forms.NumericUpDown();
            this.lblStock = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblCodigoProducto = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.lblColorProducto = new System.Windows.Forms.Label();
            this.txtColorProducto = new System.Windows.Forms.TextBox();
            this.lblPrecioVentaProducto = new System.Windows.Forms.Label();
            this.lblPrecioCompraProducto = new System.Windows.Forms.Label();
            this.lblTalleProducto = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.btnCancelarProducto = new FontAwesome.Sharp.IconButton();
            this.btnAceptarProducto = new FontAwesome.Sharp.IconButton();
            this.txtTalleProducto = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.btnEliminarProducto = new FontAwesome.Sharp.IconButton();
            this.btnModificarProducto = new FontAwesome.Sharp.IconButton();
            this.btnAgregarProducto = new FontAwesome.Sharp.IconButton();
            this.btnBuscarProducto = new FontAwesome.Sharp.IconButton();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.btnSumarStockProducto = new FontAwesome.Sharp.IconButton();
            this.txtSumarStockProducto = new System.Windows.Forms.TextBox();
            this.tctRestarStockProducto = new System.Windows.Forms.TextBox();
            this.btnRestarStockProducto = new FontAwesome.Sharp.IconButton();
            this.pnlInfoProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioVentaProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioCompraProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInfoProducto
            // 
            this.pnlInfoProducto.Controls.Add(this.nudStockProducto);
            this.pnlInfoProducto.Controls.Add(this.nudPrecioVentaProducto);
            this.pnlInfoProducto.Controls.Add(this.nudPrecioCompraProducto);
            this.pnlInfoProducto.Controls.Add(this.lblStock);
            this.pnlInfoProducto.Controls.Add(this.cboCategoria);
            this.pnlInfoProducto.Controls.Add(this.lblCategoria);
            this.pnlInfoProducto.Controls.Add(this.lblCodigoProducto);
            this.pnlInfoProducto.Controls.Add(this.txtCodigoProducto);
            this.pnlInfoProducto.Controls.Add(this.lblColorProducto);
            this.pnlInfoProducto.Controls.Add(this.txtColorProducto);
            this.pnlInfoProducto.Controls.Add(this.lblPrecioVentaProducto);
            this.pnlInfoProducto.Controls.Add(this.lblPrecioCompraProducto);
            this.pnlInfoProducto.Controls.Add(this.lblTalleProducto);
            this.pnlInfoProducto.Controls.Add(this.lblNombreProducto);
            this.pnlInfoProducto.Controls.Add(this.btnCancelarProducto);
            this.pnlInfoProducto.Controls.Add(this.btnAceptarProducto);
            this.pnlInfoProducto.Controls.Add(this.txtTalleProducto);
            this.pnlInfoProducto.Controls.Add(this.txtNombreProducto);
            this.pnlInfoProducto.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlInfoProducto.Location = new System.Drawing.Point(669, 0);
            this.pnlInfoProducto.Name = "pnlInfoProducto";
            this.pnlInfoProducto.Size = new System.Drawing.Size(286, 512);
            this.pnlInfoProducto.TabIndex = 13;
            this.pnlInfoProducto.Visible = false;
            // 
            // nudStockProducto
            // 
            this.nudStockProducto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.nudStockProducto.Location = new System.Drawing.Point(92, 290);
            this.nudStockProducto.Name = "nudStockProducto";
            this.nudStockProducto.Size = new System.Drawing.Size(86, 20);
            this.nudStockProducto.TabIndex = 25;
            this.nudStockProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudPrecioVentaProducto
            // 
            this.nudPrecioVentaProducto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.nudPrecioVentaProducto.DecimalPlaces = 2;
            this.nudPrecioVentaProducto.Location = new System.Drawing.Point(128, 242);
            this.nudPrecioVentaProducto.Name = "nudPrecioVentaProducto";
            this.nudPrecioVentaProducto.Size = new System.Drawing.Size(99, 20);
            this.nudPrecioVentaProducto.TabIndex = 24;
            this.nudPrecioVentaProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudPrecioCompraProducto
            // 
            this.nudPrecioCompraProducto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.nudPrecioCompraProducto.DecimalPlaces = 2;
            this.nudPrecioCompraProducto.Location = new System.Drawing.Point(128, 193);
            this.nudPrecioCompraProducto.Name = "nudPrecioCompraProducto";
            this.nudPrecioCompraProducto.Size = new System.Drawing.Size(99, 20);
            this.nudPrecioCompraProducto.TabIndex = 23;
            this.nudPrecioCompraProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblStock.Location = new System.Drawing.Point(26, 292);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(41, 13);
            this.lblStock.TabIndex = 21;
            this.lblStock.Text = "Stock :";
            // 
            // cboCategoria
            // 
            this.cboCategoria.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(98, 47);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 20;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCategoria.Location = new System.Drawing.Point(26, 50);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(58, 13);
            this.lblCategoria.TabIndex = 19;
            this.lblCategoria.Text = "Categoria :";
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCodigoProducto.Location = new System.Drawing.Point(26, 342);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(46, 13);
            this.lblCodigoProducto.TabIndex = 17;
            this.lblCodigoProducto.Text = "Codigo :";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCodigoProducto.Location = new System.Drawing.Point(92, 339);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(156, 20);
            this.txtCodigoProducto.TabIndex = 15;
            // 
            // lblColorProducto
            // 
            this.lblColorProducto.AutoSize = true;
            this.lblColorProducto.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblColorProducto.Location = new System.Drawing.Point(141, 147);
            this.lblColorProducto.Name = "lblColorProducto";
            this.lblColorProducto.Size = new System.Drawing.Size(37, 13);
            this.lblColorProducto.TabIndex = 15;
            this.lblColorProducto.Text = "Color :";
            // 
            // txtColorProducto
            // 
            this.txtColorProducto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtColorProducto.Location = new System.Drawing.Point(186, 144);
            this.txtColorProducto.Name = "txtColorProducto";
            this.txtColorProducto.Size = new System.Drawing.Size(73, 20);
            this.txtColorProducto.TabIndex = 12;
            // 
            // lblPrecioVentaProducto
            // 
            this.lblPrecioVentaProducto.AutoSize = true;
            this.lblPrecioVentaProducto.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPrecioVentaProducto.Location = new System.Drawing.Point(26, 244);
            this.lblPrecioVentaProducto.Name = "lblPrecioVentaProducto";
            this.lblPrecioVentaProducto.Size = new System.Drawing.Size(88, 13);
            this.lblPrecioVentaProducto.TabIndex = 12;
            this.lblPrecioVentaProducto.Text = "Precio de venta :";
            // 
            // lblPrecioCompraProducto
            // 
            this.lblPrecioCompraProducto.AutoSize = true;
            this.lblPrecioCompraProducto.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPrecioCompraProducto.Location = new System.Drawing.Point(26, 195);
            this.lblPrecioCompraProducto.Name = "lblPrecioCompraProducto";
            this.lblPrecioCompraProducto.Size = new System.Drawing.Size(96, 13);
            this.lblPrecioCompraProducto.TabIndex = 11;
            this.lblPrecioCompraProducto.Text = "Precio de compra :";
            // 
            // lblTalleProducto
            // 
            this.lblTalleProducto.AutoSize = true;
            this.lblTalleProducto.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTalleProducto.Location = new System.Drawing.Point(26, 147);
            this.lblTalleProducto.Name = "lblTalleProducto";
            this.lblTalleProducto.Size = new System.Drawing.Size(36, 13);
            this.lblTalleProducto.TabIndex = 9;
            this.lblTalleProducto.Text = "Talle :";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNombreProducto.Location = new System.Drawing.Point(26, 101);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(50, 13);
            this.lblNombreProducto.TabIndex = 8;
            this.lblNombreProducto.Text = "Nombre :";
            // 
            // btnCancelarProducto
            // 
            this.btnCancelarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnCancelarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(9)))), ((int)(((byte)(90)))));
            this.btnCancelarProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCancelarProducto.IconColor = System.Drawing.Color.Black;
            this.btnCancelarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarProducto.Location = new System.Drawing.Point(165, 427);
            this.btnCancelarProducto.Name = "btnCancelarProducto";
            this.btnCancelarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarProducto.TabIndex = 17;
            this.btnCancelarProducto.Text = "Cancelar";
            this.btnCancelarProducto.UseVisualStyleBackColor = true;
            this.btnCancelarProducto.Click += new System.EventHandler(this.btnCancelarProducto_Click);
            // 
            // btnAceptarProducto
            // 
            this.btnAceptarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(9)))), ((int)(((byte)(90)))));
            this.btnAceptarProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAceptarProducto.IconColor = System.Drawing.Color.Black;
            this.btnAceptarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAceptarProducto.Location = new System.Drawing.Point(47, 427);
            this.btnAceptarProducto.Name = "btnAceptarProducto";
            this.btnAceptarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarProducto.TabIndex = 16;
            this.btnAceptarProducto.Text = "Aceptar";
            this.btnAceptarProducto.UseVisualStyleBackColor = true;
            this.btnAceptarProducto.Click += new System.EventHandler(this.btnAceptarProducto_Click);
            // 
            // txtTalleProducto
            // 
            this.txtTalleProducto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTalleProducto.Location = new System.Drawing.Point(68, 144);
            this.txtTalleProducto.Name = "txtTalleProducto";
            this.txtTalleProducto.Size = new System.Drawing.Size(51, 20);
            this.txtTalleProducto.TabIndex = 11;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNombreProducto.Location = new System.Drawing.Point(92, 98);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(156, 20);
            this.txtNombreProducto.TabIndex = 10;
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnEliminarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(9)))), ((int)(((byte)(90)))));
            this.btnEliminarProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEliminarProducto.IconColor = System.Drawing.Color.Black;
            this.btnEliminarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarProducto.Location = new System.Drawing.Point(215, 445);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarProducto.TabIndex = 5;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(9)))), ((int)(((byte)(90)))));
            this.btnModificarProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnModificarProducto.IconColor = System.Drawing.Color.Black;
            this.btnModificarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificarProducto.Location = new System.Drawing.Point(122, 445);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnModificarProducto.TabIndex = 4;
            this.btnModificarProducto.Text = "Modificar";
            this.btnModificarProducto.UseVisualStyleBackColor = true;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(9)))), ((int)(((byte)(90)))));
            this.btnAgregarProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregarProducto.IconColor = System.Drawing.Color.Black;
            this.btnAgregarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarProducto.Location = new System.Drawing.Point(26, 445);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarProducto.TabIndex = 3;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(9)))), ((int)(((byte)(90)))));
            this.btnBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBuscarProducto.IconColor = System.Drawing.Color.Black;
            this.btnBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProducto.Location = new System.Drawing.Point(26, 27);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProducto.TabIndex = 2;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBuscarProducto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBuscarProducto.Location = new System.Drawing.Point(122, 29);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(168, 20);
            this.txtBuscarProducto.TabIndex = 1;
            // 
            // dgvInventario
            // 
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInventario.Location = new System.Drawing.Point(26, 69);
            this.dgvInventario.MultiSelect = false;
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.Size = new System.Drawing.Size(617, 343);
            this.dgvInventario.TabIndex = 7;
            // 
            // btnSumarStockProducto
            // 
            this.btnSumarStockProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSumarStockProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnSumarStockProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(9)))), ((int)(((byte)(90)))));
            this.btnSumarStockProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSumarStockProducto.IconColor = System.Drawing.Color.Black;
            this.btnSumarStockProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSumarStockProducto.Location = new System.Drawing.Point(423, 27);
            this.btnSumarStockProducto.Name = "btnSumarStockProducto";
            this.btnSumarStockProducto.Size = new System.Drawing.Size(100, 23);
            this.btnSumarStockProducto.TabIndex = 7;
            this.btnSumarStockProducto.Text = "Agregar Stock";
            this.btnSumarStockProducto.UseVisualStyleBackColor = true;
            // 
            // txtSumarStockProducto
            // 
            this.txtSumarStockProducto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSumarStockProducto.Location = new System.Drawing.Point(543, 29);
            this.txtSumarStockProducto.Name = "txtSumarStockProducto";
            this.txtSumarStockProducto.Size = new System.Drawing.Size(73, 20);
            this.txtSumarStockProducto.TabIndex = 6;
            // 
            // tctRestarStockProducto
            // 
            this.tctRestarStockProducto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tctRestarStockProducto.Location = new System.Drawing.Point(543, 447);
            this.tctRestarStockProducto.Name = "tctRestarStockProducto";
            this.tctRestarStockProducto.Size = new System.Drawing.Size(73, 20);
            this.tctRestarStockProducto.TabIndex = 8;
            // 
            // btnRestarStockProducto
            // 
            this.btnRestarStockProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestarStockProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnRestarStockProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(9)))), ((int)(((byte)(90)))));
            this.btnRestarStockProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRestarStockProducto.IconColor = System.Drawing.Color.Black;
            this.btnRestarStockProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRestarStockProducto.Location = new System.Drawing.Point(423, 445);
            this.btnRestarStockProducto.Name = "btnRestarStockProducto";
            this.btnRestarStockProducto.Size = new System.Drawing.Size(100, 23);
            this.btnRestarStockProducto.TabIndex = 9;
            this.btnRestarStockProducto.Text = "Restar Stock";
            this.btnRestarStockProducto.UseVisualStyleBackColor = true;
            // 
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(955, 512);
            this.Controls.Add(this.tctRestarStockProducto);
            this.Controls.Add(this.btnRestarStockProducto);
            this.Controls.Add(this.txtSumarStockProducto);
            this.Controls.Add(this.btnSumarStockProducto);
            this.Controls.Add(this.pnlInfoProducto);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnModificarProducto);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.dgvInventario);
            this.Name = "FormInventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.FormInventario_Load);
            this.pnlInfoProducto.ResumeLayout(false);
            this.pnlInfoProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioVentaProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioCompraProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlInfoProducto;
        private System.Windows.Forms.Label lblPrecioVentaProducto;
        private System.Windows.Forms.Label lblPrecioCompraProducto;
        private System.Windows.Forms.Label lblTalleProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private FontAwesome.Sharp.IconButton btnCancelarProducto;
        private FontAwesome.Sharp.IconButton btnAceptarProducto;
        private System.Windows.Forms.TextBox txtTalleProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private FontAwesome.Sharp.IconButton btnEliminarProducto;
        private FontAwesome.Sharp.IconButton btnModificarProducto;
        private FontAwesome.Sharp.IconButton btnAgregarProducto;
        private FontAwesome.Sharp.IconButton btnBuscarProducto;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Label lblCodigoProducto;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label lblColorProducto;
        private System.Windows.Forms.TextBox txtColorProducto;
        private FontAwesome.Sharp.IconButton btnSumarStockProducto;
        private System.Windows.Forms.TextBox txtSumarStockProducto;
        private System.Windows.Forms.TextBox tctRestarStockProducto;
        private FontAwesome.Sharp.IconButton btnRestarStockProducto;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.NumericUpDown nudStockProducto;
        private System.Windows.Forms.NumericUpDown nudPrecioVentaProducto;
        private System.Windows.Forms.NumericUpDown nudPrecioCompraProducto;
    }
}