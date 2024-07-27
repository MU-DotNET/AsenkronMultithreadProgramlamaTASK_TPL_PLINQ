using System.Diagnostics;
using System.Drawing;

ParallelForeach();
Foreach();

void ParallelForeach()
{
    Stopwatch stopwatch = new();
    stopwatch.Start();

    string picturesPath = "D:\\Github\\AsenkronMultithreadProgramlamaTASK_TPL_PLINQ\\2-Task Parallel Library(TPL)\\Pictures";
    string[]? files = Directory.GetFiles(picturesPath);

    Parallel.ForEach(files, (file) =>
    {
        Console.WriteLine($"Thread No: {Thread.CurrentThread.ManagedThreadId}");
        Image image = new Bitmap(file);
        Image? thumbnail = image.GetThumbnailImage(50, 50, () => false, IntPtr.Zero);

        thumbnail.Save(Path.Combine(picturesPath, "thumbnail", Path.GetFileName(file)));
    });
    stopwatch.Stop();
    Console.WriteLine("Parallel.ForEach İşlem tamamlandı : " + stopwatch.ElapsedMilliseconds);
}

void Foreach()
{
    Stopwatch stopwatch = new();
    stopwatch.Start();

    string picturesPath = "D:\\Github\\AsenkronMultithreadProgramlamaTASK_TPL_PLINQ\\2-Task Parallel Library(TPL)\\Pictures";
    string[]? files = Directory.GetFiles(picturesPath);

    files.ToList().ForEach((file) => 
    {
        Console.WriteLine($"Thread No: {Thread.CurrentThread.ManagedThreadId}");
        Image image = new Bitmap(file);
        Image? thumbnail = image.GetThumbnailImage(50, 50, () => false, IntPtr.Zero);

        thumbnail.Save(Path.Combine(picturesPath, "thumbnail", Path.GetFileName(file)));
    });

    stopwatch.Stop();
    Console.WriteLine("Foreach İşlem tamamlandı : " + stopwatch.ElapsedMilliseconds);
}