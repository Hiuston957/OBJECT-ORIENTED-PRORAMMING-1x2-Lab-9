/*
  * here are two built-in configurations in Visual Studio: Debug and Release
We use Debug when we build and test the program – it is here where you can use
breakpoints. This configuration is in general slower. The other configuration, Release, is
used to build the final version of the program, the one to be published. In this case, the
program is better optimized and runs faster. In this configuration, we should run the
program with Ctrl+F5.

In both configurations, pressing Ctrl+Shift+B builds the program (solution) without running
it – you can use it if you only want to create program files on the disk. To find these files,
right-click on a given project tab in Visual Studio an choose “Open Containing Folder”.
Then go to bin → Debug or Release → net[x] (x – .net version number).
Another useful tools are the preprocessor directives. They are special lines of code which
start with # (for example: #define, #if) and are preprocessed first, even before the actual
compilation of the rest of the code begins. The preprocessor directives can help in
conditional compilation. Also, some run only in a given configuration, Debug or Release.
In this example, we test the preprocessor directives, as well as the Debug and Release
configurations.
Links:
• https://www.c-sharpcorner.com/blogs/importance-of-debug-and-release-in-net
• https://www.tutorialspoint.com/csharp/csharp_preprocessor_directives.htm
• https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/preprocessordirectives
*/

#define MYFLAG // defines MYFLAG
using System;
namespace Ex_09_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // DEBUG is auto defined when the program is in the Debug configuration
#if DEBUG
            Console.WriteLine("This prints only in the Debug configuration.");
            Console.WriteLine("You don't need { } for multilines here.");
#endif
            Console.WriteLine("This prints always.");
            // You can create your own symbols with #define (example at line 1)
#if (MYFLAG && DEBUG)
            Console.WriteLine("This prints in Debug, if MYFLAG is defined.");
#elif (MYFLAG && !DEBUG)
 Console.WriteLine("This prints in Release, if MYFLAG is defined.");
#else
 Console.WriteLine("This prints if MYFLAG is not defined.");
#endif
            // You can target specific .NET version(s)
#if NET6_0_OR_GREATER
            Console.WriteLine("This prints for .NET 6+ programs");
#endif
            // You can nest #ifs
#if DEBUG
#if MYFLAG
#if NETCOREAPP
            Console.WriteLine("This prints for .NET Core / .NET 5+ programs, " +
            "with DEBUG and MYFLAG.");
#endif
#endif
#endif
            // This pragma hides the warnings, such us the ones about unreachable code
#pragma warning disable
            if (false)
                Console.WriteLine("This never prints");
#pragma warning restore
            #region testing
            // You can collapse a region to make the code look shorter
            // The code runs as normal even if collapsed
            // Name ("testing") is optional
            Console.WriteLine("Thanks for watching, please subscribe :-)");
            #endregion
        }
    }
}
