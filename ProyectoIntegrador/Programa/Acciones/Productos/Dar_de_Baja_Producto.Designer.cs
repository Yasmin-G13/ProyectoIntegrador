namespace ProyectoIntegrador.Programa.Acciones.Productos
{
    partial class Dar_de_Baja_Producto
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
            label1 = new Label();
            btn_Regresar = new Button();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_Regresar);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(680, 70);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SandyBrown;
            label1.Font = new Font("Baskerville Old Face", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(166, 19);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(381, 32);
            label1.TabIndex = 2;
            label1.Text = "DAR PRODUCTOS DE BAJA ";
            label1.Click += label1_Click;
            // 
            // btn_Regresar
            // 
            btn_Regresar.BackColor = Color.Chocolate;
            btn_Regresar.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Regresar.ForeColor = SystemColors.ButtonFace;
            btn_Regresar.Location = new Point(0, 2);
            btn_Regresar.Margin = new Padding(2);
            btn_Regresar.Name = "btn_Regresar";
            btn_Regresar.Size = new Size(136, 68);
            btn_Regresar.TabIndex = 3;
            btn_Regresar.Text = "REGRESAR";
            btn_Regresar.UseVisualStyleBackColor = false;
            btn_Regresar.Click += btn_Regresar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2025_05_12_204154;
            pictureBox1.Location = new Point(599, 2);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 88);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(637, 225);
            dataGridView1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.SandyBrown;
            button1.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(22, 330);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(637, 54);
            button1.TabIndex = 4;
            button1.Text = "DAR DE BAJA EL PRODUCTO";
            button1.UseVisualStyleBackColor = false;
            // 
            // Dar_de_Baja_Producto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(682, 395);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Dar_de_Baja_Producto";
            Text = "Dar_de_Baja_Producto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btn_Regresar;
        private Button button1;
    }
}