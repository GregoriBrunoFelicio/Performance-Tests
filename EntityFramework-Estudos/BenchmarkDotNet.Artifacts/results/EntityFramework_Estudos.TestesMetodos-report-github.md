``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.18363.1734 (1909/November2019Update/19H2)
Intel Core i7-8700 CPU 3.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=5.0.302
  [Host]     : .NET Core 3.1.17 (CoreCLR 4.700.21.31506, CoreFX 4.700.21.31502), X64 RyuJIT
  DefaultJob : .NET Core 3.1.17 (CoreCLR 4.700.21.31506, CoreFX 4.700.21.31502), X64 RyuJIT


```
| Method |     Mean |    Error |   StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------- |---------:|---------:|---------:|-------:|------:|------:|----------:|
| Teste1 | 43.91 ns | 0.425 ns | 0.398 ns | 0.0140 |     - |     - |      88 B |
| Teste2 | 45.69 ns | 0.716 ns | 0.670 ns | 0.0140 |     - |     - |      88 B |
