using ex2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ex3.Enum;

namespace ex3
{
    class Triangulo
    {
        public Vertice Vertice1 { get; private set; }
        public Vertice Vertice2 { get; private set; }
        public Vertice Vertice3 { get; private set; }
        private double LadoAB { get { return Vertice1.Distancia(Vertice2); } }
        private double LadoBC { get { return Vertice2.Distancia(Vertice3); } }
        private double LadoAC { get { return Vertice1.Distancia(Vertice3); } }
        public double Perimetro { get { return LadoAB + LadoBC + LadoAC; } }
        public Tipo Tipo { 
            get 
            {   if (LadoAB == LadoBC && LadoAB == LadoAC) return Tipo.Equilatero;
                else if (LadoAB != LadoBC && LadoAB != LadoAC && LadoBC != LadoAC) return Tipo.Escaleno;
                else return Tipo.Isosceles;
            }
        }
        public double Area { get { return (double)Math.Sqrt((Perimetro / 2) * ((Perimetro / 2) - LadoAB) * ((Perimetro / 2) - LadoBC) * ((Perimetro / 2) - LadoAC)); } }

        public Triangulo(Vertice vertice1, Vertice vertice2, Vertice vertice3)
        {
            Vertice1 = vertice1;
            Vertice2 = vertice2;
            Vertice3 = vertice3;
            if (!(LadoAC < LadoAB + LadoBC)  && !(LadoAB < LadoBC + LadoAC) && !(LadoBC < LadoAB + LadoAC))
            {
                Console.WriteLine("Com os valores desses vértices não será possível formar um triângulo");
                Vertice1.Move(0, 0);
                Vertice2.Move(0, 0);
                Vertice3.Move(0, 0);
            }
        }
        public bool TriangulosIguais(Triangulo t2)
        {
            if (Vertice1.VerticesIguais(t2.Vertice1) && Vertice2.VerticesIguais(Vertice2) && Vertice3.VerticesIguais(t2.Vertice3))
                return true;
            return false;
        }
    }
}
