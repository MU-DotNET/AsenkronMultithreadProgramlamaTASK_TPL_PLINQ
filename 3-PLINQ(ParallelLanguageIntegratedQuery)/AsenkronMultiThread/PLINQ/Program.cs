using PLINQ.Context;

MyDbContext context = new MyDbContext();
context.Products.Take(10).ToList().ForEach(x => Console.WriteLine(x.Name));