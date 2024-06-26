# Language Version 1

This project uses language version 1 and is tested for definition and consumption of
a number of features from higher language versions.

| Feature | Defition | Consumption | Notes |
| --- | --- | --- | --- |
| `dynamic` parameters | No | Yes | Performs a standard `dynamic` dispatch |
| `dynamic` returns | No | Yes | Return does a `dynamic` conversion to stated type |
| generic parameters | No | Yes | Can call with types convertible to generic type or `null` |
| generic method type inference | No | Yes | Can infer direct parameters and consume operators from generic types |
| generic type returns | No | Yes | Can consume with `object` or by taking advantage of implicit conversion operator on generic type |
| primary ctor | No | Yes | Can call like a normal constructor |
| covariant returns | No | Yes | Sees the derived return type |
| checked operators | No | No | Consumption is guarded |
| readonly members | No | No | Copies occur on `readonly` members |
| better overload candidates inst vs. static | N/A | No | |
| `ref` fields | No | No | Lets all rejoice at this one |
| `ref struct` members | No | Yes | Can consume `ref struct` members |
