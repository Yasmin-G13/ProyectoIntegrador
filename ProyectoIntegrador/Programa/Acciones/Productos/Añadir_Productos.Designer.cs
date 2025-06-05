namespace ProyectoIntegrador.Programa.Acciones.Productos
{
    partial class Añadir_Productos
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
            btnAñadirProducto = new Button();
            panel1 = new Panel();
            btn_regresar = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button13 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAñadirProducto
            // 
            btnAñadirProducto.BackColor = Color.SandyBrown;
            btnAñadirProducto.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAñadirProducto.Location = new Point(11, 329);
            btnAñadirProducto.Margin = new Padding(2);
            btnAñadirProducto.Name = "btnAñadirProducto";
            btnAñadirProducto.Size = new Size(652, 46);
            btnAñadirProducto.TabIndex = 6;
            btnAñadirProducto.Text = "AÑADIR PRODUCTO";
            btnAñadirProducto.UseVisualStyleBackColor = false;
            btnAñadirProducto.Click += btnAñadirProducto_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(btn_regresar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(680, 58);
            panel1.TabIndex = 7;
            // 
            // btn_regresar
            // 
            btn_regresar.BackColor = Color.Chocolate;
            btn_regresar.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_regresar.ForeColor = SystemColors.ButtonFace;
            btn_regresar.Location = new Point(0, 0);
            btn_regresar.Margin = new Padding(2);
            btn_regresar.Name = "btn_regresar";
            btn_regresar.Size = new Size(132, 58);
            btn_regresar.TabIndex = 9;
            btn_regresar.Text = "REGRESAR";
            btn_regresar.UseVisualStyleBackColor = false;
            btn_regresar.Click += btn_regresar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(257, 11);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(189, 32);
            label1.TabIndex = 8;
            label1.Text = "PRODUCTOS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2025_05_12_204154;
            pictureBox1.Location = new Point(610, -2);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button13
            // 
            button13.BackColor = Color.Chocolate;
            button13.Font = new Font("Times New Roman", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button13.Location = new Point(291, 175);
            button13.Margin = new Padding(2);
            button13.Name = "button13";
            button13.Size = new Size(0, 0);
            button13.TabIndex = 12;
            button13.Text = "CANTIDAD";
            button13.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.BackColor = Color.SandyBrown;
            label2.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 99);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(133, 23);
            label2.TabIndex = 14;
            label2.Text = "NOMBRE:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.SandyBrown;
            label3.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 283);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(133, 23);
            label3.TabIndex = 15;
            label3.Text = "DETALLES:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.SandyBrown;
            label4.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 193);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(133, 23);
            label4.TabIndex = 16;
            label4.Text = "PRECIO:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.SandyBrown;
            label6.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(31, 236);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(133, 23);
            label6.TabIndex = 18;
            label6.Text = "CATEGORÍA:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BackColor = Color.SandyBrown;
            label7.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(31, 148);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(133, 23);
            label7.TabIndex = 19;
            label7.Text = "CANTIDAD:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(186, 99);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(457, 27);
            textBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(186, 144);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(457, 27);
            textBox2.TabIndex = 21;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(186, 189);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(457, 27);
            textBox3.TabIndex = 22;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(186, 232);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(457, 27);
            textBox4.TabIndex = 23;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(186, 279);
            textBox5.Margin = new Padding(2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(457, 27);
            textBox5.TabIndex = 24;
            // 
            // Añadir_Productos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(682, 395);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button13);
            Controls.Add(panel1);
            Controls.Add(btnAñadirProducto);
            Margin = new Padding(2);
            Name = "Añadir_Productos";
            Text = "Añadir_Productos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Catálogo_Productos;
        private Button btn_Ventas;
        private Button btn_Inventario;
        private Button btn_Pedidos;
        private Button btn_Ajustes_Seguridad;
        private Button btn_Cerrar_Sesion;
        private Button btnAñadirProducto;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Button button13;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button btn_regresar;
    }
}