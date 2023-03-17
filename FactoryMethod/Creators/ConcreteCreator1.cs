using FactoryMethod.Interfaces;
using FactoryMethod.Products;
namespace FactoryMethod.Creators
{
    public class ConcreteCreator1: Creator
    {
        public override Iproduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }
}
