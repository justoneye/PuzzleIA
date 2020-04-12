namespace puzzle99
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.CmbTamanyos = new System.Windows.Forms.ComboBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelInstrucciones = new System.Windows.Forms.Label();
            this.botonResolver = new System.Windows.Forms.Button();
            this.labelMovimientos = new System.Windows.Forms.Label();
            this.labelTiempo = new System.Windows.Forms.Label();
            this.textoMovimientos = new System.Windows.Forms.TextBox();
            this.textoTiempo = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // CmbTamanyos
            // 
            this.CmbTamanyos.FormattingEnabled = true;
            this.CmbTamanyos.Location = new System.Drawing.Point(632, 12);
            this.CmbTamanyos.Margin = new System.Windows.Forms.Padding(2);
            this.CmbTamanyos.Name = "CmbTamanyos";
            this.CmbTamanyos.Size = new System.Drawing.Size(110, 21);
            this.CmbTamanyos.TabIndex = 10;
            this.CmbTamanyos.SelectedIndexChanged += new System.EventHandler(this.CmbTamanyos_SelectedIndexChanged);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.labelTitulo.Location = new System.Drawing.Point(12, -3);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(245, 38);
            this.labelTitulo.TabIndex = 11;
            this.labelTitulo.Text = "Rompecabezas";
            this.labelTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelInstrucciones
            // 
            this.labelInstrucciones.AutoSize = true;
            this.labelInstrucciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelInstrucciones.Location = new System.Drawing.Point(303, 15);
            this.labelInstrucciones.Name = "labelInstrucciones";
            this.labelInstrucciones.Size = new System.Drawing.Size(305, 13);
            this.labelInstrucciones.TabIndex = 12;
            this.labelInstrucciones.Text = "Antes de comenzar seleccione el número de piezas que desee:";
            // 
            // botonResolver
            // 
            this.botonResolver.Location = new System.Drawing.Point(588, 51);
            this.botonResolver.Name = "botonResolver";
            this.botonResolver.Size = new System.Drawing.Size(149, 23);
            this.botonResolver.TabIndex = 13;
            this.botonResolver.Text = "Resolver";
            this.botonResolver.UseVisualStyleBackColor = true;
            this.botonResolver.Visible = false;
            // 
            // labelMovimientos
            // 
            this.labelMovimientos.AutoSize = true;
            this.labelMovimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelMovimientos.Location = new System.Drawing.Point(585, 108);
            this.labelMovimientos.Name = "labelMovimientos";
            this.labelMovimientos.Size = new System.Drawing.Size(97, 18);
            this.labelMovimientos.TabIndex = 14;
            this.labelMovimientos.Text = "Movimientos:";
            this.labelMovimientos.Visible = false;
            this.labelMovimientos.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelTiempo
            // 
            this.labelTiempo.AutoSize = true;
            this.labelTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelTiempo.Location = new System.Drawing.Point(585, 136);
            this.labelTiempo.Name = "labelTiempo";
            this.labelTiempo.Size = new System.Drawing.Size(62, 18);
            this.labelTiempo.TabIndex = 15;
            this.labelTiempo.Text = "Tiempo:";
            this.labelTiempo.Visible = false;
            // 
            // textoMovimientos
            // 
            this.textoMovimientos.BackColor = System.Drawing.SystemColors.Window;
            this.textoMovimientos.Location = new System.Drawing.Point(688, 106);
            this.textoMovimientos.Name = "textoMovimientos";
            this.textoMovimientos.ReadOnly = true;
            this.textoMovimientos.Size = new System.Drawing.Size(54, 20);
            this.textoMovimientos.TabIndex = 16;
            this.textoMovimientos.Visible = false;
            // 
            // textoTiempo
            // 
            this.textoTiempo.BackColor = System.Drawing.SystemColors.Window;
            this.textoTiempo.Location = new System.Drawing.Point(653, 137);
            this.textoTiempo.Name = "textoTiempo";
            this.textoTiempo.ReadOnly = true;
            this.textoTiempo.Size = new System.Drawing.Size(89, 20);
            this.textoTiempo.TabIndex = 17;
            this.textoTiempo.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 609);
            this.Controls.Add(this.textoTiempo);
            this.Controls.Add(this.textoMovimientos);
            this.Controls.Add(this.labelTiempo);
            this.Controls.Add(this.labelMovimientos);
            this.Controls.Add(this.botonResolver);
            this.Controls.Add(this.labelInstrucciones);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.CmbTamanyos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Rompecabezas (Grupo 4)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CmbTamanyos;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelInstrucciones;
        private System.Windows.Forms.Button botonResolver;
        private System.Windows.Forms.Label labelMovimientos;
        private System.Windows.Forms.Label labelTiempo;
        private System.Windows.Forms.TextBox textoMovimientos;
        private System.Windows.Forms.TextBox textoTiempo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

