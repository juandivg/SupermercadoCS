using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Supermercado.Clases;
using Supermercado.View;
class Program{
    private static void Main(string[] args){
        List <Categorias> categorias = new List<Categorias>();
        List <Productos> products = new List<Productos>();
        Productos producto=new Productos();
        Productos Optionproduct=new Productos();
        Categorias categoria= new Categorias();
        Categorias Optioncategory=new Categorias();}
        Guid id=Guid.NewGuid();
        producto.Id=id.ToString();
        producto.Nombre="XXXXXX";
        producto.precioVenta=23000;
        producto.precioCompra=50000;
        producto.stock=8;
        producto.stockMin=10;
        producto.stockMax=20;
        Env.Productos.Add(producto);
        string json=JsonConvert.SerializeObject(Env.Productos, Formatting.Indented);
        File.WriteAllText(Env.FileName, json);

        Menuprincipal menu = new Menuprincipal();
        int opcion = 0;
        do
        {
            opcion=menu.Menu();
            switch(opcion){
                case 1:
                    Optionproduct=producto.RegistrarProductos();
                    products.Add(Optionproduct);
                    break;
                case 2:
                    Optioncategory=categoria.RegistrarCategoria();
                    categorias.Add(Optioncategory);
                    break;
                case 3:
                    producto.ListarProductos(products);
                    break;
                case 4:
                    categoria.
                    break;            
            }
        } while (opcion!=6);
    }
}

