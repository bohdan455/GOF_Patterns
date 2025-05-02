The Factory Method pattern defines an interface (or abstract class) for creating an object, but allows subclasses to decide which class to instantiate

The Factory Method pattern suggests that you replace direct object construction calls (using the new operator) with calls to a special factory method.

It is useful when we have similar logic but need to use different classes (of the same type) for different use cases within that logic.
These classes must inherit the same interface (or base class), and the abstract method should return this interface.

For example, we have a BaseTransactionProcessor, and it needs to process different types of transactions like credit card, PayPal, etc.
We can create an abstract TransactionProcessor class that has a Process method containing the common logic, and a GetTransaction method that returns a Transaction type value.

Then we can create CreditCardTransaction and PayPalTransaction classes, both inheriting from the Transaction class.
We also create CreditCardTransactionProcessor and PayPalTransactionProcessor classes, which implement BaseTransactionProcessor.
In these classes, the GetTransaction method would return their specific type of transaction.