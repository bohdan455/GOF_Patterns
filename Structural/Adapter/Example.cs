public interface ICustomerService
{
    Task SaveUser();
}

public interface IClientService
{
    Task SaveClient();
}

// Adapter class
public class CustomerClientAdapter : IClientService
{
    private readonly ICustomerService _customerService;

    public CustomerClientAdapter(ICustomerService customerService)
    {
        _customerService = customerService;
    }

    public Task SaveClient()
    {
        // Adapter translates SaveClient to SaveUser
        return _customerService.SaveUser();
    }
}