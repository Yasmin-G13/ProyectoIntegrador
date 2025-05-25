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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2025_05_12_204154;
            pictureBox1.Location = new Point(385, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(387, 139);
            label1.Name = "label1";
            label1.Size = new Size(108, 25);
            label1.TabIndex = 1;
            label1.Text = "REGÍSTRATE";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Sienna;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(135, 68);
            button1.TabIndex = 2;
            button1.Text = "REGRESAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btn_regresar_a_bienvenida;
            // 
            // btn_crear_usuario
            // 
            btn_crear_usuario.BackColor = Color.DarkOrange;
            btn_crear_usuario.Location = new Point(385, 401);
            btn_crear_usuario.Name = "btn_crear_usuario";
            btn_crear_usuario.Size = new Size(135, 68);
            btn_crear_usuario.TabIndex = 3;
            btn_crear_usuario.Text = "Crear";
            btn_crear_usuario.UseVisualStyleBackColor = false;
            btn_crear_usuario.Click += this.btn_crear_usuario_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SandyBrown;
            label2.Location = new Point(226, 199);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SandyBrown;
            label3.Location = new Point(197, 273);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 5;
            label3.Text = "Contraseña:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SandyBrown;
            label4.Location = new Point(137, 340);
            label4.Name = "label4";
            label4.Size = new Size(165, 25);
            label4.TabIndex = 6;
            label4.Text = "Repetir Contraseña:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.SandyBrown;
            textBox1.Location = new Point(308, 196);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(273, 31);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.SandyBrown;
            textBox2.Location = new Point(308, 270);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(273, 31);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.SandyBrown;
            textBox3.Location = new Point(308, 334);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(273, 31);
            textBox3.TabIndex = 9;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Captura_de_pantalla_2025_05_12_211642;
            pictureBox2.Location = new Point(680, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(170, 68);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // FormCrearUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(852, 494);
            Controls.Add(pictureBox2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_crear_usuario);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
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
        private TextBox textBox3;
        private PictureBox pictureBox2;
    }
}