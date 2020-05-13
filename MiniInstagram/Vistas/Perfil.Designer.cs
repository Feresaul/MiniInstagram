namespace MiniInstagram
{
    partial class Perfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfil));
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.BuscarPanel = new System.Windows.Forms.Panel();
            this.TBuscar = new System.Windows.Forms.TextBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NombreCompleto = new System.Windows.Forms.Label();
            this.NombreUsuario = new System.Windows.Forms.Label();
            this.Seguidores = new System.Windows.Forms.Label();
            this.Seguidos = new System.Windows.Forms.Label();
            this.Publicaciones = new System.Windows.Forms.Label();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GuardadoPic = new System.Windows.Forms.PictureBox();
            this.PostsPic = new System.Windows.Forms.PictureBox();
            this.ImagesPanel = new System.Windows.Forms.Panel();
            this.BGuardado = new System.Windows.Forms.Label();
            this.BPublicaciones = new System.Windows.Forms.Label();
            this.ConfigPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BPanel = new System.Windows.Forms.Panel();
            this.SeguirB = new System.Windows.Forms.Button();
            this.Biografia = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.TopPanel.SuspendLayout();
            this.BuscarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GuardadoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostsPic)).BeginInit();
            this.ConfigPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.GhostWhite;
            this.button4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(898, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 32);
            this.button4.TabIndex = 15;
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
            this.button3.Location = new System.Drawing.Point(949, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 32);
            this.button3.TabIndex = 14;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.BuscarPanel);
            this.TopPanel.Controls.Add(this.pictureBox11);
            this.TopPanel.Controls.Add(this.pictureBox3);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1006, 44);
            this.TopPanel.TabIndex = 16;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // BuscarPanel
            // 
            this.BuscarPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BuscarPanel.Controls.Add(this.TBuscar);
            this.BuscarPanel.Location = new System.Drawing.Point(384, 18);
            this.BuscarPanel.Name = "BuscarPanel";
            this.BuscarPanel.Size = new System.Drawing.Size(250, 26);
            this.BuscarPanel.TabIndex = 27;
            // 
            // TBuscar
            // 
            this.TBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBuscar.ForeColor = System.Drawing.Color.Silver;
            this.TBuscar.Location = new System.Drawing.Point(3, 3);
            this.TBuscar.MaxLength = 35;
            this.TBuscar.Multiline = true;
            this.TBuscar.Name = "TBuscar";
            this.TBuscar.Size = new System.Drawing.Size(246, 20);
            this.TBuscar.TabIndex = 25;
            this.TBuscar.Text = "Buscar";
            this.TBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBuscar.Click += new System.EventHandler(this.textBox1_Click);
            this.TBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TBuscar.Enter += new System.EventHandler(this.textBox1_Enter);
            this.TBuscar.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(842, 12);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(31, 32);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 26;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(812, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.AutoSize = true;
            this.NombreCompleto.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreCompleto.Location = new System.Drawing.Point(403, 160);
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.Size = new System.Drawing.Size(156, 23);
            this.NombreCompleto.TabIndex = 18;
            this.NombreCompleto.Text = "Nombre Completo";
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.AutoSize = true;
            this.NombreUsuario.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreUsuario.Location = new System.Drawing.Point(400, 68);
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.Size = new System.Drawing.Size(218, 37);
            this.NombreUsuario.TabIndex = 19;
            this.NombreUsuario.Text = "Nombre Usuario";
            // 
            // Seguidores
            // 
            this.Seguidores.AutoSize = true;
            this.Seguidores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Seguidores.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seguidores.Location = new System.Drawing.Point(618, 119);
            this.Seguidores.Name = "Seguidores";
            this.Seguidores.Size = new System.Drawing.Size(94, 23);
            this.Seguidores.TabIndex = 20;
            this.Seguidores.Text = "seguidores";
            this.Seguidores.Click += new System.EventHandler(this.label3_Click);
            // 
            // Seguidos
            // 
            this.Seguidos.AutoSize = true;
            this.Seguidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Seguidos.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seguidos.Location = new System.Drawing.Point(808, 119);
            this.Seguidos.Name = "Seguidos";
            this.Seguidos.Size = new System.Drawing.Size(78, 23);
            this.Seguidos.TabIndex = 21;
            this.Seguidos.Text = "seguidos";
            this.Seguidos.Click += new System.EventHandler(this.label4_Click);
            // 
            // Publicaciones
            // 
            this.Publicaciones.AutoSize = true;
            this.Publicaciones.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publicaciones.Location = new System.Drawing.Point(403, 119);
            this.Publicaciones.Name = "Publicaciones";
            this.Publicaciones.Size = new System.Drawing.Size(114, 23);
            this.Publicaciones.TabIndex = 22;
            this.Publicaciones.Text = "publicaciones";
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ControlPanel.Controls.Add(this.panel1);
            this.ControlPanel.Controls.Add(this.GuardadoPic);
            this.ControlPanel.Controls.Add(this.PostsPic);
            this.ControlPanel.Controls.Add(this.ImagesPanel);
            this.ControlPanel.Controls.Add(this.BGuardado);
            this.ControlPanel.Controls.Add(this.BPublicaciones);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ControlPanel.Location = new System.Drawing.Point(0, 244);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(1006, 380);
            this.ControlPanel.TabIndex = 25;
            this.ControlPanel.Click += new System.EventHandler(this.ControlPanel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 4);
            this.panel1.TabIndex = 31;
            // 
            // GuardadoPic
            // 
            this.GuardadoPic.Image = ((System.Drawing.Image)(resources.GetObject("GuardadoPic.Image")));
            this.GuardadoPic.Location = new System.Drawing.Point(554, 19);
            this.GuardadoPic.Name = "GuardadoPic";
            this.GuardadoPic.Size = new System.Drawing.Size(18, 23);
            this.GuardadoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GuardadoPic.TabIndex = 30;
            this.GuardadoPic.TabStop = false;
            // 
            // PostsPic
            // 
            this.PostsPic.Image = ((System.Drawing.Image)(resources.GetObject("PostsPic.Image")));
            this.PostsPic.Location = new System.Drawing.Point(354, 19);
            this.PostsPic.Name = "PostsPic";
            this.PostsPic.Size = new System.Drawing.Size(24, 23);
            this.PostsPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PostsPic.TabIndex = 29;
            this.PostsPic.TabStop = false;
            // 
            // ImagesPanel
            // 
            this.ImagesPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ImagesPanel.Location = new System.Drawing.Point(0, 53);
            this.ImagesPanel.Name = "ImagesPanel";
            this.ImagesPanel.Size = new System.Drawing.Size(1006, 327);
            this.ImagesPanel.TabIndex = 28;
            this.ImagesPanel.Click += new System.EventHandler(this.ImagesPanel_Click);
            // 
            // BGuardado
            // 
            this.BGuardado.AutoSize = true;
            this.BGuardado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BGuardado.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGuardado.Location = new System.Drawing.Point(578, 24);
            this.BGuardado.Name = "BGuardado";
            this.BGuardado.Size = new System.Drawing.Size(80, 18);
            this.BGuardado.TabIndex = 26;
            this.BGuardado.Text = "GUARDADO";
            this.BGuardado.Click += new System.EventHandler(this.label6_Click);
            // 
            // BPublicaciones
            // 
            this.BPublicaciones.AutoSize = true;
            this.BPublicaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BPublicaciones.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BPublicaciones.Location = new System.Drawing.Point(384, 24);
            this.BPublicaciones.Name = "BPublicaciones";
            this.BPublicaciones.Size = new System.Drawing.Size(106, 18);
            this.BPublicaciones.TabIndex = 27;
            this.BPublicaciones.Text = "PUBLICACIONES";
            this.BPublicaciones.Click += new System.EventHandler(this.label7_Click);
            // 
            // ConfigPanel
            // 
            this.ConfigPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ConfigPanel.Controls.Add(this.button2);
            this.ConfigPanel.Controls.Add(this.button1);
            this.ConfigPanel.Location = new System.Drawing.Point(758, 50);
            this.ConfigPanel.Name = "ConfigPanel";
            this.ConfigPanel.Size = new System.Drawing.Size(200, 73);
            this.ConfigPanel.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(3, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cerrar Sesión";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Editar Perfil";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BPanel
            // 
            this.BPanel.Location = new System.Drawing.Point(384, 50);
            this.BPanel.Name = "BPanel";
            this.BPanel.Size = new System.Drawing.Size(250, 38);
            this.BPanel.TabIndex = 43;
            // 
            // SeguirB
            // 
            this.SeguirB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeguirB.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SeguirB.Location = new System.Drawing.Point(655, 68);
            this.SeguirB.Name = "SeguirB";
            this.SeguirB.Size = new System.Drawing.Size(97, 38);
            this.SeguirB.TabIndex = 44;
            this.SeguirB.Text = "Seguir";
            this.SeguirB.UseVisualStyleBackColor = true;
            this.SeguirB.Click += new System.EventHandler(this.SeguirB_Click);
            // 
            // Biografia
            // 
            this.Biografia.Location = new System.Drawing.Point(407, 186);
            this.Biografia.Name = "Biografia";
            this.Biografia.Size = new System.Drawing.Size(109, 22);
            this.Biografia.TabIndex = 45;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(130, 50);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(52, 16);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 44;
            this.pictureBox4.TabStop = false;
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1006, 624);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Biografia);
            this.Controls.Add(this.SeguirB);
            this.Controls.Add(this.BPanel);
            this.Controls.Add(this.ConfigPanel);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.Publicaciones);
            this.Controls.Add(this.Seguidos);
            this.Controls.Add(this.Seguidores);
            this.Controls.Add(this.NombreUsuario);
            this.Controls.Add(this.NombreCompleto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Perfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Perfil";
            this.Load += new System.EventHandler(this.Perfil_Load);
            this.Click += new System.EventHandler(this.Perfil_Click);
            this.TopPanel.ResumeLayout(false);
            this.BuscarPanel.ResumeLayout(false);
            this.BuscarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GuardadoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostsPic)).EndInit();
            this.ConfigPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label NombreCompleto;
        private System.Windows.Forms.Label NombreUsuario;
        private System.Windows.Forms.Label Seguidores;
        private System.Windows.Forms.Label Seguidos;
        private System.Windows.Forms.Label Publicaciones;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Panel ImagesPanel;
        private System.Windows.Forms.Label BGuardado;
        private System.Windows.Forms.Label BPublicaciones;
        private System.Windows.Forms.PictureBox GuardadoPic;
        private System.Windows.Forms.PictureBox PostsPic;
        private System.Windows.Forms.TextBox TBuscar;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Panel ConfigPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel BuscarPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel BPanel;
        private System.Windows.Forms.Button SeguirB;
        private System.Windows.Forms.TextBox Biografia;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}