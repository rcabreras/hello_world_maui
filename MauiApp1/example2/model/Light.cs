using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp1.example2.model
{
    public class Light: ObservableObject
    {
        public int Id { get; set; }
        private bool _value;
        
        public bool Value
        {
            get => _value;
            set => SetProperty(ref _value, value);
        }
        public string? Type { get; set; }
    }
}
