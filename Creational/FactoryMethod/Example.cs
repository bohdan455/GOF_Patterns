namespace DefaultNamespace;

public abstract class BaseTransactionProcessor
{
    protected abstract Transaction GetTransaction();

    public void Proceess()
    {
        // Some logic
        var transaction = GetTransaction();
        // Some logic
    }
}

class abstract Transaction
{
    // some logic
}

class CreditCardTransaction : Transaction
{
// some logic
}

class PayPalTransaction : Transaction
{
// some logic
}

class CreditCardTransactionProcessor() : BaseTransactionProcessor
{
    protected override Transaction GetTransaction() => new CreditCardTransaction();
}

class PayPalTransactionProcessor() : BaseTransactionProcessor
{
    protected override Transaction GetTransaction() => new PayPalTransaction();
}