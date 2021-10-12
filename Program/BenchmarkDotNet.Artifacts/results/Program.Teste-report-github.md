``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.18363.1801 (1909/November2019Update/19H2)
Intel Core i7-8700 CPU 3.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=5.0.302
  [Host]     : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
  DefaultJob : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT


```
|      Method |      Mean |     Error |    StdDev |
|------------ |----------:|----------:|----------:|
|      Teste1 | 0.0264 ns | 0.0085 ns | 0.0075 ns |
| TesteNormal | 0.0203 ns | 0.0008 ns | 0.0006 ns |
