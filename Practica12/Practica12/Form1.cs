using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
namespace Practica12
{
    public partial class Form1 : Form
    {
        string archivo;
        FontStyle negritas = new FontStyle();
        FontStyle italica = new FontStyle();
        FontStyle subrayado = new FontStyle();
        FontStyle tacha = new FontStyle();
        PrintDocument printDocument1 = new PrintDocument();
        public Form1()
        {
            InitializeComponent();

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                archivo = openFile.FileName;
                using (StreamReader sr = new StreamReader(archivo))
                {
                    richTextBox1.Text = sr.ReadToEnd();
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Texto|*.txt";

            if (archivo != null) // si tiene algo la variable
            {
                using (StreamWriter sw = new StreamWriter(archivo))
                {
                    sw.Write(richTextBox1.Text);

                }
            }
            else
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    archivo = saveFile.FileName;
                    using (StreamWriter sw = new StreamWriter(saveFile.FileName))
                    {
                        sw.Write(richTextBox1.Text);
                        MessageBox.Show("Archivo guardado ", archivo);
                    }
                }
            }

        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void longitudToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
                Clipboard.SetDataObject(richTextBox1.SelectedText);
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDataObject iData = Clipboard.GetDataObject();

            string texto = (string)iData.GetData(DataFormats.Text);
            int cursor = richTextBox1.SelectionStart;
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Text = richTextBox1.Text.Remove(cursor, richTextBox1.SelectionLength);
            }
            richTextBox1.Text = richTextBox1.Text.Insert(cursor, texto);
            richTextBox1.SelectionStart = cursor + texto.Length;
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
                richTextBox1.Cut();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void negritasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (negritas == FontStyle.Bold)
            {
                negritas = FontStyle.Regular;
            }
            else
            {
                negritas = FontStyle.Bold;
            }
            richTextBox1.Font = new Font(richTextBox1.Font, negritas);
        }

        private void italicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (italica == FontStyle.Italic)
            {
                italica = FontStyle.Regular;
            }
            else
            {
                italica = FontStyle.Italic;
            }
            richTextBox1.Font = new Font(richTextBox1.Font, italica);
        }

        private void subrayadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (subrayado == FontStyle.Underline)
            {
                subrayado = FontStyle.Regular;
            }
            else
            {
                subrayado = FontStyle.Underline;
            }
            richTextBox1.Font = new Font(richTextBox1.Font, subrayado);
        }

        private void tachadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tacha == FontStyle.Strikeout)
            {
                tacha = FontStyle.Strikeout;
            }
            else
            {
                tacha = FontStyle.Strikeout;
            }
            richTextBox1.Font = new Font(richTextBox1.Font, tacha);
        }

        private void alineacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.Font = richTextBox1.SelectionFont;
            fontDialog1.Color = richTextBox1.SelectionColor;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
                richTextBox1.SelectionColor = fontDialog1.Color;
            }
        }

        private void derechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void izquierdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;

        }

        private void centradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;

        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.Document = printDocument1;
            if(printDialog1.ShowDialog()== DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}