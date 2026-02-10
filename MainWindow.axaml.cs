using Avalonia.Controls;
using AvaloniaToaster;
using AvaloniaToasterDevProject.Views;
using Microsoft.Extensions.DependencyInjection;

namespace AvaloniaToasterDevProject;

public partial class MainWindow : Window
{
    private ToastNotificationService _toastNotificationService;
    public MainWindow()
    {
        InitializeComponent();
        _toastNotificationService = Program.Services.GetRequiredService<ToastNotificationService>();
        var toastContainer = this.FindControl<Panel>("ToastContainer");
        _toastNotificationService.RegisterMainWindow(toastContainer);
        InjectExampleView();
    }

    public void InjectExampleView() => this.FindControl<ContentControl>("MainContent").Content = new ExampleView();
}