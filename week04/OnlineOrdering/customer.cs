public class Customer
{
    private string _customerName;
    private Address _customerAddress;

    public Customer(string customerName, Address customerAddress)
    {
        this._customerName = customerName;
        this._customerAddress = customerAddress;
    }

    public string GetName() => _customerName;
    public Address GetAddress() => _customerAddress;

    public bool LivesInUSA()
    {
        return _customerAddress.IsInUSA();
    }
}
