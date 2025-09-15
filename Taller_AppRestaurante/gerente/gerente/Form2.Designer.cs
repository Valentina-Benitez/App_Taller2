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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lProductos = new System.Windows.Forms.Label();
            this.lVentas = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.bEmpleados = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_Usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.bEmpleados);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lVentas);
            this.panel1.Controls.Add(this.lProductos);
            this.panel1.Controls.Add(this.pictureBox1);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(361, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lProductos
            // 
            this.lProductos.AutoSize = true;
            this.lProductos.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProductos.Location = new System.Drawing.Point(401, 35);
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
            // panelContenedor
            // 
            this.panelContenedor.Location = new System.Drawing.Point(1, 63);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(810, 391);
            this.panelContenedor.TabIndex = 1;
            // 
            // bEmpleados
            // 
            this.bEmpleados.BackColor = System.Drawing.Color.LightBlue;
            this.bEmpleados.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bEmpleados.BackgroundImage")));
            this.bEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEmpleados.Location = new System.Drawing.Point(219, 25);
            this.bEmpleados.Name = "bEmpleados";
            this.bEmpleados.Size = new System.Drawing.Size(29, 35);
            this.bEmpleados.TabIndex = 7;
            this.bEmpleados.UseVisualStyleBackColor = false;
            this.bEmpleados.Click += new System.EventHandler(this.bEmpleados_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 457);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_Usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button bEmpleados;
    }
}