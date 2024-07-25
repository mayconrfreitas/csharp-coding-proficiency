# C# Coding Proficiency Tests

Study developed based on 4 tasks related to geometric analyses in C#:

1. [Analyze all columns that have an area less than or equal to 10m².](./csharp-coding-proficiency/Services/Task01_AnalyseColumnArea.cs)
1. [Analyze all columns that are inside the terrain.](./csharp-coding-proficiency/Services/Task02_AnalyseColumnsInsideTerrain.cs)
1. [Analyze if there is a 7m space between all columns](./csharp-coding-proficiency/Services/Task03_AnalyseSpaceBetweenColumns.cs)
1. [Analyze all columns that are rectangular. Do not use the Polygon.IsRectangular property for this.](./csharp-coding-proficiency/Services/Task04_AnalyseColumnRectangular.cs)


## Installation

1. Clone the repository to your local machine:
    ```sh
    git clone https://github.com/mayconrfreitas/csharp-coding-proficiency.git
    ```

2. Navigate to the project directory:
    ```sh
    cd csharp-coding-proficiency
    ```

3. Restore the NuGet packages:
    ```sh
    dotnet restore
    ```

## Tests

This project includes unit tests to ensure the correct functionality of the functions. The tests are located in the `tests` folder and can be run using the `dotnet test` command.

### Included Unit Tests

- **TestCheckAreaLessOrEqualsTo10m2**: Checks if the area of the polygons is less than or equal to 10 m².
- **TestCheckColumnsInsideTerrain**: Checks if the polygons are within a specific area (terrain).
- **TestCheckSpaceBetweenColumns**: Checks if there is sufficient space between the polygons.
- **TestsCheckColumnsRectangular**: Checks if the polygons are rectangular.

### Running the Tests

To run the tests, use the following command:

```sh
dotnet test
```

## Dependencies

This project depends on the following libraries:

- **NetTopologySuite**: Library for geometric operations.
- **xUnit**: Test framework for .NET.

To install the dependencies, make sure to restore the NuGet packages:

```sh
dotnet restore
```

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.