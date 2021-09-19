﻿#nullable enable
using BenchmarkDotNet.Attributes;
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
                //BenchmarkRunner.Run<Teste>();
                var n1 = 10;
                var n2 = 10;

                var n3 = &n1;
                var n4 = &n2;

                var a = SumUnsafe(n3, n4);
                Console.WriteLine(a);
            }
        }

        static unsafe int SumUnsafe(int* n1, int* n2) => (int)(&n1 + (ulong)&n2);
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

    }
}
