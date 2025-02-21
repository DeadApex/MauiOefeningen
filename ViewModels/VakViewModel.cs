using CommunityToolkit.Mvvm.Input;

namespace MauiOefeningen.ViewModels;

public partial class VakViewModel : ObservableObject
{
	[ObservableProperty]
	string voornaam, naam, locatie, lokaalnr, uitvoer;

	[ObservableProperty]
	DateTime datum;

	[ObservableProperty]
	int score;

	[ObservableProperty]
	bool vast = false;

	public VakViewModel()
	{
		Voornaam = string.Empty;
		Naam = string.Empty;
		Locatie = string.Empty;
		Lokaalnr = string.Empty;
		Uitvoer	= string.Empty;
		Datum = DateTime.Now;
	}

	[RelayCommand]
	public void UitvoerTonen()
	{
		string lokaal;
        if (vast)
        {
			lokaal = "vast lokaal";
        }
        else
        {
			lokaal = "lokaal";
        }
        Uitvoer += $"Welkom {Voornaam} {Naam}\n" +
				   $"Je {lokaal} is {Lokaalnr} in {Locatie}\n" +
				   $"Je eerste les is op {Datum.ToShortDateString()}\n" +
				   $"Je hoopt {score}/20 te scoren\n";
	}
}