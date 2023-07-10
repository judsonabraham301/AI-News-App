using AINewsApp.View;

namespace AINewsApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(AINewsDetailPage), typeof(AINewsDetailPage));
    }
}
