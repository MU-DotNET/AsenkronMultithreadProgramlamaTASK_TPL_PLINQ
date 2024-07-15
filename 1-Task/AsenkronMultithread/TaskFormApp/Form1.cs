namespace TaskFormApp
{
    public partial class Form1 : Form
    {
        public int Counter { get; set; } = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnReadFile_Click(object sender, EventArgs e)
        {
            richTextBoxFile.Text = await ReadFileAsync();
        }

        private void btnCounter_Click(object sender, EventArgs e)
        {
            txtCounter.Text = Counter++.ToString();
        }

        private string ReadFile()
        {
            using StreamReader s = new("file.txt");
            Thread.Sleep(5000);
            string data = s.ReadToEnd();
            return data;
        }

        private async Task<string> ReadFileAsync()
        {
            using StreamReader s = new("file.txt");
            Task<string> myTask= s.ReadToEndAsync();
            await Task.Delay(5000);

            string data = await myTask;
            return data;
        } 
    }
}
