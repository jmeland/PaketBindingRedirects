using Newtonsoft.Json;
using System;

namespace PaketBindingRedirects
{
    class Program
    {
        static void Main()
        {
            int[] test = new int[] { 1, 2, 3 };
            Console.WriteLine(test);
            Console.WriteLine(JsonConvert.SerializeObject(test));
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
