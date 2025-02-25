using System.Collections.ObjectModel;
using A2Adolfo.Model;

namespace A2Adolfo;

/*
 Adolfo David Romero
 99155778
*/
public partial class MainPage : ContentPage
{
    List<Province> provinces = new List<Province>(); //Create empty Province list
    public ObservableCollection<Province> Provinces { get; set; }
    
    public MainPage()
    {
        InitializeComponent();
        
    }

    private void OnDisplayBtnClicked(object sender, EventArgs e)
    {
        
        /*Province ontario = new Province("Ontario", "Toronto", "ontario.jpg");
        Province alberta = new Province("Alberta", "Edmonton", "alberta.jpg");
        Province britishColumbia = new Province("British Columbia", "Victoria", "manitoba.jpg");
        Province manitoba = new Province("Manitoba", "Winnipeg", "british_columbia.jpg");
        Province newBrunswick = new Province("New brunswick", "Fredericton", "new_brunswick.jpg");
        Province newfoundlandAndLabrador = new Province("Newfoundland and Labrador", "St.John's", "newfoundland_and_labrador.jpg");
        Province novaScotia = new Province("Newfoundland and Labrador", "Halifax", "nova_scotia.jpg");
        Province princeEdwardIsland = new Province("Prince Edward Island", "Charlottetown", "prince_edward_island.jpg");
        Province quebec = new Province("Québec", "Québec", "Quebec.jpg");
        Province saskatchewan = new Province("Saskatchewan", "Regina", "saskatchewan.jpg");*/
        
        
        
        
        
    }

    
}