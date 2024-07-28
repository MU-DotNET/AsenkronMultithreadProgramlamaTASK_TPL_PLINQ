
int deger = 0;

Parallel.ForEach(Enumerable.Range(1, 100000).ToList() ,(x) =>
{
    deger = x;
});
Console.WriteLine(deger);