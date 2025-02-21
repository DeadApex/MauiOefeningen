namespace MauiOefeningen.Views;

public partial class AfbeeldingenPage : ContentPage
{
	public AfbeeldingenPage(AfbeeldingenViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}