# About

Provides several methods to customize color themes for SeriLog. 

To use the predefined themes, 

1. Add this package to your project
1. Add the following to your SeriLog configuration.

```csharp
.WriteTo.Console(theme: SeriLogCustomThemes.Theme1())
```

There are five themes, in the above example the first theme is used.

If you don’t care for something in a theme, clone the source code, make changes, compile and add a reference to the project to your project.