namespace DefaultNamespace;

abstract class Transaction
{
    // Some logic
}

class PayPalTransaction : Transaction
{
    // Some logic
}

class CreditCardTransaction : Transaction
{
    // Some logic
}
abstract class Account
{
    // Some logic
}

class CreditCardAccount : Account
{
    // Some logic
}

class PayPalAccount : Account
{
    // Some logic
}

abstract class L2L3Data
{
    // Some logic
}

class CreditCardL2L3Data : L2L3Data
{
    // Some logic
}

class PayPalL2L3Data : L2L3Data
{
    // Some logic
}

interface IPaymentFactory
{
    Transaction GetTransaction();
    Account GetAccount();
    L2L3Data GetL2L3Data();
}

class PayPalFactory : IPaymentFactory
{
    public Transaction GetTransaction() => new PayPalTransaction();
    public Account GetAccount() => new PayPalAccount();
    public L2L3Data GetL2L3Data() => new PayPalL2L3Data();
}

class CreditCardFactory : IPaymentFactory
{
    public Transaction GetTransaction() => new CreditCardTransaction();
    public Account GetAccount() => new CreditCardAccount();
    public L2L3Data GetL2L3Data() => new CreditCardL2L3Data();
}

class PaymentSystemProccessor
{
    private readonly IPaymentFactory _paymentFactory;
    
    public PaymentSystemProccessor(IPaymentFactory paymentFactory)
    {
        _paymentFactory = paymentFactory;
    }

    public void Process()
    {
        // Some logic
        var transaction = _paymentFactory.GetTransaction();
        // Some logic
        var account = _paymentFactory.GetAccount();
        // Some logic
        var l2l3Data = _paymentFactory.GetL2L3Data();
        // Some logic
    }
}