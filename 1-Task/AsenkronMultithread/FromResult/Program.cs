
class Program
{
    public static string CacheData { get; set; }
    
    public static async Task Main(string[] args)
    {
        CacheData = await GetDataAsync();
        Console.WriteLine(CacheData);
    }

    static Task<string>  GetDataAsync()
    {
        if (String.IsNullOrEmpty(CacheData))
            return File.ReadAllTextAsync("file.txt");

        else
            return Task.FromResult<string>(CacheData);
    }

}


