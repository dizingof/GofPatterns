using FactoryMethod;

Creator creator = new ConcreteCreatorA();
creator.SomeOperation();

creator = new ConcreteCreatorB();
creator.SomeOperation();

Console.ReadLine();
