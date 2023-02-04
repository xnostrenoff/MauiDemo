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
        #region Commands

        [RelayCommand]
        public async Task GotToGestures ()
        {
            await Shell.Current.GoToAsync (nameof(GesturesPage));
        }

        [RelayCommand]
        public async Task GotToMediaTakePicture()
        {
            await Shell.Current.GoToAsync(nameof(MediaTakePicturePage));
        }

        #endregion Commands
    }
}
