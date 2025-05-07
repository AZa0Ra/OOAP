using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeAsync();
        }

        private async void InitializeAsync()
        {
            await webView.EnsureCoreWebView2Async(null);
        }

        private async void Search_Click(object sender, RoutedEventArgs e)
        {
            string query = Uri.EscapeDataString(SearchBox.Text);
            string url = $"https://rozetka.com.ua/ua/search/?text={query}";
            webView.NavigateToString("<html><body>Завантаження...</body></html>");
            webView.CoreWebView2.Navigate(url);

            webView.CoreWebView2.NavigationCompleted += async (s, args) =>
            {
                try
                {
                    await Task.Delay(3000);

                    string script = @"
        (function() {
            let tiles = document.querySelectorAll('rz-product-tile');
            let results = [];

            tiles.forEach(tile => {
                let titleElement = tile.querySelector('.tile-title');
                let priceElement = tile.querySelector('.price.color-red');

                if (titleElement && priceElement) {
                    let title = titleElement.textContent.trim();
                    let price = priceElement.textContent.trim().replace(/\s+/g, ' ');
                    results.push(`${title}|||${price}`);
                }
            });

            return results.join(';');
        })();";

                    string result = await webView.CoreWebView2.ExecuteScriptAsync(script);
                    result = Regex.Unescape(result).Trim('"');

                    var items = result.Split(';', StringSplitOptions.RemoveEmptyEntries);

                    // Fork
                    var tasks = items.Select(item => Task.Run(() =>
                    {
                        var parts = item.Split("|||");
                        if (parts.Length == 2)
                            return $"{parts[0]} - {parts[1]}";
                        else
                            return "Невідомий товар";
                    })).ToArray();

                    // Join
                    var processedItems = await Task.WhenAll(tasks);

                    PriceListBox.ItemsSource = processedItems;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка: {ex.Message}");
                }
            };
        }
    }
}