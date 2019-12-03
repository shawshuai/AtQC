using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

using AtQC.Core.Models;
using AtQC.Core.Services;
using AtQC.Helpers;

using Microsoft.Toolkit.Uwp.UI.Controls;

namespace AtQC.ViewModels
{
    public class NewsViewModel : Observable
    {
        private SampleOrder _selected;

        //private News _selected;  //shawshuai

        public SampleOrder Selected
        {
            get { return _selected; }
            set { Set(ref _selected, value); }
        }

        public ObservableCollection<SampleOrder> SampleItems { get; private set; } = new ObservableCollection<SampleOrder>();

        public NewsViewModel()
        {
        }

        public async Task LoadDataAsync(MasterDetailsViewState viewState)
        {
            SampleItems.Clear();

            var data = await DataService.GetMasterDetailDataAsync();

            foreach (var item in data)
            {
                SampleItems.Add(item);
            }

            if (viewState == MasterDetailsViewState.Both)
            {
                Selected = SampleItems.First();
            }
        }
    }
}
