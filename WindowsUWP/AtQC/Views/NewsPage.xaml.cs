using System;

using AtQC.ViewModels;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Microsoft.Services.Store.Engagement;

namespace AtQC.Views
{
    public sealed partial class NewsPage : Page
    {
        public NewsViewModel ViewModel { get; } = new NewsViewModel();

        public NewsPage()
        {
            InitializeComponent();
            Loaded += NewsPage_Loaded;

            StoreServicesCustomEventLogger logger = StoreServicesCustomEventLogger.GetDefault();
            logger.Log("newsPageLoaded");
        }

        private async void NewsPage_Loaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.LoadDataAsync(MasterDetailsViewControl.ViewState);
        }
    }
}
