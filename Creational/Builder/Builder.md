The Builder pattern is great for creating an object step by step by calling its methods, instead of constructing it using a large constructor.

We create a separate Builder class that is responsible for assembling the object.
Different builders can be used if we need to create different types of objects.

Additionally, we can have a separate class called something like a Director, which is responsible for creating the object using the Builder class and calling the methods in the correct order.