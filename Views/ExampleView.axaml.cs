using Avalonia.Controls;
using AvaloniaToaster;
using AvaloniaToasterTestProject.Themes;
using Microsoft.Extensions.DependencyInjection;

namespace AvaloniaToasterTestProject.Views;

public partial class ExampleView : UserControl
{
    private ToastNotificationService _toastNotificationService;
    private SuccessTheme _successTheme;
    private ErrorTheme _errorTheme;

    public ExampleView()
    {
        InitializeComponent();
        _toastNotificationService = Program.Services.GetRequiredService<ToastNotificationService>();
        _successTheme = new();
        _errorTheme = new();
    }

    private void ShowToastGeneric(object? sender, Avalonia.Interactivity.RoutedEventArgs e) => _toastNotificationService.Show("Generic Toast");
    private void ShowToastSuccess(object? sender, Avalonia.Interactivity.RoutedEventArgs e) => _toastNotificationService.Show("Success Toast", 3000, _successTheme);
    private void ShowToastError(object? sender, Avalonia.Interactivity.RoutedEventArgs e) => _toastNotificationService.Show("Error Toast", 3000, _errorTheme);
}
