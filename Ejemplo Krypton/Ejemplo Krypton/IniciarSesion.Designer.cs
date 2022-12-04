namespace Ejemplo_Krypton
{
    partial class IniciarSesion
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
            this.kryptonPanelInicioDeSesion = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.labelOlvidasteContraseña = new System.Windows.Forms.Label();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.labelo = new System.Windows.Forms.Label();
            this.kryptonSeparator2 = new ComponentFactory.Krypton.Toolkit.KryptonSeparator();
            this.kryptonSeparator1 = new ComponentFactory.Krypton.Toolkit.KryptonSeparator();
            this.labelSlogan = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelIncorrecto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelInicioDeSesion)).BeginInit();
            this.kryptonPanelInicioDeSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanelInicioDeSesion
            // 
            this.kryptonPanelInicioDeSesion.Controls.Add(this.kryptonPanel1);
            this.kryptonPanelInicioDeSesion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanelInicioDeSesion.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanelInicioDeSesion.Name = "kryptonPanelInicioDeSesion";
            this.kryptonPanelInicioDeSesion.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuInner;
            this.kryptonPanelInicioDeSesion.Size = new System.Drawing.Size(512, 670);
            this.kryptonPanelInicioDeSesion.TabIndex = 0;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.labelIncorrecto);
            this.kryptonPanel1.Controls.Add(this.labelOlvidasteContraseña);
            this.kryptonPanel1.Controls.Add(this.buttonIngresar);
            this.kryptonPanel1.Controls.Add(this.txtPassword);
            this.kryptonPanel1.Controls.Add(this.txtUsername);
            this.kryptonPanel1.Controls.Add(this.labelo);
            this.kryptonPanel1.Controls.Add(this.kryptonSeparator2);
            this.kryptonPanel1.Controls.Add(this.kryptonSeparator1);
            this.kryptonPanel1.Controls.Add(this.labelSlogan);
            this.kryptonPanel1.Controls.Add(this.pictureBoxLogo);
            this.kryptonPanel1.Location = new System.Drawing.Point(92, 80);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuInner;
            this.kryptonPanel1.Size = new System.Drawing.Size(316, 471);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // labelOlvidasteContraseña
            // 
            this.labelOlvidasteContraseña.AutoSize = true;
            this.labelOlvidasteContraseña.BackColor = System.Drawing.Color.Transparent;
            this.labelOlvidasteContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelOlvidasteContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelOlvidasteContraseña.Font = new System.Drawing.Font("Lucida Sans", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOlvidasteContraseña.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelOlvidasteContraseña.Location = new System.Drawing.Point(75, 453);
            this.labelOlvidasteContraseña.Name = "labelOlvidasteContraseña";
            this.labelOlvidasteContraseña.Size = new System.Drawing.Size(167, 15);
            this.labelOlvidasteContraseña.TabIndex = 8;
            this.labelOlvidasteContraseña.Text = "¿Olvidaste tu contraseña?";
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.BackColor = System.Drawing.Color.Red;
            this.buttonIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIngresar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIngresar.Font = new System.Drawing.Font("Lucida Sans", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIngresar.ForeColor = System.Drawing.Color.White;
            this.buttonIngresar.Location = new System.Drawing.Point(0, 391);
            this.buttonIngresar.MaximumSize = new System.Drawing.Size(314, 45);
            this.buttonIngresar.MinimumSize = new System.Drawing.Size(314, 45);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(314, 45);
            this.buttonIngresar.TabIndex = 7;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = false;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(1, 302);
            this.txtPassword.MaximumSize = new System.Drawing.Size(314, 45);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.MinimumSize = new System.Drawing.Size(314, 45);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(314, 45);
            this.txtPassword.TabIndex = 6;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(1, 250);
            this.txtUsername.MaximumSize = new System.Drawing.Size(314, 45);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.MinimumSize = new System.Drawing.Size(314, 45);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(314, 45);
            this.txtUsername.TabIndex = 5;
            // 
            // labelo
            // 
            this.labelo.AutoSize = true;
            this.labelo.BackColor = System.Drawing.Color.Transparent;
            this.labelo.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelo.Location = new System.Drawing.Point(147, 215);
            this.labelo.Name = "labelo";
            this.labelo.Size = new System.Drawing.Size(21, 12);
            this.labelo.TabIndex = 4;
            this.labelo.Text = " o ";
            this.labelo.Click += new System.EventHandler(this.labelo_Click);
            // 
            // kryptonSeparator2
            // 
            this.kryptonSeparator2.ContainerBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuHeading;
            this.kryptonSeparator2.DrawMoveIndicator = false;
            this.kryptonSeparator2.Location = new System.Drawing.Point(164, 220);
            this.kryptonSeparator2.Name = "kryptonSeparator2";
            this.kryptonSeparator2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.kryptonSeparator2.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.LowProfile;
            this.kryptonSeparator2.Size = new System.Drawing.Size(152, 3);
            this.kryptonSeparator2.TabIndex = 3;
            this.kryptonSeparator2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.kryptonSeparator2_SplitterMoved);
            // 
            // kryptonSeparator1
            // 
            this.kryptonSeparator1.ContainerBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuHeading;
            this.kryptonSeparator1.Location = new System.Drawing.Point(3, 220);
            this.kryptonSeparator1.Name = "kryptonSeparator1";
            this.kryptonSeparator1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.kryptonSeparator1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.LowProfile;
            this.kryptonSeparator1.Size = new System.Drawing.Size(152, 3);
            this.kryptonSeparator1.TabIndex = 2;
            // 
            // labelSlogan
            // 
            this.labelSlogan.AutoSize = true;
            this.labelSlogan.BackColor = System.Drawing.Color.Transparent;
            this.labelSlogan.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSlogan.Location = new System.Drawing.Point(91, 158);
            this.labelSlogan.Name = "labelSlogan";
            this.labelSlogan.Size = new System.Drawing.Size(129, 18);
            this.labelSlogan.TabIndex = 1;
            this.labelSlogan.Text = "It\'s all about fun";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = global::Ejemplo_Krypton.Properties.Resources.PyroskateshopLogo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(103, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(104, 139);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelIncorrecto
            // 
            this.labelIncorrecto.BackColor = System.Drawing.Color.White;
            this.labelIncorrecto.ForeColor = System.Drawing.Color.Red;
            this.labelIncorrecto.Location = new System.Drawing.Point(3, 356);
            this.labelIncorrecto.Name = "labelIncorrecto";
            this.labelIncorrecto.Size = new System.Drawing.Size(310, 23);
            this.labelIncorrecto.TabIndex = 9;
            this.labelIncorrecto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 670);
            this.ControlBox = false;
            this.Controls.Add(this.kryptonPanelInicioDeSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuInner;
            this.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ContextMenuInner;
            this.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Primary;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(512, 670);
            this.MinimumSize = new System.Drawing.Size(512, 670);
            this.Name = "IniciarSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar sesión";
            this.Load += new System.EventHandler(this.IniciarSesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelInicioDeSesion)).EndInit();
            this.kryptonPanelInicioDeSesion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanelInicioDeSesion;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private ComponentFactory.Krypton.Toolkit.KryptonSeparator kryptonSeparator1;
        private System.Windows.Forms.Label labelSlogan;
        private ComponentFactory.Krypton.Toolkit.KryptonSeparator kryptonSeparator2;
        private System.Windows.Forms.Label labelo;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.Label labelOlvidasteContraseña;
        private System.Windows.Forms.Label labelIncorrecto;
    }
}