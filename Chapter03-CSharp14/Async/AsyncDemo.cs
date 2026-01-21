using System;
using System.Threading.Tasks;

namespace Chapter03.Async
{
    public static class AsyncDemo
    {
        public static async Task Run()
        {
            Console.WriteLine("--- Async/Await ---");

            Console.WriteLine("Fetching data...");
            string data = await FetchDataAsync();
            Console.WriteLine(data);

            Console.WriteLine("Running parallel tasks...");
            await ProcessDataAsync();
            Console.WriteLine("Finished parallel tasks.");
        }

        static async Task<string> FetchDataAsync()
        {
            await Task.Delay(500); // Simulate network
            return "Data received!";
        }

        static async Task ProcessDataAsync()
        {
            Task t1 = Task.Delay(100);
            Task t2 = Task.Delay(200);
            Task t3 = Task.Delay(150);

            await Task.WhenAll(t1, t2, t3);
        }
    }
}
