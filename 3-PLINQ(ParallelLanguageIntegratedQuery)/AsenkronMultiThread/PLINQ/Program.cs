
bool Islem(int x)
{
    return x % 2 == 0;
}

var array = Enumerable.Range(1,100).ToList();

array.Where(Islem).ToList().ForEach(x => Console.WriteLine(x));

var newArray = array.AsParallel().Where(Islem);

newArray.ToList().ForEach(x => Console.WriteLine(x));