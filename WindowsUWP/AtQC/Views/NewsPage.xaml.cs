using System;

using AtQC.ViewModels;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace AtQC.Views
{
    public sealed partial class NewsPage : Page
    {
        public NewsViewModel ViewModel { get; } = new NewsViewModel();

        public NewsPage()
        {
            InitializeComponent();
            Loaded += NewsPage_Loaded;
        }

        private async void NewsPage_Loaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.LoadDataAsync(MasterDetailsViewControl.ViewState);
        }
    }
}
