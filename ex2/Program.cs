using System.Globalization;

namespace ex2
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Vertice v1 = new Vertice(-3, -1);
            Vertice v2 = new Vertice(3, 7);
            Console.WriteLine(v1.Distancia(v2));
        }
    }
}