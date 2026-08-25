using System.Diagnostics;
using Lattice.Sandbox.Screens;

namespace Lattice.Sandbox;

public class Program
{
    private static TestScreen _mainScreen = null!;

    public static void Main()
    {
        Trace.Listeners.Add(new TextWriterTraceListener("lattice-trace.log"));
        Trace.AutoFlush = true;

        _mainScreen = new TestScreen();

        new Terminal().Run(_mainScreen);
    }
}