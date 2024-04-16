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
