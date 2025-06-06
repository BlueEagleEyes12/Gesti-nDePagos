namespace CapaPresentacion
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMonto = new TextBox();
            txtMedio = new TextBox();
            txtFecha = new TextBox();
            btenviar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(747, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(750, 322);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 92);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 1;
            label1.Text = "Monto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 153);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 2;
            label2.Text = "Fecha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 218);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 3;
            label3.Text = "Medio de Pago";
            label3.Click += label3_Click;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(171, 92);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(223, 27);
            txtMonto.TabIndex = 4;
            // 
            // txtMedio
            // 
            txtMedio.Location = new Point(209, 218);
            txtMedio.Name = "txtMedio";
            txtMedio.Size = new Size(223, 27);
            txtMedio.TabIndex = 5;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(171, 150);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(223, 27);
            txtFecha.TabIndex = 6;
            // 
            // btenviar
            // 
            btenviar.Location = new Point(230, 320);
            btenviar.Name = "btenviar";
            btenviar.Size = new Size(164, 29);
            btenviar.TabIndex = 7;
            btenviar.Text = "Enviar";
            btenviar.UseVisualStyleBackColor = true;
            btenviar.Click += btenviar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IMG_de_PROG;
            pictureBox1.Location = new Point(1, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1546, 503);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1559, 519);
            Controls.Add(btenviar);
            Controls.Add(txtFecha);
            Controls.Add(txtMedio);
            Controls.Add(txtMonto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMonto;
        private TextBox txtMedio;
        private TextBox txtFecha;
        private Button btenviar;
        private PictureBox pictureBox1;
    }
}
