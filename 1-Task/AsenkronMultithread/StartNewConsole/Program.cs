
Task? myTask = Task.Factory.StartNew((obj) =>
{
    Console.WriteLine("myTask çalıştı");
    Status? status = obj as Status;
    status.ThreadId = Thread.CurrentThread.ManagedThreadId;
}, new Status() { Date = DateTime.Now });

await myTask;
Status s = myTask.AsyncState as Status;
Console.WriteLine(s.Date);
Console.WriteLine(s.ThreadId);

class Status
{
    public int ThreadId { get; set; }
    public DateTime Date { get; set; }

}