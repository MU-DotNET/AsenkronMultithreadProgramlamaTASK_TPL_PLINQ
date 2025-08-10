
bool Islem(int x)
{
    return x % 2 == 0;
}

var array = Enumerable.Range(1,100).ToList();

var newArray = array.AsParallel().Where(Islem);

// newArray.ToList().ForEach(x =>
// {
//     Thread.Sleep(500);
//     Console.WriteLine(x);
// });

newArray.ForAll(x =>
{
    Thread.Sleep(500);
    Console.WriteLine(x);
});