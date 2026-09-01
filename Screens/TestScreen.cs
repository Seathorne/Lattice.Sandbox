using Lattice.Drawing;
using Lattice.Elements;
using Lattice.Screens;

namespace Lattice.Sandbox.Screens;

public sealed class TestScreen : Screen
{
    [FillWidth]
    [FixedHeight(3)]
    [Border(BorderWeight.Heavy, BorderStyle.Dense)]
    private ButtonElement _hello = null!;

    [FillWidth]
    [FixedHeight(3)]
    [Border(BorderMode.Simple)]
    private ButtonElement _world = null!;

    [FillWidth]
    [FixedHeight(3)]
    [Border(BorderWeight.Light, BorderStyle.Solid)]
    private TextElement _status = null!;

    [Border(BorderWeight.Light, BorderStyle.Sparse)]
    private GridElement _root = null!;

    private GridElement _buttons = null!;

    protected override Element Build()
    {
        _hello = new ButtonElement { Label = "Hello" };
        _world = new ButtonElement { Label = "World" };
        _status = new TextElement { Text = "ready" };

        _hello.OnActivate = () => _status.Text = "hello pressed.";
        _world.OnActivate = () => _status.Text = "world pressed.";

        _root = GridElement.Column(2);
        _buttons = GridElement.Row(2);
        _buttons.Border = Border.Double;

        _buttons.AddChild(_hello);
        _buttons.AddChild(_world);

        _root.AddChild(_buttons);
        _root.AddChild(_status);

        return _root;
    }
}