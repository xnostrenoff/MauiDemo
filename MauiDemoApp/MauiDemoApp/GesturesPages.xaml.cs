namespace MauiDemoApp;

public partial class GesturesPage : ContentPage
{
    readonly GesturesPageViewModel _viewmodel;

	public GesturesPage(GesturesPageViewModel vm)
	{
		InitializeComponent();
        _viewmodel = vm;
		BindingContext = vm;
	}

    private void subSwipHandler(object sender, SwipedEventArgs e)
    {
        var direction = Enum.GetName(typeof(SwipeDirection), e.Direction);
        _viewmodel.LogText = $"{direction} swiped";
    }

    private void subPanGetureMoveHandler(object sender, PanUpdatedEventArgs e)
    {
        var bindableObj = sender as BindableObject;
        if (bindableObj is null)
            return;

        var bounds = AbsoluteLayout.GetLayoutBounds(bindableObj);
        bounds.X += e.TotalX;
        bounds.Y += e.TotalY;
        AbsoluteLayout.SetLayoutBounds(bindableObj, bounds);
    }
}