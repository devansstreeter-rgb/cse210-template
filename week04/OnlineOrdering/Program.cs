using System;

class Program
{
    static void Main(string[] args)
    {
        Address hildaAddress = new Address("3533 S Orchid Lane", "Stowe", "Vermont", "USA");
        Customer hilda = new Customer("Hilda Green", hildaAddress);
        Product sardines = new Product("Big G Sardines, 8oz", "A04343243-G", 2.99, 2);
        Product wholeMilk = new Product("Whole Milk (1gal)", "A98432777-V", 3.49, 1);
        Product floss = new Product("Dr.Thread Dental Floss", "A454968406-J", 1.99, 1);
        List<Product>hildaCart = [sardines, wholeMilk, floss];
        Order hildaOrder = new Order(hilda, hildaCart);

        Address almaAddress = new Address ("Calle Clavos 407", "Hermosillo", "Sonora", "Mexico");
        Customer alma = new Customer("Alma Anaya", almaAddress);
        Product cheese = new Product("Wisconsin Cheddar, 10lb", "A453454354-C", 18.99, 1);
        Product rootBeer = new Product("V&V Root Beer 2L", "A725754530-P", 1.99, 4);
        Product redCups = new Product("Red Plastic Party Cups", "A675358693-I", 7.99, 2);
        List<Product>almaCart = [cheese, rootBeer, redCups];
        Order almaOrder = new Order(alma, almaCart);

        Console.WriteLine(hildaOrder.GetPackingLabel());
        Console.WriteLine(hildaOrder.GetShippingLabel());
        Console.WriteLine($"${hildaOrder.GetTotal()}\n");

        Console.WriteLine(almaOrder.GetPackingLabel());
        Console.WriteLine(almaOrder.GetShippingLabel());
        Console.WriteLine($"${almaOrder.GetTotal()}\n");
    }
}