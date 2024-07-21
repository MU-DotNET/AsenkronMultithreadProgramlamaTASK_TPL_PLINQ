namespace TaskConsoleApp;

public class WaitAny
{
    public async Task WaitAnyAsync()
    {
        Console.WriteLine("Main Thread: " + Thread.CurrentThread.ManagedThreadId);
        List<string> urlList = new()
            {
                "https://www.google.com",
                "https://www.microsoft.com",
                "https://www.amazon.com",
                "https://www.haberturk.com"
            };

        List<Task<ContentWaitAny>> taskList = new();

        urlList.ToList().ForEach(async x =>
        {
            taskList.Add(GetContentAsync(x));
        });

        int firstTaskIndex = Task.WaitAny(taskList.ToArray());

        Console.WriteLine($"{taskList[firstTaskIndex].Result.Site} - {taskList[firstTaskIndex].Result.Len}");
    }

    async Task<ContentWaitAny> GetContentAsync(string url)
    {
        ContentWaitAny c = new();
        string? data = await new HttpClient().GetStringAsync(url);
        c.Site = url;
        c.Len = data.Length;
        Console.WriteLine(url + " ~ GetContentAsync thread: " + Thread.CurrentThread.ManagedThreadId);
        return c;
    }


}
class ContentWaitAny
{
    public string Site { get; set; }
    public int Len { get; set; }
}



