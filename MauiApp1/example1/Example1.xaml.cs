using System.Collections.ObjectModel;
using MauiApp1.example1.model;

namespace MauiApp1.example1;

public partial class Example1 : ContentPage
{
    public Example1()
    {
        InitializeComponent();
        BindingContext = this;
        
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        LoadLights();
    }
    
    private async void LoadLights()
    {
        var lights = new List<Light>(await LightRepository.GetLightsAsync() ?? []); 
        //Update UI ListView
        ListLights.ItemsSource = lights;
    }
    
    
    private async void listLights_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        		
    }

    private void listLights_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        
    }
    
    private void btnTurnAllFront_Clicked(object sender, EventArgs e)
    {
        foreach (var light in ListLights.ItemsSource)
        {
            var l = (Light)light;
            _ = LightRepository.UpdateLightAsync(l.Id, !l.Value);
        }
        
        DisplayAlert("Info", "Turn all front", "OK");

        //ListLights.ItemsSource = Lights;
        LoadLights();
    }
}