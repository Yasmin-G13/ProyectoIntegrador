namespace ProyectoIntegrador.Resources
{
    partial class FormLogin
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
            btnRegresar = new Button();
            btnEntrar = new Button();
            btnRecuperar_Contraseña = new Button();
            pictureBox1 = new PictureBox();
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
            label2.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(268, 114);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(161, 23);
            label2.TabIndex = 4;
            label2.Text = "INICIAR SESIÓN";
            // 
            // textUsuario
            // 
            textUsuario.BackColor = Color.SandyBrown;
            textUsuario.Location = new Point(268, 176);
            textUsuario.Margin = new Padding(2);
            textUsuario.Name = "textUsuario";
            textUsuario.Size = new Size(279, 27);
            textUsuario.TabIndex = 5;
            // 
            // label3
            // 
            label3.BackColor = Color.SandyBrown;
            label3.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(102, 180);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(151, 23);
            label3.TabIndex = 6;
            label3.Text = "USUARIO: ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SandyBrown;
            label4.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(102, 232);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(151, 23);
            label4.TabIndex = 8;
            label4.Text = "CONTRASEÑA:";
            // 
            // textContraseña
            // 
            textContraseña.BackColor = Color.SandyBrown;
            textContraseña.Location = new Point(268, 232);
            textContraseña.Margin = new Padding(2);
            textContraseña.Name = "textContraseña";
            textContraseña.Size = new Size(279, 27);
            textContraseña.TabIndex = 7;
            textContraseña.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(102, 281);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(317, 23);
            label5.TabIndex = 9;
            label5.Text = "¿OLVIDASTE TU CONTRASEÑA?";
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.Sienna;
            btnRegresar.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.ForeColor = Color.White;
            btnRegresar.Location = new Point(-2, 0);
            btnRegresar.Margin = new Padding(2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(137, 54);
            btnRegresar.TabIndex = 14;
            btnRegresar.Text = "REGRESAR";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.Sienna;
            btnEntrar.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(268, 330);
            btnEntrar.Margin = new Padding(2);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(161, 54);
            btnEntrar.TabIndex = 15;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnRecuperar_Contraseña
            // 
            btnRecuperar_Contraseña.BackColor = Color.AntiqueWhite;
            btnRecuperar_Contraseña.Font = new Font("Baskerville Old Face", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnRecuperar_Contraseña.ForeColor = Color.Black;
            btnRecuperar_Contraseña.Location = new Point(418, 281);
            btnRecuperar_Contraseña.Margin = new Padding(2);
            btnRecuperar_Contraseña.Name = "btnRecuperar_Contraseña";
            btnRecuperar_Contraseña.Size = new Size(157, 28);
            btnRecuperar_Contraseña.TabIndex = 16;
            btnRecuperar_Contraseña.Text = "RECUPERALA";
            btnRecuperar_Contraseña.UseVisualStyleBackColor = false;
            btnRecuperar_Contraseña.Click += btnRecuperar_Contraseña_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2025_05_12_204154;
            pictureBox1.Location = new Point(299, 11);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(682, 395);
            Controls.Add(pictureBox1);
            Controls.Add(btnRecuperar_Contraseña);
            Controls.Add(btnEntrar);
            Controls.Add(btnRegresar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textContraseña);
            Controls.Add(label3);
            Controls.Add(textUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Margin = new Padding(2);
            Name = "FormLogin";
            TransparencyKey = SystemColors.Control;
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
        private Button btnRegresar;
        private Button btnEntrar;
        private Button btnRecuperar_Contraseña;
        private TextBox textUsuario;
        private TextBox textContraseña;
        private PictureBox pictureBox1;
    }
}