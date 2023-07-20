namespace AbstractFactory.Product;

public class SamsungGalaxy : ISmartPhone
{
    public string GetModelDetails()
    {
        return "Model: SamSung Galaxy\nRam:28GB\nCamera: 13MP\n";
    }
}