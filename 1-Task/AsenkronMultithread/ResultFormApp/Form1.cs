namespace ResultFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static int counter = 0;
        private void btnRead_Click(object sender, EventArgs e)
        {
            Task<string>? myTask = new HttpClient().GetStringAsync("https://www.microsoft.com");

            richTextBox1.Text = myTask.Result;

        }

        private void btnCounter_Click(object sender, EventArgs e)
        {
            btnCounter.Text = counter++.ToString();
        }
    }
}
