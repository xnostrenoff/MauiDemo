using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
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

        #endregion Properties

        #region Commands

        [RelayCommand]
        public async Task GotToPage(string parameter)
        {
            await Shell.Current.GoToAsync(parameter);
        }

        #endregion Commands
    }
}
