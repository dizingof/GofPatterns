namespace FactoryMethod
{
    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public void SomeOperation()
        {
            var product = FactoryMethod();
            product.Operation();
        }
    }
}
