namespace gerente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ltitulo = new System.Windows.Forms.Label();
            this.lEmpleados = new System.Windows.Forms.Label();
            this.pictureBox1_Usuario = new System.Windows.Forms.PictureBox();
            this.lProductos = new System.Windows.Forms.Label();
            this.lVentas = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bEmpleados = new System.Windows.Forms.Button();
            this.bProductos = new System.Windows.Forms.Button();
            this.bVentas = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_Usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.bVentas);
            this.panel1.Controls.Add(this.bProductos);
            this.panel1.Controls.Add(this.bEmpleados);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lVentas);
            this.panel1.Controls.Add(this.lProductos);
            this.panel1.Controls.Add(this.pictureBox1_Usuario);
            this.panel1.Controls.Add(this.lEmpleados);
            this.panel1.Controls.Add(this.ltitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 65);
            this.panel1.TabIndex = 0;
            // 
            // ltitulo
            // 
            this.ltitulo.AutoSize = true;
            this.ltitulo.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltitulo.Location = new System.Drawing.Point(42, 22);
            this.ltitulo.Name = "ltitulo";
            this.ltitulo.Size = new System.Drawing.Size(137, 18);
            this.ltitulo.TabIndex = 0;
            this.ltitulo.Text = "Sabor Argentino";
            // 
            // lEmpleados
            // 
            this.lEmpleados.AutoSize = true;
            this.lEmpleados.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEmpleados.Location = new System.Drawing.Point(254, 35);
            this.lEmpleados.Name = "lEmpleados";
            this.lEmpleados.Size = new System.Drawing.Size(73, 15);
            this.lEmpleados.TabIndex = 1;
            this.lEmpleados.Text = "Empleados";
            this.lEmpleados.Click += new System.EventHandler(this.lEmpleados_Click);
            // 
            // pictureBox1_Usuario
            // 
            this.pictureBox1_Usuario.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1_Usuario.Image")));
            this.pictureBox1_Usuario.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1_Usuario.Name = "pictureBox1_Usuario";
            this.pictureBox1_Usuario.Size = new System.Drawing.Size(30, 31);
            this.pictureBox1_Usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1_Usuario.TabIndex = 2;
            this.pictureBox1_Usuario.TabStop = false;
            // 
            // lProductos
            // 
            this.lProductos.AutoSize = true;
            this.lProductos.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProductos.Location = new System.Drawing.Point(401, 36);
            this.lProductos.Name = "lProductos";
            this.lProductos.Size = new System.Drawing.Size(68, 15);
            this.lProductos.TabIndex = 4;
            this.lProductos.Text = "Productos";
            // 
            // lVentas
            // 
            this.lVentas.AutoSize = true;
            this.lVentas.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lVentas.Location = new System.Drawing.Point(544, 35);
            this.lVentas.Name = "lVentas";
            this.lVentas.Size = new System.Drawing.Size(48, 15);
            this.lVentas.TabIndex = 5;
            this.lVentas.Text = "Ventas";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(769, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // bEmpleados
            // 
            this.bEmpleados.BackColor = System.Drawing.Color.LightBlue;
            this.bEmpleados.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bEmpleados.BackgroundImage")));
            this.bEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEmpleados.Location = new System.Drawing.Point(219, 25);
            this.bEmpleados.Name = "bEmpleados";
            this.bEmpleados.Size = new System.Drawing.Size(29, 37);
            this.bEmpleados.TabIndex = 7;
            this.bEmpleados.UseVisualStyleBackColor = false;
            this.bEmpleados.Click += new System.EventHandler(this.bEmpleados_Click);
            // 
            // bProductos
            // 
            this.bProductos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bProductos.BackgroundImage")));
            this.bProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bProductos.Location = new System.Drawing.Point(361, 25);
            this.bProductos.Name = "bProductos";
            this.bProductos.Size = new System.Drawing.Size(34, 37);
            this.bProductos.TabIndex = 0;
            this.bProductos.UseVisualStyleBackColor = true;
            this.bProductos.Click += new System.EventHandler(this.bProductos_Click);
            // 
            // bVentas
            // 
            this.bVentas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bVentas.BackgroundImage")));
            this.bVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVentas.Location = new System.Drawing.Point(504, 25);
            this.bVentas.Name = "bVentas";
            this.bVentas.Size = new System.Drawing.Size(34, 38);
            this.bVentas.TabIndex = 0;
            this.bVentas.UseVisualStyleBackColor = true;
            this.bVentas.Click += new System.EventHandler(this.bVentas_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(811, 392);
            this.panel2.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 457);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_Usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lEmpleados;
        private System.Windows.Forms.Label ltitulo;
        private System.Windows.Forms.PictureBox pictureBox1_Usuario;
        private System.Windows.Forms.Label lVentas;
        private System.Windows.Forms.Label lProductos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button bEmpleados;
        private System.Windows.Forms.Button bProductos;
        private System.Windows.Forms.Button bVentas;
        private System.Windows.Forms.Panel panel2;
    }
}