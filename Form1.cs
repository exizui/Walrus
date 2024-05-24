namespace Walrus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"хахаха от моржара");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int maxX = this.ClientSize.Width - this.button2.Width;
            int maxY = this.ClientSize.Height - this.button2.Height;

            int x = random.Next(maxX);
            int y = random.Next(maxY);

            button2.Location = new Point(x, y);

        }
    }
}
