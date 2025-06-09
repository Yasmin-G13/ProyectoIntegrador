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
            btn_Pedidos = new Button();
            btn_Ventas = new Button();
            btn_Catálogo_Productos = new Button();
            dataPedidos = new DataGridView();
            btnAñadirPedido = new Button();
            btnEditarPedido = new Button();
            btnEliminarPedido = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataPedidos).BeginInit();
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
            panel1.Size = new Size(877, 46);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(380, 5);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 1;
            label1.Text = "PEDIDOS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2025_05_12_204154;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnCerrarSesion);
            panel2.Controls.Add(btn_Cerrar_Sesion);
            panel2.Controls.Add(btn_Pedidos);
            panel2.Controls.Add(btn_Ventas);
            panel2.Controls.Add(btn_Catálogo_Productos);
            panel2.Location = new Point(2, 49);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(97, 184);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.Chocolate;
            btnCerrarSesion.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrarSesion.Location = new Point(4, 126);
            btnCerrarSesion.Margin = new Padding(3, 2, 3, 2);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(93, 48);
            btnCerrarSesion.TabIndex = 6;
            btnCerrarSesion.Text = "CERRAR SESIÓN";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btn_Cerrar_Sesion
            // 
            btn_Cerrar_Sesion.BackColor = Color.Chocolate;
            btn_Cerrar_Sesion.Location = new Point(0, 250);
            btn_Cerrar_Sesion.Margin = new Padding(2);
            btn_Cerrar_Sesion.Name = "btn_Cerrar_Sesion";
            btn_Cerrar_Sesion.Size = new Size(108, 58);
            btn_Cerrar_Sesion.TabIndex = 5;
            btn_Cerrar_Sesion.Text = "CERRAR SESIÓN";
            btn_Cerrar_Sesion.UseVisualStyleBackColor = false;
            // 
            // btn_Pedidos
            // 
            btn_Pedidos.BackColor = Color.Chocolate;
            btn_Pedidos.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Pedidos.Location = new Point(1, 90);
            btn_Pedidos.Margin = new Padding(2);
            btn_Pedidos.Name = "btn_Pedidos";
            btn_Pedidos.Size = new Size(94, 32);
            btn_Pedidos.TabIndex = 3;
            btn_Pedidos.Text = "PEDIDOS";
            btn_Pedidos.UseVisualStyleBackColor = false;
            btn_Pedidos.Click += btn_Pedidos_Click;
            // 
            // btn_Ventas
            // 
            btn_Ventas.BackColor = Color.Chocolate;
            btn_Ventas.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Ventas.Location = new Point(2, 50);
            btn_Ventas.Margin = new Padding(2);
            btn_Ventas.Name = "btn_Ventas";
            btn_Ventas.Size = new Size(95, 36);
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
            btn_Catálogo_Productos.Size = new Size(97, 46);
            btn_Catálogo_Productos.TabIndex = 0;
            btn_Catálogo_Productos.Text = "PRODUCTOS";
            btn_Catálogo_Productos.UseVisualStyleBackColor = false;
            btn_Catálogo_Productos.Click += btn_Catálogo_Productos_Click;
            // 
            // dataPedidos
            // 
            dataPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataPedidos.Location = new Point(133, 64);
            dataPedidos.Margin = new Padding(3, 2, 3, 2);
            dataPedidos.Name = "dataPedidos";
            dataPedidos.RowHeadersWidth = 51;
            dataPedidos.Size = new Size(707, 169);
            dataPedidos.TabIndex = 2;
            dataPedidos.CellClick += dataPedidos_CellClick;
            // 
            // btnAñadirPedido
            // 
            btnAñadirPedido.BackColor = Color.SandyBrown;
            btnAñadirPedido.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAñadirPedido.Location = new Point(133, 253);
            btnAñadirPedido.Margin = new Padding(3, 2, 3, 2);
            btnAñadirPedido.Name = "btnAñadirPedido";
            btnAñadirPedido.Size = new Size(707, 33);
            btnAñadirPedido.TabIndex = 3;
            btnAñadirPedido.Text = "AÑADIR PEDIDO";
            btnAñadirPedido.UseVisualStyleBackColor = false;
            btnAñadirPedido.Click += btnAñadirPedido_Click;
            // 
            // btnEditarPedido
            // 
            btnEditarPedido.BackColor = Color.SandyBrown;
            btnEditarPedido.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditarPedido.Location = new Point(133, 290);
            btnEditarPedido.Margin = new Padding(3, 2, 3, 2);
            btnEditarPedido.Name = "btnEditarPedido";
            btnEditarPedido.Size = new Size(707, 33);
            btnEditarPedido.TabIndex = 4;
            btnEditarPedido.Text = "EDITAR PEDIDO";
            btnEditarPedido.UseVisualStyleBackColor = false;
            btnEditarPedido.Click += btnEditarPedido_Click;
            // 
            // btnEliminarPedido
            // 
            btnEliminarPedido.BackColor = Color.SandyBrown;
            btnEliminarPedido.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarPedido.Location = new Point(133, 328);
            btnEliminarPedido.Margin = new Padding(3, 2, 3, 2);
            btnEliminarPedido.Name = "btnEliminarPedido";
            btnEliminarPedido.Size = new Size(707, 33);
            btnEliminarPedido.TabIndex = 5;
            btnEliminarPedido.Text = "ELIMINAR PEDIDO";
            btnEliminarPedido.UseVisualStyleBackColor = false;
            btnEliminarPedido.Click += btnEliminarPedido_Click;
            // 
            // Pedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(876, 390);
            Controls.Add(btnEliminarPedido);
            Controls.Add(btnEditarPedido);
            Controls.Add(btnAñadirPedido);
            Controls.Add(dataPedidos);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Pedidos";
            Text = "Pedidos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataPedidos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Button btnCerrarSesion;
        private Button btn_Pedidos;
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
        private DataGridView dataPedidos;
        private Button btnAñadirPedido;
        private Button btnEditarPedido;
        private Button btnEliminarPedido;
    }
}