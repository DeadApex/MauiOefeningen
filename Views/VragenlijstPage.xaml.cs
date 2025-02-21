namespace MauiOefeningen.Views;

public partial class VragenlijstPage : ContentPage
{
	public VragenlijstPage(VragenlijstViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}