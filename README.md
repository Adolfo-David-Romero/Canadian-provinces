📌 **.NET MAUI Province List App**
----------------------------------

This small-scale .NET MAUI project demonstrates key foundational concepts in **mobile app development with C#**, including:

-   **ListView for data presentation**
-   **Data binding with a ViewModel**
-   **Navigation between pages**
-   **Event handling in .NET MAUI**
-   **Working with images in MAUI applications**

* * * * *

🚀 **Overview**
---------------

The app displays a list of **Canadian provinces**, each represented by:

-   A **name**
-   A **capital city**
-   A **province flag (image)**

Users can **toggle the list visibility** using a button and **tap a province** to navigate to a **detailed view**.

* * * * *

🔑 **Key Concepts in .NET MAUI & C#**
-------------------------------------

### 1️⃣ **ListView for Displaying Data**

We use `ListView` to present **province data** in a structured list format.

```
<ListView ItemsSource="{Binding Provinces}">
    <ListView.ItemTemplate>
        <DataTemplate>
            <ImageCell ImageSource="{Binding ProvinceFlag}"
                       Text="{Binding ProvinceName}"
                       Detail="{Binding ProvinceCapital}"/>
        </DataTemplate>
    </ListView.ItemTemplate>
</ListView>
```

**Core Concept:** The `ListView` control in .NET MAUI provides a **built-in UI for structured data** and supports easy data binding.

* * * * *

### 2️⃣ **Data Binding with a ViewModel**

Instead of hardcoding data in the UI, we use a **ViewModel (`ProvinceViewModel`)** to provide a **list of provinces** dynamically.

```
public class ProvinceViewModel
{
    List<Province> provinces = new List<Province>();

    public ProvinceViewModel()
    {
        provinces.AddRange(new []
        {
            new Province("Ontario", "Toronto", "ontario.png"),
            new Province("Alberta", "Edmonton", "alberta.png"),
            new Province("Québec", "Québec", "quebec.png")
        });
    }

    public List<Province> GetProvinces()
    {
        return provinces;
    }
}
```

**Core Concept:** This follows the **MVVM (Model-View-ViewModel) pattern**, which **separates UI logic from data** for maintainability.

* * * * *

### 3️⃣ **Navigation Between Views**

Tapping a province **navigates to a detailed view**.


```
private async void OnProvinceSelected(object sender, SelectedItemChangedEventArgs e)
{
    if (e.SelectedItem is Province selectedProvince)
    {
        await Navigation.PushAsync(new ProvinceDetailPage(selectedProvince));
        provincesListView.SelectedItem = null; // Clear selection
    }
}
```

**Core Concept:** .NET MAUI uses `Navigation.PushAsync()` for **seamless page transitions**.

* * * * *

### 4️⃣ **Working with Images in .NET MAUI**

-   **Images are stored in `Resources/Images`** (for local assets).
-   **They are referenced directly** in the UI via `Source="{Binding ProvinceFlag}"`.

* * * * *

🎯 **How to Run**
-----------------

1.  Clone the repository:


    ```git clone https://github.com/your-repo/ProvinceListApp.git```

2.  Open the project in **Visual Studio**.
3.  Run the project on an **Android/iOS emulator** or a **physical device**.

* * * * *

📌 **Future Improvements**
--------------------------

-   🔹 **Use `CollectionView` instead of `ListView`** for better performance.
-   🔹 **Fetch data from an API** instead of a static list.
-   🔹 **Implement full MVVM architecture** (move logic out of `MainPage.xaml.cs`).

* * * * *

📜 **Conclusion**
-----------------

This exercise covers **foundational concepts** in .NET MAUI + C#, including: ✅ **ListView for displaying structured data**\
✅ **Data binding with a ViewModel**\
✅ **Navigation between pages**\
✅ **Event handling in a mobile UI**\
✅ **Working with images in MAUI**

This serves as a strong **starting point for building more complex MAUI applications**! 🚀

* * * * *

Let me know if you'd like to tweak this further! 😊
