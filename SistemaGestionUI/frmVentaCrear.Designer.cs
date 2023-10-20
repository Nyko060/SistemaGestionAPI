namespace SistemaGestionUI
{
    partial class frmVentaCrear
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
            pictureBox1 = new PictureBox();
            lblNuevaVenta = new Label();
            btnAgregarProducto = new Button();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Descripciones = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            TotalProducto = new DataGridViewTextBoxColumn();
            lblTotal = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.caja;
            pictureBox1.Location = new Point(213, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lblNuevaVenta
            // 
            lblNuevaVenta.AutoSize = true;
            lblNuevaVenta.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNuevaVenta.Location = new Point(28, 31);
            lblNuevaVenta.Name = "lblNuevaVenta";
            lblNuevaVenta.Size = new Size(179, 37);
            lblNuevaVenta.TabIndex = 5;
            lblNuevaVenta.Text = "Nueva Venta";
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarProducto.Location = new Point(654, 11);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(119, 57);
            btnAgregarProducto.TabIndex = 7;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Cantidad, Descripciones, Precio, TotalProducto });
            dataGridView1.Location = new Point(28, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(745, 349);
            dataGridView1.TabIndex = 8;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.DataPropertyName = "Cantidad";
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Descripciones
            // 
            Descripciones.DataPropertyName = "Descripciones";
            Descripciones.HeaderText = "Descripciones";
            Descripciones.Name = "Descripciones";
            Descripciones.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.DataPropertyName = "Precio";
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // TotalProducto
            // 
            TotalProducto.DataPropertyName = "TotalProducto";
            TotalProducto.HeaderText = "Total Producto";
            TotalProducto.Name = "TotalProducto";
            TotalProducto.ReadOnly = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(166, 457);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(96, 37);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "Total: ";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(574, 450);
            button1.Name = "button1";
            button1.Size = new Size(199, 57);
            button1.TabIndex = 10;
            button1.Text = "Confirmar Venta";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmVentaCrear
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(800, 519);
            Controls.Add(button1);
            Controls.Add(lblTotal);
            Controls.Add(dataGridView1);
            Controls.Add(btnAgregarProducto);
            Controls.Add(pictureBox1);
            Controls.Add(lblNuevaVenta);
            Name = "frmVentaCrear";
            Text = "Crear Nueva Venta";
            Load += frmVentaCrear_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblNuevaVenta;
        private Button btnAgregarProducto;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Descripciones;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn TotalProducto;
        private Label lblTotal;
        private Button button1;
    }
}