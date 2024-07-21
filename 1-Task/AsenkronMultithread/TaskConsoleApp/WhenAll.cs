namespace TaskConsoleApp
{
    public class WhenAll
    {
        public async Task WhenAllAsync()
        {
            Console.WriteLine("Main Thread: " + Thread.CurrentThread.ManagedThreadId);
            List<string> urlList = new()
            {
                "https://www.google.com",
                "https://www.microsoft.com",
                "https://www.amazon.com",
                "https://www.haberturk.com",
                 "https://www.google.com",
                "https://www.microsoft.com",
                "https://www.amazon.com",
                "https://www.haberturk.com"
            };

            List<Task<Content>> taskList = new();

            urlList.ToList().ForEach(async x =>
            {
                taskList.Add(GetContentAsync(x));
            });

            var contents = Task.WhenAll(taskList);

            Console.WriteLine("WhenAll metodundan sonra başka işler yaptım");

            var data = await contents;

            data.ToList().ForEach(x =>
            {
                Console.WriteLine($"{x.Site} boyut:{x.Len}");
            });


        }

        async Task<Content> GetContentAsync(string url)
        {
            Content c = new();
            var data = await new HttpClient().GetStringAsync(url);
            c.Site = url;
            c.Len = data.Length;
            Console.WriteLine("GetContentAsync thread: " + Thread.CurrentThread.ManagedThreadId);
            return c;
        }


    }
    class Content
    {
        public string Site { get; set; }
        public int Len { get; set; }
    }
}
