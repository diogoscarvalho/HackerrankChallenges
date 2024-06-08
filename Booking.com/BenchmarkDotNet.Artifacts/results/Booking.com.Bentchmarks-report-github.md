```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3593/23H2/2023Update/SunValley3)
Intel Core i9-9880H CPU 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.101
  [Host]     : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2


```
| Method                        | Mean     | Error    | StdDev   | Median   | Gen0   | Allocated |
|------------------------------ |---------:|---------:|---------:|---------:|-------:|----------:|
| CountDuplicates               | 472.5 ns | 18.30 ns | 53.66 ns | 458.1 ns | 0.1173 |     984 B |
| CountDuplicatesWithDictionary | 446.7 ns | 11.90 ns | 34.72 ns | 443.4 ns | 0.1173 |     984 B |
