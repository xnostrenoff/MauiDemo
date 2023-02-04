namespace MauiDemoApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute (nameof(GesturesPage), typeof(GesturesPage));
		Routing.RegisterRoute(nameof(MediaTakePicturePage), typeof(MediaTakePicturePage));
	}
}
