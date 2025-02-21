using CommunityToolkit.Mvvm.Input;

namespace MauiOefeningen.ViewModels;

public partial class AfbeeldingenViewModel : ObservableObject
{
	[ObservableProperty]
	string afbeelding;

	[ObservableProperty]
	int keuze;

	public AfbeeldingenViewModel()
	{
		Keuze = 1;
		Afbeelding = $"landschap{Keuze}.jpg";
	}

	[RelayCommand]
	public void UitvoerTonen()
	{
		Afbeelding = $"landschap{Keuze}.jpg";
	}
}