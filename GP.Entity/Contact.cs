public class Contact
{
    public int Number {get; set;}
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public string UPINumber { get; set; }

    
    public bool CallContactWithNumber(string phoneNumber)
    {
        if (phoneNumber == "1234")
        {
            return true;
        }
        return false;
    }
}