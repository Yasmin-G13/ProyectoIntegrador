namespace ProyectoIntegrador.Programa.Acciones.Productos.Ajustes_Seguridad
{
    partial class Ajustes
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
            label2 = new Label();
            label1 = new Label();
            textNuevaContraseña = new TextBox();
            textRepetirContraseña = new TextBox();
            btnGuardar = new Button();
            btnManual = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btRegresar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-1, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 89);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(288, 38);
            label2.Name = "label2";
            label2.Size = new Size(127, 32);
            label2.TabIndex = 0;
            label2.Text = "AJUSTES";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(188, 118);
            label1.Name = "label1";
            label1.Size = new Size(243, 23);
            label1.TabIndex = 2;
            label1.Text = "CAMBIAR CONTRASEÑA";
            // 
            // textNuevaContraseña
            // 
            textNuevaContraseña.Location = new Point(452, 179);
            textNuevaContraseña.Name = "textNuevaContraseña";
            textNuevaContraseña.Size = new Size(264, 27);
            textNuevaContraseña.TabIndex = 3;
            // 
            // textRepetirContraseña
            // 
            textRepetirContraseña.Location = new Point(452, 223);
            textRepetirContraseña.Name = "textRepetirContraseña";
            textRepetirContraseña.Size = new Size(264, 27);
            textRepetirContraseña.TabIndex = 4;
            textRepetirContraseña.UseSystemPasswordChar = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SandyBrown;
            btnGuardar.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(230, 284);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(159, 49);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnManual
            // 
            btnManual.BackColor = Color.SandyBrown;
            btnManual.Location = new Point(544, 389);
            btnManual.Name = "btnManual";
            btnManual.Size = new Size(232, 49);
            btnManual.TabIndex = 6;
            btnManual.Text = "MANUAL DE USUARIO";
            btnManual.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(199, 180);
            label3.Name = "label3";
            label3.Size = new Size(221, 23);
            label3.TabIndex = 8;
            label3.Text = "CONTRASEÑA NUEVA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(199, 224);
            label4.Name = "label4";
            label4.Size = new Size(234, 23);
            label4.TabIndex = 9;
            label4.Text = "REPETIR CONTRASEÑA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Baskerville Old Face", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(285, 421);
            label5.Name = "label5";
            label5.Size = new Size(253, 17);
            label5.TabIndex = 10;
            label5.Text = "¿CONFUSIONES CON EL SISTEMA?";
            // 
            // btRegresar
            // 
            btRegresar.BackColor = Color.SandyBrown;
            btRegresar.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btRegresar.Location = new Point(12, 388);
            btRegresar.Name = "btRegresar";
            btRegresar.Size = new Size(159, 49);
            btRegresar.TabIndex = 11;
            btRegresar.Text = "REGRESAR";
            btRegresar.UseVisualStyleBackColor = false;
            btRegresar.Click += btRegresar_Click;
            // 
            // Ajustes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(btRegresar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnManual);
            Controls.Add(btnGuardar);
            Controls.Add(textRepetirContraseña);
            Controls.Add(textNuevaContraseña);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Ajustes";
            Text = "Ajustes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnVentas;
        private Button btnInventario;
        private Button btnAjustes;
        private Button btnCerrarSesion;
        private Button btnPedidos;
        private Button btnProductos;
        private Label label2;
        private Label label1;
        private TextBox textNuevaContraseña;
        private TextBox textBox2;
        private Button btnGuardar;
        private Button btnManual;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textRepetirContraseña;
        private Button btRegresar;
    }
}