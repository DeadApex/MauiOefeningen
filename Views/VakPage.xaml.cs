namespace MauiOefeningen.Views;

public partial class VakPage : ContentPage
{
	public VakPage(VakViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
    }

    private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {

    }
}