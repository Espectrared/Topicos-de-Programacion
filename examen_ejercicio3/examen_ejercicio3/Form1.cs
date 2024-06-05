namespace examen_ejercicio3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            
            InitializeComponent();
            StreamWriter fichero;

            if (!File.Exists("datos.txt"))
            {
                MessageBox.Show("se creo el archivo");
                fichero = File.CreateText("datos.txt");
            }
            else
            {
                fichero = File.AppendText("datos.txt");
            }
            fichero.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = File.ReadAllText("datos.txt");
        }
    }
}
