using System.Text.Json;
using ProductosCS;

string pathProductos = @"C:\Users\julian\Documents\taller1\tp11repaso\tl1-tp11-repaso-2026-julianbustospondal/productos1.json";
string pathGuardar = @"C:\Users\julian\Documents\taller1\tp11repaso\tl1-tp11-repaso-2026-julianbustospondal/Reporte.json";

if (!File.Exists(pathProductos))
{
    Console.WriteLine("El archivo de productos no existe.");
}
else
{
    string jsonProductos = File.ReadAllText(pathProductos);
    List<Productos> listaProductos = JsonSerializer.Deserialize<List<Productos>>(jsonProductos)!;

    List<ProductoReporte> reporte = new List<ProductoReporte>();

    foreach (Productos producto in listaProductos)
    {
        double valorTotalCalculado = producto.Stock * producto.Precio;
        bool necesitaRepoCalculado = producto.Stock < 3;


        ProductoReporte nuevoItem = new ProductoReporte(
            producto.Nombre,
            valorTotalCalculado,
            necesitaRepoCalculado
        );

        reporte.Add(nuevoItem);
    }

    var opcionesJson = new JsonSerializerOptions
    {
        WriteIndented = true,
        Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
    };

    string jsonFinal = JsonSerializer.Serialize(reporte, opcionesJson);
    File.WriteAllText(pathGuardar, jsonFinal, new System.Text.UTF8Encoding(true));

    Console.WriteLine("Reporte generado con éxito usando una clase dedicada.");
}
