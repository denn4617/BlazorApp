namespace EstaldoApp.Models;
// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class Adresse
{
    private string _etage;
    private string _dør;
    private string _husnr;

    public string id { get; set; }
    public int status { get; set; }
    public int darstatus { get; set; }
    public string vejkode { get; set; }
    public string vejnavn { get; set; }
    public string adresseringsvejnavn { get; set; }
    public string husnr 
    {
        get
        {
            return " " + _husnr + ", ";
        }
        set
        {
            _husnr = value;
        }
    }

    public string etage
    {
        get
        {
            if (_etage == null)
            {
                return "";
            }

            return " " + _etage;
        }
        set
        {
            _etage = value;
        }
    }

    public string dør 
    {
        get
        {
            if (_dør == null)
            {
                return "";
            }

            return " " + _dør + ", ";
        }
        set
        {
            _dør = value;
        }
    }
    public string supplerendebynavn { get; set; }
    public string postnr { get; set; }
    public string postnrnavn { get; set; }
    public object stormodtagerpostnr { get; set; }
    public object stormodtagerpostnrnavn { get; set; }
    public string kommunekode { get; set; }
    public string adgangsadresseid { get; set; }
    public double x { get; set; }
    public double y { get; set; }
    public string href { get; set; }

    // public override string ToString()
    // {
    //     return vejnavn + husnr + etage + dør + postnr + postnrnavn;
    // }
}

public class JsonRootObject
{
    public Adresse adresse { get; set; }
    public string tekst { get; set; }
}

public class SortedJsonRootObject
{
    
}