using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiDemoApp
{
    public partial class GesturesPageViewModel : ObservableObject
    {
        #region Properties

        /// <summary>
        /// Define 
        /// </summary>
        [ObservableProperty]
        string logText;

        #endregion 

        #region Commands

        [RelayCommand]
        async Task GoToBack()
        {
            await Shell.Current.GoToAsync("..");
        }

        #endregion Commands

    }
}
