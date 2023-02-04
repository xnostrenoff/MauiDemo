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
        public async Task GotToGesturesPage ()
        {
            await Shell.Current.GoToAsync (nameof(GesturesPage));
        }

        #endregion Commands
    }
}
