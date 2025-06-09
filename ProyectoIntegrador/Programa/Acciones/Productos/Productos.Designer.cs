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
            dgvProductos = new DataGridView();
            btnProductos = new Button();
            btnVentas = new Button();
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
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
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
            panel1.Size = new Size(945, 72);
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
            label1.Location = new Point(456, 20);
            label1.Name = "label1";
            label1.Size = new Size(150, 25);
            label1.TabIndex = 0;
            label1.Text = "PRODUCTOS";
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(131, 78);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(812, 330);
            dgvProductos.TabIndex = 2;
            dgvProductos.CellContentClick += dataGridView2_CellContentClick;
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
            btnVentas.Location = new Point(-3, 62);
            btnVentas.Margin = new Padding(3, 2, 3, 2);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(127, 57);
            btnVentas.TabIndex = 3;
            btnVentas.Text = "VENTAS";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.Chocolate;
            btnCerrarSesion.Font = new Font("Times New Roman", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrarSesion.Location = new Point(-3, 186);
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
            btnAñadirProducto.Location = new Point(207, 413);
            btnAñadirProducto.Margin = new Padding(3, 2, 3, 2);
            btnAñadirProducto.Name = "btnAñadirProducto";
            btnAñadirProducto.Size = new Size(696, 47);
            btnAñadirProducto.TabIndex = 7;
            btnAñadirProducto.Text = "AÑADIR PRODUCTOS";
            btnAñadirProducto.UseVisualStyleBackColor = false;
            btnAñadirProducto.Click += btnAñadirProducto_Click_1;
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.BackColor = Color.SandyBrown;
            btnModificarProducto.Location = new Point(207, 464);
            btnModificarProducto.Margin = new Padding(3, 2, 3, 2);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(696, 47);
            btnModificarProducto.TabIndex = 8;
            btnModificarProducto.Text = "MODIFICAR PRODUCTO";
            btnModificarProducto.UseVisualStyleBackColor = false;
            btnModificarProducto.Click += btnModificarProducto_Click;
            // 
            // btnDarBaja
            // 
            btnDarBaja.BackColor = Color.SandyBrown;
            btnDarBaja.Location = new Point(207, 515);
            btnDarBaja.Margin = new Padding(3, 2, 3, 2);
            btnDarBaja.Name = "btnDarBaja";
            btnDarBaja.Size = new Size(696, 42);
            btnDarBaja.TabIndex = 9;
            btnDarBaja.Text = "DAR DE BAJA PRODUCTO";
            btnDarBaja.UseVisualStyleBackColor = false;
            btnDarBaja.Click += btnDarBaja_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnPedidos);
            panel2.Controls.Add(btnProductos);
            panel2.Controls.Add(btnVentas);
            panel2.Controls.Add(btnCerrarSesion);
            panel2.Location = new Point(-2, 77);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(127, 247);
            panel2.TabIndex = 10;
            // 
            // btnPedidos
            // 
            btnPedidos.BackColor = Color.Chocolate;
            btnPedidos.Font = new Font("Times New Roman", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPedidos.Location = new Point(0, 124);
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
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1016, 626);
            Controls.Add(dgvProductos);
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
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
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
        private DataGridView dgvProductos;
        //>>>>>>> datawritview no funciona
    }
}