public class Order {
    public int Number { get; set; }
    public DateTime OrderDate { get; set; }
    public int CustomerNo { get; set; }
    public string Status { get; set; }

    public Contact FindCustomerWithCustomerNo(int customerNo)
    {
        Contact newContact = new Contact()
        {
            Number = customerNo,
            PhoneNumber = "9876543210"
        };
        return newContact;
    }
}