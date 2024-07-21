int cacheData = 150;

int data = await GetData();
Console.WriteLine(data);
ValueTask<int> GetData()
{
    return new (cacheData);
}