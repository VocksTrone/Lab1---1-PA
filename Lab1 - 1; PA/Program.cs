public class Product
{
    //Clase para almacenar productos
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    public Product(string name, double price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }
    public void Sell(int quantity)
    {
        if (Quantity >= quantity)
        {
            Quantity -= quantity;
            Console.WriteLine($"Se vendieron {quantity} productos {Name}.");
            Console.WriteLine($"Aún hay {Quantity} Productos con este Nombre");
        }
    }
}