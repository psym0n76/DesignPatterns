namespace Command
{
    public class AddCustomerCommand : ICommand
    {
        private readonly CustomerService _customer;

        public AddCustomerCommand(CustomerService customer)
        {
            _customer = customer;
        }

        public void Execute()
        {
            _customer.AddCustomer();
        }
    }
}