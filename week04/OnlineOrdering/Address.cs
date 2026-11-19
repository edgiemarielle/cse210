public class Address
{
    private string _street = "";
    private string _city = "";
    private string _state = "";
    private string _country = "";

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    public bool IsInUSA()
    {
        string country = _country.Trim();
        return country.Equals("USA", StringComparison.OrdinalIgnoreCase)
            || country.Equals("United States", StringComparison.OrdinalIgnoreCase);
    }
    public string GetAddressLabel()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}