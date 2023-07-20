// See https://aka.ms/new-console-template for more information

using AbstractFactory;
using AbstractFactory.ConcreteFactory;

IMobilePhone nokiaMobilePhone = new Nokia();
var nokiaClient = new MobileClient(nokiaMobilePhone);

Console.WriteLine("****************** NOKIA ****************");
Console.WriteLine(nokiaClient.getNormalPhoneDetailes());
Console.WriteLine(nokiaClient.getSmartPhoneDetailes());


IMobilePhone samsungMobilePhone = new Samsung();
var samsungClient = new MobileClient(samsungMobilePhone);
Console.WriteLine("****************** SAMSUNG ****************");
Console.WriteLine(samsungClient.getNormalPhoneDetailes());
Console.WriteLine(samsungClient.getSmartPhoneDetailes());

Console.ReadKey();