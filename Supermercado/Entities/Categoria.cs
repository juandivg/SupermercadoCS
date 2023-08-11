using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Supermercado.Entities;
public class Categoria
{
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
    public static void AddCategoria()
    {
        Categoria categoria = new Categoria();
        System.Console.WriteLine("Ingrese el ID de la categoria");
        categoria.Id = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Ingrese el nombre de la categoria");
        categoria.Nombre = Console.ReadLine();
        Env.Supermercado.Categorias.Add(categoria);

    }
    public IEnumerable<Categoria> ListarCategorias(){
        return from categoria in Env.Supermercado.Categorias
            select categoria;

    }
}