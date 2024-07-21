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
            string data = string.Empty;

            Task<string> okuma = ReadFileAsync2();

            richTextBoxProcess.Text = await new HttpClient().GetStringAsync(new Uri("https://www.google.com"));

            data = await okuma;
            richTextBoxFile.Text = data;
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
            Task<string> myTask = s.ReadToEndAsync();
            await Task.Delay(5000);

            string data = await myTask;
            return data;
        }

        private Task<string> ReadFileAsync2()
        {
            using StreamReader s = new("file.txt");
            return s.ReadToEndAsync();
        }
    }
}
