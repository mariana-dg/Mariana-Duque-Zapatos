// See https://aka.ms/new-console-template for more information

var zapato = new Zapatos();
Zapatos zapato1 = new Zapatos();
Zapatos zapato2 = zapato1;

zapato.Id = 1;
zapato.Nombre = "Adidas";
zapato.Disponible = true;
zapato.precio = 50.000m;

zapato.Marcas = new List<Marcas>();
zapato.Marcas.Add(new Marcas(){Id = 1, Nombre = "Nike"});

Console.WriteLine(zapato.Nombre);
Console.WriteLine(zapato.precio);


public class Tipos
{
    public int Id = 0;
    public string nombre = " ";
}
public class Marcas 
{
    public int Id = 0;
    public String Nombre = " ";
}
public class Inventario
{
    public int Id = 0;
}
public class Zapatos 
{
    public int Id = 0;
    public string Nombre = " ";
    public bool Disponible = false;
    public decimal precio = 0.0m;
    public List<Marcas> Marcas = new List<Marcas> ();

}