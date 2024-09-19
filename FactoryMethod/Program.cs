using FactoryMethod;

Creator creator = new ConcreteCreatorA();
creator.SomeOperation();

creator = new ConcreteCreatorB();
creator.SomeOperation();


int? a = 2;
int? b = null;

Console.WriteLine(a);

Console.ReadLine();
