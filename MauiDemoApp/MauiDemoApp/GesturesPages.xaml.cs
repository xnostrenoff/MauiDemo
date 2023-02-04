namespace MauiDemoApp;

public partial class GesturesPage : ContentPage
{
	public GesturesPage(GesturesPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}