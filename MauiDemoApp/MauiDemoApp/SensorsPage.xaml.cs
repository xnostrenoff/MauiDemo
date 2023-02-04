namespace MauiDemoApp;

public partial class SensorsPage : ContentPage
{
    #region Variables

    private readonly SensorsPageViewModel _viewmodel;

    #endregion Variables

    public SensorsPage(SensorsPageViewModel vm)
	{
		InitializeComponent();
        _viewmodel = vm;
        BindingContext = vm;
	}
}