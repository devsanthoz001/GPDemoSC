public class ContactTests
{
    [Fact]
    public void CheckIfAllPropertiesAreEnteredExistsTest()
    {
        // Arrange
        Contact contactJKD = new Contact();
        // Act
        contactJKD.Name = "JKD";
        contactJKD.UPINumber = "1000";
        contactJKD.PhoneNumber = "123 456 7890";
        contactJKD.Address = "1234 Street Lane";
        // Assert
        Assert.Equal("JKD", contactJKD.Name);
        Assert.Equal("1000", contactJKD.UPINumber);
        Assert.Equal("123 456 7890", contactJKD.PhoneNumber);
        Assert.Equal("1234 Street Lane", contactJKD.Address);
    }

    [Fact]
    public void CheckIfContactHasPhoneNumberWhileOrderingTest()
    {
        //Arrange
        Order newOrder = new Order();
        //Act
        newOrder.Number = 1;
        newOrder.OrderDate = new DateTime(2023, 08, 28);
        newOrder.CustomerNo = 1;

        Contact contact = new Contact()
        {
            Number = 1,
            Name = "JKD",
            PhoneNumber = "1234",
            Address = "Somwhere in MH",
            UPINumber = "1234"
        };
        //Assert
        Assert.NotNull(contact);
        Assert.NotNull(contact.PhoneNumber);
    }

    [Fact]
    public void EnsurePhoneNumberEnteredIsValidForOrderTest()
    {
        // Given

        // When

        // Then
    }
    [Fact]
    public void CallCustomerWithContactNumberAfterOrderIsPreparedTest()
    {
        //Arrange
        Order newCustOrder = new Order() { };
        Contact customerContact = newCustOrder.FindCustomerWithCustomerNo(newCustOrder.CustomerNo);
        //Act
        bool resultOfCall =customerContact.CallContactWithNumber(customerContact.PhoneNumber);
        //Assert
        Assert.True(resultOfCall);
    }
    

}