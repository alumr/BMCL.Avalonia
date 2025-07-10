using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace BMCL.Avalonia.Views.Windows;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        this.PointerPressed += (sender, e) =>
        {
            if (e.GetCurrentPoint(this).Properties.IsLeftButtonPressed)
            {
                BeginMoveDrag(e);
            }
        };
    }

    private void Close_OnClick(object? sender, RoutedEventArgs e)
    {
        Close();
    }

    private void Maximize_OnClick(object? sender, RoutedEventArgs e)
    {
        if (WindowState == WindowState.Normal)
        {
            WindowState = WindowState.Maximized;

            MaximizeIcon.Path = "/Assets/Images/max-max.svg";
        }
        else
        {
            WindowState = WindowState.Normal;
            
            MaximizeIcon.Path = "/Assets/Images/max-min.svg";
        }
    }

    private void Minimize_OnClick(object? sender, RoutedEventArgs e)
    {
        WindowState = WindowState.Minimized;
    }
}