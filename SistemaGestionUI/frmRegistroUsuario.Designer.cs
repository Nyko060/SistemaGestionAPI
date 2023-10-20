namespace SistemaGestionUI
{
    partial class frmRegistroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroUsuario));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(137, 128);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(184, 35);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(137, 170);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(184, 35);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(212, 211);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(163, 35);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(166, 257);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(209, 35);
            textBox4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, 60);
            label1.Name = "label1";
            label1.Size = new Size(205, 30);
            label1.TabIndex = 4;
            label1.Text = "Registro de Usuario";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Cyan;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(263, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(148, 115);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(31, 128);
            label2.Name = "label2";
            label2.Size = new Size(100, 30);
            label2.TabIndex = 10;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(33, 170);
            label3.Name = "label3";
            label3.Size = new Size(102, 30);
            label3.TabIndex = 11;
            label3.Text = "Apellido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(31, 211);
            label4.Name = "label4";
            label4.Size = new Size(175, 30);
            label4.TabIndex = 12;
            label4.Text = "NombreUsuario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(31, 257);
            label5.Name = "label5";
            label5.Size = new Size(129, 30);
            label5.TabIndex = 13;
            label5.Text = "Contraseña:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(33, 302);
            label6.Name = "label6";
            label6.Size = new Size(62, 30);
            label6.TabIndex = 14;
            label6.Text = "Mail:";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(101, 302);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(274, 35);
            textBox5.TabIndex = 15;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(101, 352);
            button1.Name = "button1";
            button1.Size = new Size(242, 53);
            button1.TabIndex = 16;
            button1.Text = "Confirmar Registro";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmRegistroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(443, 417);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "frmRegistroUsuario";
            Text = "frmRegistroUsuario";
            Load += frmRegistroUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox5;
        private Button button1;
    }
}