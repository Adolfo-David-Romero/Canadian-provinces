using A2Adolfo.Model;

namespace A2Adolfo.ViewModel;

public class ProvinceViewModel
{
    List<Province> provinces = new List<Province>(); //Create empty Province list

    public ProvinceViewModel()
    {
        //populate list
        provinces.AddRange(new []
        {
            new Province("Ontario", "Toronto", "ontario.png"),
            new Province("Alberta", "Edmonton", "alberta.png"),
            new Province("British Columbia", "Victoria", "manitoba.png"),
            new Province("Manitoba", "Winnipeg", "british_columbia.png"),
            new Province("New Brunswick", "Fredericton", "new_brunswick.png"),
            new Province("Newfoundland and Labrador", "St.John's", "newfoundland_and_labrador.png"),
            new Province("Nova Scotia", "Halifax", "nova_scotia.png"),
            new Province("Prince Edward Island", "Charlottetown", "prince_edward_island.png"),
            new Province("Québec", "Québec", "Quebec.png"),
            new Province("Saskatchewan", "Regina", "saskatchewan.png")
        });
    }

    //returns list of provinces
    public List<Province> GetProvinces()
    {
        return provinces;
    }
}