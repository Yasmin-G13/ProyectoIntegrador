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
            label1 = new Label();
            btnProductos = new Button();
            btnVentas = new Button();
            btnInventario = new Button();
            btnAjustes = new Button();
            btnCerrarSesion = new Button();
            btnAñadirProducto = new Button();
            btnModificarProducto = new Button();
            btnDarBaja = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            conexionMySQLBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conexionMySQLBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, 1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(704, 59);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(275, 16);
            label1.Name = "label1";
            label1.Size = new Size(189, 32);
            label1.TabIndex = 0;
            label1.Text = "PRODUCTOS";
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.Chocolate;
            btnProductos.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProductos.Location = new Point(12, 20);
            btnProductos.Margin = new Padding(3, 2, 3, 2);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(82, 22);
            btnProductos.TabIndex = 2;
            btnProductos.Text = "PRODUCTOS";
            btnProductos.UseVisualStyleBackColor = false;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.Chocolate;
            btnVentas.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVentas.Location = new Point(12, 58);
            btnVentas.Margin = new Padding(3, 2, 3, 2);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(82, 22);
            btnVentas.TabIndex = 3;
            btnVentas.Text = "VENTAS";
            btnVentas.UseVisualStyleBackColor = false;
            // 
            // btnInventario
            // 
            btnInventario.BackColor = Color.Chocolate;
            btnInventario.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInventario.Location = new Point(12, 102);
            btnInventario.Margin = new Padding(3, 2, 3, 2);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(82, 22);
            btnInventario.TabIndex = 4;
            btnInventario.Text = "INVENTARIO";
            btnInventario.UseVisualStyleBackColor = false;
            // 
            // btnAjustes
            // 
            btnAjustes.BackColor = Color.Chocolate;
            btnAjustes.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAjustes.Location = new Point(12, 143);
            btnAjustes.Margin = new Padding(3, 2, 3, 2);
            btnAjustes.Name = "btnAjustes";
            btnAjustes.Size = new Size(82, 22);
            btnAjustes.TabIndex = 5;
            btnAjustes.Text = "AJUSTES";
            btnAjustes.UseVisualStyleBackColor = false;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.Chocolate;
            btnCerrarSesion.Location = new Point(12, 212);
            btnCerrarSesion.Margin = new Padding(3, 2, 3, 2);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(82, 46);
            btnCerrarSesion.TabIndex = 6;
            btnCerrarSesion.Text = "CERRAR SESIÓN";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // btnAñadirProducto
            // 
            btnAñadirProducto.BackColor = Color.SandyBrown;
            btnAñadirProducto.Location = new Point(163, 189);
            btnAñadirProducto.Margin = new Padding(3, 2, 3, 2);
            btnAñadirProducto.Name = "btnAñadirProducto";
            btnAñadirProducto.Size = new Size(508, 34);
            btnAñadirProducto.TabIndex = 7;
            btnAñadirProducto.Text = "AÑADIR PRODUCTOS";
            btnAñadirProducto.UseVisualStyleBackColor = false;
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.BackColor = Color.SandyBrown;
            btnModificarProducto.Location = new Point(163, 230);
            btnModificarProducto.Margin = new Padding(3, 2, 3, 2);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(508, 36);
            btnModificarProducto.TabIndex = 8;
            btnModificarProducto.Text = "MODIFICAR PRODUCTO";
            btnModificarProducto.UseVisualStyleBackColor = false;
            // 
            // btnDarBaja
            // 
            btnDarBaja.BackColor = Color.SandyBrown;
            btnDarBaja.Location = new Point(163, 276);
            btnDarBaja.Margin = new Padding(3, 2, 3, 2);
            btnDarBaja.Name = "btnDarBaja";
            btnDarBaja.Size = new Size(508, 34);
            btnDarBaja.TabIndex = 9;
            btnDarBaja.Text = "DAR DE BAJA PRODUCTO";
            btnDarBaja.UseVisualStyleBackColor = false;
            btnDarBaja.Click += button8_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnProductos);
            panel2.Controls.Add(btnVentas);
            panel2.Controls.Add(btnInventario);
            panel2.Controls.Add(btnAjustes);
            panel2.Controls.Add(btnCerrarSesion);
            panel2.Location = new Point(-2, 58);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(124, 287);
            panel2.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.DataSource = conexionMySQLBindingSource;
            dataGridView1.Location = new Point(163, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(508, 92);
            dataGridView1.TabIndex = 11;
            // 
            // conexionMySQLBindingSource
            // 
            conexionMySQLBindingSource.DataSource = typeof(ConexionMySQL);
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(700, 338);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(btnDarBaja);
            Controls.Add(btnModificarProducto);
            Controls.Add(btnAñadirProducto);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Productos";
            Text = "FormProductos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}