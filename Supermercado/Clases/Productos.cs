using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Supermercado.Clases;
class Productos{
    private int id;
    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    private string nombre;
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    public int stock { get; set; }
    public int stockMin { get; set; }
    public int stockMax { get; set; }
     public double precioVenta { get; set; }
     public double precioCompra { get; set; }
     public Productos (int id, string nombre, int stock, int stockMin, int stockMax, int precioVenta, int precioCompra){
        this.id = id;
        this.nombre = nombre;
        this.stock=stock;
        this.stockMin=stockMin;
        this.stockMax=stockMax;
        this.precioVenta=precioVenta;
        this.precioCompra=precioCompra;
     }
     public Productos(){
        if(!File.Exists(Env.FileName)){
            File.WriteAllText(Env.FileName, "");
        }
     }
     public Productos() { }

     public Productos RegistrarProductos(){
        Productos productos = new Productos();
        System.Console.WriteLine("Ingrese el id del producto");
        productos.Id=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Ingrese el nombre del producto");
        productos.Nombre=Console.ReadLine();
        System.Console.WriteLine("Ingrese el stock del producto");
        productos.stock=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Ingrese el stock minimo del producto");
        productos.stockMin=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Ingrese el stock maximo del producto");
        productos.stockMax=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Ingrese el precio de venta del producto");
        productos.precioVenta=Double.Parse(Console.ReadLine());
        System.Console.WriteLine("Ingrese el precio de compra");
        productos.precioCompra=Double.Parse(Console.ReadLine());

        return productos;

     }
     public void ListarProductos(List <Productos> productos){
        System.Console.WriteLine("Id producto \tNombre del producto \tStock");
        foreach(Productos product in productos){
        System.Console.WriteLine($"{product.Id}\t {product.Nombre}\t {product.stock}");
        }
     }
     public void Inventario(List <Productos> productos){
        System.Console.WriteLine("{0,-20} {1,-20} {2,-20} {3,-20} {4,10}", "IdProducto", "NombreProducto", "Stock", "Valor Unidad", "Subtotal");
        foreach(Productos producto in productos){
            System.Console.WriteLine("{0,-20} {1,-20} {2,-20} {3,-20} {4,10}", producto.Id, producto.Nombre, producto.stock, producto.precioVenta, );
        }
     }
     
    
}