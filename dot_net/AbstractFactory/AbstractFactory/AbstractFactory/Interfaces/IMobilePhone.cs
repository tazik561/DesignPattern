namespace AbstractFactory;

// Abstract Factory 
public interface IMobilePhone
{
    ISmartPhone GetSmartPhone();
    INormalPhone GetNormalPhone();
}