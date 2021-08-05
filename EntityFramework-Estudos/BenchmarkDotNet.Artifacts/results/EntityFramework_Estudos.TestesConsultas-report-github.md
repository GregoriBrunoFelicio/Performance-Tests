``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.18363.1679 (1909/November2019Update/19H2)
Intel Core i7-8700 CPU 3.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=5.0.301
  [Host]     : .NET Core 3.1.16 (CoreCLR 4.700.21.26205, CoreFX 4.700.21.26205), X64 RyuJIT
  DefaultJob : .NET Core 3.1.16 (CoreCLR 4.700.21.26205, CoreFX 4.700.21.26205), X64 RyuJIT


```
|                       Method |     Mean |     Error |    StdDev |    Gen 0 |    Gen 1 | Gen 2 | Allocated |
|----------------------------- |---------:|----------:|----------:|---------:|---------:|------:|----------:|
| ObterUsuariosSemAsNoTracking | 3.761 ms | 0.0284 ms | 0.0222 ms | 257.8125 | 117.1875 |     - |  1,609 KB |
| ObterUsuariosComAsNoTracking | 2.238 ms | 0.0274 ms | 0.0229 ms | 109.3750 |  31.2500 |     - |    675 KB |
