namespace MauiOefeningen.Views;

public partial class GetallenRijPage : ContentPage
{
	public GetallenRijPage(GetallenRijViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}