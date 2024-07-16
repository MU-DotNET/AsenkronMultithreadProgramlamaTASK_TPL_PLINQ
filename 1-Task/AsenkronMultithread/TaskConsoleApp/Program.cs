
#region ContunieWith
//Console.WriteLine("Hello, World!");

//Task? myTask = new HttpClient().GetStringAsync("https://www.google.com").ContinueWith((data) =>
//{
//	Console.WriteLine("data uzunluk :" + data.Result.Length);
//});

//Console.WriteLine("Arada yapılacak işler");

//await myTask; 
#endregion
#region WithoutContinueWith
//Console.WriteLine("Hello, World!");

//Task<string>? myTask = new HttpClient().GetStringAsync("https://www.google.com");

//Console.WriteLine("Arada yapılacak işler");

//string? data = await myTask;

//Console.WriteLine("data uzunluk :" + data.Length);

#endregion
#region ContinueWithLambdaFunction

Console.WriteLine("Hello, World!");

var myTask = new HttpClient().GetStringAsync("https://www.google.com")
    .ContinueWith(calis);

Console.WriteLine("Arada yapılacak işler");

await myTask;


void calis(Task<string> data)
{
    Console.WriteLine("data uzunluk: " + data.Result.Length);
}

#endregion