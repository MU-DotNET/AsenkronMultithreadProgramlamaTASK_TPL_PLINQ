namespace Task.CancellationFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CancellationTokenSource cancellationTokenSource = new();

        private async void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                
                Task<string>? myTask = new HttpClient().GetStringAsync("https://www.google.com", cancellationTokenSource.Token);
                string? data = await myTask;
                await System.Threading.Tasks.Task.Delay(5000);
                richTextBox1.Text = data;
            }
            catch (TaskCanceledException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            cancellationTokenSource.Cancel();
        }
    }
}
