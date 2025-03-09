namespace A2Adolfo.Model;

/*
 Adolfo David Romero
 99155778
*/
public class Province
{
    //Fields
    private string _provinceName;
    private string _provinceCapital;
    private string _provinceFlag;
    
    //Constructor
    public Province(string provinceName, string provinceCapital, string provinceFlag)
    {
        this._provinceName = provinceName;
        this._provinceCapital = provinceCapital;
        this._provinceFlag = provinceFlag;
    }
    
    //Properties
    public string ProvinceName
    {
        get { return _provinceName; }
        set { _provinceName = value; }
    }

    public string ProvinceCapital
    {
        get { return _provinceCapital; }
        set { _provinceCapital = value; }
    }

    public string ProvinceFlag
    {
        get { return _provinceFlag; }
        set { _provinceFlag = value; }
    }
    
   
    
}