using System.Globalization;
using Microsoft.FSharp.Collections;

Console.WriteLine("Hello, World!");

CultureInfo.CurrentCulture = new CultureInfo("de");
CultureInfo.CurrentUICulture= new CultureInfo("de");

try
{
    // Throws a localized ArgumentException
    SeqModule.Head(SeqModule.Empty<int>());
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Handled: {ex.Message}");
}

Console.WriteLine("Wait a bit and press any key");

Console.Read();