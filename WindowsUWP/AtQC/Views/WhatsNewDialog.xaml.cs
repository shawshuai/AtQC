using System;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Microsoft.Services.Store.Engagement;

namespace AtQC.Views
{
    public sealed partial class WhatsNewDialog : ContentDialog
    {
        public WhatsNewDialog()
        {
            // TODO WTS: Update the contents of this dialog every time you release a new version of the app
            RequestedTheme = (Window.Current.Content as FrameworkElement).RequestedTheme;
            InitializeComponent();

            StoreServicesCustomEventLogger logger = StoreServicesCustomEventLogger.GetDefault();
            logger.Log("whatsNewDialogDisplayed");
        }
    }
}
