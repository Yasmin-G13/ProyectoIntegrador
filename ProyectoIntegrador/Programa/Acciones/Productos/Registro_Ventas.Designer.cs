namespace ProyectoIntegrador.Programa.Acciones.Productos
{
    partial class Registro_Ventas
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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel2 = new Panel();
            btn_Cerrar_Sesion = new Button();
            btn_Pedidos = new Button();
            btn_Ventas = new Button();
            btn_Catálogo_Productos = new Button();
            panel4 = new Panel();
            label2 = new Label();
            dgvVentas = new DataGridView();
            btnAgregarVenta = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(780, 47);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(152, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(279, 27);
            label1.TabIndex = 1;
            label1.Text = "REGISTRO DE VENTAS ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2025_05_12_204154;
            pictureBox1.Location = new Point(548, 2);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(btn_Cerrar_Sesion);
            panel3.Controls.Add(btn_Pedidos);
            panel3.Controls.Add(btn_Ventas);
            panel3.Controls.Add(btn_Catálogo_Productos);
            panel3.Location = new Point(0, 47);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(88, 167);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SandyBrown;
            panel2.Location = new Point(90, 211);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(507, 38);
            panel2.TabIndex = 2;
            // 
            // btn_Cerrar_Sesion
            // 
            btn_Cerrar_Sesion.BackColor = Color.Chocolate;
            btn_Cerrar_Sesion.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Cerrar_Sesion.Location = new Point(0, 126);
            btn_Cerrar_Sesion.Margin = new Padding(2);
            btn_Cerrar_Sesion.Name = "btn_Cerrar_Sesion";
            btn_Cerrar_Sesion.Size = new Size(87, 39);
            btn_Cerrar_Sesion.TabIndex = 5;
            btn_Cerrar_Sesion.Text = "CERRAR SESIÓN";
            btn_Cerrar_Sesion.UseVisualStyleBackColor = false;
            btn_Cerrar_Sesion.Click += btn_Cerrar_Sesion_Click;
            // 
            // btn_Pedidos
            // 
            btn_Pedidos.BackColor = Color.Chocolate;
            btn_Pedidos.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Pedidos.Location = new Point(0, 88);
            btn_Pedidos.Margin = new Padding(2);
            btn_Pedidos.Name = "btn_Pedidos";
            btn_Pedidos.Size = new Size(87, 34);
            btn_Pedidos.TabIndex = 3;
            btn_Pedidos.Text = "PEDIDOS";
            btn_Pedidos.UseVisualStyleBackColor = false;
            btn_Pedidos.Click += btn_Pedidos_Click;
            // 
            // btn_Ventas
            // 
            btn_Ventas.BackColor = Color.Chocolate;
            btn_Ventas.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Ventas.Location = new Point(0, 50);
            btn_Ventas.Margin = new Padding(2);
            btn_Ventas.Name = "btn_Ventas";
            btn_Ventas.Size = new Size(87, 34);
            btn_Ventas.TabIndex = 1;
            btn_Ventas.Text = "VENTAS";
            btn_Ventas.UseVisualStyleBackColor = false;
            btn_Ventas.Click += btn_Ventas_Click;
            // 
            // btn_Catálogo_Productos
            // 
            btn_Catálogo_Productos.BackColor = Color.Chocolate;
            btn_Catálogo_Productos.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Catálogo_Productos.Location = new Point(0, 0);
            btn_Catálogo_Productos.Margin = new Padding(2);
            btn_Catálogo_Productos.Name = "btn_Catálogo_Productos";
            btn_Catálogo_Productos.Size = new Size(87, 46);
            btn_Catálogo_Productos.TabIndex = 0;
            btn_Catálogo_Productos.Text = "CATÁLOGO/\r\nPRODUCTO";
            btn_Catálogo_Productos.UseVisualStyleBackColor = false;
            btn_Catálogo_Productos.Click += btn_Catálogo_Productos_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SandyBrown;
            panel4.Controls.Add(label2);
            panel4.Location = new Point(90, 260);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(690, 38);
            panel4.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 8);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(301, 30);
            label2.TabIndex = 0;
            label2.Text = "                                    Col. Los Pinitos\r\nContacto: 1545340116              mueblesnyas@gmail.com";
            label2.Click += label2_Click;
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(91, 51);
            dgvVentas.Margin = new Padding(3, 2, 3, 2);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.Size = new Size(689, 175);
            dgvVentas.TabIndex = 3;
            // 
            // btnAgregarVenta
            // 
            btnAgregarVenta.BackColor = Color.SandyBrown;
            btnAgregarVenta.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarVenta.Location = new Point(132, 230);
            btnAgregarVenta.Margin = new Padding(3, 2, 3, 2);
            btnAgregarVenta.Name = "btnAgregarVenta";
            btnAgregarVenta.Size = new Size(635, 26);
            btnAgregarVenta.TabIndex = 4;
            btnAgregarVenta.Text = "AGREGAR VENTA ";
            btnAgregarVenta.UseVisualStyleBackColor = false;
            btnAgregarVenta.Click += button1_Click;
            // 
            // Registro_Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(790, 404);
            Controls.Add(btnAgregarVenta);
            Controls.Add(dgvVentas);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Registro_Ventas";
            Text = "Registro_Ventas";
            Load += ventas_load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Button btn_Catálogo_Productos;
        private Button btn_Cerrar_Sesion;
        private Button btn_Pedidos;
        private Button btn_Ventas;
        private Panel panel2;
        private Panel panel4;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NOMBRE_CLIENTE;
        private DataGridViewTextBoxColumn CANTIDAD;
        private DataGridViewTextBoxColumn PRODUCTOS;
        private DataGridViewTextBoxColumn DETALLES;
        private DataGridViewTextBoxColumn PRECIO;
        private DataGridViewTextBoxColumn FECHA;
        private DataGridView dgvVentas;
        private Button btnAgregarVenta;
    }
}