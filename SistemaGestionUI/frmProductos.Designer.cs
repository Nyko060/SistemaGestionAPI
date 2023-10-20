namespace SistemaGestionUI
{
    partial class frmProductos
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
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Descripciones = new DataGridViewTextBoxColumn();
            Costo = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            btnEditar = new DataGridViewButtonColumn();
            btnEliminar = new DataGridViewButtonColumn();
            lblListaDeProductos = new Label();
            btnCrear = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Descripciones, Costo, PrecioVenta, Stock, btnEditar, btnEliminar });
            dataGridView1.Location = new Point(28, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(745, 349);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Descripciones
            // 
            Descripciones.DataPropertyName = "Descripciones";
            Descripciones.HeaderText = "Descripciones";
            Descripciones.Name = "Descripciones";
            Descripciones.ReadOnly = true;
            // 
            // Costo
            // 
            Costo.DataPropertyName = "Costo";
            Costo.HeaderText = "Costo";
            Costo.Name = "Costo";
            Costo.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            PrecioVenta.DataPropertyName = "PrecioVenta";
            PrecioVenta.HeaderText = "PrecioVenta";
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            // 
            // Stock
            // 
            Stock.DataPropertyName = "Stock";
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            // 
            // btnEditar
            // 
            btnEditar.HeaderText = "Editar";
            btnEditar.Name = "btnEditar";
            btnEditar.ReadOnly = true;
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            // 
            // btnEliminar
            // 
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Name = "btnEliminar";
            btnEliminar.ReadOnly = true;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseColumnTextForButtonValue = true;
            // 
            // lblListaDeProductos
            // 
            lblListaDeProductos.AutoSize = true;
            lblListaDeProductos.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblListaDeProductos.Location = new Point(28, 22);
            lblListaDeProductos.Name = "lblListaDeProductos";
            lblListaDeProductos.Size = new Size(254, 37);
            lblListaDeProductos.TabIndex = 2;
            lblListaDeProductos.Text = "Lista de Productos";
            // 
            // btnCrear
            // 
            btnCrear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCrear.Location = new Point(654, 12);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(119, 57);
            btnCrear.TabIndex = 3;
            btnCrear.Text = "Agregar";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.caja;
            pictureBox1.Location = new Point(288, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnCrear);
            Controls.Add(lblListaDeProductos);
            Controls.Add(dataGridView1);
            Name = "frmProductos";
            Text = "frmProducto";
            Load += frmProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Descripciones;
        private DataGridViewTextBoxColumn Costo;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewButtonColumn btnEditar;
        private DataGridViewButtonColumn btnEliminar;
        private Label lblListaDeProductos;
        private Button btnCrear;
        private PictureBox pictureBox1;
    }
}