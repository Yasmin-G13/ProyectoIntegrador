namespace ProyectoIntegrador
{
    partial class FormBienvenida
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBienvenida));
            colorDialog1 = new ColorDialog();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            btn_ir_a_iniciar_sesion = new Button();
            btn_ir_a_crear_usuario = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // colorDialog1
            // 
            colorDialog1.Color = Color.SandyBrown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(370, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(293, 189);
            label1.Name = "label1";
            label1.Size = new Size(254, 25);
            label1.TabIndex = 1;
            label1.Text = "BIENVENIDO A LA MUEBLERIA";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(318, 312);
            label4.Name = "label4";
            label4.Size = new Size(212, 25);
            label4.TabIndex = 6;
            label4.Text = "¿ERES NUEVO USUARIO?";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(682, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(158, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // btn_ir_a_iniciar_sesion
            // 
            btn_ir_a_iniciar_sesion.BackColor = Color.Sienna;
            btn_ir_a_iniciar_sesion.Location = new Point(293, 217);
            btn_ir_a_iniciar_sesion.Name = "btn_ir_a_iniciar_sesion";
            btn_ir_a_iniciar_sesion.Size = new Size(254, 75);
            btn_ir_a_iniciar_sesion.TabIndex = 8;
            btn_ir_a_iniciar_sesion.Text = "INICIAR SESION";
            btn_ir_a_iniciar_sesion.UseVisualStyleBackColor = false;
            btn_ir_a_iniciar_sesion.Click += button1_Click;
            // 
            // btn_ir_a_crear_usuario
            // 
            btn_ir_a_crear_usuario.BackColor = Color.Sienna;
            btn_ir_a_crear_usuario.Location = new Point(293, 340);
            btn_ir_a_crear_usuario.Name = "btn_ir_a_crear_usuario";
            btn_ir_a_crear_usuario.Size = new Size(254, 75);
            btn_ir_a_crear_usuario.TabIndex = 9;
            btn_ir_a_crear_usuario.Text = "REGÍSTRATE";
            btn_ir_a_crear_usuario.UseVisualStyleBackColor = false;
            btn_ir_a_crear_usuario.Click += btn_ir_a_crear_usuario_Click;
            // 
            // FormBienvenida
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(852, 494);
            Controls.Add(btn_ir_a_crear_usuario);
            Controls.Add(btn_ir_a_iniciar_sesion);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FormBienvenida";
            Text = "BIENVENIDO";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColorDialog colorDialog1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label4;
        private PictureBox pictureBox2;
        private Button btn_ir_a_iniciar_sesion;
        private Button btn_ir_a_crear_usuario;
    }
}
