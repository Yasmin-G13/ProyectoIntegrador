namespace ProyectoIntegrador.Programa.Acciones.Productos
{
    partial class ModificarProductos
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
            dataGridView1 = new DataGridView();
            conexionMySQLBindingSource = new BindingSource(components);
            label1 = new Label();
            btnRegresar = new Button();
            btnModificar = new Button();
            dataGridViewProductos = new DataGridView();
            NOMBRE = new Label();
            CANTIDAD = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textNombre = new TextBox();
            textCantidad = new TextBox();
            textPrecio = new TextBox();
            textCategoria = new TextBox();
            textDetalles = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conexionMySQLBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnRegresar);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 59);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.DataSource = conexionMySQLBindingSource;
            dataGridView1.Location = new Point(12, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(658, 216);
            dataGridView1.TabIndex = 2;
            // 
            // conexionMySQLBindingSource
            // 
            conexionMySQLBindingSource.DataSource = typeof(ConexionMySQL);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SandyBrown;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(238, 18);
            label1.Name = "label1";
            label1.Size = new Size(189, 32);
            label1.TabIndex = 0;
            label1.Text = "PRODUCTOS";
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.Chocolate;
            btnRegresar.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.ForeColor = SystemColors.ButtonFace;
            btnRegresar.Location = new Point(0, 0);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(139, 59);
            btnRegresar.TabIndex = 1;
            btnRegresar.Text = "REGRESAR";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.SandyBrown;
            btnModificar.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(24, 357);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(618, 42);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "MODIFICAR PRODUCTO";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Location = new Point(24, 65);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.RowHeadersWidth = 51;
            dataGridViewProductos.Size = new Size(618, 87);
            dataGridViewProductos.TabIndex = 3;
            // 
            // NOMBRE
            // 
            NOMBRE.AutoSize = true;
            NOMBRE.Location = new Point(38, 172);
            NOMBRE.Name = "NOMBRE";
            NOMBRE.Size = new Size(70, 20);
            NOMBRE.TabIndex = 4;
            NOMBRE.Text = "NOMBRE";
            // 
            // CANTIDAD
            // 
            CANTIDAD.AutoSize = true;
            CANTIDAD.Location = new Point(43, 201);
            CANTIDAD.Name = "CANTIDAD";
            CANTIDAD.Size = new Size(83, 20);
            CANTIDAD.TabIndex = 5;
            CANTIDAD.Text = "CANTIDAD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 229);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 6;
            label4.Text = "DETALLES";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 267);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 7;
            label5.Text = "PRECIO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 304);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 8;
            label6.Text = "CATEGORIA";
            // 
            // textNombre
            // 
            textNombre.Location = new Point(186, 165);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(456, 27);
            textNombre.TabIndex = 9;
            // 
            // textCantidad
            // 
            textCantidad.Location = new Point(186, 198);
            textCantidad.Name = "textCantidad";
            textCantidad.Size = new Size(456, 27);
            textCantidad.TabIndex = 10;
            // 
            // textPrecio
            // 
            textPrecio.Location = new Point(186, 264);
            textPrecio.Name = "textPrecio";
            textPrecio.Size = new Size(456, 27);
            textPrecio.TabIndex = 12;
            // 
            // textCategoria
            // 
            textCategoria.Location = new Point(186, 297);
            textCategoria.Name = "textCategoria";
            textCategoria.Size = new Size(456, 27);
            textCategoria.TabIndex = 13;
            // 
            // textDetalles
            // 
            textDetalles.Location = new Point(185, 231);
            textDetalles.Name = "textDetalles";
            textDetalles.Size = new Size(457, 27);
            textDetalles.TabIndex = 14;
            // 
            // ModificarProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(682, 413);
            Controls.Add(textDetalles);
            Controls.Add(textCategoria);
            Controls.Add(textPrecio);
            Controls.Add(textCantidad);
            Controls.Add(textNombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(CANTIDAD);
            Controls.Add(NOMBRE);
            Controls.Add(dataGridViewProductos);
            Controls.Add(btnModificar);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "ModificarProductos";
            Text = "ModificarProductos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)conexionMySQLBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnRegresar;
        private Button button2;
        private DataGridView dataGridView1;
        private BindingSource conexionMySQLBindingSource;
        private Button btnModificar;
        private DataGridView dataGridViewProductos;
        private Label NOMBRE;
        private Label CANTIDAD;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textNombre;
        private TextBox textCantidad;
        private TextBox textPrecio;
        private TextBox textCategoria;
        private TextBox textDetalles;
    }
}