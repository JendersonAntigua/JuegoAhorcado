namespace JuegoDelAhorcado
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnimales = new System.Windows.Forms.Button();
            this.btnFrutas = new System.Windows.Forms.Button();
            this.btncarros = new System.Windows.Forms.Button();
            this.botonesABC = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPalabra = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureAhorcado = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAhorcado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seleccione la categoria con la que desee jugar";
            // 
            // btnAnimales
            // 
            this.btnAnimales.Location = new System.Drawing.Point(35, 79);
            this.btnAnimales.Name = "btnAnimales";
            this.btnAnimales.Size = new System.Drawing.Size(140, 23);
            this.btnAnimales.TabIndex = 8;
            this.btnAnimales.Text = "Animales";
            this.btnAnimales.UseVisualStyleBackColor = true;
            this.btnAnimales.Click += new System.EventHandler(this.btnAnimales_Click);
            // 
            // btnFrutas
            // 
            this.btnFrutas.Location = new System.Drawing.Point(35, 126);
            this.btnFrutas.Name = "btnFrutas";
            this.btnFrutas.Size = new System.Drawing.Size(140, 23);
            this.btnFrutas.TabIndex = 9;
            this.btnFrutas.Text = "Frutas";
            this.btnFrutas.UseVisualStyleBackColor = true;
            this.btnFrutas.Click += new System.EventHandler(this.btnFrutas_Click);
            // 
            // btncarros
            // 
            this.btncarros.Location = new System.Drawing.Point(35, 169);
            this.btncarros.Name = "btncarros";
            this.btncarros.Size = new System.Drawing.Size(140, 23);
            this.btncarros.TabIndex = 10;
            this.btncarros.Text = "Marca de carros";
            this.btncarros.UseVisualStyleBackColor = true;
            this.btncarros.Click += new System.EventHandler(this.btncarros_Click);
            // 
            // botonesABC
            // 
            this.botonesABC.Location = new System.Drawing.Point(259, 387);
            this.botonesABC.Name = "botonesABC";
            this.botonesABC.Size = new System.Drawing.Size(345, 163);
            this.botonesABC.TabIndex = 11;
            // 
            // flowLayoutPalabra
            // 
            this.flowLayoutPalabra.Location = new System.Drawing.Point(292, 303);
            this.flowLayoutPalabra.Name = "flowLayoutPalabra";
            this.flowLayoutPalabra.Size = new System.Drawing.Size(485, 78);
            this.flowLayoutPalabra.TabIndex = 0;
            // 
            // pictureAhorcado
            // 
            this.pictureAhorcado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureAhorcado.Location = new System.Drawing.Point(330, 79);
            this.pictureAhorcado.Name = "pictureAhorcado";
            this.pictureAhorcado.Size = new System.Drawing.Size(218, 218);
            this.pictureAhorcado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAhorcado.TabIndex = 0;
            this.pictureAhorcado.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 645);
            this.Controls.Add(this.flowLayoutPalabra);
            this.Controls.Add(this.botonesABC);
            this.Controls.Add(this.btncarros);
            this.Controls.Add(this.btnFrutas);
            this.Controls.Add(this.btnAnimales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureAhorcado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureAhorcado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnimales;
        private System.Windows.Forms.Button btnFrutas;
        private System.Windows.Forms.Button btncarros;
        private System.Windows.Forms.FlowLayoutPanel botonesABC;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPalabra;
        private System.Windows.Forms.PictureBox pictureAhorcado;
    }
}

