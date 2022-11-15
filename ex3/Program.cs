using ex2;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Vertice v1 = new Vertice(6, 8);
            Vertice v2 = new Vertice(1, -4);
            Vertice v3 = new Vertice(6, -4);
            Triangulo t1 = new Triangulo(v1, v2, v3);
            Console.WriteLine(t1.Perimetro);
            Console.WriteLine(t1.Area);
            Console.WriteLine(t1.Tipo);
        }
    }
}