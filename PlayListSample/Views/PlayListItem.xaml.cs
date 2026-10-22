

namespace PlayListSample.Views;

[QueryProperty(nameof(RecieveId),"message")]
public partial class PlayListItem : ContentPage
{
	private string receiveId;
	public string RecieveId { get=>receiveId; set
		{
			receiveId = value; OnPropertyChanged();
		} }
	public PlayListItem()
	{
		InitializeComponent();
		BindingContext = this;
	}
}