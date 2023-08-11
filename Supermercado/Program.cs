using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Supermercado.Entities;
using Supermercado.View;
using Supermercado;
using Newtonsoft.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        int opcion;
        if(Env.ValidarFile(Env.FileName)==false){
            File.WriteAllText(Env.FileName, "");
        }
        else{
            Env.LoadDataProductos(Env.FileName);
        }
        Env.ImprimirData("dddddd", Env.Supermercado.Categorias);
        do
        {
            opcion=Menuprincipal.MenuPrincipal();
            switch(opcion){
                case 1:
                    break;
                case 2:
                    Categoria.AddCategoria();
                    string json= JsonConvert.SerializeObject(Env.Supermercado, Formatting.Indented);
                    File.WriteAllText(Env.FileName, json);
                    break;
                case 3:
                    break;
                default:
                    break;    

            }
        } while (opcion!=3);
    }
}

