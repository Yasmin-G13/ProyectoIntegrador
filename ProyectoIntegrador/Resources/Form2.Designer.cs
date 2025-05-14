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
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Captura_de_pantalla_2025_05_12_211642;
            pictureBox2.Location = new Point(682, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 66);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Sienna;
            label1.Location = new Point(25, 5);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 2;
            label1.Text = "REGRESAR";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Sienna;
            textBox1.Location = new Point(0, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(305, 155);
            label2.Name = "label2";
            label2.Size = new Size(140, 25);
            label2.TabIndex = 4;
            label2.Text = "INICIAR SESION";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.SandyBrown;
            textBox2.Location = new Point(271, 192);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(279, 31);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SandyBrown;
            label3.Location = new Point(178, 195);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 6;
            label3.Text = "USUARIO: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SandyBrown;
            label4.Location = new Point(159, 251);
            label4.Name = "label4";
            label4.Size = new Size(130, 25);
            label4.TabIndex = 8;
            label4.Text = "CONTRASEÑA:";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.SandyBrown;
            textBox3.Location = new Point(285, 248);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(279, 31);
            textBox3.TabIndex = 7;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(173, 306);
            label5.Name = "label5";
            label5.Size = new Size(263, 25);
            label5.TabIndex = 9;
            label5.Text = "¿OLVIDASTE TU CONTRASEÑA?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(432, 306);
            label6.Name = "label6";
            label6.Size = new Size(118, 25);
            label6.TabIndex = 10;
            label6.Text = "RECUPERALA";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.DarkOrange;
            textBox4.Location = new Point(306, 394);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 11;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.DarkOrange;
            label7.Location = new Point(349, 397);
            label7.Name = "label7";
            label7.Size = new Size(77, 25);
            label7.TabIndex = 12;
            label7.Text = "ENTRAR";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2025_05_12_204154;
            pictureBox1.Location = new Point(325, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(848, 522);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox2);
            Name = "Form2";
            Text = "INICIAR SESION";
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
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private Label label6;
        private TextBox textBox4;
        private Label label7;
        private PictureBox pictureBox1;
    }
}