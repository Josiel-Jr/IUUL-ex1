using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    public class Vertice
    {
        public double X { get; private set; } 
        public double Y { get; private set; }
        public Vertice(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double Distancia(Vertice v2)
        {
            return (double) Math.Sqrt(Math.Pow((v2.X - X),2) + Math.Pow((v2.Y - Y),2));
        }
        public void Move(double x, double y)
        {
            X = x;
            Y = y;
        }
        public bool VerticesIguais(Vertice v2)
        {
            if (X.Equals(v2.X) && Y.Equals(v2.Y))
                return true;
            return false;
        }
    }
}
