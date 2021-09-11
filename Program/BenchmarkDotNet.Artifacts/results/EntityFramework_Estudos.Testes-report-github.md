``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.18363.1679 (1909/November2019Update/19H2)
Intel Core i7-8700 CPU 3.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=5.0.301
  [Host]     : .NET Core 3.1.16 (CoreCLR 4.700.21.26205, CoreFX 4.700.21.26205), X64 RyuJIT
  DefaultJob : .NET Core 3.1.16 (CoreCLR 4.700.21.26205, CoreFX 4.700.21.26205), X64 RyuJIT


```
|        Method |     Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------- |---------:|----------:|----------:|-------:|------:|------:|----------:|
| ObterUsuarios | 1.481 ms | 0.0294 ms | 0.0600 ms | 7.8125 |     - |     - |     73 KB |
