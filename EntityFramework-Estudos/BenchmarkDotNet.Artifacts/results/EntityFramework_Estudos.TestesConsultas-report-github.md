``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.18363.1734 (1909/November2019Update/19H2)
Intel Core i7-8700 CPU 3.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=5.0.302
  [Host]     : .NET Core 3.1.17 (CoreCLR 4.700.21.31506, CoreFX 4.700.21.31502), X64 RyuJIT
  DefaultJob : .NET Core 3.1.17 (CoreCLR 4.700.21.31506, CoreFX 4.700.21.31502), X64 RyuJIT


```
|         Method |      Mean |     Error |    StdDev |    Gen 0 |    Gen 1 |    Gen 2 | Allocated |
|--------------- |----------:|----------:|----------:|---------:|---------:|---------:|----------:|
|    JoinComLinq |  7.987 ms | 0.0793 ms | 0.0703 ms | 453.1250 | 156.2500 |  62.5000 |      3 MB |
|    JoinSemLinq |  7.968 ms | 0.0611 ms | 0.0541 ms | 453.1250 | 156.2500 |  62.5000 |      3 MB |
| JoinComInclude | 18.259 ms | 0.3594 ms | 0.4798 ms | 875.0000 | 375.0000 | 156.2500 |      5 MB |
