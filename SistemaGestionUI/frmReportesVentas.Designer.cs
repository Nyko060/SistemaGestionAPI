namespace SistemaGestionUI
{
    partial class frmReportesVentas
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            IdVentas = new DataGridViewTextBoxColumn();
            CantidadProductosVendidos = new DataGridViewTextBoxColumn();
            TotalFacturado = new DataGridViewTextBoxColumn();
            VerDetalle = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(243, 19);
            label1.Name = "label1";
            label1.Size = new Size(307, 45);
            label1.TabIndex = 0;
            label1.Text = "Reportes de Ventas";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdVentas, CantidadProductosVendidos, TotalFacturado, VerDetalle });
            dataGridView1.Location = new Point(40, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(711, 337);
            dataGridView1.TabIndex = 1;
            // 
            // IdVentas
            // 
            IdVentas.HeaderText = "Id Ventas";
            IdVentas.Name = "IdVentas";
            // 
            // CantidadProductosVendidos
            // 
            CantidadProductosVendidos.HeaderText = "Cantidad Productos Vendidos";
            CantidadProductosVendidos.Name = "CantidadProductosVendidos";
            // 
            // TotalFacturado
            // 
            TotalFacturado.HeaderText = "TotalFacturado";
            TotalFacturado.Name = "TotalFacturado";
            // 
            // VerDetalle
            // 
            VerDetalle.HeaderText = "";
            VerDetalle.Name = "VerDetalle";
            VerDetalle.Text = "Ver Detalle";
            // 
            // frmReportesVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "frmReportesVentas";
            Text = "frmReportesVentas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IdVentas;
        private DataGridViewTextBoxColumn CantidadProductosVendidos;
        private DataGridViewTextBoxColumn TotalFacturado;
        private DataGridViewButtonColumn VerDetalle;
    }
}