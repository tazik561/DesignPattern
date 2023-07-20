namespace AbstractFactory.Product;

public class NokiaPixel : ISmartPhone
{
    public string GetModelDetails()
    {
        return "Model: Nokia Pixel\nRam:3GB\nCamera: 8MP\n";
    }
}