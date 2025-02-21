namespace MauiOefeningen.Views;

public partial class NaamTonenPage : ContentPage
{
	public NaamTonenPage(NaamTonenViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}