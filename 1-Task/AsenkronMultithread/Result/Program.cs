var task = new HttpClient().GetStringAsync("https://www.google.com")
    .ContinueWith((data) =>
    {

    });


//string GetData()
//{
//    var task = new HttpClient().GetStringAsync("https://www.google.com");
//    return task.Result;
//}