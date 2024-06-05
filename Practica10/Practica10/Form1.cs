using System;

namespace Practica10
{
    public partial class Form1 : Form
    {
        double num1, num2, resultado;
        string temp = "";



        public Form1()
        {
            InitializeComponent();
            try
            {
                StreamWriter fichero;
                if (!File.Exists("historial.txt"))
                {
                    fichero = File.CreateText("historial.txt");
                }
                else
                {
                    fichero = File.AppendText("historial.txt");
                }
                fichero.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show("No se creo");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button5_Click(object sender, EventArgs e)
        {
            String num = btn_7.Text;
            textBox1.Text = textBox1.Text + num;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            String num = btn_8.Text;
            textBox1.Text = textBox1.Text + num;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            String num = btn_9.Text;
            textBox1.Text = textBox1.Text + num;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            String num = btn_4.Text;
            textBox1.Text = textBox1.Text + num;

        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            String num = btn_5.Text;
            textBox1.Text = textBox1.Text + num;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            String num = btn_6.Text;
            textBox1.Text = textBox1.Text + num;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            String num = btn_1.Text;
            textBox1.Text = textBox1.Text + num;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {

            String num = btn_2.Text;
            textBox1.Text = textBox1.Text + num;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            String num = btn_3.Text;
            textBox1.Text = textBox1.Text + num;

        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            String num = btn_0.Text;
            textBox1.Text = textBox1.Text + num;

        }

        private void btn_ce_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void btn_punto_Click(object sender, EventArgs e)
        {
            String num = btn_punto.Text;
            textBox1.Text = textBox1.Text + num;
        }


        private void btn_suma_Click(object sender, EventArgs e)
        {
            string temporal = textBox1.Text;


            if (!string.IsNullOrEmpty(temporal))
            {
textBox1.Text="";
                temp = "+";
            }

        }

        private void btn_flecha_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);


        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            string temporal = textBox1.Text;

            if (!string.IsNullOrEmpty(temporal))
            {
                try
                {

                    num2 = Convert.ToDouble(temporal);

                    switch (temp)
                    {
                        case "+":
                            resultado = num1 + num2;
                            break;
                        case "-":
                            resultado = num1 - num2;
                            break;
                        case "*":
                            resultado = num1 * num2;
                            break;
                        case "/":
                            resultado = num1 / num2;
                            break;
                        case "sqrt":
                            resultado = Math.Sqrt(num1);
                            break;
                        case "sin":
                            resultado = Math.Sin(num1);
                            break;
                        case "cos":
                            resultado = Math.Cos(num1);
                            break;
                        case "tan":
                            resultado = Math.Tan(num1);
                            break;
                        case "cuad":
                            resultado = Math.Pow(num1, 2);
                            break;
                        case "fact":
                            resultado = 1;
                            for (int i = 1; i <= num1; i++)
                            {
                                resultado = resultado * i;
                            }
                            break;
                        case "log":
                            resultado = Math.Log(num1);
                            break;


                    }

                    System.Console.WriteLine("Resultado: " + resultado);

                    textBox1.Text = resultado.ToString();
                    try
                    {
                        StreamWriter fichero;
                        fichero = File.AppendText("historial.txt");
                        fichero.WriteLine(num1  + temp + num2 + "=" + resultado+"\n");

                        fichero.Close();

                    }
                    catch (Exception es)
                    {
                        MessageBox.Show("No se creo");
                    }
                    temp = "";

                }
                catch (FormatException ed)
                {

                    MessageBox.Show("No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_resta_Click(object sender, EventArgs e)
        {
        textBox1.Text="";    
            temp = "-";
        }

        private void btn_multiplicacion_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            temp = "*";
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            temp = "/";
        }

        private void btn_raiz_Click(object sender, EventArgs e)
        {
            string temporal = textBox1.Text;


            if (!string.IsNullOrEmpty(temporal))
            {
                num1 = Convert.ToDouble(temporal);
                temp = "sqrt";
            }
        }

        private void btn_seno_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            temp = "sin";
        }

        private void btn_coseno_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            temp = "cos";
        }

        private void btn_tangente_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            temp = "tan";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            temp = "cuad";
        }

        private void btn_factorial_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            temp = "fact";
        }

        private void btn_log10_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            temp = "log";
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_historial.Visible = true;
            btn_historial.ReadOnly = true;
            btn_historial.Text = File.ReadAllText("historial.txt");



        }

        private void borrarHistoialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete("historial.txt");
            }
            catch (Exception es)
            {
                MessageBox.Show("No se creo");
            }
        }

        private void btn_historial_TextChanged(object sender, EventArgs e)
        {

        }

     
    }
}
