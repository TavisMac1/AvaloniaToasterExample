using Avalonia.Layout;
using Avalonia.Media;
using AvaloniaToaster.Interfaces;
using AvaloniaToasterTestProject.Themes;

namespace AvaloniaToasterDevProject.Themes;

public class ErrorTheme : IAvaloniaToasterThemes
{
    public IBrush BackgroundColor => Avalonia.Media.Brushes.Red;

    public IBrush ForegroundColor => Avalonia.Media.Brushes.White;

    public HorizontalAlignment? HorizontalAlignment => Avalonia.Layout.HorizontalAlignment.Right;

    public VerticalAlignment? VerticalAlignment => Avalonia.Layout.VerticalAlignment.Bottom;

    public double? BorderRadius => null;
}
