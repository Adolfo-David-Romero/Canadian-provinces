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
            new Province("Ontario", "Toronto", "ontario.jpg"),
            new Province("Alberta", "Edmonton", "alberta.jpg"),
            new Province("British Columbia", "Victoria", "manitoba.jpg"),
            new Province("Manitoba", "Winnipeg", "british_columbia.jpg"),
            new Province("New Brunswick", "Fredericton", "new_brunswick.jpg"),
            new Province("Newfoundland and Labrador", "St.John's", "newfoundland_and_labrador.jpg"),
            new Province("Nova Scotia", "Halifax", "nova_scotia.jpg"),
            new Province("Prince Edward Island", "Charlottetown", "prince_edward_island.jpg"),
            new Province("Québec", "Québec", "Quebec.jpg"),
            new Province("Saskatchewan", "Regina", "saskatchewan.jpg")
        });
    }

    //returns list of provinces
    public List<Province> GetProvinces()
    {
        return provinces;
    }
}