namespace gerente
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1_Nombre = new System.Windows.Forms.Label();
            this.label2_Contraseña = new System.Windows.Forms.Label();
            this.textBox3_nombre = new System.Windows.Forms.TextBox();
            this.textBox4_contraseña = new System.Windows.Forms.TextBox();
            this.button1_iniciar = new System.Windows.Forms.Button();
            this.pictureBox1_LogoRestaurante = new System.Windows.Forms.PictureBox();
            this.pictureBox2_ojoAbierto = new System.Windows.Forms.PictureBox();
            this.pictureBox3_ojoCerrado = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_LogoRestaurante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_ojoAbierto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3_ojoCerrado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1_Nombre
            // 
            this.label1_Nombre.AutoSize = true;
            this.label1_Nombre.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_Nombre.Location = new System.Drawing.Point(129, 137);
            this.label1_Nombre.Name = "label1_Nombre";
            this.label1_Nombre.Size = new System.Drawing.Size(59, 15);
            this.label1_Nombre.TabIndex = 0;
            this.label1_Nombre.Text = "Nombre";
            // 
            // label2_Contraseña
            // 
            this.label2_Contraseña.AutoSize = true;
            this.label2_Contraseña.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_Contraseña.Location = new System.Drawing.Point(116, 199);
            this.label2_Contraseña.Name = "label2_Contraseña";
            this.label2_Contraseña.Size = new System.Drawing.Size(82, 15);
            this.label2_Contraseña.TabIndex = 1;
            this.label2_Contraseña.Text = "Contraseña";
            // 
            // textBox3_nombre
            // 
            this.textBox3_nombre.Location = new System.Drawing.Point(79, 166);
            this.textBox3_nombre.Name = "textBox3_nombre";
            this.textBox3_nombre.Size = new System.Drawing.Size(156, 20);
            this.textBox3_nombre.TabIndex = 2;
            // 
            // textBox4_contraseña
            // 
            this.textBox4_contraseña.ForeColor = System.Drawing.Color.Black;
            this.textBox4_contraseña.Location = new System.Drawing.Point(79, 228);
            this.textBox4_contraseña.Name = "textBox4_contraseña";
            this.textBox4_contraseña.PasswordChar = '*';
            this.textBox4_contraseña.Size = new System.Drawing.Size(156, 20);
            this.textBox4_contraseña.TabIndex = 3;
            this.textBox4_contraseña.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button1_iniciar
            // 
            this.button1_iniciar.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_iniciar.Location = new System.Drawing.Point(119, 293);
            this.button1_iniciar.Name = "button1_iniciar";
            this.button1_iniciar.Size = new System.Drawing.Size(79, 35);
            this.button1_iniciar.TabIndex = 4;
            this.button1_iniciar.Text = "Iniciar";
            this.button1_iniciar.UseVisualStyleBackColor = true;
            this.button1_iniciar.Click += new System.EventHandler(this.button1_iniciar_Click);
            // 
            // pictureBox1_LogoRestaurante
            // 
            this.pictureBox1_LogoRestaurante.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1_LogoRestaurante.Image")));
            this.pictureBox1_LogoRestaurante.Location = new System.Drawing.Point(109, 12);
            this.pictureBox1_LogoRestaurante.Name = "pictureBox1_LogoRestaurante";
            this.pictureBox1_LogoRestaurante.Size = new System.Drawing.Size(100, 77);
            this.pictureBox1_LogoRestaurante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1_LogoRestaurante.TabIndex = 5;
            this.pictureBox1_LogoRestaurante.TabStop = false;
            // 
            // pictureBox2_ojoAbierto
            // 
            this.pictureBox2_ojoAbierto.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2_ojoAbierto.Image")));
            this.pictureBox2_ojoAbierto.Location = new System.Drawing.Point(252, 224);
            this.pictureBox2_ojoAbierto.Name = "pictureBox2_ojoAbierto";
            this.pictureBox2_ojoAbierto.Size = new System.Drawing.Size(30, 32);
            this.pictureBox2_ojoAbierto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2_ojoAbierto.TabIndex = 6;
            this.pictureBox2_ojoAbierto.TabStop = false;
            this.pictureBox2_ojoAbierto.Click += new System.EventHandler(this.pictureBox2_ojoAbierto_Click);
            // 
            // pictureBox3_ojoCerrado
            // 
            this.pictureBox3_ojoCerrado.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3_ojoCerrado.Image")));
            this.pictureBox3_ojoCerrado.Location = new System.Drawing.Point(252, 228);
            this.pictureBox3_ojoCerrado.Name = "pictureBox3_ojoCerrado";
            this.pictureBox3_ojoCerrado.Size = new System.Drawing.Size(30, 28);
            this.pictureBox3_ojoCerrado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3_ojoCerrado.TabIndex = 7;
            this.pictureBox3_ojoCerrado.TabStop = false;
            this.pictureBox3_ojoCerrado.Visible = false;
            this.pictureBox3_ojoCerrado.Click += new System.EventHandler(this.pictureBox3_ojoCerrado_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(315, 354);
            this.Controls.Add(this.pictureBox3_ojoCerrado);
            this.Controls.Add(this.pictureBox2_ojoAbierto);
            this.Controls.Add(this.pictureBox1_LogoRestaurante);
            this.Controls.Add(this.button1_iniciar);
            this.Controls.Add(this.textBox4_contraseña);
            this.Controls.Add(this.textBox3_nombre);
            this.Controls.Add(this.label2_Contraseña);
            this.Controls.Add(this.label1_Nombre);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_LogoRestaurante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_ojoAbierto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3_ojoCerrado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lContraseña;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox LogoDelRestaurante;
        private System.Windows.Forms.PictureBox ojoAbierto;
        private System.Windows.Forms.PictureBox ojoCerrado;
        private System.Windows.Forms.Button bIniciar;
        private System.Windows.Forms.Label label1_Nombre;
        private System.Windows.Forms.Label label2_Contraseña;
        private System.Windows.Forms.TextBox textBox3_nombre;
        private System.Windows.Forms.TextBox textBox4_contraseña;
        private System.Windows.Forms.Button button1_iniciar;
        private System.Windows.Forms.PictureBox pictureBox1_LogoRestaurante;
        private System.Windows.Forms.PictureBox pictureBox2_ojoAbierto;
        private System.Windows.Forms.PictureBox pictureBox3_ojoCerrado;
    }
}

