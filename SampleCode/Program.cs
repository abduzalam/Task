using System.Diagnostics;
using System.Runtime.InteropServices;

internal class Program
{
    private static async Task Main(string[] args)
    {
        Console.WriteLine("This is sample app to demonstrate async await program!");
        Console.WriteLine($"Application Starts at: {DateTime.Now.ToLongTimeString()}");

        foreach(var item in await FetchItems()) { 
        Console.WriteLine($"Printing item '{item}' at {DateTime.Now.ToLongTimeString()}");
        }
        Console.WriteLine($"Application Ends at: {DateTime.Now.ToLongTimeString()}");
    }

    private static async Task<IEnumerable<int>> FetchItems()
    {
        List<int> items = new List<int>();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Waiting for 1 sec before adding item '{i}' at: {DateTime.Now.ToLongTimeString()}");
            await Task.Delay(1000);// 1 Sec, Before adding each i to items, app wait for 1 sec , so over all 10 secs to finish the app
            items.Add(i);
            Console.WriteLine($"Added item '{i}' at: {DateTime.Now.ToLongTimeString()}");
        }
        return items;
    }
}