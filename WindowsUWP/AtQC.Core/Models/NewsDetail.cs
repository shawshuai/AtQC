using System;
using System.Collections.Generic;

namespace AtQC.Core.Models
{
    // TODO WTS: Remove this class once your pages/features are using your data.
    // This is used by the SampleDataService.
    // It is the model class we use to display data on pages like Grid, Chart, and Master Detail.
    public class NewsDetail
    {
        public long OrderID { get; set; }

        public char Symbol => (char)SymbolCode;

        public int SymbolCode { get; set; }

        public long NewsID { get; set; }

        public Uri HeadImageLink { get; set; }

        public string NewsTitle { get; set; }

        public string NewsSource { get; set; }

        public DateTime PublishTime { get; set; }

        public string Author { get; set; }

        public string Editor { get; set; }

        public Uri SourceLink { get; set; }

        public Uri NewsBody { get; set; }

    }
}
