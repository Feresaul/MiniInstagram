namespace MiniInstagram.Vistas
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.NombreUsuario = new System.Windows.Forms.Label();
            this.NombreCompleto = new System.Windows.Forms.Label();
            this.StoryPanel = new System.Windows.Forms.Panel();
            this.PostsPanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.ConfigPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.BuscarPanel = new System.Windows.Forms.Panel();
            this.TBuscarI = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button8 = new System.Windows.Forms.Button();
            this.BPanel = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ImagenPerfil = new MiniInstagram.Modelos.ImagenCircular();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.ConfigPanel.SuspendLayout();
            this.BuscarPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(842, 12);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(31, 32);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 28;
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
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
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
            this.button4.TabIndex = 30;
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
            this.button3.TabIndex = 29;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.AutoSize = true;
            this.NombreUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NombreUsuario.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreUsuario.Location = new System.Drawing.Point(756, 99);
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.Size = new System.Drawing.Size(125, 21);
            this.NombreUsuario.TabIndex = 32;
            this.NombreUsuario.Text = "Nombre Usuario";
            this.NombreUsuario.Click += new System.EventHandler(this.NombreUsuario_Click);
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.AutoSize = true;
            this.NombreCompleto.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreCompleto.Location = new System.Drawing.Point(758, 120);
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.Size = new System.Drawing.Size(123, 18);
            this.NombreCompleto.TabIndex = 33;
            this.NombreCompleto.Text = "Nombre Completo";
            // 
            // StoryPanel
            // 
            this.StoryPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StoryPanel.Location = new System.Drawing.Point(621, 220);
            this.StoryPanel.Name = "StoryPanel";
            this.StoryPanel.Size = new System.Drawing.Size(298, 332);
            this.StoryPanel.TabIndex = 34;
            this.StoryPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StoryPanel_MouseClick);
            // 
            // PostsPanel
            // 
            this.PostsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.PostsPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PostsPanel.Location = new System.Drawing.Point(104, 98);
            this.PostsPanel.Name = "PostsPanel";
            this.PostsPanel.Size = new System.Drawing.Size(450, 489);
            this.PostsPanel.TabIndex = 35;
            this.PostsPanel.Click += new System.EventHandler(this.PostsPanel_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1006, 44);
            this.TopPanel.TabIndex = 1;
            this.TopPanel.Click += new System.EventHandler(this.TopPanel_MouseClick);
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            // 
            // ConfigPanel
            // 
            this.ConfigPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ConfigPanel.Controls.Add(this.button2);
            this.ConfigPanel.Location = new System.Drawing.Point(758, 50);
            this.ConfigPanel.Name = "ConfigPanel";
            this.ConfigPanel.Size = new System.Drawing.Size(200, 38);
            this.ConfigPanel.TabIndex = 37;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cerrar Sesión";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BuscarPanel
            // 
            this.BuscarPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BuscarPanel.Controls.Add(this.TBuscarI);
            this.BuscarPanel.Location = new System.Drawing.Point(384, 18);
            this.BuscarPanel.Name = "BuscarPanel";
            this.BuscarPanel.Size = new System.Drawing.Size(250, 26);
            this.BuscarPanel.TabIndex = 28;
            // 
            // TBuscarI
            // 
            this.TBuscarI.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TBuscarI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBuscarI.ForeColor = System.Drawing.Color.Silver;
            this.TBuscarI.Location = new System.Drawing.Point(2, 3);
            this.TBuscarI.MaxLength = 35;
            this.TBuscarI.Multiline = true;
            this.TBuscarI.Name = "TBuscarI";
            this.TBuscarI.Size = new System.Drawing.Size(246, 20);
            this.TBuscarI.TabIndex = 26;
            this.TBuscarI.Text = "Buscar";
            this.TBuscarI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBuscarI.TextChanged += new System.EventHandler(this.TBuscarI_TextChanged);
            this.TBuscarI.Enter += new System.EventHandler(this.TBuscarI_Enter);
            this.TBuscarI.Leave += new System.EventHandler(this.TBuscarI_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(621, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 30);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stories";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Location = new System.Drawing.Point(560, 98);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(38, 50);
            this.button8.TabIndex = 41;
            this.button8.Text = "+";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // BPanel
            // 
            this.BPanel.Location = new System.Drawing.Point(384, 50);
            this.BPanel.Name = "BPanel";
            this.BPanel.Size = new System.Drawing.Size(250, 38);
            this.BPanel.TabIndex = 42;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(135, 50);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 16);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 43;
            this.pictureBox4.TabStop = false;
            // 
            // ImagenPerfil
            // 
            this.ImagenPerfil.Image = ((System.Drawing.Image)(resources.GetObject("ImagenPerfil.Image")));
            this.ImagenPerfil.Location = new System.Drawing.Point(681, 88);
            this.ImagenPerfil.Name = "ImagenPerfil";
            this.ImagenPerfil.Size = new System.Drawing.Size(60, 60);
            this.ImagenPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenPerfil.TabIndex = 31;
            this.ImagenPerfil.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(260, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1006, 624);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.BPanel);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BuscarPanel);
            this.Controls.Add(this.ConfigPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.PostsPanel);
            this.Controls.Add(this.StoryPanel);
            this.Controls.Add(this.NombreCompleto);
            this.Controls.Add(this.NombreUsuario);
            this.Controls.Add(this.ImagenPerfil);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.Click += new System.EventHandler(this.Inicio_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ConfigPanel.ResumeLayout(false);
            this.BuscarPanel.ResumeLayout(false);
            this.BuscarPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private Modelos.ImagenCircular ImagenPerfil;
        private System.Windows.Forms.Label NombreUsuario;
        private System.Windows.Forms.Label NombreCompleto;
        private System.Windows.Forms.Panel StoryPanel;
        private System.Windows.Forms.Panel PostsPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel ConfigPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel BuscarPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox TBuscarI;
        private System.Windows.Forms.Panel BPanel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button1;
    }
}