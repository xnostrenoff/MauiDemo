namespace MauiDemoApp;

public partial class MediaTakePicturePage : ContentPage
{
    #region Variables

    readonly MediaTakePicturePageViewModel _viewmodel;

    #endregion Variables

    #region Ctor

    public MediaTakePicturePage(MediaTakePicturePageViewModel vm)
	{
		InitializeComponent();
        _viewmodel = vm;
        BindingContext = vm;
	}

    #endregion Ctor
}