namespace SistemaGestionUI
{
    partial class frmEliminarProducto
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
            btnEliminar = new Button();
            txtUsuario = new TextBox();
            numStock = new NumericUpDown();
            label5 = new Label();
            txtDescripcion = new TextBox();
            numPrecio = new NumericUpDown();
            numCosto = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCosto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(31, 399);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Padding = new Padding(0, 0, 7, 0);
            btnEliminar.Size = new Size(208, 87);
            btnEliminar.TabIndex = 33;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsuario.Location = new Point(12, 327);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(227, 35);
            txtUsuario.TabIndex = 32;
            // 
            // numStock
            // 
            numStock.DecimalPlaces = 3;
            numStock.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            numStock.Location = new Point(12, 257);
            numStock.Maximum = new decimal(new int[] { 1569325055, 23283064, 0, 0 });
            numStock.Name = "numStock";
            numStock.Size = new Size(124, 35);
            numStock.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 222);
            label5.Name = "label5";
            label5.Size = new Size(78, 29);
            label5.TabIndex = 30;
            label5.Text = "Stock";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtDescripcion.Location = new Point(12, 42);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(227, 35);
            txtDescripcion.TabIndex = 29;
            // 
            // numPrecio
            // 
            numPrecio.DecimalPlaces = 3;
            numPrecio.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            numPrecio.Location = new Point(12, 184);
            numPrecio.Maximum = new decimal(new int[] { 1569325055, 23283064, 0, 0 });
            numPrecio.Name = "numPrecio";
            numPrecio.Size = new Size(124, 35);
            numPrecio.TabIndex = 28;
            // 
            // numCosto
            // 
            numCosto.DecimalPlaces = 3;
            numCosto.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            numCosto.Location = new Point(12, 113);
            numCosto.Maximum = new decimal(new int[] { 1569325055, 23283064, 0, 0 });
            numCosto.Name = "numCosto";
            numCosto.Size = new Size(124, 35);
            numCosto.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 295);
            label4.Name = "label4";
            label4.Size = new Size(124, 29);
            label4.TabIndex = 26;
            label4.Text = "IdUsuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 151);
            label3.Name = "label3";
            label3.Size = new Size(192, 29);
            label3.TabIndex = 25;
            label3.Text = "Precio de Venta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(196, 29);
            label2.TabIndex = 24;
            label2.Text = "Precio de Costo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(150, 29);
            label1.TabIndex = 23;
            label1.Text = "Descripción";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.boton;
            pictureBox1.Location = new Point(57, 418);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // frmEliminarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(273, 520);
            Controls.Add(pictureBox1);
            Controls.Add(btnEliminar);
            Controls.Add(txtUsuario);
            Controls.Add(numStock);
            Controls.Add(label5);
            Controls.Add(txtDescripcion);
            Controls.Add(numPrecio);
            Controls.Add(numCosto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmEliminarProducto";
            Text = "frmEliminarProducto";
            Load += frmEliminarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCosto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
        private TextBox txtUsuario;
        private NumericUpDown numStock;
        private Label label5;
        private TextBox txtDescripcion;
        private NumericUpDown numPrecio;
        private NumericUpDown numCosto;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}