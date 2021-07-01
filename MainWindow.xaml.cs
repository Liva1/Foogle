using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CefSharp;

namespace foogle
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GoButton_Click(object sender, RoutedEventArgs e)
        {
            Browser.Load(AddressBar.Text);
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            Browser.Reload(true);
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            Browser.Load("https://duckduckgo.com/%22");
            AddressBar.Text = "Enter URL";
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (Browser.WebBrowser.CanGoBack)
            {
                Browser.WebBrowser.Back();
            }
        }
    }
}
