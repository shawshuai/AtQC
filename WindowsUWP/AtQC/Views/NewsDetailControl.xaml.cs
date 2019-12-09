using System;

using AtQC.Core.Models;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace AtQC.Views
{
    public sealed partial class NewsDetailControl : UserControl
    {
        //public News

        public NewsDetail MasterMenuItem
        {
            get { return GetValue(MasterMenuItemProperty) as NewsDetail; }
            set { SetValue(MasterMenuItemProperty, value); }
        }

        public static readonly DependencyProperty MasterMenuItemProperty = DependencyProperty.Register("MasterMenuItem", typeof(NewsDetail), typeof(NewsDetailControl), new PropertyMetadata(null, OnMasterMenuItemPropertyChanged));

        public NewsDetailControl()
        {
            InitializeComponent();
        }

        private static void OnMasterMenuItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as NewsDetailControl;
            control.ForegroundElement.ChangeView(0, 0, 1);
        }
    }
}
