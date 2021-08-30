``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.18363.1734 (1909/November2019Update/19H2)
Intel Core i7-8700 CPU 3.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=5.0.302
  [Host]     : .NET Core 3.1.17 (CoreCLR 4.700.21.31506, CoreFX 4.700.21.31502), X64 RyuJIT
  DefaultJob : .NET Core 3.1.17 (CoreCLR 4.700.21.31506, CoreFX 4.700.21.31502), X64 RyuJIT


```
|                 Method |       Mean |      Error |     StdDev |     Median |    Gen 0 |    Gen 1 |   Gen 2 | Allocated |
|----------------------- |-----------:|-----------:|-----------:|-----------:|---------:|---------:|--------:|----------:|
|      ConsultaComToList | 310.005 ms | 23.2458 ms | 68.5408 ms | 323.239 ms |        - |        - |       - |      1 MB |
| ConsultaComAsQueriable | 309.913 ms | 22.7954 ms | 67.2128 ms | 334.579 ms |        - |        - |       - |      1 MB |
|        ConsultaComNada | 341.504 ms |  9.3959 ms | 26.5014 ms | 337.589 ms |        - |        - |       - |      1 MB |
|            JoinComLinq |   7.896 ms |  0.0773 ms |  0.0645 ms |   7.903 ms | 453.1250 | 156.2500 | 62.5000 |      3 MB |
|            JoinSemLinq |   8.064 ms |  0.1378 ms |  0.1222 ms |   8.043 ms | 453.1250 | 156.2500 | 62.5000 |      3 MB |
|         JoinComInclude |  13.354 ms |  0.6989 ms |  2.0608 ms |  12.604 ms |        - |        - |       - |      5 MB |
