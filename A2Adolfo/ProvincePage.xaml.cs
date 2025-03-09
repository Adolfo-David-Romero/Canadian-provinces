using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A2Adolfo.Model;

namespace A2Adolfo;

/*
 Adolfo David Romero
 99155778
*/

public partial class ProvincePage : ContentPage
{
    public ProvincePage(Province province)
    {
        InitializeComponent();
        
        ProvinceFlagImage.Source = province.ProvinceFlag;
        ProvinceNameLabel.Text = province.ProvinceName;
        ProvinceCapitalLabel.Text = $"Capital: {province.ProvinceCapital}";
    }
}