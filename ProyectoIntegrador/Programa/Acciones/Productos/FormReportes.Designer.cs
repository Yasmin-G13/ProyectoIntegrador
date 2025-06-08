namespace ProyectoIntegrador.Programa.Acciones.Productos
{
    partial class FormReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportes));
            btn_ir_a_crear_usuario = new Button();
            btnReportePedidos = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_ir_a_crear_usuario
            // 
            btn_ir_a_crear_usuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_ir_a_crear_usuario.BackColor = Color.Chocolate;
            btn_ir_a_crear_usuario.Font = new Font("Baskerville Old Face", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ir_a_crear_usuario.Location = new Point(276, 341);
            btn_ir_a_crear_usuario.Margin = new Padding(2);
            btn_ir_a_crear_usuario.Name = "btn_ir_a_crear_usuario";
            btn_ir_a_crear_usuario.Size = new Size(253, 60);
            btn_ir_a_crear_usuario.TabIndex = 14;
            btn_ir_a_crear_usuario.Text = "REGÍSTRATE";
            btn_ir_a_crear_usuario.UseVisualStyleBackColor = false;
            // 
            // btnReportePedidos
            // 
            btnReportePedidos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnReportePedidos.BackColor = Color.Chocolate;
            btnReportePedidos.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportePedidos.Location = new Point(276, 213);
            btnReportePedidos.Margin = new Padding(2);
            btnReportePedidos.Name = "btnReportePedidos";
            btnReportePedidos.Size = new Size(253, 60);
            btnReportePedidos.TabIndex = 13;
            btnReportePedidos.Text = "PEDIDOS POR FECHAS";
            btnReportePedidos.UseVisualStyleBackColor = false;
            btnReportePedidos.Click += btnReportePedidos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Edwardian Script ITC", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(232, 154);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(336, 47);
            label1.TabIndex = 11;
            label1.Text = "Bienvenido a la Mueblería";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(351, 50);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_ir_a_crear_usuario);
            Controls.Add(btnReportePedidos);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FormReportes";
            Text = "FormReportes";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_ir_a_crear_usuario;
        private Button btnReportePedidos;
        private Label label1;
        private PictureBox pictureBox1;
    }
}