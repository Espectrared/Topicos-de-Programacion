namespace practica13
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox_Color = new PictureBox();
            btn_texto = new Button();
            btn_linea = new Button();
            btn_rectangulo = new Button();
            pic_color = new Button();
            btn_elipse = new Button();
            btn_borrar = new Button();
            btn_color = new Button();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            fuenteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            salirToolStripMenuItem = new ToolStripMenuItem();
            btn_pincel = new Button();
            btn_relleno = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            fontDialog1 = new FontDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Color).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(pictureBox_Color);
            panel1.Controls.Add(btn_texto);
            panel1.Controls.Add(btn_linea);
            panel1.Controls.Add(btn_rectangulo);
            panel1.Controls.Add(pic_color);
            panel1.Controls.Add(btn_elipse);
            panel1.Controls.Add(btn_borrar);
            panel1.Controls.Add(btn_color);
            panel1.Controls.Add(menuStrip1);
            panel1.Controls.Add(btn_pincel);
            panel1.Controls.Add(btn_relleno);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(864, 100);
            panel1.TabIndex = 0;
            // 
            // pictureBox_Color
            // 
            pictureBox_Color.Cursor = Cursors.Hand;
            pictureBox_Color.Image = (Image)resources.GetObject("pictureBox_Color.Image");
            pictureBox_Color.Location = new Point(35, 27);
            pictureBox_Color.Name = "pictureBox_Color";
            pictureBox_Color.Size = new Size(149, 70);
            pictureBox_Color.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Color.TabIndex = 9;
            pictureBox_Color.TabStop = false;
            pictureBox_Color.MouseClick += pictureBox_Color_MouseClick;
            // 
            // btn_texto
            // 
            btn_texto.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_texto.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            btn_texto.FlatStyle = FlatStyle.Flat;
            btn_texto.ForeColor = Color.White;
            btn_texto.Image = (Image)resources.GetObject("btn_texto.Image");
            btn_texto.ImageAlign = ContentAlignment.TopCenter;
            btn_texto.Location = new Point(779, 27);
            btn_texto.Name = "btn_texto";
            btn_texto.Size = new Size(54, 70);
            btn_texto.TabIndex = 8;
            btn_texto.Text = "Texto";
            btn_texto.TextAlign = ContentAlignment.BottomCenter;
            btn_texto.UseVisualStyleBackColor = true;
            btn_texto.Click += btn_texto_Click;
            // 
            // btn_linea
            // 
            btn_linea.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_linea.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            btn_linea.FlatStyle = FlatStyle.Flat;
            btn_linea.ForeColor = Color.White;
            btn_linea.Image = (Image)resources.GetObject("btn_linea.Image");
            btn_linea.ImageAlign = ContentAlignment.TopCenter;
            btn_linea.Location = new Point(725, 27);
            btn_linea.Name = "btn_linea";
            btn_linea.Size = new Size(48, 70);
            btn_linea.TabIndex = 8;
            btn_linea.Text = "Linea";
            btn_linea.TextAlign = ContentAlignment.BottomCenter;
            btn_linea.UseVisualStyleBackColor = true;
            btn_linea.Click += btn_linea_Click;
            // 
            // btn_rectangulo
            // 
            btn_rectangulo.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_rectangulo.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            btn_rectangulo.FlatStyle = FlatStyle.Flat;
            btn_rectangulo.ForeColor = Color.White;
            btn_rectangulo.Image = (Image)resources.GetObject("btn_rectangulo.Image");
            btn_rectangulo.ImageAlign = ContentAlignment.TopCenter;
            btn_rectangulo.Location = new Point(642, 27);
            btn_rectangulo.Name = "btn_rectangulo";
            btn_rectangulo.Size = new Size(77, 70);
            btn_rectangulo.TabIndex = 7;
            btn_rectangulo.Text = "Rectangulo";
            btn_rectangulo.TextAlign = ContentAlignment.BottomCenter;
            btn_rectangulo.UseVisualStyleBackColor = true;
            btn_rectangulo.Click += btn_rectangulo_Click;
            // 
            // pic_color
            // 
            pic_color.BackColor = Color.White;
            pic_color.FlatAppearance.MouseDownBackColor = Color.Maroon;
            pic_color.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            pic_color.FlatStyle = FlatStyle.Flat;
            pic_color.Location = new Point(192, 55);
            pic_color.Name = "pic_color";
            pic_color.Size = new Size(39, 23);
            pic_color.TabIndex = 3;
            pic_color.TextAlign = ContentAlignment.BottomCenter;
            pic_color.UseVisualStyleBackColor = false;
            // 
            // btn_elipse
            // 
            btn_elipse.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_elipse.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            btn_elipse.FlatStyle = FlatStyle.Flat;
            btn_elipse.ForeColor = Color.White;
            btn_elipse.Image = (Image)resources.GetObject("btn_elipse.Image");
            btn_elipse.ImageAlign = ContentAlignment.TopCenter;
            btn_elipse.Location = new Point(588, 27);
            btn_elipse.Name = "btn_elipse";
            btn_elipse.Size = new Size(48, 70);
            btn_elipse.TabIndex = 5;
            btn_elipse.Text = "Elipse";
            btn_elipse.TextAlign = ContentAlignment.BottomCenter;
            btn_elipse.UseVisualStyleBackColor = true;
            btn_elipse.Click += btn_elipse_Click;
            // 
            // btn_borrar
            // 
            btn_borrar.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_borrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            btn_borrar.FlatStyle = FlatStyle.Flat;
            btn_borrar.ForeColor = Color.White;
            btn_borrar.Image = (Image)resources.GetObject("btn_borrar.Image");
            btn_borrar.ImageAlign = ContentAlignment.TopCenter;
            btn_borrar.Location = new Point(532, 27);
            btn_borrar.Name = "btn_borrar";
            btn_borrar.Size = new Size(50, 70);
            btn_borrar.TabIndex = 6;
            btn_borrar.Text = "borrar";
            btn_borrar.TextAlign = ContentAlignment.BottomCenter;
            btn_borrar.UseVisualStyleBackColor = true;
            btn_borrar.Click += btn_borrar_Click;
            // 
            // btn_color
            // 
            btn_color.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_color.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            btn_color.FlatStyle = FlatStyle.Flat;
            btn_color.ForeColor = Color.White;
            btn_color.Image = (Image)resources.GetObject("btn_color.Image");
            btn_color.ImageAlign = ContentAlignment.TopCenter;
            btn_color.Location = new Point(335, 27);
            btn_color.Name = "btn_color";
            btn_color.Size = new Size(58, 70);
            btn_color.TabIndex = 1;
            btn_color.Text = "Color";
            btn_color.TextAlign = ContentAlignment.BottomCenter;
            btn_color.UseVisualStyleBackColor = true;
            btn_color.Click += btn_color_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(864, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirToolStripMenuItem, nuevoToolStripMenuItem, guardarToolStripMenuItem, fuenteToolStripMenuItem, toolStripSeparator1, salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Image = (Image)resources.GetObject("abrirToolStripMenuItem.Image");
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(116, 22);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Image = (Image)resources.GetObject("nuevoToolStripMenuItem.Image");
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(116, 22);
            nuevoToolStripMenuItem.Text = "Nuevo";
            nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Image = (Image)resources.GetObject("guardarToolStripMenuItem.Image");
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(116, 22);
            guardarToolStripMenuItem.Text = "Guardar";
            guardarToolStripMenuItem.Click += guardarToolStripMenuItem_Click;
            // 
            // fuenteToolStripMenuItem
            // 
            fuenteToolStripMenuItem.Image = (Image)resources.GetObject("fuenteToolStripMenuItem.Image");
            fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            fuenteToolStripMenuItem.Size = new Size(116, 22);
            fuenteToolStripMenuItem.Text = "Fuente";
            fuenteToolStripMenuItem.Click += fuenteToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(113, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Image = (Image)resources.GetObject("salirToolStripMenuItem.Image");
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(116, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // btn_pincel
            // 
            btn_pincel.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_pincel.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            btn_pincel.FlatStyle = FlatStyle.Flat;
            btn_pincel.ForeColor = Color.White;
            btn_pincel.Image = (Image)resources.GetObject("btn_pincel.Image");
            btn_pincel.ImageAlign = ContentAlignment.TopCenter;
            btn_pincel.Location = new Point(471, 27);
            btn_pincel.Name = "btn_pincel";
            btn_pincel.Size = new Size(55, 70);
            btn_pincel.TabIndex = 3;
            btn_pincel.Text = "pincel";
            btn_pincel.TextAlign = ContentAlignment.BottomCenter;
            btn_pincel.UseVisualStyleBackColor = true;
            btn_pincel.Click += btn_pincel_Click;
            // 
            // btn_relleno
            // 
            btn_relleno.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_relleno.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            btn_relleno.FlatStyle = FlatStyle.Flat;
            btn_relleno.ForeColor = Color.White;
            btn_relleno.Image = (Image)resources.GetObject("btn_relleno.Image");
            btn_relleno.ImageAlign = ContentAlignment.TopCenter;
            btn_relleno.Location = new Point(399, 27);
            btn_relleno.Name = "btn_relleno";
            btn_relleno.Size = new Size(66, 70);
            btn_relleno.TabIndex = 4;
            btn_relleno.Text = "Relleno";
            btn_relleno.TextAlign = ContentAlignment.BottomCenter;
            btn_relleno.UseVisualStyleBackColor = true;
            btn_relleno.Click += btn_relleno_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 411);
            panel2.Name = "panel2";
            panel2.Size = new Size(864, 100);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(864, 511);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.MouseClick += pictureBox1_MouseClick;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 511);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Color).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem fuenteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private PictureBox pictureBox1;
        protected Button pic_color;
        private Button btn_color;
        private Button btn_pincel;
        private Button btn_relleno;
        private Button btn_elipse;
        private Button btn_borrar;
        private Button btn_rectangulo;
        private Button btn_linea;
        private Button btn_texto;
        private PictureBox pictureBox_Color;
        private FontDialog fontDialog1;
    }
}
