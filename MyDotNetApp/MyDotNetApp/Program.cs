using System;

namespace MyDotNetApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Greeter.SayHello());
        }
    }

    public static class Greeter
    {
        public static string SayHello() => "Hello from Sourav Dutta!";
    }
}
