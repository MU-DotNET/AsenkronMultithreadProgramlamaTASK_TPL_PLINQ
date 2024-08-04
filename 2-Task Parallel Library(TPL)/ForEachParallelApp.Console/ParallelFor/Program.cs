long totalByte = 0;

string[]? files = Directory.GetFiles(@"D:\Github\AsenkronMultithreadProgramlamaTASK_TPL_PLINQ\2-Task Parallel Library(TPL)\Pictures");

Parallel.For(0, files.Length, (index) =>
{
    FileInfo? fileInfo = new FileInfo(files[index]);

    Interlocked.Add(ref totalByte, fileInfo.Length);
});
Console.WriteLine("Total Byte : " + totalByte.ToString());