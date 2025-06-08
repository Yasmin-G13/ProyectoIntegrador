namespace ProyectoIntegrador.Programa.Acciones.Productos
{
    partial class AgregarVentas
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
            butnAñadirventa = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textCliente = new TextBox();
            textProducto = new TextBox();
            textCantidad = new TextBox();
            textDetalles = new TextBox();
            textPrecio = new TextBox();
            panel1 = new Panel();
            label6 = new Label();
            butnRegresar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // butnAñadirventa
            // 
            butnAñadirventa.BackColor = Color.SandyBrown;
            butnAñadirventa.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            butnAñadirventa.Location = new Point(315, 332);
            butnAñadirventa.Name = "butnAñadirventa";
            butnAñadirventa.Size = new Size(326, 39);
            butnAñadirventa.TabIndex = 0;
            butnAñadirventa.Text = "AÑADIR VENTA";
            butnAñadirventa.UseVisualStyleBackColor = false;
            butnAñadirventa.Click += butnAñadirventa_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.SandyBrown;
            label1.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 108);
            label1.Name = "label1";
            label1.Size = new Size(265, 23);
            label1.TabIndex = 2;
            label1.Text = "CLIENTE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.SandyBrown;
            label2.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 155);
            label2.Name = "label2";
            label2.Size = new Size(265, 23);
            label2.TabIndex = 3;
            label2.Text = "PRODUCTO";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.SandyBrown;
            label3.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 202);
            label3.Name = "label3";
            label3.Size = new Size(265, 23);
            label3.TabIndex = 4;
            label3.Text = "CANTIDAD";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.SandyBrown;
            label4.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(37, 247);
            label4.Name = "label4";
            label4.Size = new Size(265, 23);
            label4.TabIndex = 5;
            label4.Text = "DETALLES";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.SandyBrown;
            label5.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(37, 285);
            label5.Name = "label5";
            label5.Size = new Size(265, 23);
            label5.TabIndex = 6;
            label5.Text = "PRECIO";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textCliente
            // 
            textCliente.Location = new Point(325, 108);
            textCliente.Name = "textCliente";
            textCliente.Size = new Size(446, 27);
            textCliente.TabIndex = 8;
            // 
            // textProducto
            // 
            textProducto.Location = new Point(325, 155);
            textProducto.Name = "textProducto";
            textProducto.Size = new Size(446, 27);
            textProducto.TabIndex = 9;
            // 
            // textCantidad
            // 
            textCantidad.Location = new Point(325, 198);
            textCantidad.Name = "textCantidad";
            textCantidad.Size = new Size(446, 27);
            textCantidad.TabIndex = 10;
            // 
            // textDetalles
            // 
            textDetalles.Location = new Point(325, 243);
            textDetalles.Name = "textDetalles";
            textDetalles.Size = new Size(446, 27);
            textDetalles.TabIndex = 11;
            // 
            // textPrecio
            // 
            textPrecio.Location = new Point(325, 281);
            textPrecio.Name = "textPrecio";
            textPrecio.Size = new Size(446, 27);
            textPrecio.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(butnRegresar);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(795, 65);
            panel1.TabIndex = 13;
            // 
            // label6
            // 
            label6.BackColor = Color.SandyBrown;
            label6.Font = new Font("Baskerville Old Face", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(381, 8);
            label6.Name = "label6";
            label6.Size = new Size(200, 50);
            label6.TabIndex = 14;
            label6.Text = "VENTAS";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // butnRegresar
            // 
            butnRegresar.BackColor = Color.Chocolate;
            butnRegresar.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butnRegresar.ForeColor = SystemColors.ButtonHighlight;
            butnRegresar.Location = new Point(10, 9);
            butnRegresar.Name = "butnRegresar";
            butnRegresar.Size = new Size(151, 53);
            butnRegresar.TabIndex = 14;
            butnRegresar.Text = "REGRESAR";
            butnRegresar.UseVisualStyleBackColor = false;
            butnRegresar.Click += butnRegresar_Click;
            // 
            // AgregarVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(textPrecio);
            Controls.Add(textDetalles);
            Controls.Add(textCantidad);
            Controls.Add(textProducto);
            Controls.Add(textCliente);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(butnAñadirventa);
            Name = "AgregarVenta";
            Text = "AgregarVenta";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butnAñadirventa;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textCliente;
        private TextBox textProducto;
        private TextBox textCantidad;
        private TextBox textDetalles;
        private TextBox textPrecio;
        private Panel panel1;
        private Label label6;
        private Button butnRegresar;
    }
}