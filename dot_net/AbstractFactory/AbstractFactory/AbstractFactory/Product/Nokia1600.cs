namespace AbstractFactory.Product;

public class Nokia1600 : INormalPhone
{
    public string GetModelDetails()
    {
        return "Model: Nokia 1600\nRam:NA\nCamera: NA\n";
    }
}