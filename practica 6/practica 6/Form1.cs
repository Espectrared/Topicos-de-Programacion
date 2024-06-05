namespace practica_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cadena=textBox1.Text;
            int longitud = cadena.Length;
            textBox2.Text = longitud.ToString();
            String fin = cadena[cadena.Length - 1].ToString();
            textBox3.Text = fin;
            String inicio = cadena[0].ToString();
            textBox4.Text = inicio;
            String subcadena = cadena.Substring(1, 5);
            textBox5.Text = subcadena;
            String a=cadena.IndexOf("a").ToString();
            textBox6.Text = a;
            String mayusculas = cadena.ToUpper();
            textBox7.Text = mayusculas;
            String minusculas = cadena.ToLower();
            textBox8.Text = minusculas;
            String remplazo = cadena.Replace(" ", "");
            textBox9.Text = remplazo;
        }
    }
}
