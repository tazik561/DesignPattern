using AbstractFactory.Product;

namespace AbstractFactory.ConcreteFactory;

//ConcreteFactory
public class Nokia: IMobilePhone
{
    public ISmartPhone GetSmartPhone()
    {
        return new NokiaPixel();
    }

    public INormalPhone GetNormalPhone()
    {
        return new Nokia1600();
    }
}