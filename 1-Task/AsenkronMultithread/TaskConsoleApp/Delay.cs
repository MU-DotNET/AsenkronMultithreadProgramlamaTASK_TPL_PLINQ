namespace TaskConsoleApp
{
    public class Delay
    {
        public async Task DelayAsync()
        {
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            await Task.Delay(1000);
            Console.WriteLine("1 saniye bekledik : " + DateTime.Now.ToLongTimeString());
        }
    }
}
