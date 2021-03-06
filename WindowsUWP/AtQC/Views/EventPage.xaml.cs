﻿using System;

using AtQC.ViewModels;

using Windows.UI.Xaml.Controls;
using Microsoft.Services.Store.Engagement;

namespace AtQC.Views
{
    public sealed partial class EventPage : Page
    {
        public EventViewModel ViewModel { get; } = new EventViewModel();

        public EventPage()
        {
            InitializeComponent();

            StoreServicesCustomEventLogger logger = StoreServicesCustomEventLogger.GetDefault();
            logger.Log("eventPageLoaded");
        }
    }
}
