namespace Practica7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            matriculabox.Text = matriculabox.Text.ToUpper();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult si = MessageBox.Show(" ¿Deseas Salir?", "Salida del programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (si == DialogResult.Yes)
            {
                Close();

            }
            else
            {
                button1.Focus();
            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                if (string.IsNullOrEmpty(matriculabox.Text))
                {
                    MessageBox.Show("Ingresa la matrícula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    matriculabox.Focus();
                    return;
                }
                else if (!matriculabox.Text.All(char.IsDigit))
                {
                    MessageBox.Show("La matrícula debe contener solo dígitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    matriculabox.Focus();
                    return;
                }
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Ingresa el nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Focus();
                    return;
                }
                if (textBox3.Text == "")
                {
                    MessageBox.Show("Ingresa el apellido paterno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox3.Focus();
                    return;
                }
                if (matriculabox.Text == "")
                {
                    MessageBox.Show("Ingresa el apellido materno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    matriculabox.Focus();
                    return;
                }
                if (textBox5.Text == "")
                {
                    MessageBox.Show("La escuela", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox5.Focus();
                    return;
                }
                if (textBox6.Text == "")
                {
                    MessageBox.Show("Ingresa la carrera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox6.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(textBox7.Text))
                {
                    MessageBox.Show("Ingresa la matrícula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox7.Focus();
                    return;
                }
                else if (!textBox7.Text.All(char.IsDigit))
                {
                    MessageBox.Show("el semestre solo debe contener solo dígitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox7.Focus();
                    return;
                }

                MessageBox.Show(
                    "Matricula: " + matriculabox.Text +
                    "\nNombre: " + textBox1.Text +
                    "\nApellido Paterno: " + textBox2.Text +
                    "\nApellido Materno: "
                    + textBox3.Text +
                    "\nEscuela: " + textBox5.Text +
                    "\nCarrera: " + textBox6.Text +
                    "\nSemestre: " + textBox7.Text,
                    "Datos del Alumno", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}