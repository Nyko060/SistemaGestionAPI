namespace SistemaGestionUI
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            pnlLateral = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pnlBotonera = new Panel();
            pictureBox6 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnUsuario = new Button();
            btnSalir = new Button();
            btnReportes = new Button();
            btnVentas = new Button();
            btnProductos = new Button();
            btnUsuarios = new Button();
            pnlLogo = new Panel();
            pictureBox1 = new PictureBox();
            pnlLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlBotonera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlLateral
            // 
            pnlLateral.AutoScroll = true;
            pnlLateral.BackColor = Color.FromArgb(64, 64, 64);
            pnlLateral.Controls.Add(pictureBox5);
            pnlLateral.Controls.Add(pictureBox4);
            pnlLateral.Controls.Add(pictureBox2);
            pnlLateral.Controls.Add(pnlBotonera);
            pnlLateral.Controls.Add(btnReportes);
            pnlLateral.Controls.Add(btnVentas);
            pnlLateral.Controls.Add(btnProductos);
            pnlLateral.Controls.Add(btnUsuarios);
            pnlLateral.Controls.Add(pnlLogo);
            pnlLateral.Dock = DockStyle.Left;
            pnlLateral.Location = new Point(0, 0);
            pnlLateral.Name = "pnlLateral";
            pnlLateral.Size = new Size(250, 537);
            pnlLateral.TabIndex = 4;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.Image = Properties.Resources.reportes;
            pictureBox5.Location = new Point(25, 232);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(44, 39);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Image = Properties.Resources.contrato;
            pictureBox4.Location = new Point(25, 187);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(44, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = Properties.Resources.caja;
            pictureBox2.Location = new Point(22, 139);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pnlBotonera
            // 
            pnlBotonera.Controls.Add(pictureBox6);
            pnlBotonera.Controls.Add(pictureBox3);
            pnlBotonera.Controls.Add(btnUsuario);
            pnlBotonera.Controls.Add(btnSalir);
            pnlBotonera.Dock = DockStyle.Top;
            pnlBotonera.Location = new Point(0, 277);
            pnlBotonera.Name = "pnlBotonera";
            pnlBotonera.Size = new Size(250, 165);
            pnlBotonera.TabIndex = 5;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.White;
            pictureBox6.Image = Properties.Resources.cerrar_sesion;
            pictureBox6.Location = new Point(25, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(44, 39);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 3;
            pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = Properties.Resources.grupo;
            pictureBox3.Location = new Point(25, 51);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // btnUsuario
            // 
            btnUsuario.Dock = DockStyle.Top;
            btnUsuario.Location = new Point(0, 45);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(250, 45);
            btnUsuario.TabIndex = 1;
            btnUsuario.Text = "Usuarios";
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Top;
            btnSalir.Location = new Point(0, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(250, 45);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnReportes
            // 
            btnReportes.Dock = DockStyle.Top;
            btnReportes.Location = new Point(0, 229);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(250, 48);
            btnReportes.TabIndex = 4;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnVentas
            // 
            btnVentas.Dock = DockStyle.Top;
            btnVentas.Location = new Point(0, 181);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(250, 48);
            btnVentas.TabIndex = 3;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnProductos
            // 
            btnProductos.BackgroundImageLayout = ImageLayout.None;
            btnProductos.Dock = DockStyle.Top;
            btnProductos.ImageAlign = ContentAlignment.MiddleRight;
            btnProductos.Location = new Point(0, 133);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(250, 48);
            btnProductos.TabIndex = 2;
            btnProductos.Tag = "";
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.White;
            btnUsuarios.DialogResult = DialogResult.No;
            btnUsuarios.Image = Properties.Resources.grupo;
            btnUsuarios.Location = new Point(0, 133);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(250, 45);
            btnUsuarios.TabIndex = 1;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = false;
            // 
            // pnlLogo
            // 
            pnlLogo.Controls.Add(pictureBox1);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(250, 133);
            pnlLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(10);
            pictureBox1.Size = new Size(250, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(983, 537);
            Controls.Add(pnlLateral);
            Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "frmMenuPrincipal";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "MENU";
            pnlLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlBotonera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlLateral;
        private Panel pnlLogo;
        private Button btnVentas;
        private Button btnProductos;
        private Button btnReportes;
        private Panel pnlBotonera;
        private Button btnUsuarios;
        private Button btnSalir;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnUsuario;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
    }
}