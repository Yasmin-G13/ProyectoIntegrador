namespace ProyectoIntegrador.Resources
{
    partial class Form2
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
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textUsuario = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textContraseña = new TextBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            btnRegresar = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Captura_de_pantalla_2025_05_12_211642;
            pictureBox2.Location = new Point(546, 2);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(136, 54);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Sienna;
            label1.Location = new Point(20, 4);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(281, 118);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 4;
            label2.Text = "INICIAR SESION";
            // 
            // textUsuario
            // 
            textUsuario.BackColor = Color.SandyBrown;
            textUsuario.Location = new Point(268, 176);
            textUsuario.Margin = new Padding(2);
            textUsuario.Name = "textUsuario";
            textUsuario.Size = new Size(224, 27);
            textUsuario.TabIndex = 5;            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SandyBrown;
            label3.Location = new Point(155, 176);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 6;
            label3.Text = "USUARIO: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SandyBrown;
            label4.Location = new Point(126, 237);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 8;
            label4.Text = "CONTRASEÑA:";
            // 
            // textContraseña
            // 
            textContraseña.BackColor = Color.SandyBrown;
            textContraseña.Location = new Point(268, 230);
            textContraseña.Margin = new Padding(2);
            textContraseña.Name = "textContraseña";
            textContraseña.Size = new Size(224, 27);
            textContraseña.TabIndex = 7;
            textContraseña.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(110, 290);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(219, 20);
            label5.TabIndex = 9;
            label5.Text = "¿OLVIDASTE TU CONTRASEÑA?";
            label5.Click += label5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2025_05_12_204154;
            pictureBox1.Location = new Point(290, 11);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.Sienna;
            btnRegresar.Location = new Point(-2, 0);
            btnRegresar.Margin = new Padding(2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(108, 54);
            btnRegresar.TabIndex = 14;
            btnRegresar.Text = "REGRESAR";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkOrange;
            button2.Location = new Point(268, 330);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(108, 54);
            button2.TabIndex = 15;
            button2.Text = "ENTRAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Location = new Point(364, 283);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(128, 27);
            button3.TabIndex = 16;
            button3.Text = "Recuperala";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(682, 395);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnRegresar);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textContraseña);
            Controls.Add(label3);
            Controls.Add(textUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Margin = new Padding(2);
            Name = "Form2";
            Text = "INICIAR SESION";
            TransparencyKey = Color.Transparent;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        //  private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private PictureBox pictureBox1;
        private Button btnRegresar;
        private Button button2;
        private Button button3;
        private TextBox textUsuario;
        private TextBox textContraseña;
    }
}