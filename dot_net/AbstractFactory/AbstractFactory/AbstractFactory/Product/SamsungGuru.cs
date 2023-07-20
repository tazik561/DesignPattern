namespace AbstractFactory.Product;

public class SamsungGuru : INormalPhone
{
    public string GetModelDetails()
    {
        return "Model: Samsung Guru\nRam:NA\nCamera: NA\n";
    }
}