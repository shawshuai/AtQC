using System;
using System.Collections.Generic;

namespace AtQC.Core.Models
{
    // TODO WTS: Remove this class once your pages/features are using your data.
    // This is used by the SampleDataService.
    // It is the model class we use to display data on pages like Grid, Chart, and Master Detail.
    public class NewsController
    {
        public ICollection<NewsDetail> Newses { get; set; }

        public string Publisher { get; set; }

        public DateTime PublishTime { get; set; }


    }
}
