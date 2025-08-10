using PLINQ.Context;
using PLINQ.Entities;

MyDbContext context = new MyDbContext();

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

context.Products.AsParallel().WithExecutionMode(ParallelExecutionMode.ForceParallelism).ForAll(p => WriteLog(p));

void WriteLog(Product product)
{
    Console.WriteLine(product.Name + " log'a kaydedildi.");
}