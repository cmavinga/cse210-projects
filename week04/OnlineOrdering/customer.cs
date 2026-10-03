public class Customer
{
    private string customerName;
    private Address customerAddress;

    public Customer(string customerName, Address customerAddress)
    {
        this.customerName = customerName;
        this.customerAddress = customerAddress;
    }

    public string GetName() => customerName;
    public Address GetAddress() => customerAddress;

    public bool LivesInUSA()
    {
        return customerAddress.IsInUSA();
    }
}
