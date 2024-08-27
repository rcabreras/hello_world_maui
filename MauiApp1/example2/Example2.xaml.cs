using System.Collections.ObjectModel;
using MauiApp1.example2.model;

namespace MauiApp1.example2;

public partial class Example2 : ContentPage
{
    public Example2()
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
        var lights = new ObservableCollection<Light>(await LightRepository.GetLightsAsync() ?? []); 
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
    }
}