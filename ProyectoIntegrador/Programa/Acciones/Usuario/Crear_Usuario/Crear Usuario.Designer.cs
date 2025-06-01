namespace ProyectoIntegrador
{
    partial class FormCrearUsuario
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            btn_crear_usuario = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textNombre = new TextBox();
            textContraseña = new TextBox();
            textRepetirContraseña = new TextBox();
            pictureBox2 = new PictureBox();
            labelCorreo = new Label();
            textCorreo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2025_05_12_204154;
            pictureBox1.Location = new Point(308, 10);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(310, 111);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 1;
            label1.Text = "REGÍSTRATE";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Sienna;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(108, 54);
            button1.TabIndex = 2;
            button1.Text = "REGRESAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btn_regresar_a_bienvenida;
            // 
            // btn_crear_usuario
            // 
            btn_crear_usuario.BackColor = Color.DarkOrange;
            btn_crear_usuario.Location = new Point(554, 330);
            btn_crear_usuario.Margin = new Padding(2);
            btn_crear_usuario.Name = "btn_crear_usuario";
            btn_crear_usuario.Size = new Size(108, 54);
            btn_crear_usuario.TabIndex = 3;
            btn_crear_usuario.Text = "Crear";
            btn_crear_usuario.UseVisualStyleBackColor = false;
            btn_crear_usuario.Click += btn_crear_usuario_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SandyBrown;
            label2.Location = new Point(181, 159);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SandyBrown;
            label3.Location = new Point(156, 243);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 5;
            label3.Text = "Contraseña:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SandyBrown;
            label4.Location = new Point(107, 288);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(138, 20);
            label4.TabIndex = 6;
            label4.Text = "Repetir Contraseña:";
            // 
            // textNombre
            // 
            textNombre.BackColor = Color.FromArgb(255, 192, 128);
            textNombre.Location = new Point(246, 157);
            textNombre.Margin = new Padding(2);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(219, 27);
            textNombre.TabIndex = 7;
            // 
            // textContraseña
            // 
            textContraseña.BackColor = Color.FromArgb(255, 192, 128);
            textContraseña.Location = new Point(246, 240);
            textContraseña.Margin = new Padding(2);
            textContraseña.Name = "textContraseña";
            textContraseña.Size = new Size(219, 27);
            textContraseña.TabIndex = 8;
            // 
            // textRepetirContraseña
            // 
            textRepetirContraseña.BackColor = Color.FromArgb(255, 192, 128);
            textRepetirContraseña.Location = new Point(246, 285);
            textRepetirContraseña.Margin = new Padding(2);
            textRepetirContraseña.Name = "textRepetirContraseña";
            textRepetirContraseña.Size = new Size(219, 27);
            textRepetirContraseña.TabIndex = 9;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Captura_de_pantalla_2025_05_12_211642;
            pictureBox2.Location = new Point(544, 0);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(136, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.BackColor = Color.SandyBrown;
            labelCorreo.Location = new Point(181, 203);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(54, 20);
            labelCorreo.TabIndex = 11;
            labelCorreo.Text = "Correo";
            labelCorreo.Click += label5_Click;
            // 
            // textCorreo
            // 
            textCorreo.BackColor = Color.FromArgb(255, 192, 128);
            textCorreo.Location = new Point(246, 200);
            textCorreo.Name = "textCorreo";
            textCorreo.Size = new Size(216, 27);
            textCorreo.TabIndex = 12;
            // 
            // FormCrearUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(682, 395);
            Controls.Add(textCorreo);
            Controls.Add(labelCorreo);
            Controls.Add(pictureBox2);
            Controls.Add(textRepetirContraseña);
            Controls.Add(textContraseña);
            Controls.Add(textNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_crear_usuario);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "FormCrearUsuario";
            Text = "Crear Usuario";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Button btn_crear_usuario;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textRepetirContraseña;
        private PictureBox pictureBox2;
        private TextBox textnombre;
        private TextBox textNombre;
        private TextBox textConraseña;
        private TextBox textContraseña;
        private Label TextCorreo;
        private TextBox textCorreo;
        private Label labelCorreo;
    }
}