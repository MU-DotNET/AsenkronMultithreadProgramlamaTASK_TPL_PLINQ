namespace TaskConsoleApp
{
    public class ContinueWith
    {
        #region ContunieWith
        public async Task ContinueWithAsync()
        {
            Console.WriteLine("Hello, World!");

            Task? myTask = new HttpClient().GetStringAsync("https://www.google.com").ContinueWith((data) =>
            {
                Console.WriteLine("data uzunluk :" + data.Result.Length);
            });

            Console.WriteLine("Arada yapılacak işler");

            await myTask;
        }

        #endregion
        #region WithoutContinueWith
        public async Task WithoutContinueWith()
        {
            Console.WriteLine("Hello, World!");

            Task<string>? myTask = new HttpClient().GetStringAsync("https://www.google.com");

            Console.WriteLine("Arada yapılacak işler");

            string? data = await myTask;

            Console.WriteLine("data uzunluk :" + data.Length);
        }


        #endregion
        #region ContinueWithLambdaFunction
        public async Task ContinueWithLambdaFunction()
        {
            Console.WriteLine("Hello, World!");

            var myTask = new HttpClient().GetStringAsync("https://www.google.com")
                .ContinueWith(calis);

            Console.WriteLine("Arada yapılacak işler");

            await myTask;
        }
        private void calis(Task<string> data)
        {
            Console.WriteLine("data uzunluk: " + data.Result.Length);
        }

        #endregion
    }
}
