using System.Windows.Forms;

namespace practica13
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics g;
        Boolean paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black);
        int index = 0;
        Pen borrador = new Pen(Color.White, 10);
        int x, y, sX, sY, cX, cY, pt;
        private Font fuenteseleccionada;
        ColorDialog cd = new ColorDialog();
        Color colorNuevo;
        public Form1()
        {
            InitializeComponent();
            this.Width = 900;
            this.Height = 700;
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            pictureBox1.Image = bmp;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            cX = e.X;
            cY = e.Y;

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                switch (index)
                {
                    case 1:

                        px = e.Location;
                        g.DrawLine(p, px, py);
                        py = px;
                        break;
                    case 2:
                        px = e.Location;
                        g.DrawLine(borrador, px, py);
                        py = px;
                        break;
                    default:
                        break;
                }
            }
            pictureBox1.Refresh();
            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            sX = x - cX;
            sY = y - cY;
            switch (index)
            {
                case 3:
                    g.DrawEllipse(p, cX, cY, sX, sY);
                    break;
                case 4:
                    g.DrawRectangle(p, cX, cY, sX, sY);
                    break;
                case 5:
                    g.DrawLine(p, cX, cY, x, y);
                    break;
                default:
                    break;

            }
        }

        private void btn_pincel_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void btn_elipse_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void btn_rectangulo_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void btn_linea_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == 6)
            {
                //nuevo textbox
                TextBox txtbox = new TextBox();
                txtbox.Location = e.Location;
                txtbox.Size = new Size(100, 20);
                txtbox.TextChanged += Txtbox_TextChanged;
                if (fuenteseleccionada != null)
                {
                    txtbox.Font = fuenteseleccionada;
                }
                pictureBox1.Controls.Add(txtbox);
                txtbox.Focus();

            }
            switch (index)
            {
                case 6:
                    // Crear un nuevo TextBox
                    TextBox txtBox = new TextBox();
                    txtBox.Location = e.Location;
                    txtBox.Size = new Size(100, 20);
                    txtBox.TextChanged += Txtbox_TextChanged;
                    // Aplicar la fuente seleccionada
                    if (fuenteseleccionada != null)
                    {
                        txtBox.Font = fuenteseleccionada;
                    }
                    // Agregar el TextBox al PictureBox
                    pictureBox1.Controls.Add(txtBox);
                    txtBox.Focus();
                    break;
                case 7:
                    Point point = set_point(pictureBox1, e.Location);
                    rellenar(bmp, point.X, point.Y, colorNuevo);
                    break;
                default:
                    break;
            }
        }
        private void Txtbox_TextChanged(object sender, EventArgs e)
        {
            TextBox txtbox = (TextBox)sender;
            txtbox.Size = new Size(txtbox.Text.Length * 8 + 2, 20);

        }

        private void btn_texto_Click(object sender, EventArgs e)
        {
            index = 6;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (paint)
            {
                switch (index)
                {
                    case 3:
                        g.DrawEllipse(p, cX, cY, sX, sY);
                        break;
                    case 4:
                        g.DrawRectangle(p, cX, cY, sX, sY);
                        break;
                    case 5:
                        g.DrawLine(p, cX, cY, x, y);
                        break;
                    default:
                        break;
                }
            }
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            colorNuevo = cd.Color;
            pic_color.BackColor = colorNuevo;
            p.Color = colorNuevo;
        }
        static Point set_point(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }

        private void pictureBox_Color_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = set_point(pictureBox_Color, e.Location);
            pic_color.BackColor = ((Bitmap)pictureBox_Color.Image).GetPixel(point.X, point.Y);
            colorNuevo = pic_color.BackColor;
            p.Color = colorNuevo;
        }
        private void validar(Bitmap bmp, Stack<Point> sp, int x, int y, Color colorviejo, Color colorNuevo)
        {
            Color cx = bmp.GetPixel(x, y);
            if (cx == colorviejo)
            {
                sp.Push(new Point(x, y));
                bmp.SetPixel(x, y, colorNuevo);

            }
        }

        private void rellenar(Bitmap bmp, int x, int y, Color colorNew)
        {
            Color colorViejo = bmp.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bmp.SetPixel(x, y, colorNew);
            if (colorViejo == colorNew)
            {
                return;
            }
            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bmp.Width - 1 && pt.Y < bmp.Height - 1)
                {
                    validar(bmp, pixel, pt.X - 1, pt.Y, colorViejo, colorNew);
                    validar(bmp, pixel, pt.X, pt.Y - 1, colorViejo, colorNew);
                    validar(bmp, pixel, pt.X + 1, pt.Y, colorViejo, colorNew);
                    validar(bmp, pixel, pt.X, pt.Y + 1, colorViejo, colorNew);
                }
            }
        }

        private void btn_relleno_Click(object sender, EventArgs e)
        {
            index = 7;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al abrir el archivo: " + ex.Message);
                    }
                }
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            // Eliminar todos los TextBox en el PictureBox
            foreach (Control control in pictureBox1.Controls.OfType<TextBox>().ToList())
            {
                pictureBox1.Controls.Remove(control);
                control.Dispose(); // Liberar recursos asociados al TextBox
              
            }
            
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de imagen|*.png;*.jpg;*.bmp|Todos los archivos | . ";
            saveFileDialog.Title = "Guardar imagen";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = saveFileDialog.FileName;
                // Crear un nuevo Bitmap con las dimensiones del PictureBox
                Bitmap bmp = new Bitmap(pictureBox_Color.Width, pictureBox_Color.Height);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    // Dibujar la imagen del PictureBox en el nuevo Bitmap
                    g.DrawImage(pictureBox_Color.Image, 0, 0);
                    // Dibujar los TextBox en el nuevo Bitmap
                    foreach (Control control in pictureBox_Color.Controls.OfType<TextBox>())
                    {
                        g.DrawString(control.Text, control.Font, Brushes.Black, control.Location);
                    }
                }
                // Guardar el nuevo Bitmap en el archivo
                bmp.Save(rutaArchivo);
            }
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                fuenteseleccionada = fontDialog1.Font;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
