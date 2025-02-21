using System.Xml.Serialization;
using CommunityToolkit.Mvvm.Input;

namespace MauiOefeningen.ViewModels;

public partial class VragenlijstViewModel : ObservableObject
{
    [ObservableProperty]
    string naam, keuzeEten, keuzeDrinken, uitvoer;

    [ObservableProperty]
    int dagenSport, score;

    [ObservableProperty]
    bool zichtbaar;

    [ObservableProperty]
    List<string> keuzeMenu = new List<string> { "Ja", "Nee" };

    public VragenlijstViewModel()
    {
        Starten();
    }

    [RelayCommand]
    private async void Starten()
    {
        Naam = string.Empty;
        KeuzeEten = string.Empty;
        KeuzeDrinken = string.Empty;
        Uitvoer = string.Empty;
        DagenSport = 0;
        Score = 0;
        Zichtbaar = false;
        do
        {
            Naam = await Shell.Current.DisplayPromptAsync("Naam ingeven", "Geef je naam in:", "Doorgaan");
            if (Naam == string.Empty)
            {
                await Shell.Current.DisplayAlert("Fout", "Je moet verplicht een naam ingeven", "Ok");
            }
        }
        while (Naam == string.Empty);
        Zichtbaar = true;
    }

    [RelayCommand]
    public void UitvoerTonen()
    {
        if (KeuzeEten == string.Empty || KeuzeEten == string.Empty)
        {
            Shell.Current.DisplayAlert("Fout", "Maak een keuze bij alle vragen", "ok");
            return;
        }

        switch (KeuzeEten) 
        {
            case "Ja":
                Uitvoer += "Je eet voldoende, ";
                Score++;
                break;
            case "Nee":
                Uitvoer += "Je eet onvoldoende, ";
                break;
        }

        switch (KeuzeDrinken)
        {
            case "Ja":
                Uitvoer += "je drinkt voldoende, ";
                Score++;
                break;
            case "Nee":
                Uitvoer += "je drinkt onvoldoende, ";
                break;
        }

        switch (DagenSport)
        {
            case 0:
            case 1:
            case 2:
                Uitvoer += "en je sport onvoldoende.\n";
                break;
            case 3:
            case 4:
            case 5:
            case 6:
            case 7:
                Uitvoer += "en je sport voldoende.\n";
                Score++;
                break;
        }

        if (Score == 3)
        {
            Uitvoer += $"Je bent in topvorm, {Naam}. Doe zo verder kanjer!\n";
        }
        else
        {
            Uitvoer += $"Voldoende eten, drinken en sporten is belangrijk, {Naam}\n";
        }

    }
}