using CommunityToolkit.Mvvm.Input;

namespace MauiOefeningen.ViewModels;

public partial class NaamTonenViewModel : ObservableObject
{
	[ObservableProperty]
	string naam, uitvoer;

	[ObservableProperty]
	int getal;

	public NaamTonenViewModel()
	{
		Naam = string.Empty;
		Uitvoer = string.Empty;
	}

	[RelayCommand]
	public void UitvoerTonen()
	{
		Uitvoer += "Resultaat:";
        for (int i = 0; i < getal; i++)
        {
            if (i == getal - 1)
            {
				Uitvoer += $" {Naam}";
            }
			else
			{
                Uitvoer += $" {Naam},";
            }
        }
    }

	[RelayCommand]
	public void UitvoerLeegmaken()
	{
		Uitvoer = string.Empty;
	}
}