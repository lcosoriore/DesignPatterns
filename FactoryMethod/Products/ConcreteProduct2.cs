using FactoryMethod.Interfaces;
namespace FactoryMethod.Products
{
    public class ConcreteProduct2 : Iproduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct2}";
        }
    }
}
