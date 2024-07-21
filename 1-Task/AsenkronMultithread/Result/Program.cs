Console.WriteLine(GetData());

string GetData()
{
    var task = new HttpClient().GetStringAsync("https://www.google.com");
    return task.Result;
}