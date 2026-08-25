using Lattice.Elements;
using Lattice.Screens;

namespace Lattice.Sandbox.Screens;

public sealed class TestScreen : Screen
{
    [FillWidth]
    private ButtonElement _hello = null!;

    [FillWidth]
    private ButtonElement _world = null!;

    [FillWidth]
    private TextElement _status = null!;

    protected override Element Build()
    {
        _hello = new ButtonElement { Label = "Hello" };
        _world = new ButtonElement { Label = "World" };
        _status = new TextElement { Text = "ready" };

        _hello.OnActivate = () => _status.Text = "hello pressed.";
        _world.OnActivate = () => _status.Text = "world pressed.";

        GridElement root = GridElement.Column(2);
        GridElement buttons = GridElement.Row(2);

        buttons.AddChild(_hello);
        buttons.AddChild(_world);

        root.AddChild(buttons);
        root.AddChild(_status);

        return root;
    }
}