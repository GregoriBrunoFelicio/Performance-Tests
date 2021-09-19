``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.18363.1801 (1909/November2019Update/19H2)
Intel Core i7-8700 CPU 3.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=5.0.302
  [Host]     : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
  DefaultJob : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT


```
|      Method |     Mean |     Error |    StdDev |   Median |
|------------ |---------:|----------:|----------:|---------:|
|  ComDispose | 2.489 ms | 0.0816 ms | 0.2353 ms | 2.545 ms |
| ComTryCatch | 2.664 ms | 0.0554 ms | 0.1634 ms | 2.736 ms |
