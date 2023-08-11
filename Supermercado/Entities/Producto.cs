using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Supermercado.Entities;
public class Producto{
    private string id;
    public string Id
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
    private int stock;
    public int Stock
    {
      get { return stock; }
      set { stock = value; }
    }
    
   private int stockMin;
   public int StockMin
   {
      get { return stockMin; }
      set { stockMin = value; }
   }
   
   private int stockMax;
   public int StockMax
   {
      get { return stockMax; }
      set { stockMax = value; }
   }
   
     private double precioVenta;
     public double PrecioVenta
     {
      get { return precioVenta; }
      set { precioVenta = value; }
     }
     
     private double precioCompra;
     public double PrecioCompra
     {
      get { return precioCompra; }
      set { precioCompra = value; }
     }
     private int idCategoria;
     public int IdCategoria
     {
      get { return idCategoria; }
      set { idCategoria = value; }
     }
     
     public Producto(){
        if(!File.Exists(Env.FileName)){
            File.WriteAllText(Env.FileName, "");
        }
     }

     public void AddProductos(){
        Producto productos = new Producto();
        System.Console.WriteLine("Ingrese el id del producto");
        productos.Id=Console.ReadLine();
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

        Env.Supermercado.Productos.Add(productos);

     }
     
    
}