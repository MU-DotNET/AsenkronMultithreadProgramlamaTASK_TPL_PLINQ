
Console.WriteLine("1. adım");

Task<string>? myTask = GetContentAsync();

Console.WriteLine("2. adım");

string? content = await myTask;

Console.WriteLine("3. Adım => " + content.Length);


async Task<string> GetContentAsync()
{
    return await new HttpClient().GetStringAsync("https://www.google.com");
}