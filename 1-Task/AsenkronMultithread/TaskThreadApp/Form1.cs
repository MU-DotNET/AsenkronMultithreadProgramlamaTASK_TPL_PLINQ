namespace TaskThreadApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int Counter { get; set; } = 0;
        private void btnIncrease_Click(object sender, EventArgs e)
        {
            btnIncrease.Text = Counter++.ToString();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            Task? aTask = GoAsync(progressBar1);
            Task? bTask = GoAsync(progressBar2);

            await Task.WhenAll(aTask, bTask);
        }
        private void GoSync(ProgressBar progressBar)
        {
            Enumerable.Range(1, 100).ToList().ForEach(i =>
            {
                Thread.Sleep(100);
                progressBar.Value = i;
            });
        }
        private async Task GoAsync(ProgressBar progressBar)
        {
            await Task.Run(() =>
            {
                Enumerable.Range(1, 100).ToList().ForEach(i =>
                {
                    Thread.Sleep(100);
                    progressBar.Invoke((MethodInvoker)delegate { progressBar.Value = i; });
                });
            });

        }
    }
}
