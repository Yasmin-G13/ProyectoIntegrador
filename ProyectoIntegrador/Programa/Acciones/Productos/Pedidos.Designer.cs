namespace ProyectoIntegrador.Programa.Acciones.Productos
{
    partial class Pedidos
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
            panel2 = new Panel();
            btnCerrarSesion = new Button();
            btn_Cerrar_Sesion = new Button();
            btn_Ajustes_Seguridad = new Button();
            btn_Pedidos = new Button();
            btn_Inventario = new Button();
            btn_Ventas = new Button();
            btn_Catálogo_Productos = new Button();
            dgvPedidos = new DataGridView();
            NOMBRE_CLIENTE = new DataGridViewTextBoxColumn();
            CANTIDAD = new DataGridViewTextBoxColumn();
            PRODUCTO = new DataGridViewTextBoxColumn();
            DETALLES = new DataGridViewTextBoxColumn();
            PRECIO = new DataGridViewTextBoxColumn();
            FEC_PED = new DataGridViewTextBoxColumn();
            STATUS = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Font = new Font("Baskerville Old Face", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1002, 61);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(334, 17);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(138, 32);
            label1.TabIndex = 1;
            label1.Text = "PEDIDOS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2025_05_12_204154;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnCerrarSesion);
            panel2.Controls.Add(btn_Cerrar_Sesion);
            panel2.Controls.Add(btn_Ajustes_Seguridad);
            panel2.Controls.Add(btn_Pedidos);
            panel2.Controls.Add(btn_Inventario);
            panel2.Controls.Add(btn_Ventas);
            panel2.Controls.Add(btn_Catálogo_Productos);
            panel2.Location = new Point(2, 65);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(111, 338);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.Chocolate;
            btnCerrarSesion.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrarSesion.Location = new Point(3, 272);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(106, 64);
            btnCerrarSesion.TabIndex = 6;
            btnCerrarSesion.Text = "CERRAR SESIÓN";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btn_Cerrar_Sesion
            // 
            btn_Cerrar_Sesion.BackColor = Color.Chocolate;
            btn_Cerrar_Sesion.Location = new Point(0, 333);
            btn_Cerrar_Sesion.Margin = new Padding(2);
            btn_Cerrar_Sesion.Name = "btn_Cerrar_Sesion";
            btn_Cerrar_Sesion.Size = new Size(124, 77);
            btn_Cerrar_Sesion.TabIndex = 5;
            btn_Cerrar_Sesion.Text = "CERRAR SESIÓN";
            btn_Cerrar_Sesion.UseVisualStyleBackColor = false;
            // 
            // btn_Ajustes_Seguridad
            // 
            btn_Ajustes_Seguridad.BackColor = Color.Chocolate;
            btn_Ajustes_Seguridad.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Ajustes_Seguridad.Location = new Point(2, 222);
            btn_Ajustes_Seguridad.Margin = new Padding(2);
            btn_Ajustes_Seguridad.Name = "btn_Ajustes_Seguridad";
            btn_Ajustes_Seguridad.Size = new Size(107, 45);
            btn_Ajustes_Seguridad.TabIndex = 4;
            btn_Ajustes_Seguridad.Text = "AJUSTES\r\n\r\n";
            btn_Ajustes_Seguridad.UseVisualStyleBackColor = false;
            btn_Ajustes_Seguridad.Click += btn_Ajustes_Seguridad_Click;
            // 
            // btn_Pedidos
            // 
            btn_Pedidos.BackColor = Color.Chocolate;
            btn_Pedidos.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Pedidos.Location = new Point(2, 170);
            btn_Pedidos.Margin = new Padding(2);
            btn_Pedidos.Name = "btn_Pedidos";
            btn_Pedidos.Size = new Size(107, 42);
            btn_Pedidos.TabIndex = 3;
            btn_Pedidos.Text = "PEDIDOS";
            btn_Pedidos.UseVisualStyleBackColor = false;
            btn_Pedidos.Click += btn_Pedidos_Click;
            // 
            // btn_Inventario
            // 
            btn_Inventario.BackColor = Color.Chocolate;
            btn_Inventario.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Inventario.Location = new Point(0, 118);
            btn_Inventario.Margin = new Padding(2);
            btn_Inventario.Name = "btn_Inventario";
            btn_Inventario.Size = new Size(111, 48);
            btn_Inventario.TabIndex = 2;
            btn_Inventario.Text = "INVENTARIO";
            btn_Inventario.UseVisualStyleBackColor = false;
            btn_Inventario.Click += btn_Inventario_Click;
            // 
            // btn_Ventas
            // 
            btn_Ventas.BackColor = Color.Chocolate;
            btn_Ventas.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Ventas.Location = new Point(2, 66);
            btn_Ventas.Margin = new Padding(2);
            btn_Ventas.Name = "btn_Ventas";
            btn_Ventas.Size = new Size(109, 48);
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
            btn_Catálogo_Productos.Size = new Size(111, 62);
            btn_Catálogo_Productos.TabIndex = 0;
            btn_Catálogo_Productos.Text = "PRODUCTOS";
            btn_Catálogo_Productos.UseVisualStyleBackColor = false;
            btn_Catálogo_Productos.Click += btn_Catálogo_Productos_Click;
            // 
            // dgvPedidos
            // 
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Columns.AddRange(new DataGridViewColumn[] { NOMBRE_CLIENTE, CANTIDAD, PRODUCTO, DETALLES, PRECIO, FEC_PED, STATUS });
            dgvPedidos.Location = new Point(115, 65);
            dgvPedidos.Margin = new Padding(2);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.RowHeadersWidth = 62;
            dgvPedidos.Size = new Size(889, 334);
            dgvPedidos.TabIndex = 2;
            // 
            // NOMBRE_CLIENTE
            // 
            NOMBRE_CLIENTE.HeaderText = "NOMBRE CLIENTE";
            NOMBRE_CLIENTE.MinimumWidth = 8;
            NOMBRE_CLIENTE.Name = "NOMBRE_CLIENTE";
            NOMBRE_CLIENTE.Width = 125;
            // 
            // CANTIDAD
            // 
            CANTIDAD.HeaderText = "CANTIDAD";
            CANTIDAD.MinimumWidth = 8;
            CANTIDAD.Name = "CANTIDAD";
            CANTIDAD.Width = 125;
            // 
            // PRODUCTO
            // 
            PRODUCTO.HeaderText = "PRODUCTO";
            PRODUCTO.MinimumWidth = 8;
            PRODUCTO.Name = "PRODUCTO";
            PRODUCTO.Width = 120;
            // 
            // DETALLES
            // 
            DETALLES.HeaderText = "DETALLES";
            DETALLES.MinimumWidth = 8;
            DETALLES.Name = "DETALLES";
            DETALLES.Width = 125;
            // 
            // PRECIO
            // 
            PRECIO.HeaderText = "PRECIO";
            PRECIO.MinimumWidth = 8;
            PRECIO.Name = "PRECIO";
            PRECIO.Width = 80;
            // 
            // FEC_PED
            // 
            FEC_PED.HeaderText = "FECHA PEDIDO";
            FEC_PED.MinimumWidth = 8;
            FEC_PED.Name = "FEC_PED";
            FEC_PED.Width = 120;
            // 
            // STATUS
            // 
            STATUS.HeaderText = "STATUS";
            STATUS.MinimumWidth = 8;
            STATUS.Name = "STATUS";
            STATUS.Width = 125;
            // 
            // Pedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1057, 556);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dgvPedidos);
            Margin = new Padding(2);
            Name = "Pedidos";
            Text = "Pedidos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Button btnCerrarSesion;
        private Button btn_Ajustes_Seguridad;
        private Button btn_Pedidos;
        private Button btn_Inventario;
        private Button btn_Ventas;
        private Button btn_Cerrar_Sesion;
        private Button btn_Catálogo_Productos;
        private DataGridView dgvPedidos;
        private DataGridViewTextBoxColumn NOMBRE_CLIENTE;
        private DataGridViewTextBoxColumn CANTIDAD;
        private DataGridViewTextBoxColumn PRODUCTO;
        private DataGridViewTextBoxColumn DETALLES;
        private DataGridViewTextBoxColumn PRECIO;
        private DataGridViewTextBoxColumn FEC_PED;
        private DataGridViewTextBoxColumn STATUS;
    }
}