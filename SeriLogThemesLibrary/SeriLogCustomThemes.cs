using Serilog.Sinks.SystemConsole.Themes;
namespace SeriLogThemesLibrary;
public class SeriLogCustomThemes
{
    public static SystemConsoleTheme Theme1()
    {
        Dictionary<ConsoleThemeStyle, SystemConsoleThemeStyle> customThemeStyles = new()
            {
                {
                    ConsoleThemeStyle.Text, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Green,
                    }
                },
                {
                    ConsoleThemeStyle.String, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Yellow,
                    }
                },
                {
                    ConsoleThemeStyle.Number, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Cyan,
                    }
                },
                {
                    ConsoleThemeStyle.Boolean, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Red,
                    }
                },
                {
                    ConsoleThemeStyle.LevelInformation, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.DarkCyan,
                    }
                },
                {
                    ConsoleThemeStyle.SecondaryText, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.White//, Background = ConsoleColor.DarkBlue,
                    }
                },
                {
                    ConsoleThemeStyle.Null, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Black, 
                        Background = ConsoleColor.Yellow,
                    }
                },
                {
                    ConsoleThemeStyle.LevelError, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.White, 
                        Background = ConsoleColor.Red,
                    }
                },
                {
                    ConsoleThemeStyle.LevelFatal, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Black, Background = ConsoleColor.Cyan,
                    }
                },
                {
                    ConsoleThemeStyle.LevelWarning, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Magenta,
                        Background = ConsoleColor.Yellow,
                    }
                },
                {
                    ConsoleThemeStyle.LevelVerbose, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.White
                    }
                },
                {
                    ConsoleThemeStyle.Name, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Black,
                        Background = ConsoleColor.Yellow,
                    }
                },
                {
                    ConsoleThemeStyle.Scalar, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.White
                    }
                }

            };

        return new SystemConsoleTheme(customThemeStyles);
    }

    public static SystemConsoleTheme Theme2()
    {
        Dictionary<ConsoleThemeStyle, SystemConsoleThemeStyle> customThemeStyles = new()
            {

                {
                    ConsoleThemeStyle.String, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Green,
                    }
                },
                {
                    ConsoleThemeStyle.Number, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Cyan,
                    }
                },
                {
                    ConsoleThemeStyle.Boolean, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Red,
                    }
                },
                {
                    ConsoleThemeStyle.LevelInformation, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Black,
                        Background = ConsoleColor.White
                    }
                },
                {
                    ConsoleThemeStyle.SecondaryText, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.White
                    }
                },
                {
                    ConsoleThemeStyle.Null, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Black,
                        Background = ConsoleColor.Yellow,
                    }
                },
                {
                    ConsoleThemeStyle.LevelError, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.White,
                        Background = ConsoleColor.Red,
                    }
                },
                {
                    ConsoleThemeStyle.LevelFatal, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Black, Background = ConsoleColor.Cyan,
                    }
                },
                {
                    ConsoleThemeStyle.LevelWarning, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Magenta,
                        Background = ConsoleColor.Yellow,
                    }
                },
                {
                    ConsoleThemeStyle.LevelVerbose, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.White,
                        Background = ConsoleColor.Green,
                    }
                },
                {
                    ConsoleThemeStyle.Name, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Black,
                        Background = ConsoleColor.Yellow,
                    }
                }

            };

        return new SystemConsoleTheme(customThemeStyles);
    }

    public static SystemConsoleTheme Theme3()
    {
        Dictionary<ConsoleThemeStyle, SystemConsoleThemeStyle> customThemeStyles = new()
            {

                {
                    ConsoleThemeStyle.String, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Green,
                    }
                },
                {
                    ConsoleThemeStyle.LevelInformation, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Black,
                        Background = ConsoleColor.White
                    }
                },
                {
                    ConsoleThemeStyle.LevelError, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.White,
                        Background = ConsoleColor.Red,
                    }
                },
                {
                    ConsoleThemeStyle.LevelFatal, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Black, Background = ConsoleColor.Cyan,
                    }
                },
                {
                    ConsoleThemeStyle.LevelWarning, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Magenta,
                        Background = ConsoleColor.Yellow,
                    }
                },
                {
                    ConsoleThemeStyle.LevelVerbose, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.White,
                        Background = ConsoleColor.Green,
                    }
                },
                {
                    ConsoleThemeStyle.Name, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Black,
                        Background = ConsoleColor.Yellow,
                    }
                }

            };

        return new SystemConsoleTheme(customThemeStyles);
    }

    public static SystemConsoleTheme Theme4()
    {
        Dictionary<ConsoleThemeStyle, SystemConsoleThemeStyle> customThemeStyles = new()
            {
                {
                    ConsoleThemeStyle.Boolean, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.DarkYellow,
                    }
                },
                {
                    ConsoleThemeStyle.Number, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.White,
                    }
                },
                {
                    ConsoleThemeStyle.String, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Green,
                    }
                },
                {
                    ConsoleThemeStyle.LevelInformation, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.White,
                        Background = ConsoleColor.Green,
                    }
                },
                {
                    ConsoleThemeStyle.LevelError, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.White,
                        Background = ConsoleColor.Red,
                    }
                },
                {
                    ConsoleThemeStyle.LevelFatal, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Yellow, Background = ConsoleColor.DarkMagenta,
                    }
                },
                {
                    ConsoleThemeStyle.LevelWarning, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Magenta,
                        Background = ConsoleColor.Yellow,
                    }
                },
                {
                    ConsoleThemeStyle.Name, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Cyan
                    }
                }

            };

        return new SystemConsoleTheme(customThemeStyles);
    }

    public static SystemConsoleTheme Theme5()
    {
        Dictionary<ConsoleThemeStyle, SystemConsoleThemeStyle> customThemeStyles = new()
            {
                {
                    ConsoleThemeStyle.Text, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Green,
                    }
                },
                {
                    ConsoleThemeStyle.String, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Yellow,
                    }
                },
                {
                    ConsoleThemeStyle.Number, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Cyan,
                    }
                },
                {
                    ConsoleThemeStyle.LevelInformation, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.White,
                        Background = ConsoleColor.Green,
                    }
                },
                {
                    ConsoleThemeStyle.LevelError, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.White,
                        Background = ConsoleColor.Red,
                    }
                },
                {
                    ConsoleThemeStyle.LevelFatal, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Yellow, Background = ConsoleColor.DarkMagenta,
                    }
                },
                {
                    ConsoleThemeStyle.LevelWarning, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Magenta,
                        Background = ConsoleColor.Yellow,
                    }
                },
                {
                    ConsoleThemeStyle.Scalar, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.White
                    }
                },
                {
                    ConsoleThemeStyle.SecondaryText, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.DarkGray
                    }
                },
                {
                    ConsoleThemeStyle.TertiaryText, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.DarkGray
                    }
                }

            };

        return new SystemConsoleTheme(customThemeStyles);
    }

    public static SystemConsoleTheme Default()
    {
        return Theme5();
    }

    public static SystemConsoleTheme Theme()
    {
        Dictionary<ConsoleThemeStyle, SystemConsoleThemeStyle> customThemeStyles = new()
            {
                {
                    ConsoleThemeStyle.Text, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Green,
                    }
                },
                {
                    ConsoleThemeStyle.String, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Yellow,
                    }
                },
                {
                    ConsoleThemeStyle.Name, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Black,
                        Background = ConsoleColor.Yellow,
                    }
                }

            };

        return new SystemConsoleTheme(customThemeStyles);
    }
}
