using System;
using Sana07;

try
{
    Product[] product = new Product[3];
    ShoppingCart shoppingCart = new ShoppingCart();
    product[0] = new Smartphone("Samsung", 58000, 50, 6.8, 12, 512, 5000);
    product[1] = new Computer("ARTLINE", 28000, 10, 600, 16, 12, 480);
    product[2] = new _Monitor("Acer", 5600, 32, 180, 23.8, "IPS", "Black");
    shoppingCart.AddToShoppingCart(product[0]);
    shoppingCart.AddToShoppingCart(product[1]);
    shoppingCart.AddToShoppingCart(product[2]);
    Console.WriteLine(shoppingCart.ShowCart());
    Console.WriteLine(shoppingCart.GetPrice());
}
catch(MyExceptions ex)
{
    Console.WriteLine($"{ex.Message} in field {ex.Field} in class {ex.Class}");
}
catch (Exception)
{
    throw new Exception("other exception");
}