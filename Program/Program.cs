using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            BenchmarkRunner.Run<Teste>();
        }
    }

    public class Teste
    {
        [Benchmark]
        public void Teste1() => Console.WriteLine(":)");

        [Benchmark]
        public void Teste2()
        {
            Console.WriteLine(":)");
        }
    }
}
