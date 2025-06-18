using System.Collections.ObjectModel;

namespace AppApuntes;

public partial class MainPage : ContentPage
{
    ObservableCollection<string> notas = new ObservableCollection<string>();

    public MainPage()
    {
        InitializeComponent();
        ListaNotas.ItemsSource = notas;
    }

    private void AgregarNota_Clicked(object sender, EventArgs e)
    {
        
    }

    private void EliminarNota_Clicked(object sender, EventArgs e)
    {
        
    }
}
