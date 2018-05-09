using System;
using MisClases.Gente;

namespace MisClases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Producto p = new Producto("0001", "Platanito");
            var p2 = new Producto("0002", "Mora negra", 0.05m);
            var p3 = new Producto("0003", "Dentadura", 1);
            var p4 = new Producto ("0004", "fresa", 0.5m);


            Console.WriteLine(p.GetDescripcionProducto());
            Console.WriteLine(p2.GetDescripcionProducto());
            Console.WriteLine(p3.GetDescripcionProducto());
            Console.WriteLine(p4.GetDescripcionProducto());
            

            var yo = new Plebeyo ("David", "Alañon", 27, Genero.Hombre);
            Console.WriteLine(yo.GetNombreCompleto());

            var duque = new Aristocrata("Manuel", "Delgado", 55, Genero.Hombre, "Conde");
            Console.WriteLine(duque.GetNombreCompleto());
        }
    }
}
