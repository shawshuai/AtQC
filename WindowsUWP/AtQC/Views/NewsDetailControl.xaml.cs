using System;

using AtQC.Core.Models;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace AtQC.Views
{
    public sealed partial class NewsDetailControl : UserControl
    {
        //public News

        public SampleOrder MasterMenuItem
        {
            get { return GetValue(MasterMenuItemProperty) as SampleOrder; }
            set { SetValue(MasterMenuItemProperty, value); }
        }

        public static readonly DependencyProperty MasterMenuItemProperty = DependencyProperty.Register("MasterMenuItem", typeof(SampleOrder), typeof(NewsDetailControl), new PropertyMetadata(null, OnMasterMenuItemPropertyChanged));

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
