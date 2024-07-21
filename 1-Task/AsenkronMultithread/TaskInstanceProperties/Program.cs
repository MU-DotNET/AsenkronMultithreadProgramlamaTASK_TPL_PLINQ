Task myTask = Task.Run(() =>
{
    Console.WriteLine("MyTask çalıştı");
    throw new ArgumentException("Bir hata geldi.");
});

await myTask;

Console.WriteLine("İşlem Bitti");