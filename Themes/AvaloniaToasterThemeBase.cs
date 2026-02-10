using Avalonia.Layout;
using Avalonia.Media;

namespace AvaloniaToasterTestProject.Themes;

/// <summary>
/// Inherit this class to create a theme
/// </summary>
public class AvaloniaToasterThemeBase
{
    public virtual IBrush BackgroundColor => Avalonia.Media.Brushes.Black;

    public virtual IBrush ForegroundColor => Avalonia.Media.Brushes.White;

    public virtual HorizontalAlignment? HorizontalAlignment => null;

    public virtual VerticalAlignment? VerticalAlignment => null;

    public virtual double? BorderRadius => null;
}
