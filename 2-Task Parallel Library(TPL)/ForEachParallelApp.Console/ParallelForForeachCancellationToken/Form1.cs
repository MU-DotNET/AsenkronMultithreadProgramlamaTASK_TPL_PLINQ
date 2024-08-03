using System.Threading;

namespace ParallelForForeachCancellationToken
{
    public partial class Form1 : Form
    {
        CancellationTokenSource cancellationTokenSource;
        private static int counter = 0;
        public Form1()
        {
            InitializeComponent();
            cancellationTokenSource = new();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cancellationTokenSource = new();
            List<string> urls = new()
            {
                "https://www.google.com",
                "https://www.microsoft.com",
                "https://www.amazon.com",
                "https://www.google.com",
                "https://www.microsoft.com",
                "https://www.amazon.com",
                "https://www.google.com",
                "https://www.microsoft.com",
                "https://www.amazon.com",
                "https://www.google.com",
                "https://www.microsoft.com",
                "https://www.amazon.com",
                "https://www.google.com",
                "https://www.microsoft.com",
                "https://www.amazon.com",
            };

            HttpClient client = new();
            ParallelOptions parallelOptions = new();
            parallelOptions.CancellationToken = cancellationTokenSource.Token;

            Task.Run(() =>
            {
                try
                {
                    Parallel.ForEach(urls, parallelOptions, (url) =>
                    {
                        string content = client.GetStringAsync(url).Result;
                        string data = $"{url} : {content.Length}";

                        parallelOptions.CancellationToken.ThrowIfCancellationRequested();
                        listBox1.Invoke((MethodInvoker)delegate { listBox1.Items.Add(data); });
                    });
                }
                catch(OperationCanceledException ex)
                {
                    MessageBox.Show("Ýþlem iptal edildi : " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata meydana geldi : " + ex.Message);
                }
            });

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cancellationTokenSource.Cancel();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = counter++.ToString();
        }
    }
}
