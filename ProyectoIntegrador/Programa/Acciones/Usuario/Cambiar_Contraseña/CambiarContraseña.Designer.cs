namespace ProyectoIntegrador.Programa.Acciones.Usuario.Cambiar_Contraseña
{
    partial class CambiarContraseña
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
            pictureBox2 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            btn_Confirmar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2025_05_12_204154;
            pictureBox1.Location = new Point(325, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Captura_de_pantalla_2025_05_12_211642;
            pictureBox2.Location = new Point(692, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(158, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(275, 153);
            label1.Name = "label1";
            label1.Size = new Size(246, 29);
            label1.TabIndex = 2;
            label1.Text = "Cambiar Contraseña";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.SandyBrown;
            textBox1.Location = new Point(292, 262);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(369, 31);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SandyBrown;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 262);
            label2.Name = "label2";
            label2.Size = new Size(274, 29);
            label2.TabIndex = 4;
            label2.Text = "Escribe tu Contraseña:\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SandyBrown;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 349);
            label3.Name = "label3";
            label3.Size = new Size(261, 29);
            label3.TabIndex = 5;
            label3.Text = "Repite tu Contraseña:\r\n";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.SandyBrown;
            textBox2.Location = new Point(292, 347);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(369, 31);
            textBox2.TabIndex = 6;
            // 
            // btn_Confirmar
            // 
            btn_Confirmar.BackColor = Color.Sienna;
            btn_Confirmar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Confirmar.Location = new Point(352, 414);
            btn_Confirmar.Name = "btn_Confirmar";
            btn_Confirmar.Size = new Size(135, 68);
            btn_Confirmar.TabIndex = 7;
            btn_Confirmar.Text = "Confirmar";
            btn_Confirmar.UseVisualStyleBackColor = false;
            // 
            // CambiarContraseña
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(852, 494);
            Controls.Add(btn_Confirmar);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "CambiarContraseña";
            Text = "CambiarContraseña";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Button btn_Confirmar;
    }
}