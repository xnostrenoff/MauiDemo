using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiDemoApp
{
    public partial class MainPageViewModel : ObservableObject
    {
        #region Properties

        public string GesturesPageName
            => nameof(GesturesPage);

        public string TakePicturePageName
            => nameof(MediaTakePicturePage);

        public string SensorPageName
            => nameof(SensorsPage);

        public IEnumerable<string> Pages
            => _pages;
        internal readonly ObservableCollection<string> _pages;

        #endregion Properties

        #region CTor

        public MainPageViewModel ()
        {
            _pages = new ObservableCollection<string>
            {
                nameof(GesturesPage),
                nameof(MediaTakePicturePage),
                nameof(SensorsPage)
            };
        }

        #endregion CTor

        #region Commands

        [RelayCommand]
        public async Task GotToPage(string parameter)
        {
            await Shell.Current.GoToAsync(parameter);
        }

        #endregion Commands
    }
}
