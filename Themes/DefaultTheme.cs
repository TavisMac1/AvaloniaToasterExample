using Avalonia.Layout;
using Avalonia.Media;
namespace AvaloniaToasterTestProject.Themes;
internal class DefaultTheme : AvaloniaToasterThemeBase
{
    public override IBrush BackgroundColor => Avalonia.Media.Brushes.Black;

    public override IBrush ForegroundColor => Avalonia.Media.Brushes.White;

    public override HorizontalAlignment? HorizontalAlignment => Avalonia.Layout.HorizontalAlignment.Right;

    public override VerticalAlignment? VerticalAlignment => Avalonia.Layout.VerticalAlignment.Bottom;

    public override double? BorderRadius => null;
}
