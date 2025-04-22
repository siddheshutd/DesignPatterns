using System;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Service : IService
    {
        public string GetData(string key)
        {
            Console.WriteLine($"Fetching data for key: {key}...");
            // Simulate data fetching delay
            Task.Delay(2000).Wait();
            return $"Data for {key}";
        }
    }
}
