using Lattice.Elements;
using Lattice.Screens;

namespace Lattice.Sandbox.Screens;

public sealed class TestScreen : Screen
{
    [AdaptiveWidth]
    private ButtonElement _hello = null!;

    [FillWidth]
    private ButtonElement _world = null!;

    protected override Element Build()
    {
        _hello = new ButtonElement { Label = "Hello" };
        _world = new ButtonElement { Label = "World" };

        GridElement root = GridElement.Row(2);
        root.AddChild(_hello);
        root.AddChild(_world);

        return root;
    }
}