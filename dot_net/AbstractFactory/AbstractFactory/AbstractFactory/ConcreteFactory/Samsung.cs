using AbstractFactory.Product;

namespace AbstractFactory.ConcreteFactory;

public class Samsung : IMobilePhone
{
    public ISmartPhone GetSmartPhone()
    {
        return new SamsungGalaxy();
    }

    public INormalPhone GetNormalPhone()
    {
        return new SamsungGuru();
    }
}