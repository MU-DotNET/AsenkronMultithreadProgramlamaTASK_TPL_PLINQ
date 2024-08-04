
int total = 0;

Parallel.ForEach(Enumerable.Range(1, 100).ToList(), () => 0, (x, loop, subtotal) =>
{
    subtotal += x;
    return subtotal;
}, (y) => Interlocked.Add(ref total, y));
Console.WriteLine(total);


Parallel.For(0, 100, () => 0, (x, loop, subtotal) => 
{ 
    subtotal += x; 
    return subtotal;
}, (y) => Interlocked.Add(ref total, y));