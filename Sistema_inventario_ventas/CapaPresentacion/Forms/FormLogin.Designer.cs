
namespace CapaPresentacion.Forms
{
    partial class FormLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbxNDocLogin = new System.Windows.Forms.TextBox();
            this.tbxPasswordLogin = new System.Windows.Forms.TextBox();
            this.lblNDocLogin = new System.Windows.Forms.Label();
            this.lblContraseñaLogin = new System.Windows.Forms.Label();
            this.btnLogin = new FontAwesome.Sharp.IconButton();
            this.btnCancelLogin = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 142);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(81, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 117);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbxNDocLogin
            // 
            this.tbxNDocLogin.Location = new System.Drawing.Point(51, 187);
            this.tbxNDocLogin.Name = "tbxNDocLogin";
            this.tbxNDocLogin.Size = new System.Drawing.Size(193, 20);
            this.tbxNDocLogin.TabIndex = 1;
            // 
            // tbxPasswordLogin
            // 
            this.tbxPasswordLogin.Location = new System.Drawing.Point(50, 244);
            this.tbxPasswordLogin.Name = "tbxPasswordLogin";
            this.tbxPasswordLogin.PasswordChar = '*';
            this.tbxPasswordLogin.Size = new System.Drawing.Size(193, 20);
            this.tbxPasswordLogin.TabIndex = 2;
            // 
            // lblNDocLogin
            // 
            this.lblNDocLogin.AutoSize = true;
            this.lblNDocLogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNDocLogin.Location = new System.Drawing.Point(18, 164);
            this.lblNDocLogin.Name = "lblNDocLogin";
            this.lblNDocLogin.Size = new System.Drawing.Size(77, 13);
            this.lblNDocLogin.TabIndex = 3;
            this.lblNDocLogin.Text = "N° Documento";
            // 
            // lblContraseñaLogin
            // 
            this.lblContraseñaLogin.AutoSize = true;
            this.lblContraseñaLogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblContraseñaLogin.Location = new System.Drawing.Point(18, 220);
            this.lblContraseñaLogin.Name = "lblContraseñaLogin";
            this.lblContraseñaLogin.Size = new System.Drawing.Size(61, 13);
            this.lblContraseñaLogin.TabIndex = 4;
            this.lblContraseñaLogin.Text = "Contraseña";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(129)))), ((int)(((byte)(43)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLogin.IconColor = System.Drawing.Color.Black;
            this.btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogin.Location = new System.Drawing.Point(55, 311);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(65, 30);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Ingresar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancelLogin
            // 
            this.btnCancelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(14)))), ((int)(((byte)(4)))));
            this.btnCancelLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelLogin.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCancelLogin.FlatAppearance.BorderSize = 0;
            this.btnCancelLogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCancelLogin.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCancelLogin.IconColor = System.Drawing.Color.Black;
            this.btnCancelLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelLogin.Location = new System.Drawing.Point(171, 312);
            this.btnCancelLogin.Name = "btnCancelLogin";
            this.btnCancelLogin.Size = new System.Drawing.Size(65, 30);
            this.btnCancelLogin.TabIndex = 4;
            this.btnCancelLogin.Text = "Cancelar";
            this.btnCancelLogin.UseVisualStyleBackColor = false;
            this.btnCancelLogin.Click += new System.EventHandler(this.btnCancelLogin_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(284, 393);
            this.Controls.Add(this.btnCancelLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblContraseñaLogin);
            this.Controls.Add(this.lblNDocLogin);
            this.Controls.Add(this.tbxPasswordLogin);
            this.Controls.Add(this.tbxNDocLogin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbxNDocLogin;
        private System.Windows.Forms.TextBox tbxPasswordLogin;
        private System.Windows.Forms.Label lblNDocLogin;
        private System.Windows.Forms.Label lblContraseñaLogin;
        private FontAwesome.Sharp.IconButton btnLogin;
        private FontAwesome.Sharp.IconButton btnCancelLogin;
    }
}