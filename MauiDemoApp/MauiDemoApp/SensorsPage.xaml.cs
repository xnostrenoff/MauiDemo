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

    private void ContentPage_Disappearing(object sender, EventArgs e)
    {
        _viewmodel.CaptureMovements = false;
    }

    private void ContentPage_Appearing(object sender, EventArgs e)
    {
        _viewmodel.CaptureMovements = true;
    }
}