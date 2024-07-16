namespace TaskConsoleApp
{
    public class WhenAny
    {
        public async Task WhenAnyAsync()
        {
            Console.WriteLine("Main Thread: " + Thread.CurrentThread.ManagedThreadId);
            List<string> urlList = new()
            {
                "https://www.google.com",
                "https://www.microsoft.com",
                "https://www.amazon.com",
                "https://www.haberturk.com"
            };

            List<Task<ContentWhenAny>> taskList = new();

            urlList.ToList().ForEach(async x =>
            {
                taskList.Add(GetContentAsync(x));
            });

            var firstData = await Task.WhenAny(taskList);

            Console.WriteLine($"{firstData.Result.Site} - {firstData.Result.Len}");
        }

        async Task<ContentWhenAny> GetContentAsync(string url)
        {
            ContentWhenAny c = new();
            string? data = await new HttpClient().GetStringAsync(url);
            c.Site = url;
            c.Len = data.Length;
            Console.WriteLine("GetContentAsync thread: " + Thread.CurrentThread.ManagedThreadId);
            return c;
        }


    }
    class ContentWhenAny
    {
        public string Site { get; set; }
        public int Len { get; set; }
    }
}
