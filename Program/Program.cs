#nullable enable
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.IO;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            unsafe
            {
                BenchmarkRunner.Run<Teste>();
            }
        }

    }

    public class Teste
    {
        string manyLines = @"This is line one
This is line two
Here is line three
The penultimate line is line four
This is the final, fifth line.";

        [Benchmark]
        public void ComDispose()
        {
            using var reader = new StringReader(manyLines);
            string? item;
            do
            {
                item = reader.ReadLine();
                Console.WriteLine(item);
            } while (item != null);
        }

        [Benchmark]
        public void ComTryCatch()
        {
            var reader = new StringReader(manyLines);
            try
            {
                string? item;
                do
                {
                    item = reader.ReadLine();
                    Console.WriteLine(item);
                } while (item != null);
            }
            finally
            {
                reader.Dispose();
            }
        }

        [Benchmark]
        public void ComFinalize()
        {
            var reader = new StringReader(manyLines);
            string? item;
            do
            {
                item = reader.ReadLine();
                Console.WriteLine(item);
            } while (item != null);

            GC.SuppressFinalize(this);
        }
    }
}
