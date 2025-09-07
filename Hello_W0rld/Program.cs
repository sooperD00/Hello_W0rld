using Figgle;
using Figgle.Fonts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloW0rldApp;

class AsciiConsole
{
    static void Main()
    {
        // Initial greeting and instructions
        Console.WriteLine("Welcome to Hello_W0rld ASCII Console.");
        Console.WriteLine(FiggleFonts.Standard.Render("Hello_W0rld!"));
        Console.WriteLine("Type something (or press Enter to quit).");
        Console.WriteLine("Commands: list | set <font> | random <text>");

        // Dictionary of fonts with their names
        var fonts = new Dictionary<string, FiggleFont>(StringComparer.OrdinalIgnoreCase)
        {
            { "standard", FiggleFonts.Standard },
            { "slant", FiggleFonts.Slant },
            { "ghost", FiggleFonts.Ghost },
            { "banner", FiggleFonts.Banner },
            { "doom", FiggleFonts.Doom }
        };

        // Random number generator for random font selection
        var rng = new Random();
        var currentFont = fonts["standard"];

        while (true)
        {
            // Prompt for input
            Console.Write("\n> ");
            string? input = Console.ReadLine();

            // Exit on empty input
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            // Split input into command and arguments
            var parts = input.Split(' ', 2, StringSplitOptions.RemoveEmptyEntries);
            var command = parts[0];

            // Handle commands
            if (command.Equals("list", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Available fonts:");
                foreach (var f in fonts.Keys)
                    Console.WriteLine($" - {f}");
                continue;
            }
            else if (command.Equals("set", StringComparison.OrdinalIgnoreCase))
            {
                if (parts.Length < 2)
                {
                    Console.WriteLine("Usage: set <font>");
                    continue;
                }
                var fontName = parts[1];
                if (fonts.TryGetValue(fontName, out var chosenFont))
                {
                    currentFont = chosenFont;
                    Console.WriteLine($"Font changed to: {fontName}");
                }
                else
                {
                    Console.WriteLine($"Unknown font: {fontName}");
                }
                continue;
            }
            else if (command.Equals("random", StringComparison.OrdinalIgnoreCase))
            {
                if (parts.Length < 2)
                {
                    Console.WriteLine("Usage: random <text>");
                    continue;
                }
                var text = parts[1];
                var fontPair = fonts.ElementAt(rng.Next(fonts.Count));
                Console.WriteLine(fontPair.Value.Render(text));
                Console.WriteLine($"(above: {fontPair.Key} font)");
                continue;
            }

            // Default: render input using current font
            Console.WriteLine(currentFont.Render(input));
        }
    }
}
