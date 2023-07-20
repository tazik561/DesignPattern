namespace AbstractFactory;

public class MobileClient
{
    public MobileClient(IMobilePhone factory)
    {
        _smartPhone = factory.GetSmartPhone();
        _normalPhone = factory.GetNormalPhone();
    }

    private ISmartPhone _smartPhone;
    private INormalPhone _normalPhone;



    public string getSmartPhoneDetailes()
    {
        return _smartPhone.GetModelDetails();
    }
    
    public string getNormalPhoneDetailes()
    {
        return _normalPhone.GetModelDetails();
    }
}