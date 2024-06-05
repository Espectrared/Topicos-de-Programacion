namespace Practica12
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
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            salirToolStripMenuItem = new ToolStripMenuItem();
            imprimirToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            copiarToolStripMenuItem = new ToolStripMenuItem();
            pegarToolStripMenuItem = new ToolStripMenuItem();
            cortarToolStripMenuItem = new ToolStripMenuItem();
            seleccionarTodoToolStripMenuItem = new ToolStripMenuItem();
            deshacerToolStripMenuItem = new ToolStripMenuItem();
            rehacerToolStripMenuItem = new ToolStripMenuItem();
            limpiarToolStripMenuItem = new ToolStripMenuItem();
            formatoToolStripMenuItem = new ToolStripMenuItem();
            mayusculasToolStripMenuItem = new ToolStripMenuItem();
            minusculasToolStripMenuItem = new ToolStripMenuItem();
            longitudToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            negritasToolStripMenuItem = new ToolStripMenuItem();
            italicasToolStripMenuItem = new ToolStripMenuItem();
            subrayadoToolStripMenuItem = new ToolStripMenuItem();
            tachadoToolStripMenuItem = new ToolStripMenuItem();
            ciToolStripMenuItem = new ToolStripMenuItem();
            alineacionToolStripMenuItem = new ToolStripMenuItem();
            alineacionToolStripMenuItem1 = new ToolStripMenuItem();
            derechaToolStripMenuItem = new ToolStripMenuItem();
            izquierdaToolStripMenuItem = new ToolStripMenuItem();
            centradoToolStripMenuItem = new ToolStripMenuItem();
            justificadoToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButton6 = new ToolStripButton();
            toolStripButton7 = new ToolStripButton();
            toolStripButton8 = new ToolStripButton();
            toolStripButton9 = new ToolStripButton();
            toolStripButton10 = new ToolStripButton();
            toolStripButton11 = new ToolStripButton();
            toolStripButton12 = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripButton13 = new ToolStripButton();
            toolStripButton14 = new ToolStripButton();
            toolStripButton15 = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripButton17 = new ToolStripButton();
            toolStripButton18 = new ToolStripButton();
            toolStripButton19 = new ToolStripButton();
            toolStripButton16 = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripButton20 = new ToolStripButton();
            toolStripButton21 = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            toolStripButton22 = new ToolStripButton();
            toolStripButton23 = new ToolStripButton();
            toolStripButton24 = new ToolStripButton();
            toolStripButton25 = new ToolStripButton();
            richTextBox1 = new RichTextBox();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, editarToolStripMenuItem, formatoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, abrirToolStripMenuItem, guardarToolStripMenuItem, toolStripSeparator1, salirToolStripMenuItem, imprimirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "&Archivo";
            archivoToolStripMenuItem.ToolTipText = "Salir de la aplicacion";
            archivoToolStripMenuItem.Click += archivoToolStripMenuItem_Click;
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Image = (Image)resources.GetObject("nuevoToolStripMenuItem.Image");
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            nuevoToolStripMenuItem.Size = new Size(180, 22);
            nuevoToolStripMenuItem.Text = "Nuevo";
            nuevoToolStripMenuItem.ToolTipText = "Nuevo Archivo de texto";
            nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Image = (Image)resources.GetObject("abrirToolStripMenuItem.Image");
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            abrirToolStripMenuItem.Size = new Size(180, 22);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.ToolTipText = "Abrir Archivo de Texto";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Image = (Image)resources.GetObject("guardarToolStripMenuItem.Image");
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            guardarToolStripMenuItem.Size = new Size(180, 22);
            guardarToolStripMenuItem.Text = "Guardar";
            guardarToolStripMenuItem.ToolTipText = "Guarda Archivo de Texto";
            guardarToolStripMenuItem.Click += guardarToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Image = (Image)resources.GetObject("salirToolStripMenuItem.Image");
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            salirToolStripMenuItem.Size = new Size(180, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // imprimirToolStripMenuItem
            // 
            imprimirToolStripMenuItem.Image = (Image)resources.GetObject("imprimirToolStripMenuItem.Image");
            imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            imprimirToolStripMenuItem.Size = new Size(180, 22);
            imprimirToolStripMenuItem.Text = "Imprimir";
            imprimirToolStripMenuItem.Click += imprimirToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copiarToolStripMenuItem, pegarToolStripMenuItem, cortarToolStripMenuItem, seleccionarTodoToolStripMenuItem, deshacerToolStripMenuItem, rehacerToolStripMenuItem, limpiarToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(49, 20);
            editarToolStripMenuItem.Text = "&Editar";
            // 
            // copiarToolStripMenuItem
            // 
            copiarToolStripMenuItem.Image = (Image)resources.GetObject("copiarToolStripMenuItem.Image");
            copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            copiarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copiarToolStripMenuItem.Size = new Size(203, 22);
            copiarToolStripMenuItem.Text = "Copiar";
            copiarToolStripMenuItem.ToolTipText = "Copiar texto";
            copiarToolStripMenuItem.Click += copiarToolStripMenuItem_Click;
            // 
            // pegarToolStripMenuItem
            // 
            pegarToolStripMenuItem.Image = (Image)resources.GetObject("pegarToolStripMenuItem.Image");
            pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            pegarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pegarToolStripMenuItem.Size = new Size(203, 22);
            pegarToolStripMenuItem.Text = "Pegar";
            pegarToolStripMenuItem.ToolTipText = "Pegar Texto";
            pegarToolStripMenuItem.Click += pegarToolStripMenuItem_Click;
            // 
            // cortarToolStripMenuItem
            // 
            cortarToolStripMenuItem.Image = (Image)resources.GetObject("cortarToolStripMenuItem.Image");
            cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            cortarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cortarToolStripMenuItem.Size = new Size(203, 22);
            cortarToolStripMenuItem.Text = "Cortar";
            cortarToolStripMenuItem.ToolTipText = "Cortar el texto";
            cortarToolStripMenuItem.Click += cortarToolStripMenuItem_Click;
            // 
            // seleccionarTodoToolStripMenuItem
            // 
            seleccionarTodoToolStripMenuItem.Image = (Image)resources.GetObject("seleccionarTodoToolStripMenuItem.Image");
            seleccionarTodoToolStripMenuItem.Name = "seleccionarTodoToolStripMenuItem";
            seleccionarTodoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            seleccionarTodoToolStripMenuItem.Size = new Size(203, 22);
            seleccionarTodoToolStripMenuItem.Text = "Seleccionar Todo";
            seleccionarTodoToolStripMenuItem.ToolTipText = "Seleccionar todo el texto";
            seleccionarTodoToolStripMenuItem.Click += seleccionarTodoToolStripMenuItem_Click;
            // 
            // deshacerToolStripMenuItem
            // 
            deshacerToolStripMenuItem.Image = (Image)resources.GetObject("deshacerToolStripMenuItem.Image");
            deshacerToolStripMenuItem.Name = "deshacerToolStripMenuItem";
            deshacerToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            deshacerToolStripMenuItem.Size = new Size(203, 22);
            deshacerToolStripMenuItem.Text = "Deshacer";
            deshacerToolStripMenuItem.ToolTipText = "Deshacer el texto";
            // 
            // rehacerToolStripMenuItem
            // 
            rehacerToolStripMenuItem.Image = (Image)resources.GetObject("rehacerToolStripMenuItem.Image");
            rehacerToolStripMenuItem.Name = "rehacerToolStripMenuItem";
            rehacerToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            rehacerToolStripMenuItem.Size = new Size(203, 22);
            rehacerToolStripMenuItem.Text = "Rehacer";
            rehacerToolStripMenuItem.ToolTipText = "Limpiar el texto";
            // 
            // limpiarToolStripMenuItem
            // 
            limpiarToolStripMenuItem.Image = (Image)resources.GetObject("limpiarToolStripMenuItem.Image");
            limpiarToolStripMenuItem.Name = "limpiarToolStripMenuItem";
            limpiarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.L;
            limpiarToolStripMenuItem.Size = new Size(203, 22);
            limpiarToolStripMenuItem.Text = "Limpiar";
            limpiarToolStripMenuItem.ToolTipText = "Limpiar el texto";
            limpiarToolStripMenuItem.Click += limpiarToolStripMenuItem_Click;
            // 
            // formatoToolStripMenuItem
            // 
            formatoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mayusculasToolStripMenuItem, minusculasToolStripMenuItem, longitudToolStripMenuItem, colorToolStripMenuItem, ciToolStripMenuItem, alineacionToolStripMenuItem, alineacionToolStripMenuItem1 });
            formatoToolStripMenuItem.Name = "formatoToolStripMenuItem";
            formatoToolStripMenuItem.Size = new Size(64, 20);
            formatoToolStripMenuItem.Text = "&Formato";
            // 
            // mayusculasToolStripMenuItem
            // 
            mayusculasToolStripMenuItem.Image = (Image)resources.GetObject("mayusculasToolStripMenuItem.Image");
            mayusculasToolStripMenuItem.Name = "mayusculasToolStripMenuItem";
            mayusculasToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.Y;
            mayusculasToolStripMenuItem.Size = new Size(175, 22);
            mayusculasToolStripMenuItem.Text = "Mayusculas";
            mayusculasToolStripMenuItem.ToolTipText = "Poner Mayusculas";
            // 
            // minusculasToolStripMenuItem
            // 
            minusculasToolStripMenuItem.Image = (Image)resources.GetObject("minusculasToolStripMenuItem.Image");
            minusculasToolStripMenuItem.Name = "minusculasToolStripMenuItem";
            minusculasToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.M;
            minusculasToolStripMenuItem.Size = new Size(175, 22);
            minusculasToolStripMenuItem.Text = "Minusculas";
            minusculasToolStripMenuItem.ToolTipText = "Poner Minusculas";
            // 
            // longitudToolStripMenuItem
            // 
            longitudToolStripMenuItem.Image = (Image)resources.GetObject("longitudToolStripMenuItem.Image");
            longitudToolStripMenuItem.Name = "longitudToolStripMenuItem";
            longitudToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.L;
            longitudToolStripMenuItem.Size = new Size(175, 22);
            longitudToolStripMenuItem.Text = "Longitud";
            longitudToolStripMenuItem.ToolTipText = "Optener la longitud de la cadena";
            longitudToolStripMenuItem.Click += longitudToolStripMenuItem_Click;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { negritasToolStripMenuItem, italicasToolStripMenuItem, subrayadoToolStripMenuItem, tachadoToolStripMenuItem });
            colorToolStripMenuItem.Image = (Image)resources.GetObject("colorToolStripMenuItem.Image");
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(175, 22);
            colorToolStripMenuItem.Text = "Formato";
            colorToolStripMenuItem.ToolTipText = "Formtato del texto";
            colorToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // negritasToolStripMenuItem
            // 
            negritasToolStripMenuItem.Image = (Image)resources.GetObject("negritasToolStripMenuItem.Image");
            negritasToolStripMenuItem.Name = "negritasToolStripMenuItem";
            negritasToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.B;
            negritasToolStripMenuItem.Size = new Size(172, 22);
            negritasToolStripMenuItem.Text = "Negritas";
            negritasToolStripMenuItem.ToolTipText = "Poner Negritas";
            negritasToolStripMenuItem.Click += negritasToolStripMenuItem_Click;
            // 
            // italicasToolStripMenuItem
            // 
            italicasToolStripMenuItem.Image = (Image)resources.GetObject("italicasToolStripMenuItem.Image");
            italicasToolStripMenuItem.Name = "italicasToolStripMenuItem";
            italicasToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.I;
            italicasToolStripMenuItem.Size = new Size(172, 22);
            italicasToolStripMenuItem.Text = "Italicas";
            italicasToolStripMenuItem.ToolTipText = "Poner Italica";
            italicasToolStripMenuItem.Click += italicasToolStripMenuItem_Click;
            // 
            // subrayadoToolStripMenuItem
            // 
            subrayadoToolStripMenuItem.Image = (Image)resources.GetObject("subrayadoToolStripMenuItem.Image");
            subrayadoToolStripMenuItem.Name = "subrayadoToolStripMenuItem";
            subrayadoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.U;
            subrayadoToolStripMenuItem.Size = new Size(172, 22);
            subrayadoToolStripMenuItem.Text = "Subrayado";
            subrayadoToolStripMenuItem.ToolTipText = "Subrayar Texto";
            subrayadoToolStripMenuItem.Click += subrayadoToolStripMenuItem_Click;
            // 
            // tachadoToolStripMenuItem
            // 
            tachadoToolStripMenuItem.Image = (Image)resources.GetObject("tachadoToolStripMenuItem.Image");
            tachadoToolStripMenuItem.Name = "tachadoToolStripMenuItem";
            tachadoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.T;
            tachadoToolStripMenuItem.Size = new Size(172, 22);
            tachadoToolStripMenuItem.Text = "Tachado";
            tachadoToolStripMenuItem.ToolTipText = "Tachar Texto";
            tachadoToolStripMenuItem.Click += tachadoToolStripMenuItem_Click;
            // 
            // ciToolStripMenuItem
            // 
            ciToolStripMenuItem.Image = (Image)resources.GetObject("ciToolStripMenuItem.Image");
            ciToolStripMenuItem.Name = "ciToolStripMenuItem";
            ciToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.C;
            ciToolStripMenuItem.Size = new Size(175, 22);
            ciToolStripMenuItem.Text = "Color";
            ciToolStripMenuItem.ToolTipText = "Cambiar el color de texto";
            ciToolStripMenuItem.Visible = false;
            ciToolStripMenuItem.Click += ciToolStripMenuItem_Click;
            // 
            // alineacionToolStripMenuItem
            // 
            alineacionToolStripMenuItem.Image = (Image)resources.GetObject("alineacionToolStripMenuItem.Image");
            alineacionToolStripMenuItem.Name = "alineacionToolStripMenuItem";
            alineacionToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.A;
            alineacionToolStripMenuItem.Size = new Size(175, 22);
            alineacionToolStripMenuItem.Text = "Fuente";
            alineacionToolStripMenuItem.ToolTipText = "Cambiar la funte";
            alineacionToolStripMenuItem.Click += alineacionToolStripMenuItem_Click;
            // 
            // alineacionToolStripMenuItem1
            // 
            alineacionToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { derechaToolStripMenuItem, izquierdaToolStripMenuItem, centradoToolStripMenuItem, justificadoToolStripMenuItem });
            alineacionToolStripMenuItem1.Name = "alineacionToolStripMenuItem1";
            alineacionToolStripMenuItem1.Size = new Size(175, 22);
            alineacionToolStripMenuItem1.Text = "Alineacion";
            alineacionToolStripMenuItem1.ToolTipText = "Alinear texto";
            // 
            // derechaToolStripMenuItem
            // 
            derechaToolStripMenuItem.Image = (Image)resources.GetObject("derechaToolStripMenuItem.Image");
            derechaToolStripMenuItem.Name = "derechaToolStripMenuItem";
            derechaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D;
            derechaToolStripMenuItem.Size = new Size(184, 22);
            derechaToolStripMenuItem.Text = "Derecha";
            derechaToolStripMenuItem.ToolTipText = "Alinear texto a la derecha";
            derechaToolStripMenuItem.Click += derechaToolStripMenuItem_Click;
            // 
            // izquierdaToolStripMenuItem
            // 
            izquierdaToolStripMenuItem.Image = (Image)resources.GetObject("izquierdaToolStripMenuItem.Image");
            izquierdaToolStripMenuItem.Name = "izquierdaToolStripMenuItem";
            izquierdaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.I;
            izquierdaToolStripMenuItem.Size = new Size(184, 22);
            izquierdaToolStripMenuItem.Text = "Izquierda";
            izquierdaToolStripMenuItem.ToolTipText = "Alinear texto a la izquierda";
            izquierdaToolStripMenuItem.Click += izquierdaToolStripMenuItem_Click;
            // 
            // centradoToolStripMenuItem
            // 
            centradoToolStripMenuItem.Image = (Image)resources.GetObject("centradoToolStripMenuItem.Image");
            centradoToolStripMenuItem.Name = "centradoToolStripMenuItem";
            centradoToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.Space;
            centradoToolStripMenuItem.Size = new Size(184, 22);
            centradoToolStripMenuItem.Text = "Centrado";
            centradoToolStripMenuItem.ToolTipText = "Alinear texto al centro";
            centradoToolStripMenuItem.Click += centradoToolStripMenuItem_Click;
            // 
            // justificadoToolStripMenuItem
            // 
            justificadoToolStripMenuItem.Image = (Image)resources.GetObject("justificadoToolStripMenuItem.Image");
            justificadoToolStripMenuItem.Name = "justificadoToolStripMenuItem";
            justificadoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.J;
            justificadoToolStripMenuItem.Size = new Size(184, 22);
            justificadoToolStripMenuItem.Text = "Justificado";
            justificadoToolStripMenuItem.ToolTipText = "Justificar Texto";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton4, toolStripButton5, toolStripSeparator2, toolStripButton6, toolStripButton7, toolStripButton8, toolStripButton9, toolStripButton10, toolStripButton11, toolStripButton12, toolStripSeparator3, toolStripButton13, toolStripButton14, toolStripButton15, toolStripSeparator4, toolStripButton17, toolStripButton18, toolStripButton19, toolStripButton16, toolStripSeparator5, toolStripButton20, toolStripButton21, toolStripSeparator6, toolStripButton22, toolStripButton23, toolStripButton24, toolStripButton25 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.ToolTipText = "Crear nuevo archivo de texto";
            toolStripButton1.Click += abrirToolStripMenuItem_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.ToolTipText = "Abrir archivo ";
            toolStripButton2.Click += abrirToolStripMenuItem_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(23, 22);
            toolStripButton3.Text = "toolStripButton3";
            toolStripButton3.ToolTipText = "Guardar Archivo";
            toolStripButton3.Click += guardarToolStripMenuItem_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(23, 22);
            toolStripButton4.Text = "toolStripButton4";
            toolStripButton4.ToolTipText = "Salir";
            toolStripButton4.Click += salirToolStripMenuItem_Click;
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(23, 22);
            toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripButton6
            // 
            toolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton6.Image = (Image)resources.GetObject("toolStripButton6.Image");
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(23, 22);
            toolStripButton6.Text = "toolStripButton6";
            toolStripButton6.Click += copiarToolStripMenuItem_Click;
            // 
            // toolStripButton7
            // 
            toolStripButton7.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton7.Image = (Image)resources.GetObject("toolStripButton7.Image");
            toolStripButton7.ImageTransparentColor = Color.Magenta;
            toolStripButton7.Name = "toolStripButton7";
            toolStripButton7.Size = new Size(23, 22);
            toolStripButton7.Text = "toolStripButton7";
            toolStripButton7.Click += pegarToolStripMenuItem_Click;
            // 
            // toolStripButton8
            // 
            toolStripButton8.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton8.Image = (Image)resources.GetObject("toolStripButton8.Image");
            toolStripButton8.ImageTransparentColor = Color.Magenta;
            toolStripButton8.Name = "toolStripButton8";
            toolStripButton8.Size = new Size(23, 22);
            toolStripButton8.Text = "toolStripButton8";
            toolStripButton8.Click += cortarToolStripMenuItem_Click;
            // 
            // toolStripButton9
            // 
            toolStripButton9.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton9.Image = (Image)resources.GetObject("toolStripButton9.Image");
            toolStripButton9.ImageTransparentColor = Color.Magenta;
            toolStripButton9.Name = "toolStripButton9";
            toolStripButton9.Size = new Size(23, 22);
            toolStripButton9.Text = "toolStripButton9";
            toolStripButton9.Click += seleccionarTodoToolStripMenuItem_Click;
            // 
            // toolStripButton10
            // 
            toolStripButton10.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton10.Image = (Image)resources.GetObject("toolStripButton10.Image");
            toolStripButton10.ImageTransparentColor = Color.Magenta;
            toolStripButton10.Name = "toolStripButton10";
            toolStripButton10.Size = new Size(23, 22);
            toolStripButton10.Text = "toolStripButton10";
            // 
            // toolStripButton11
            // 
            toolStripButton11.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton11.Image = (Image)resources.GetObject("toolStripButton11.Image");
            toolStripButton11.ImageTransparentColor = Color.Magenta;
            toolStripButton11.Name = "toolStripButton11";
            toolStripButton11.Size = new Size(23, 22);
            toolStripButton11.Text = "toolStripButton11";
            // 
            // toolStripButton12
            // 
            toolStripButton12.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton12.Image = (Image)resources.GetObject("toolStripButton12.Image");
            toolStripButton12.ImageTransparentColor = Color.Magenta;
            toolStripButton12.Name = "toolStripButton12";
            toolStripButton12.Size = new Size(23, 22);
            toolStripButton12.Text = "toolStripButton12";
            toolStripButton12.Click += limpiarToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // toolStripButton13
            // 
            toolStripButton13.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton13.Image = (Image)resources.GetObject("toolStripButton13.Image");
            toolStripButton13.ImageTransparentColor = Color.Magenta;
            toolStripButton13.Name = "toolStripButton13";
            toolStripButton13.Size = new Size(23, 22);
            toolStripButton13.Text = "toolStripButton13";
            // 
            // toolStripButton14
            // 
            toolStripButton14.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton14.Image = (Image)resources.GetObject("toolStripButton14.Image");
            toolStripButton14.ImageTransparentColor = Color.Magenta;
            toolStripButton14.Name = "toolStripButton14";
            toolStripButton14.Size = new Size(23, 22);
            toolStripButton14.Text = "toolStripButton14";
            // 
            // toolStripButton15
            // 
            toolStripButton15.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton15.Image = (Image)resources.GetObject("toolStripButton15.Image");
            toolStripButton15.ImageTransparentColor = Color.Magenta;
            toolStripButton15.Name = "toolStripButton15";
            toolStripButton15.Size = new Size(23, 22);
            toolStripButton15.Text = "toolStripButton15";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 25);
            // 
            // toolStripButton17
            // 
            toolStripButton17.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton17.Image = (Image)resources.GetObject("toolStripButton17.Image");
            toolStripButton17.ImageTransparentColor = Color.Magenta;
            toolStripButton17.Name = "toolStripButton17";
            toolStripButton17.Size = new Size(23, 22);
            toolStripButton17.Text = "toolStripButton17";
            toolStripButton17.Click += negritasToolStripMenuItem_Click;
            // 
            // toolStripButton18
            // 
            toolStripButton18.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton18.Image = (Image)resources.GetObject("toolStripButton18.Image");
            toolStripButton18.ImageTransparentColor = Color.Magenta;
            toolStripButton18.Name = "toolStripButton18";
            toolStripButton18.Size = new Size(23, 22);
            toolStripButton18.Text = "toolStripButton18";
            // 
            // toolStripButton19
            // 
            toolStripButton19.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton19.Image = (Image)resources.GetObject("toolStripButton19.Image");
            toolStripButton19.ImageTransparentColor = Color.Magenta;
            toolStripButton19.Name = "toolStripButton19";
            toolStripButton19.Size = new Size(23, 22);
            toolStripButton19.Text = "toolStripButton19";
            // 
            // toolStripButton16
            // 
            toolStripButton16.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton16.Image = (Image)resources.GetObject("toolStripButton16.Image");
            toolStripButton16.ImageTransparentColor = Color.Magenta;
            toolStripButton16.Name = "toolStripButton16";
            toolStripButton16.Size = new Size(23, 22);
            toolStripButton16.Text = "toolStripButton16";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 25);
            // 
            // toolStripButton20
            // 
            toolStripButton20.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton20.Image = (Image)resources.GetObject("toolStripButton20.Image");
            toolStripButton20.ImageTransparentColor = Color.Magenta;
            toolStripButton20.Name = "toolStripButton20";
            toolStripButton20.Size = new Size(23, 22);
            toolStripButton20.Text = "toolStripButton20";
            toolStripButton20.Click += ciToolStripMenuItem_Click;
            // 
            // toolStripButton21
            // 
            toolStripButton21.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton21.Image = (Image)resources.GetObject("toolStripButton21.Image");
            toolStripButton21.ImageTransparentColor = Color.Magenta;
            toolStripButton21.Name = "toolStripButton21";
            toolStripButton21.Size = new Size(23, 22);
            toolStripButton21.Text = "toolStripButton21";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 25);
            // 
            // toolStripButton22
            // 
            toolStripButton22.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton22.Image = (Image)resources.GetObject("toolStripButton22.Image");
            toolStripButton22.ImageTransparentColor = Color.Magenta;
            toolStripButton22.Name = "toolStripButton22";
            toolStripButton22.Size = new Size(23, 22);
            toolStripButton22.Text = "toolStripButton22";
            // 
            // toolStripButton23
            // 
            toolStripButton23.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton23.Image = (Image)resources.GetObject("toolStripButton23.Image");
            toolStripButton23.ImageTransparentColor = Color.Magenta;
            toolStripButton23.Name = "toolStripButton23";
            toolStripButton23.Size = new Size(23, 22);
            toolStripButton23.Text = "toolStripButton23";
            // 
            // toolStripButton24
            // 
            toolStripButton24.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton24.Image = (Image)resources.GetObject("toolStripButton24.Image");
            toolStripButton24.ImageTransparentColor = Color.Magenta;
            toolStripButton24.Name = "toolStripButton24";
            toolStripButton24.Size = new Size(23, 22);
            toolStripButton24.Text = "toolStripButton24";
            // 
            // toolStripButton25
            // 
            toolStripButton25.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton25.Image = (Image)resources.GetObject("toolStripButton25.Image");
            toolStripButton25.ImageTransparentColor = Color.Magenta;
            toolStripButton25.Name = "toolStripButton25";
            toolStripButton25.Size = new Size(23, 22);
            toolStripButton25.Text = "toolStripButton25";
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 49);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 401);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem copiarToolStripMenuItem;
        private ToolStripMenuItem pegarToolStripMenuItem;
        private ToolStripMenuItem cortarToolStripMenuItem;
        private ToolStripMenuItem seleccionarTodoToolStripMenuItem;
        private ToolStripMenuItem deshacerToolStripMenuItem;
        private ToolStripMenuItem rehacerToolStripMenuItem;
        private ToolStripMenuItem limpiarToolStripMenuItem;
        private ToolStripMenuItem formatoToolStripMenuItem;
        private ToolStripMenuItem mayusculasToolStripMenuItem;
        private ToolStripMenuItem minusculasToolStripMenuItem;
        private ToolStripMenuItem longitudToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem ciToolStripMenuItem;
        private ToolStripMenuItem alineacionToolStripMenuItem;
        private ToolStripMenuItem negritasToolStripMenuItem;
        private ToolStripMenuItem italicasToolStripMenuItem;
        private ToolStripMenuItem subrayadoToolStripMenuItem;
        private ToolStripMenuItem tachadoToolStripMenuItem;
        private ToolStripMenuItem alineacionToolStripMenuItem1;
        private ToolStripMenuItem derechaToolStripMenuItem;
        private ToolStripMenuItem izquierdaToolStripMenuItem;
        private ToolStripMenuItem centradoToolStripMenuItem;
        private ToolStripMenuItem justificadoToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem imprimirToolStripMenuItem;
        private ToolStripButton toolStripButton5;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton6;
        private ToolStripButton toolStripButton7;
        private ToolStripButton toolStripButton8;
        private ToolStripButton toolStripButton9;
        private ToolStripButton toolStripButton10;
        private ToolStripButton toolStripButton11;
        private ToolStripButton toolStripButton12;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripButton13;
        private ToolStripButton toolStripButton14;
        private ToolStripButton toolStripButton15;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton toolStripButton17;
        private ToolStripButton toolStripButton18;
        private ToolStripButton toolStripButton19;
        private RichTextBox richTextBox1;
        private ToolStripButton toolStripButton16;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton toolStripButton20;
        private ToolStripButton toolStripButton21;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton toolStripButton22;
        private ToolStripButton toolStripButton23;
        private ToolStripButton toolStripButton24;
        private ToolStripButton toolStripButton25;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
    }
}
