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

    public List<Province> Provinces { get; set; }

    public MainPage()
    {
        InitializeComponent();

        // Load data from ViewModel
        Provinces = viewModel.GetProvinces();

        // Bind ListView to data
        provincesListView.ItemsSource = Provinces;
    }

    private void OnDisplayBtnClicked(object sender, EventArgs e)
    {
        // Toggle visibility of ListView
        provincesListView.IsVisible = !provincesListView.IsVisible;

        if (sender is Button button)
        {
            button.Text = provincesListView.IsVisible ? "Hide Provinces" : "Display Provinces";
        }
    }

    private async void OnProvinceSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem is Province selectedProvince)
        {
            // Navigate to ProvinceDetailPage
            await Navigation.PushAsync(new ProvincePage(selectedProvince));

            // Clear selection
            provincesListView.SelectedItem = null;
        }
    }
}