namespace GdiondoSQL
{
    partial class frmConexion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConexion));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.lblServidor = new System.Windows.Forms.Label();
            this.cbxConexion = new System.Windows.Forms.ComboBox();
            this.listImages = new System.Windows.Forms.ImageList(this.components);
            this.lblHost = new System.Windows.Forms.Label();
            this.gbxParametros = new System.Windows.Forms.GroupBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lblPuerto = new System.Windows.Forms.Label();
            this.lblBaseDeDatos = new System.Windows.Forms.Label();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.txtBaseDeDatos = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pbxSimbolo = new System.Windows.Forms.PictureBox();
            this.pbxCerrar = new System.Windows.Forms.PictureBox();
            this.pnlTitulo.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.gbxParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSimbolo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnlTitulo.Controls.Add(this.pbxSimbolo);
            this.pnlTitulo.Controls.Add(this.pbxCerrar);
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(621, 34);
            this.pnlTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(266, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(88, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gediondo";
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.SystemColors.Menu;
            this.pnlContenido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenido.Controls.Add(this.btnCerrar);
            this.pnlContenido.Controls.Add(this.btnEntrar);
            this.pnlContenido.Controls.Add(this.gbxParametros);
            this.pnlContenido.Controls.Add(this.lblServidor);
            this.pnlContenido.Controls.Add(this.cbxConexion);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 34);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(621, 309);
            this.pnlContenido.TabIndex = 2;
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Location = new System.Drawing.Point(12, 29);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(166, 21);
            this.lblServidor.TabIndex = 1;
            this.lblServidor.Text = "Seleccione servidor: ";
            // 
            // cbxConexion
            // 
            this.cbxConexion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxConexion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxConexion.FormattingEnabled = true;
            this.cbxConexion.Location = new System.Drawing.Point(184, 26);
            this.cbxConexion.Name = "cbxConexion";
            this.cbxConexion.Size = new System.Drawing.Size(179, 28);
            this.cbxConexion.TabIndex = 0;
            this.cbxConexion.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbxConexion_DrawItem);
            this.cbxConexion.SelectedIndexChanged += new System.EventHandler(this.cbxConexion_SelectedIndexChanged);
            // 
            // listImages
            // 
            this.listImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listImages.ImageStream")));
            this.listImages.TransparentColor = System.Drawing.Color.Transparent;
            this.listImages.Images.SetKeyName(0, "mysql.png");
            this.listImages.Images.SetKeyName(1, "sqlserver.png");
            this.listImages.Images.SetKeyName(2, "sqlite.png");
            this.listImages.Images.SetKeyName(3, "postgres.png");
            this.listImages.Images.SetKeyName(4, "raven.png");
            this.listImages.Images.SetKeyName(5, "1494258020-leafspringplantecologygreen_84346.png");
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(65, 26);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(52, 21);
            this.lblHost.TabIndex = 2;
            this.lblHost.Text = "Host: ";
            // 
            // gbxParametros
            // 
            this.gbxParametros.Controls.Add(this.txtBaseDeDatos);
            this.gbxParametros.Controls.Add(this.txtPuerto);
            this.gbxParametros.Controls.Add(this.lblBaseDeDatos);
            this.gbxParametros.Controls.Add(this.lblPuerto);
            this.gbxParametros.Controls.Add(this.txtPwd);
            this.gbxParametros.Controls.Add(this.lblPwd);
            this.gbxParametros.Controls.Add(this.txtUsuario);
            this.gbxParametros.Controls.Add(this.lblUsuario);
            this.gbxParametros.Controls.Add(this.txtHost);
            this.gbxParametros.Controls.Add(this.lblHost);
            this.gbxParametros.Location = new System.Drawing.Point(41, 66);
            this.gbxParametros.Name = "gbxParametros";
            this.gbxParametros.Size = new System.Drawing.Size(539, 181);
            this.gbxParametros.TabIndex = 3;
            this.gbxParametros.TabStop = false;
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(123, 23);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(98, 27);
            this.txtHost.TabIndex = 3;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(43, 73);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(74, 21);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario: ";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(123, 70);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 27);
            this.txtUsuario.TabIndex = 5;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(6, 131);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(111, 21);
            this.lblPwd.TabIndex = 6;
            this.lblPwd.Text = "Contraseña: ";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(123, 128);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(100, 27);
            this.txtPwd.TabIndex = 7;
            this.txtPwd.UseSystemPasswordChar = true;
            // 
            // lblPuerto
            // 
            this.lblPuerto.AutoSize = true;
            this.lblPuerto.Location = new System.Drawing.Point(267, 26);
            this.lblPuerto.Name = "lblPuerto";
            this.lblPuerto.Size = new System.Drawing.Size(69, 21);
            this.lblPuerto.TabIndex = 8;
            this.lblPuerto.Text = "Puerto: ";
            // 
            // lblBaseDeDatos
            // 
            this.lblBaseDeDatos.AutoSize = true;
            this.lblBaseDeDatos.Location = new System.Drawing.Point(276, 73);
            this.lblBaseDeDatos.Name = "lblBaseDeDatos";
            this.lblBaseDeDatos.Size = new System.Drawing.Size(128, 21);
            this.lblBaseDeDatos.TabIndex = 9;
            this.lblBaseDeDatos.Text = "Base de datos: ";
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(342, 23);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(100, 27);
            this.txtPuerto.TabIndex = 10;
            // 
            // txtBaseDeDatos
            // 
            this.txtBaseDeDatos.Location = new System.Drawing.Point(271, 97);
            this.txtBaseDeDatos.Multiline = true;
            this.txtBaseDeDatos.Name = "txtBaseDeDatos";
            this.txtBaseDeDatos.Size = new System.Drawing.Size(222, 58);
            this.txtBaseDeDatos.TabIndex = 11;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEntrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.Blue;
            this.btnEntrar.Location = new System.Drawing.Point(41, 263);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(123, 32);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.Blue;
            this.btnCerrar.Location = new System.Drawing.Point(455, 263);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(123, 32);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pbxSimbolo
            // 
            this.pbxSimbolo.BackgroundImage = global::GdiondoSQL.Properties.Resources.depositphotos_44842299_stock_illustration_smelly_toilet;
            this.pbxSimbolo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxSimbolo.Location = new System.Drawing.Point(-1, 0);
            this.pbxSimbolo.Name = "pbxSimbolo";
            this.pbxSimbolo.Size = new System.Drawing.Size(44, 41);
            this.pbxSimbolo.TabIndex = 2;
            this.pbxSimbolo.TabStop = false;
            // 
            // pbxCerrar
            // 
            this.pbxCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxCerrar.BackgroundImage = global::GdiondoSQL.Properties.Resources.Windows_Close_Program_22531;
            this.pbxCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxCerrar.Location = new System.Drawing.Point(582, 0);
            this.pbxCerrar.Name = "pbxCerrar";
            this.pbxCerrar.Size = new System.Drawing.Size(39, 34);
            this.pbxCerrar.TabIndex = 1;
            this.pbxCerrar.TabStop = false;
            this.pbxCerrar.Click += new System.EventHandler(this.pbxCerrar_Click);
            // 
            // frmConexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 343);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlTitulo);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmConexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmConexion_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlContenido.ResumeLayout(false);
            this.pnlContenido.PerformLayout();
            this.gbxParametros.ResumeLayout(false);
            this.gbxParametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSimbolo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pbxCerrar;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.ComboBox cbxConexion;
        private System.Windows.Forms.ImageList listImages;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.GroupBox gbxParametros;
        private System.Windows.Forms.Label lblPuerto;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label lblBaseDeDatos;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.TextBox txtBaseDeDatos;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pbxSimbolo;
    }
}

