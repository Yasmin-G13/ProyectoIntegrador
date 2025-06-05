namespace ProyectoIntegrador.Programa.Acciones.Productos
{
    partial class ModificarProductos
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            conexionMySQLBindingSource = new BindingSource(components);
            label1 = new Label();
            btnRegresar = new Button();
            btnModificar = new Button();
            dataGridView2 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conexionMySQLBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnRegresar);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 72);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.DataSource = conexionMySQLBindingSource;
            dataGridView1.Location = new Point(12, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(658, 216);
            dataGridView1.TabIndex = 2;
            // 
            // conexionMySQLBindingSource
            // 
            conexionMySQLBindingSource.DataSource = typeof(ConexionMySQL);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SandyBrown;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(236, 17);
            label1.Name = "label1";
            label1.Size = new Size(189, 32);
            label1.TabIndex = 0;
            label1.Text = "PRODUCTOS";
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.Chocolate;
            btnRegresar.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.ForeColor = SystemColors.ButtonFace;
            btnRegresar.Location = new Point(0, 0);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(139, 72);
            btnRegresar.TabIndex = 1;
            btnRegresar.Text = "REGRESAR";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.SandyBrown;
            btnModificar.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(24, 318);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(618, 42);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "MODIFICAR PRODUCTO";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.DataSource = conexionMySQLBindingSource;
            dataGridView2.Location = new Point(24, 96);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(618, 188);
            dataGridView2.TabIndex = 3;
            // 
            // ModificarProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(682, 395);
            Controls.Add(dataGridView2);
            Controls.Add(btnModificar);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "ModificarProductos";
            Text = "ModificarProductos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)conexionMySQLBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnRegresar;
        private Button button2;
        private DataGridView dataGridView1;
        private BindingSource conexionMySQLBindingSource;
        private Button btnModificar;
        private DataGridView dataGridView2;
    }
}