using System.Collections.ObjectModel;
using A2Adolfo.Model;
using A2Adolfo.ViewModel;

namespace A2Adolfo;

/*
 Adolfo David Romero
 99155778
*/
public partial class MainPage : ContentPage
{
    private ProvinceViewModel viewModel = new ProvinceViewModel();
    List<Province> provinces = new List<Province>(); //Create empty Province list
    ObservableCollection<Province> provincesList;
    
    public MainPage()
    {
        InitializeComponent();
        provinces = viewModel.GetProvinces();
        provincesList = new ObservableCollection<Province>(provinces);
    }

    private void OnDisplayBtnClicked(object sender, EventArgs e)
    {
        provincesListView.ItemsSource = provincesList;
    }

    private void productsListView_ItemSelected(object sender, EventArgs e)
    {
        
    }

    
}