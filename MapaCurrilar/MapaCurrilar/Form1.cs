namespace MapaCurrilar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
           this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
