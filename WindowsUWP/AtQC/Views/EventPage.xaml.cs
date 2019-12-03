using System;

using AtQC.ViewModels;

using Windows.UI.Xaml.Controls;

namespace AtQC.Views
{
    public sealed partial class EventPage : Page
    {
        public EventViewModel ViewModel { get; } = new EventViewModel();

        public EventPage()
        {
            InitializeComponent();
        }
    }
}
