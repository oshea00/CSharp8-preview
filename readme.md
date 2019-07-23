# C# 8.0 Preview - IAsyncEnumerable and Linq

Short demo of the new IAsyncEnumerable feature in C# 8.0.

## Project setup for new projects

* Install the latest .Net Core 3.0 preview.
* In Visual Studio 2019, allow preview features under: Tools->Options->Environment->Preview Features
* VSCode needs no changes.

## Additional steps for new projects

* csproj file for new projects should have LangVersion tag for C# 8.0
```
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>netcoreapp3.0</TargetFramework>
    <LangVersion>8.0</LangVersion>
  </PropertyGroup>
```
* Install system.linq.async package to project. 

Example:

dotnet add package System.Linq.Async -v 4.0.0-preview.6.build.801

