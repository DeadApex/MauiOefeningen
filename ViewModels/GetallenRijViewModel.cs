using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiOefeningen.ViewModels;

public partial class GetallenRijViewModel : ObservableObject
{
	[ObservableProperty]
	int getal, kleinsteGetal, grootsteGetal;

	[ObservableProperty]
	ObservableCollection<int> getallen;

	public GetallenRijViewModel()
	{
		Getal = 0;
		Getallen = [];
	}

	[RelayCommand]
	private async void GetalToevoegen()
	{
        if (Getal > 20)
        {
			await Shell.Current.DisplayAlert("Fout", "Je getal mag niet groter zijn dan 20", "Ok");
        }
        else
        {
            Getallen.Add(Getal);
            Getal = 0;
        }

		KleinsteGetal = Getallen.Min();
		GrootsteGetal = Getallen.Max();
	}
}