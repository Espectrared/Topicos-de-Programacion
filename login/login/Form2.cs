using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace login
{
    public partial class Form2 : Form
    {
    
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (!Regex.IsMatch(textBox1.Text, "^[a-zA-Z]+$"))
                {
                    MessageBox.Show("Por favor, ingrese solo letras.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = "";
                }

                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("Por favor ingrese un nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                    return;
                }
                else if (textBox2.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("El nombre no puede contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(textBox3.Text))
                {
                    MessageBox.Show("Por favor ingrese un nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                    return;
                }
             
                if (string.IsNullOrEmpty(textBox4.Text))
                {
                    MessageBox.Show("Por favor ingrese un nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(textBox5.Text))
                {
                    MessageBox.Show("Por favor ingrese un nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(textBox6.Text))
                {
                    MessageBox.Show("Por favor ingrese un nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                    return;
                }
                MessageBox.Show("Bienvenido " + textBox1.Text, "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }
    }
}
