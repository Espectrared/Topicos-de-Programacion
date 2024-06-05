namespace Cronometro
{
    public partial class Form1 : Form
    {
        int segundos = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos++;
            TimeSpan t = TimeSpan.FromSeconds(segundos);
            label1.Text = t.ToString(@"hh\:mm\:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            segundos = 0;
            label1.Text = "00:00:00";
        }
    }
}
