namespace TaskConsoleApp
{
    public class WaitAll
    {
        public async Task WaitAllAsync()
        {
            Console.WriteLine("Main Thread: " + Thread.CurrentThread.ManagedThreadId);
            List<string> urlList = new()
            {
                "https://www.google.com",
                "https://www.microsoft.com",
                "https://www.amazon.com",
                "https://www.haberturk.com"
            };

            List<Task<ContentWaitAll>> taskList = new();

            urlList.ToList().ForEach(async x =>
            {
                taskList.Add(GetContentAsync(x));
            });
            Console.WriteLine("WaitAll metodundan önce");
            //Task.WaitAll(taskList.ToArray());
            bool result = Task.WaitAll(taskList.ToArray(), 3000);

            Console.WriteLine("3 saniyede geldi mi? : " + result);
            Console.WriteLine("WaitAll metodundan sonra");

            Console.WriteLine($"{taskList.First().Result.Site} - {taskList.First().Result.Len}");
        }

        async Task<ContentWaitAll> GetContentAsync(string url)
        {
            ContentWaitAll c = new();
            string? data = await new HttpClient().GetStringAsync(url);
            c.Site = url;
            c.Len = data.Length;
            Console.WriteLine(url + " ~ GetContentAsync thread: " + Thread.CurrentThread.ManagedThreadId);
            return c;
        }


    }
    class ContentWaitAll
    {
        public string Site { get; set; }
        public int Len { get; set; }
    }
}
