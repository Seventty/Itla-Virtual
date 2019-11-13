namespace ItlaVirtual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsuarioBox = new System.Windows.Forms.TextBox();
            this.ContraseñaBox = new System.Windows.Forms.TextBox();
            this.LogButton = new System.Windows.Forms.Button();
            this.RegButton = new System.Windows.Forms.Button();
            this.LogoItla = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoItla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Noto Kufi Arabic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Noto Kufi Arabic", 8.25F);
            this.label2.Location = new System.Drawing.Point(174, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // UsuarioBox
            // 
            this.UsuarioBox.Location = new System.Drawing.Point(102, 276);
            this.UsuarioBox.Name = "UsuarioBox";
            this.UsuarioBox.Size = new System.Drawing.Size(220, 20);
            this.UsuarioBox.TabIndex = 3;
            this.UsuarioBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ContraseñaBox
            // 
            this.ContraseñaBox.Location = new System.Drawing.Point(102, 356);
            this.ContraseñaBox.Name = "ContraseñaBox";
            this.ContraseñaBox.Size = new System.Drawing.Size(220, 20);
            this.ContraseñaBox.TabIndex = 4;
            this.ContraseñaBox.TextChanged += new System.EventHandler(this.ContraseñaBox_TextChanged);
            // 
            // LogButton
            // 
            this.LogButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LogButton.Location = new System.Drawing.Point(125, 451);
            this.LogButton.Name = "LogButton";
            this.LogButton.Size = new System.Drawing.Size(75, 23);
            this.LogButton.TabIndex = 5;
            this.LogButton.Text = "Log in";
            this.LogButton.UseVisualStyleBackColor = false;
            this.LogButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegButton
            // 
            this.RegButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.RegButton.Location = new System.Drawing.Point(229, 451);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(75, 23);
            this.RegButton.TabIndex = 6;
            this.RegButton.Text = "Registrarme";
            this.RegButton.UseVisualStyleBackColor = false;
            this.RegButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // LogoItla
            // 
            this.LogoItla.Image = global::ItlaVirtual.Properties.Resources.Escudo_ITLA_01;
            this.LogoItla.Location = new System.Drawing.Point(102, 12);
            this.LogoItla.Name = "LogoItla";
            this.LogoItla.Size = new System.Drawing.Size(220, 205);
            this.LogoItla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoItla.TabIndex = 0;
            this.LogoItla.TabStop = false;
            this.LogoItla.Click += new System.EventHandler(this.LogoItla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 500);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.LogButton);
            this.Controls.Add(this.ContraseñaBox);
            this.Controls.Add(this.UsuarioBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogoItla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login ITLA";
            ((System.ComponentModel.ISupportInitialize)(this.LogoItla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoItla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsuarioBox;
        private System.Windows.Forms.TextBox ContraseñaBox;
        private System.Windows.Forms.Button LogButton;
        private System.Windows.Forms.Button RegButton;
    }
}