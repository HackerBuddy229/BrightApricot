using System;

namespace BrightApricot.TestDataGenerator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            new Generator("TestData.json").Run();
        }
    }
}
