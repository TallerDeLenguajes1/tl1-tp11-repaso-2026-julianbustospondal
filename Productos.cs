namespace ProductosCS;

public class Productos
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public double Precio { get; set; }
    public int Stock { get; set; }
    public string? Categoria { get; set; }

    public Productos(int id, string nombre, double precio, int stock, string categoria)
    {
        Id = id;
        Nombre = nombre;
        Precio = precio;
        Stock = stock;
        Categoria = categoria;

    }

}
public class ProductoReporte
{
    public string? Nombre { get; set; }
    public double ValorTotalStock { get; set; }
    public bool NecesitaRepo { get; set; }

    // Constructor para inicializar fácilmente los valores
    public ProductoReporte(string? nombre, double valorTotalStock, bool necesitaRepo)
    {
        Nombre = nombre;
        ValorTotalStock = valorTotalStock;
        NecesitaRepo = necesitaRepo;
    }
}