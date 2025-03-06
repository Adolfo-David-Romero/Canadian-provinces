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
        
        ProvincesCollectionView.ItemsSource = provincesList; // Set the items source directly on the CollectionView
    }

    private void OnDisplayBtnClicked(object sender, EventArgs e)
    {
        // Toggle the visibility of the CollectionView
        ProvincesCollectionView.IsVisible = !ProvincesCollectionView.IsVisible;

        if (sender is Button button)
        {
            button.Text = ProvincesCollectionView.IsVisible ? "Hide Provinces" : "Display Provinces";
        }
    }

    /*private void productsListView_ItemSelected(object sender, EventArgs e)
    {
        
    }*/

    
}