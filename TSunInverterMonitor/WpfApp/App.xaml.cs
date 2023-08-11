using System;
using System.Runtime.CompilerServices;
using System.Windows;

namespace WpfApp
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
    internal static void HandleException(Exception ex, [CallerMemberName] string sender = "")
    {
      MessageBox.Show(ex.ToString(), $"Ausnahme in {sender}", MessageBoxButton.OK, MessageBoxImage.Error);
    }
  }
}