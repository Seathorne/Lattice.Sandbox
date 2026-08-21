using System.Diagnostics;
using Lattice.Text;

namespace Lattice.Sandbox;

public class Program
{
    public static void Main(string[] args)
    {
        Trace.Listeners.Add(new TextWriterTraceListener("lattice-trace.log"));
        Trace.AutoFlush = true;
        
        new Lattice.Terminal().RunDiagnostics([ProbeRanges.MahjongTiles]);
    }
}