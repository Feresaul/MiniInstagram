namespace MiniInstagram
{
    partial class LogIn
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
            System.Windows.Forms.Button Mostrar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.Ingresar = new System.Windows.Forms.Button();
            this.Correo = new System.Windows.Forms.Label();
            this.Contra = new System.Windows.Forms.Label();
            this.TCorreo = new System.Windows.Forms.TextBox();
            this.TContra = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Q = new System.Windows.Forms.Label();
            this.Registrar = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Respuesta = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            Mostrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // Mostrar
            // 
            Mostrar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            Mostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            Mostrar.CausesValidation = false;
            Mostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            Mostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Mostrar.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Mostrar.Location = new System.Drawing.Point(769, 338);
            Mostrar.Name = "Mostrar";
            Mostrar.Size = new System.Drawing.Size(75, 32);
            Mostrar.TabIndex = 5;
            Mostrar.Text = "Mostrar";
            Mostrar.UseVisualStyleBackColor = false;
            Mostrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Ingresar
            // 
            this.Ingresar.AutoEllipsis = true;
            this.Ingresar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ingresar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Ingresar.Location = new System.Drawing.Point(563, 391);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.Size = new System.Drawing.Size(307, 46);
            this.Ingresar.TabIndex = 5;
            this.Ingresar.Text = "Iniciar Sesión";
            this.Ingresar.UseVisualStyleBackColor = false;
            this.Ingresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Correo
            // 
            this.Correo.AutoSize = true;
            this.Correo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Correo.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correo.Location = new System.Drawing.Point(595, 253);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(220, 17);
            this.Correo.TabIndex = 5;
            this.Correo.Text = "Télefono, usuario o correo electrónico";
            // 
            // Contra
            // 
            this.Contra.AutoSize = true;
            this.Contra.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Contra.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contra.Location = new System.Drawing.Point(595, 318);
            this.Contra.Name = "Contra";
            this.Contra.Size = new System.Drawing.Size(72, 17);
            this.Contra.TabIndex = 5;
            this.Contra.Text = "Contraseña";
            // 
            // TCorreo
            // 
            this.TCorreo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCorreo.Location = new System.Drawing.Point(593, 273);
            this.TCorreo.Margin = new System.Windows.Forms.Padding(8);
            this.TCorreo.MaxLength = 35;
            this.TCorreo.Multiline = true;
            this.TCorreo.Name = "TCorreo";
            this.TCorreo.Size = new System.Drawing.Size(246, 32);
            this.TCorreo.TabIndex = 5;
            // 
            // TContra
            // 
            this.TContra.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TContra.Location = new System.Drawing.Point(593, 338);
            this.TContra.Margin = new System.Windows.Forms.Padding(8);
            this.TContra.MaxLength = 20;
            this.TContra.Multiline = true;
            this.TContra.Name = "TContra";
            this.TContra.Size = new System.Drawing.Size(182, 32);
            this.TContra.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(539, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Q
            // 
            this.Q.AutoSize = true;
            this.Q.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q.Location = new System.Drawing.Point(595, 471);
            this.Q.Name = "Q";
            this.Q.Size = new System.Drawing.Size(159, 17);
            this.Q.TabIndex = 9;
            this.Q.Text = "¿No tienes una cuenta?";
            // 
            // Registrar
            // 
            this.Registrar.AutoSize = true;
            this.Registrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Registrar.Location = new System.Drawing.Point(760, 471);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(73, 17);
            this.Registrar.TabIndex = 10;
            this.Registrar.Text = "Regístrate";
            this.Registrar.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1006, 55);
            this.panel3.TabIndex = 11;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.GhostWhite;
            this.button4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(888, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 32);
            this.button4.TabIndex = 13;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.GhostWhite;
            this.button3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(939, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 32);
            this.button3.TabIndex = 12;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-117, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(618, 584);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(916, 50);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(618, 584);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // Respuesta
            // 
            this.Respuesta.Location = new System.Drawing.Point(539, 516);
            this.Respuesta.Name = "Respuesta";
            this.Respuesta.Size = new System.Drawing.Size(340, 25);
            this.Respuesta.TabIndex = 14;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(781, 187);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(89, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1006, 624);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Respuesta);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.Q);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(Mostrar);
            this.Controls.Add(this.TContra);
            this.Controls.Add(this.TCorreo);
            this.Controls.Add(this.Contra);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.Ingresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.LogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ingresar;
        private System.Windows.Forms.Label Correo;
        private System.Windows.Forms.Label Contra;
        private System.Windows.Forms.TextBox TCorreo;
        private System.Windows.Forms.TextBox TContra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Q;
        private System.Windows.Forms.Label Registrar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel Respuesta;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}