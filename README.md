# Timely
Timely (or Timely Extensions) is a small C# Library that gives you some shortcuts for Dates and TimeSpan.
With these you can do stuff like `15.February(1996)` or `16.Minutes() + 20.Seconds()`.

## Methods
### Date Extensions
With `DateExtensions` you can write dates in a natural way. It uses the in Europe commonly used `dd-MMM-yyyy` syntax.
To write 15th February 1996 you can write the following:

```csharp
15.February(1996)
// or
15.Feb(1996)
```

You can leave the year parameter empty to use the current year.

```csharp
15.Feb()  // => returns "15th February 2017" in the year 2017
```

#### API Syntax
```csharp
DateTime <int:day>.<month>([<year>])
```

#### Methods
All these methods return a `DateTime` instance.

- `Jan([int? year])` or `January([int? year])`
- `Feb([int? year])` or `February([int? year])`
- `Mar([int? year])` or `March([int? year])`
- `Apr([int? year])` or `April([int? year])`
- `May([int? year])` _(no short hand here, May is already short enough)_
- `Jun([int? year])` or `June([int? year])`
- `Jul([int? year])` or `July([int? year])`
- `Aug([int? year])` or `August([int? year])`
- `Sep([int? year])` or `September([int? year])`
- `Oct([int? year])` or `October([int? year])`
- `Nov([int? year])` or `November([int? year])`
- `Dec([int? year])` or `December([int? year])`

### Time Extensions
With `TimeExtensions` you can create simple TimeSpans from a simple query.

```csharp
16.Minutes()  // => returns a new TimeSpan with 16 minutes
```

If you want to create a specific TimeSpan with e.g. minutes and seconds you can just add two queries together:

```csharp
16.Minutes() + 20.Seconds() // => return 16:20 min
```

#### API Syntax
```csharp
TimeSpan <int:amount>.<unit>()
```

#### Methods
All these methods return a `TimeSpan` instance.

- `Milliseconds()`
- `Seconds()`
- `Minutes()`
- `Hours()`
- `Days()`

## Purpose of this project
This project is just a test for me to learn how to write Unit Tests in VS2017 and how to publish a NuGet package.

That being said I hope someone finds this package useful and uses it.

## License
This project is licensed under the MIT License. See LICENSE for more info.
