When we need to create similar objects with a common parent class but with different logic inside them, we can use the Abstract Factory pattern.

An Abstract Factory class is responsible only for creating objects and doesn't contain any logic itself.
It also implements a factory interface, so we can have multiple factories where each returns a similar base-type object but with different implementations.

When we need to use this factory, we can simply use the factory interface, and the user of our logic would decide which factory to provide.

Typical use case is when we need to do some work on one group of object but don't want to depend on their realization

For example, we create a payment processor, and every processor has its own Transaction, Account, and L2L3Data.

The difference between the Factory Method and Abstract Factory is that the Factory Method creates a single type of object, while the Abstract Factory is responsible for creating a family of related objects that are meant to be used together.
