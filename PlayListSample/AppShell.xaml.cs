using PlayListSample.Views;

namespace PlayListSample;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		RoutingPages();
	}
	private void RoutingPages()
	{
		Routing.RegisterRoute("MyPlayist", typeof(PlayListItem));
	}
}