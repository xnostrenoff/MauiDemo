using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiDemoApp
{
    public partial class MediaTakePicturePageViewModel : ObservableObject
    {
        #region Variables

        [ObservableProperty]
        ImageSource photo;

        #endregion Variables

        #region Commands

        [RelayCommand]
        async Task GoToBack()
        {
            await Shell.Current.GoToAsync("..");
        }

        [RelayCommand]
        async Task TakePhoto ()
        {
            if (MediaPicker.Default.IsCaptureSupported)
            {
                FileResult fileResult = await MediaPicker.Default.CapturePhotoAsync();

                if (fileResult != null)
                {
                    var stream = await fileResult.OpenReadAsync();
                    Photo = ImageSource.FromStream(() => stream);                        
                }
            }
        }

        #endregion Commands
    }
}
