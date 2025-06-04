namespace ProyectoIntegrador.Programa.Acciones.Usuario.Cerrar_Sesion
{
    partial class CerrarSesion
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
            btn_Si = new Button();
            btn_No = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2025_05_12_204154;
            pictureBox1.Location = new Point(278, 2);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Captura_de_pantalla_2025_05_12_211642;
            pictureBox2.Location = new Point(544, 2);
            pictureBox2.Margin = new Padding(2, 2, 2, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(136, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AntiqueWhite;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(186, 150);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(284, 52);
            label1.TabIndex = 2;
            label1.Text = "Estas seguro de que deseas\r\n             cerrar sesión\r\n";
            // 
            // btn_Si
            // 
            btn_Si.BackColor = Color.Sienna;
            btn_Si.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Si.Location = new Point(124, 248);
            btn_Si.Margin = new Padding(2, 2, 2, 2);
            btn_Si.Name = "btn_Si";
            btn_Si.Size = new Size(108, 54);
            btn_Si.TabIndex = 3;
            btn_Si.Text = "SI";
            btn_Si.UseVisualStyleBackColor = false;
            btn_Si.Click += btn_Si_Click;
            // 
            // btn_No
            // 
            btn_No.BackColor = Color.Sienna;
            btn_No.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_No.Location = new Point(414, 248);
            btn_No.Margin = new Padding(2, 2, 2, 2);
            btn_No.Name = "btn_No";
            btn_No.Size = new Size(108, 54);
            btn_No.TabIndex = 4;
            btn_No.Text = "NO";
            btn_No.UseVisualStyleBackColor = false;
            // 
            // CerrarSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(682, 395);
            Controls.Add(btn_No);
            Controls.Add(btn_Si);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "CerrarSesion";
            Text = "CerrarSesion";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Button btn_Si;
        private Button btn_No;
    }
}