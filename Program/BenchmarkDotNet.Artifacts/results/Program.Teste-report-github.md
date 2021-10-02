``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.18363.1801 (1909/November2019Update/19H2)
Intel Core i7-8700 CPU 3.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=5.0.302
  [Host]     : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
  DefaultJob : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT


```
|      Method |     Mean |     Error |    StdDev |   Median |
|------------ |---------:|----------:|----------:|---------:|
|  ComDispose | 1.669 ms | 0.1534 ms | 0.4523 ms | 1.468 ms |
| ComTryCatch | 1.620 ms | 0.1044 ms | 0.3062 ms | 1.478 ms |
| ComFinalize | 1.441 ms | 0.0288 ms | 0.0541 ms | 1.455 ms |
