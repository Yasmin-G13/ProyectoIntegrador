namespace ProyectoIntegrador.Programa.Acciones.Productos
{
    partial class EditarPedidos
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
            textStatus = new TextBox();
            textDetalles = new TextBox();
            textCantidad = new TextBox();
            textNombredelproducto = new TextBox();
            textNombredelcliente = new TextBox();
            panel1 = new Panel();
            label6 = new Label();
            butnRegresar = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            NOMBRE = new Label();
            butnGuardar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textStatus
            // 
            textStatus.Location = new Point(329, 314);
            textStatus.Name = "textStatus";
            textStatus.Size = new Size(413, 27);
            textStatus.TabIndex = 25;
            // 
            // textDetalles
            // 
            textDetalles.Location = new Point(329, 267);
            textDetalles.Name = "textDetalles";
            textDetalles.Size = new Size(413, 27);
            textDetalles.TabIndex = 24;
            // 
            // textCantidad
            // 
            textCantidad.Location = new Point(329, 228);
            textCantidad.Name = "textCantidad";
            textCantidad.Size = new Size(413, 27);
            textCantidad.TabIndex = 23;
            // 
            // textNombredelproducto
            // 
            textNombredelproducto.Location = new Point(329, 188);
            textNombredelproducto.Name = "textNombredelproducto";
            textNombredelproducto.Size = new Size(413, 27);
            textNombredelproducto.TabIndex = 22;
            // 
            // textNombredelcliente
            // 
            textNombredelcliente.Location = new Point(329, 146);
            textNombredelcliente.Name = "textNombredelcliente";
            textNombredelcliente.Size = new Size(413, 27);
            textNombredelcliente.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(butnRegresar);
            panel1.Location = new Point(-1, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 68);
            panel1.TabIndex = 20;
            // 
            // label6
            // 
            label6.BackColor = Color.SandyBrown;
            label6.Font = new Font("Baskerville Old Face", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(330, 9);
            label6.Name = "label6";
            label6.Size = new Size(200, 55);
            label6.TabIndex = 9;
            label6.Text = "PEDIDOS";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // butnRegresar
            // 
            butnRegresar.BackColor = Color.Chocolate;
            butnRegresar.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butnRegresar.ForeColor = SystemColors.ButtonFace;
            butnRegresar.Location = new Point(3, 0);
            butnRegresar.Name = "butnRegresar";
            butnRegresar.Size = new Size(136, 64);
            butnRegresar.TabIndex = 9;
            butnRegresar.Text = "REGRESAR";
            butnRegresar.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.BackColor = Color.SandyBrown;
            label5.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 314);
            label5.Name = "label5";
            label5.Size = new Size(265, 23);
            label5.TabIndex = 19;
            label5.Text = "STATUS:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.SandyBrown;
            label4.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 271);
            label4.Name = "label4";
            label4.Size = new Size(265, 23);
            label4.TabIndex = 18;
            label4.Text = "DETALLES:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.BackColor = Color.SandyBrown;
            label3.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 229);
            label3.Name = "label3";
            label3.Size = new Size(265, 29);
            label3.TabIndex = 17;
            label3.Text = "CANTIDAD:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SandyBrown;
            label2.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 192);
            label2.Name = "label2";
            label2.Size = new Size(265, 23);
            label2.TabIndex = 16;
            label2.Text = "NOMBRE DEL PRODUCTO:";
            // 
            // NOMBRE
            // 
            NOMBRE.AccessibleName = "";
            NOMBRE.BackColor = Color.SandyBrown;
            NOMBRE.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NOMBRE.Location = new Point(25, 150);
            NOMBRE.Name = "NOMBRE";
            NOMBRE.Size = new Size(265, 23);
            NOMBRE.TabIndex = 15;
            NOMBRE.Text = "NOMBRE DEL CLIENTE:";
            NOMBRE.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // butnGuardar
            // 
            butnGuardar.BackColor = Color.SandyBrown;
            butnGuardar.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            butnGuardar.Location = new Point(133, 377);
            butnGuardar.Name = "butnGuardar";
            butnGuardar.Size = new Size(515, 51);
            butnGuardar.TabIndex = 14;
            butnGuardar.Text = "EDITAR PEDIDO";
            butnGuardar.UseVisualStyleBackColor = false;
            butnGuardar.Click += butnGuardar_Click_1;
            // 
            // EditarPedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textStatus);
            Controls.Add(textDetalles);
            Controls.Add(textCantidad);
            Controls.Add(textNombredelproducto);
            Controls.Add(textNombredelcliente);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(NOMBRE);
            Controls.Add(butnGuardar);
            Name = "EditarPedidos";
            Text = "EditarPedidos";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textStatus;
        private TextBox textDetalles;
        private TextBox textCantidad;
        private TextBox textNombredelproducto;
        private TextBox textNombredelcliente;
        private Panel panel1;
        private Label label6;
        private Button butnRegresar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label NOMBRE;
        private Button butnGuardar;
    }
}