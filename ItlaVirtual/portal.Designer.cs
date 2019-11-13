namespace ItlaVirtual
{
    partial class portal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(portal));
            this.BotonContinuar = new System.Windows.Forms.Button();
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.Slider = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).BeginInit();
            this.SuspendLayout();
            // 
            // BotonContinuar
            // 
            this.BotonContinuar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BotonContinuar.Font = new System.Drawing.Font("Miriam CLM", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BotonContinuar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BotonContinuar.Location = new System.Drawing.Point(458, 434);
            this.BotonContinuar.Name = "BotonContinuar";
            this.BotonContinuar.Size = new System.Drawing.Size(75, 23);
            this.BotonContinuar.TabIndex = 2;
            this.BotonContinuar.Text = "Entrar";
            this.BotonContinuar.UseVisualStyleBackColor = false;
            this.BotonContinuar.Click += new System.EventHandler(this.BotonContinuar_Click);
            // 
            // Temporizador
            // 
            this.Temporizador.Enabled = true;
            this.Temporizador.Interval = 2000;
            this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
            // 
            // Slider
            // 
            this.Slider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Slider.Image = global::ItlaVirtual.Properties.Resources._1;
            this.Slider.Location = new System.Drawing.Point(0, 0);
            this.Slider.Name = "Slider";
            this.Slider.Size = new System.Drawing.Size(958, 469);
            this.Slider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Slider.TabIndex = 1;
            this.Slider.TabStop = false;
            this.Slider.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 469);
            this.Controls.Add(this.BotonContinuar);
            this.Controls.Add(this.Slider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "portal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instituto Tecnologico de Las Américas";
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Slider;
        private System.Windows.Forms.Button BotonContinuar;
        private System.Windows.Forms.Timer Temporizador;
    }
}

