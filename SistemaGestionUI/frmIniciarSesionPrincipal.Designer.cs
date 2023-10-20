namespace SistemaGestionUI
{
    partial class frmIniciarSesionPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIniciarSesionPrincipal));
            btnIniciarSesion = new Button();
            label1 = new Label();
            label2 = new Label();
            txtNombreUsuario = new TextBox();
            txtContraseña = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnIniciarSesion.Location = new Point(146, 204);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(153, 70);
            btnIniciarSesion.TabIndex = 0;
            btnIniciarSesion.Text = "Iniciar Sesion";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 113);
            label1.Name = "label1";
            label1.Size = new Size(211, 30);
            label1.TabIndex = 1;
            label1.Text = "Nombre de Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(94, 158);
            label2.Name = "label2";
            label2.Size = new Size(129, 30);
            label2.TabIndex = 2;
            label2.Text = "Contraseña:";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreUsuario.Location = new Point(226, 113);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(205, 35);
            txtNombreUsuario.TabIndex = 3;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.Location = new Point(226, 158);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(205, 35);
            txtContraseña.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Iniciar_Sesion;
            pictureBox1.Location = new Point(167, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(172, 310);
            button1.Name = "button1";
            button1.Size = new Size(103, 41);
            button1.TabIndex = 6;
            button1.Text = "Registro";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Cyan;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(87, 290);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(79, 79);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // frmIniciarSesionPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(443, 381);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombreUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnIniciarSesion);
            Name = "frmIniciarSesionPrincipal";
            Text = "INICIAR SESION";
            Load += frmIniciarSesionPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciarSesion;
        private Label label1;
        private Label label2;
        private TextBox txtNombreUsuario;
        private TextBox txtContraseña;
        private PictureBox pictureBox1;
        private Button button1;
        private PictureBox pictureBox2;
    }
}