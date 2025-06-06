namespace ProyectoIntegrador.Programa.Acciones.Productos
{
    partial class Productos
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            btnProductos = new Button();
            btnVentas = new Button();
            btnInventario = new Button();
            btnAjustes = new Button();
            btnCerrarSesion = new Button();
            btnAñadirProducto = new Button();
            btnModificarProducto = new Button();
            btnDarBaja = new Button();
            panel2 = new Panel();
            btnPedidos = new Button();
            dataGridView1 = new DataGridView();
            conexionMySQLBindingSource = new BindingSource(components);
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conexionMySQLBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, 1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 72);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2025_05_12_204154;
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(343, 17);
            label1.Name = "label1";
            label1.Size = new Size(189, 32);
            label1.TabIndex = 0;
            label1.Text = "PRODUCTOS";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(144, 78);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(696, 237);
            dataGridView2.TabIndex = 2;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.Chocolate;
            btnProductos.Font = new Font("Times New Roman", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProductos.Location = new Point(0, 1);
            btnProductos.Margin = new Padding(3, 2, 3, 2);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(127, 57);
            btnProductos.TabIndex = 2;
            btnProductos.Text = "PRODUCTOS";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.Chocolate;
            btnVentas.Font = new Font("Times New Roman", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVentas.Location = new Point(0, 62);
            btnVentas.Margin = new Padding(3, 2, 3, 2);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(127, 57);
            btnVentas.TabIndex = 3;
            btnVentas.Text = "VENTAS";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnInventario
            // 
            btnInventario.BackColor = Color.Chocolate;
            btnInventario.Font = new Font("Times New Roman", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInventario.Location = new Point(0, 132);
            btnInventario.Margin = new Padding(3, 2, 3, 2);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(127, 57);
            btnInventario.TabIndex = 4;
            btnInventario.Text = "INVENTARIO";
            btnInventario.UseVisualStyleBackColor = false;
            btnInventario.Click += btnInventario_Click;
            // 
            // btnAjustes
            // 
            btnAjustes.BackColor = Color.Chocolate;
            btnAjustes.Font = new Font("Times New Roman", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAjustes.Location = new Point(-4, 278);
            btnAjustes.Margin = new Padding(3, 2, 3, 2);
            btnAjustes.Name = "btnAjustes";
            btnAjustes.Size = new Size(131, 57);
            btnAjustes.TabIndex = 5;
            btnAjustes.Text = "AJUSTES";
            btnAjustes.UseVisualStyleBackColor = false;
            btnAjustes.Click += btnAjustes_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.Chocolate;
            btnCerrarSesion.Font = new Font("Times New Roman", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrarSesion.Location = new Point(0, 349);
            btnCerrarSesion.Margin = new Padding(3, 2, 3, 2);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(127, 57);
            btnCerrarSesion.TabIndex = 6;
            btnCerrarSesion.Text = "CERRAR SESIÓN";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnAñadirProducto
            // 
            btnAñadirProducto.BackColor = Color.SandyBrown;
            btnAñadirProducto.Location = new Point(144, 320);
            btnAñadirProducto.Margin = new Padding(3, 2, 3, 2);
            btnAñadirProducto.Name = "btnAñadirProducto";
            btnAñadirProducto.Size = new Size(696, 57);
            btnAñadirProducto.TabIndex = 7;
            btnAñadirProducto.Text = "AÑADIR PRODUCTOS";
            btnAñadirProducto.UseVisualStyleBackColor = false;
            btnAñadirProducto.Click += btnAñadirProducto_Click_1;
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.BackColor = Color.SandyBrown;
            btnModificarProducto.Location = new Point(144, 381);
            btnModificarProducto.Margin = new Padding(3, 2, 3, 2);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(696, 57);
            btnModificarProducto.TabIndex = 8;
            btnModificarProducto.Text = "MODIFICAR PRODUCTO";
            btnModificarProducto.UseVisualStyleBackColor = false;
            btnModificarProducto.Click += btnModificarProducto_Click;
            // 
            // btnDarBaja
            // 
            btnDarBaja.BackColor = Color.SandyBrown;
            btnDarBaja.Location = new Point(144, 442);
            btnDarBaja.Margin = new Padding(3, 2, 3, 2);
            btnDarBaja.Name = "btnDarBaja";
            btnDarBaja.Size = new Size(696, 57);
            btnDarBaja.TabIndex = 9;
            btnDarBaja.Text = "DAR DE BAJA PRODUCTO";
            btnDarBaja.UseVisualStyleBackColor = false;
            btnDarBaja.Click += button8_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnPedidos);
            panel2.Controls.Add(btnProductos);
            panel2.Controls.Add(btnVentas);
            panel2.Controls.Add(btnInventario);
            panel2.Controls.Add(btnAjustes);
            panel2.Controls.Add(btnCerrarSesion);
            panel2.Location = new Point(-2, 77);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(127, 422);
            panel2.TabIndex = 10;
            // 
            // btnPedidos
            // 
            btnPedidos.BackColor = Color.Chocolate;
            btnPedidos.Font = new Font("Times New Roman", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPedidos.Location = new Point(3, 205);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(124, 57);
            btnPedidos.TabIndex = 12;
            btnPedidos.Text = "PEDIDOS";
            btnPedidos.UseVisualStyleBackColor = false;
            btnPedidos.Click += btnPedidos_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.DataSource = conexionMySQLBindingSource;
            dataGridView1.Location = new Point(144, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(696, 237);
            dataGridView1.TabIndex = 11;
            // 
            // conexionMySQLBindingSource
            // 
            conexionMySQLBindingSource.DataSource = typeof(ConexionMySQL);
            // 
            // button1
            // 
            button1.BackColor = Color.Chocolate;
            button1.Font = new Font("Times New Roman", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(3, 205);
            button1.Name = "button1";
            button1.Size = new Size(124, 57);
            button1.TabIndex = 12;
            button1.Text = "PEDIDOS";
            button1.UseVisualStyleBackColor = false;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(852, 494);
            Controls.Add(dataGridView2);
            Controls.Add(panel2);
            Controls.Add(btnDarBaja);
            Controls.Add(btnModificarProducto);
            Controls.Add(btnAñadirProducto);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Productos";
            Text = "FormProductos";
            Load += productos_load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)conexionMySQLBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Button btnProductos;
        private Button btnVentas;
        private Button btnInventario;
        private Button btnAjustes;
        private Button btnCerrarSesion;
        private Button btnAñadirProducto;
        private Button btnModificarProducto;
        private Button btnDarBaja;
        private Panel panel2;
        private DataGridView dataGridView1;
        private BindingSource conexionMySQLBindingSource;
        private PictureBox pictureBox1;
//<<<<<<< HEAD
        private Button btnPedidos;
//=======
        private Button button1;
        private DataGridView MiDridView;
        private DataGridView dataGridView2;
        //>>>>>>> datawritview no funciona
    }
}