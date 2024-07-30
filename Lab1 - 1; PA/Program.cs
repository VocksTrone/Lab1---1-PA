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
    //Función para Actualizar Precios
    public void UpdatePrice(double newprice)
    {
        Price = newprice;
        Console.WriteLine($"El Producto {Name}, Ahora tiene un Precio de: {newprice}");
    }
    //Función para Mostrar el Contenido
    public void ShowContent()
    {
        Console.WriteLine($"Producto: {Name}, Precio: {Price}, Cantidad: {Quantity}");
    }
}

//Clase de Tienda en línea 
public class OnlineStore
{
   //Lista para Almacenar Productos 
    public List<Product> productList = new List<Product>();
    //Método para Añadir un Nuevo Producto y Revisar su Existencia
    public void AddProduct(string name, double price, int quantity)
    {
        Console.WriteLine("Ingrese el Nombre del Producto");
        Product nameProduct = productList.Find(p => p.Name == name);
        if (nameProduct == null)
        {
            Console.WriteLine("Ingrese el Precio del Producto");
            double priceProduct = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Stock del Producto");
            int quantityProduct = int.Parse(Console.ReadLine());
            Product newProduct = new Product(name, price, quantity);
            productList.Add(newProduct);
        }
        else
        {
            Console.WriteLine("Este Producto Ya Existe");
        }
    }
    //Método para Consultar Productos usando la Función .Find
    public Product ConsultProduct(string name)
    {
        return productList.Find(p => p.Name == name);
    }
    //Método para Mostrar los Productos Almacenados
    public void ShowInventory()
    {
        Console.WriteLine("El Inventario de Productos es:");
        foreach (Product product in productList)
        {
            product.ShowContent();
        }
    }
    
}