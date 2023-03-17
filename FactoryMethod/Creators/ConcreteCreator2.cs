using FactoryMethod.Interfaces;
using FactoryMethod.Products;
namespace FactoryMethod.Creators
{
    public class ConcreteCreator2 : Creator
    {
        public override Iproduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
