using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Supermercado.Clases;
class Categorias
{
    private int id;
    public int ID
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
    public Categorias(int id, string nombre)
    {
        this.id = id;
        this.nombre = nombre;
    }
    public Categorias() { }
    public Categorias RegistrarCategoria()
    {
        Categorias categorias = new Categorias();
        System.Console.WriteLine("Ingrese el ID de la categoria");
        categorias.ID = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Ingrese el nombre de la categoria");
        categorias.Nombre = nombre;
        return categorias;

    }
    public void ListarProductos(List<Categorias> categorias)
    {
        System.Console.WriteLine("Id Categoria \tNombre Categoria");
        foreach (Categorias categoria in categorias)
        {
            System.Console.WriteLine($"{categoria.Id}\t {categoria.Nombre}");
        }
    }
}