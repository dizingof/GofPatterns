namespace FactoryMethod
{
    public class ConcreteProductA : IProduct
    {
        public void Operation()
        {
            Console.WriteLine("Product A is created.");
        }
    }
}
