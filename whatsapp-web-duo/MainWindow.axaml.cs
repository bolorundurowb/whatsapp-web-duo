using Avalonia.Controls;
using WebViewControl;

namespace whatsapp_web_duo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TabSelectionChanged(object? sender, SelectionChangedEventArgs e)
        {
            var selectedIndex = (sender as TabControl)?.SelectedIndex;

            var webview = new WebView();
        }
    }
}