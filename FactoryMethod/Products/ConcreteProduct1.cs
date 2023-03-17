using FactoryMethod.Interfaces;
namespace FactoryMethod.Products
{
    public class ConcreteProduct1 : Iproduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct1}";
        }
    }
}
