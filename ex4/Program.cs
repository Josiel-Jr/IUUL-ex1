using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ex2;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Vertice v1 = new Vertice(4, 7);
            Vertice v2 = new Vertice(4, 3);
            Vertice v3 = new Vertice(1, 3);
            Poligono p1 = new Poligono(v1,v2,v3);
            Console.WriteLine(p1.perimetroPoligono());
            Vertice v4 = new Vertice(10, 3);
            Vertice v5 = new Vertice(4, 3);
            p1.listPoligono();
            p1.AddVertice(v4);
            Console.WriteLine();
            p1.listPoligono();
            p1.RemoveVertice(v5);
            Console.WriteLine();
            p1.listPoligono();
            /* p1.AddVertice(v4);
             p1.listPoligono();
             Console.WriteLine();
             p1.RemoveVertice(v2);
             p1.listPoligono();
             Console.WriteLine();
             p1.RemoveVertice(v1);
             p1.listPoligono();
             p1.AddVertice(v1);*/
        }
    }
}