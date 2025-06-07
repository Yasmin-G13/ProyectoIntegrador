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
            btn_Ajustes_Seguridad = new Button();
            btn_Pedidos = new Button();
            btn_Inventario = new Button();
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
            panel1.Size = new Size(706, 63);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(174, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(353, 34);
            label1.TabIndex = 1;
            label1.Text = "REGISTRO DE VENTAS ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2025_05_12_204154;
            pictureBox1.Location = new Point(626, 2);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(btn_Cerrar_Sesion);
            panel3.Controls.Add(btn_Ajustes_Seguridad);
            panel3.Controls.Add(btn_Pedidos);
            panel3.Controls.Add(btn_Inventario);
            panel3.Controls.Add(btn_Ventas);
            panel3.Controls.Add(btn_Catálogo_Productos);
            panel3.Location = new Point(0, 63);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(101, 333);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SandyBrown;
            panel2.Location = new Point(103, 281);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(579, 50);
            panel2.TabIndex = 2;
            // 
            // btn_Cerrar_Sesion
            // 
            btn_Cerrar_Sesion.BackColor = Color.Chocolate;
            btn_Cerrar_Sesion.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Cerrar_Sesion.Location = new Point(0, 281);
            btn_Cerrar_Sesion.Margin = new Padding(2);
            btn_Cerrar_Sesion.Name = "btn_Cerrar_Sesion";
            btn_Cerrar_Sesion.Size = new Size(99, 52);
            btn_Cerrar_Sesion.TabIndex = 5;
            btn_Cerrar_Sesion.Text = "CERRAR SESIÓN";
            btn_Cerrar_Sesion.UseVisualStyleBackColor = false;
            btn_Cerrar_Sesion.Click += btn_Cerrar_Sesion_Click;
            // 
            // btn_Ajustes_Seguridad
            // 
            btn_Ajustes_Seguridad.BackColor = Color.Chocolate;
            btn_Ajustes_Seguridad.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Ajustes_Seguridad.Location = new Point(-1, 218);
            btn_Ajustes_Seguridad.Margin = new Padding(2);
            btn_Ajustes_Seguridad.Name = "btn_Ajustes_Seguridad";
            btn_Ajustes_Seguridad.Size = new Size(99, 58);
            btn_Ajustes_Seguridad.TabIndex = 4;
            btn_Ajustes_Seguridad.Text = "AJUSTES/\r\nSEGURIDAD\r\n";
            btn_Ajustes_Seguridad.UseVisualStyleBackColor = false;
            btn_Ajustes_Seguridad.Click += btn_Ajustes_Seguridad_Click;
            // 
            // btn_Pedidos
            // 
            btn_Pedidos.BackColor = Color.Chocolate;
            btn_Pedidos.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Pedidos.Location = new Point(-1, 167);
            btn_Pedidos.Margin = new Padding(2);
            btn_Pedidos.Name = "btn_Pedidos";
            btn_Pedidos.Size = new Size(99, 46);
            btn_Pedidos.TabIndex = 3;
            btn_Pedidos.Text = "PEDIDOS";
            btn_Pedidos.UseVisualStyleBackColor = false;
            btn_Pedidos.Click += btn_Pedidos_Click;
            // 
            // btn_Inventario
            // 
            btn_Inventario.BackColor = Color.Chocolate;
            btn_Inventario.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Inventario.Location = new Point(-1, 117);
            btn_Inventario.Margin = new Padding(2);
            btn_Inventario.Name = "btn_Inventario";
            btn_Inventario.Size = new Size(99, 46);
            btn_Inventario.TabIndex = 2;
            btn_Inventario.Text = "INVENTARIO";
            btn_Inventario.UseVisualStyleBackColor = false;
            btn_Inventario.Click += btn_Inventario_Click;
            // 
            // btn_Ventas
            // 
            btn_Ventas.BackColor = Color.Chocolate;
            btn_Ventas.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Ventas.Location = new Point(0, 66);
            btn_Ventas.Margin = new Padding(2);
            btn_Ventas.Name = "btn_Ventas";
            btn_Ventas.Size = new Size(99, 46);
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
            btn_Catálogo_Productos.Size = new Size(99, 62);
            btn_Catálogo_Productos.TabIndex = 0;
            btn_Catálogo_Productos.Text = "CATÁLOGO/\r\nPRODUCTO";
            btn_Catálogo_Productos.UseVisualStyleBackColor = false;
            btn_Catálogo_Productos.Click += btn_Catálogo_Productos_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SandyBrown;
            panel4.Controls.Add(label2);
            panel4.Location = new Point(103, 344);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(603, 52);
            panel4.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 6);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(381, 40);
            label2.TabIndex = 0;
            label2.Text = "                                    Col. Los Pinitos\r\nContacto: 1545340116              mueblesnyas@gmail.com";
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(121, 86);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.Size = new Size(561, 190);
            dgvVentas.TabIndex = 3;
            // 
            // btnAgregarVenta
            // 
            btnAgregarVenta.BackColor = Color.SandyBrown;
            btnAgregarVenta.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarVenta.Location = new Point(121, 294);
            btnAgregarVenta.Name = "btnAgregarVenta";
            btnAgregarVenta.Size = new Size(561, 34);
            btnAgregarVenta.TabIndex = 4;
            btnAgregarVenta.Text = "AGREGAR VENTA ";
            btnAgregarVenta.UseVisualStyleBackColor = false;
            btnAgregarVenta.Click += button1_Click;
            // 
            // Registro_Ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(702, 397);
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
        private Button btn_Ajustes_Seguridad;
        private Button btn_Pedidos;
        private Button btn_Inventario;
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