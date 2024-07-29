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
    //Función para Vender Productos
    public void Sell(int quantity)
    {
        if (Quantity >= quantity)
        {
            Quantity -= quantity;
            Console.WriteLine($"Se vendieron {quantity} productos {Name}.");
            Console.WriteLine($"Aún hay {Quantity} Productos con este Nombre");
        }
        else
        {
            Console.WriteLine("No Existe Suficiente Cantidad para Vender");
        }
    }
    //Función para Restock
    public void Restock(int quantity)
    {
        Quantity += quantity;
        Console.WriteLine($"Se Filleo el Stock de {Name} con {quantity} Productos");
        Console.WriteLine($"El Stock Final quedó con {Quantity}");
    }
}