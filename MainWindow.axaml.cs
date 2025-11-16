using Avalonia.Controls;
using AvaloniaToaster;
using AvaloniaToasterTestProject.Views;
using Microsoft.Extensions.DependencyInjection;

namespace AvaloniaToasterTestProject;

public partial class MainWindow : Window
{
    private ToastNotificationService _toastNotificationService;
    public MainWindow()
    {
        InitializeComponent();
        _toastNotificationService = Program.Services.GetRequiredService<ToastNotificationService>();
        _toastNotificationService.RegisterMainWindow(this);
        InjectExampleView();
    }

    public void InjectExampleView() => this.FindControl<ContentControl>("MainContent").Content = new ExampleView();
}