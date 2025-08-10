using PLINQ.Context;
using PLINQ.Entities;

MyDbContext context = new MyDbContext();


#region Exception Handle

var products = context.Products.Take(100).ToArray();

products[3].Name = "##";

products[5].Name = "##";

var query = products.AsParallel().Where(isControl);

try
{
query.ForAll(x => Console.WriteLine(x.Name));
}
catch (AggregateException ex)
{
    ex.InnerExceptions.ToList().ForEach(x =>
    {
        if (x is IndexOutOfRangeException)
        {
        Console.WriteLine("Hata: array sınırları dışına çıkıldı.");
        }
    });
}

bool isControl(Product p)
{
    try
    {
        return p.Name[2]=='a';
    }
    catch (Exception ex)
    {
        Console.WriteLine("Dizi Sınırları aşışdı");
        return false;
    }
}

#endregion

#region AsOrdered
// var product = (from p in context.Products.AsParallel()
//     where p.ListPrice > 10M
//     select p).Take(10);

// var product = (from p in context.Products
//         where p.ListPrice > 10M
//             select p).Take(10);
//
// product.AsParallel().ForAll(x => Console.WriteLine($"{x.Name} -> {x.ListPrice}"));
    
// product.ToList().ForEach(x => Console.WriteLine(x.Name));

// product.ForAll(x => Console.WriteLine(x));

// var product = (from p in context.Products.AsParallel()
//     where p.ListPrice > 10M
//     select p).Take(10);

//context.Products.AsParallel().WithDegreeOfParallelism(2).ForAll(p => WriteLog(p));

// context.Products.AsParallel().WithExecutionMode(ParallelExecutionMode.ForceParallelism).ForAll(p => WriteLog(p));

// context.Products.AsParallel().AsOrdered().Where(p => p.ListPrice > 10M).ToList().ForEach(p => Console.WriteLine($"{p.Name} -  {p.ListPrice}"));
//
// void WriteLog(Product product)
// {
//     Console.WriteLine(product.Name + " log'a kaydedildi.");
// }


#endregion
