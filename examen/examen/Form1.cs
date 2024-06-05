namespace examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cadena = textBox1.Text;
            int edad = int.Parse(cadena);
            if(edad<18)
            {
                MessageBox.Show("eres menor de edad","Warning");
            }
            else
            {
                MessageBox.Show("eres mayor de edad");
            }
        }
    }
}
