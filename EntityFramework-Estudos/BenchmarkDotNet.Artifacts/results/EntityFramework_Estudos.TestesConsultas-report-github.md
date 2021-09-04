``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.18363.1734 (1909/November2019Update/19H2)
Intel Core i7-8700 CPU 3.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=5.0.302
  [Host]     : .NET Core 3.1.17 (CoreCLR 4.700.21.31506, CoreFX 4.700.21.31502), X64 RyuJIT
  DefaultJob : .NET Core 3.1.17 (CoreCLR 4.700.21.31506, CoreFX 4.700.21.31502), X64 RyuJIT


```
|                 Method |     Mean |   Error |   StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------- |---------:|--------:|---------:|------:|------:|------:|----------:|
|      ConsultaComToList | 321.2 ms | 6.52 ms | 18.19 ms |     - |     - |     - |      1 MB |
| ConsultaComAsQueriable | 334.9 ms | 9.60 ms | 26.60 ms |     - |     - |     - |      1 MB |
|        ConsultaComNada | 344.5 ms | 8.79 ms | 24.50 ms |     - |     - |     - |      1 MB |
