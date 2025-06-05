namespace ProyectoIntegrador.Programa.Acciones.Productos
{
    partial class Inventario
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
            panel2 = new Panel();
            btnCerrarSesión = new Button();
            btnAjustes = new Button();
            btnPedidos = new Button();
            btnInventario = new Button();
            btnVentas = new Button();
            btnProductos = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 82);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(282, 23);
            label1.Name = "label1";
            label1.Size = new Size(191, 32);
            label1.TabIndex = 0;
            label1.Text = "INVENTARIO";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnCerrarSesión);
            panel2.Controls.Add(btnAjustes);
            panel2.Controls.Add(btnPedidos);
            panel2.Controls.Add(btnInventario);
            panel2.Controls.Add(btnVentas);
            panel2.Controls.Add(btnProductos);
            panel2.Location = new Point(-1, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(131, 371);
            panel2.TabIndex = 1;
            // 
            // btnCerrarSesión
            // 
            btnCerrarSesión.BackColor = Color.Chocolate;
            btnCerrarSesión.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrarSesión.Location = new Point(0, 297);
            btnCerrarSesión.Name = "btnCerrarSesión";
            btnCerrarSesión.Size = new Size(119, 60);
            btnCerrarSesión.TabIndex = 5;
            btnCerrarSesión.Text = "CERRAR SESIÓN";
            btnCerrarSesión.UseVisualStyleBackColor = false;
            btnCerrarSesión.Click += btnCerrarSesión_Click;
            // 
            // btnAjustes
            // 
            btnAjustes.BackColor = Color.Chocolate;
            btnAjustes.Location = new Point(3, 245);
            btnAjustes.Name = "btnAjustes";
            btnAjustes.Size = new Size(116, 46);
            btnAjustes.TabIndex = 4;
            btnAjustes.Text = "AJUSTES";
            btnAjustes.UseVisualStyleBackColor = false;
            btnAjustes.Click += btnAjustes_Click;
            // 
            // btnPedidos
            // 
            btnPedidos.BackColor = Color.Chocolate;
            btnPedidos.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPedidos.Location = new Point(3, 185);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(116, 54);
            btnPedidos.TabIndex = 3;
            btnPedidos.Text = "PEDIDOS";
            btnPedidos.UseVisualStyleBackColor = false;
            btnPedidos.Click += btnPedidos_Click;
            // 
            // btnInventario
            // 
            btnInventario.BackColor = Color.Chocolate;
            btnInventario.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInventario.Location = new Point(3, 129);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(116, 50);
            btnInventario.TabIndex = 2;
            btnInventario.Text = "INVENTARIO";
            btnInventario.UseVisualStyleBackColor = false;
            btnInventario.Click += btnInventario_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.Chocolate;
            btnVentas.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVentas.Location = new Point(3, 71);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(116, 50);
            btnVentas.TabIndex = 1;
            btnVentas.Text = "VENTAS";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.Chocolate;
            btnProductos.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProductos.Location = new Point(3, 6);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(116, 59);
            btnProductos.TabIndex = 0;
            btnProductos.Text = "PRODUCTOS";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(155, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(619, 312);
            dataGridView1.TabIndex = 2;
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Inventario";
            Text = "Inventario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnCerrarSesión;
        private Button btnAjustes;
        private Button btnPedidos;
        private Button btnInventario;
        private Button btnVentas;
        private Button btnProductos;
        private Label label1;
        private DataGridView dataGridView1;
    }
}