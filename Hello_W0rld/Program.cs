using Figgle;
using Figgle.Fonts;
using System;

namespace HelloW0rldApp;

class AsciiConsole
{
    static void Main()
    {
        // Initial greeting and instructions
        Console.WriteLine("Welcome to Hello_W0rld ASCII Console.");
        Console.WriteLine(FiggleFonts.Standard.Render("Hello_W0rld!"));
        Console.WriteLine("Type something (or press Enter to quit):");

        while (true)
        {
            Console.Write("\n> ");
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            // Render with multiple fonts
            Console.WriteLine(FiggleFonts.Standard.Render(input));
        }
    }
}
