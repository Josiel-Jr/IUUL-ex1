using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ex2;

namespace ex4
{
    class Poligono
    {
        List<Vertice> Vertices = new List<Vertice>();
        public int qtVertices
        {
            get { return Vertices.Count; }
        }
        public Poligono(params Vertice[] vertices)
        {
            if (vertices.Length > 2)
            {
                foreach(Vertice vertice in vertices)
                {
                    Vertices.Add(vertice);
                }
            }
        }
        public void listPoligono()
        {
            foreach(Vertice vertice in Vertices)
            {
                Console.WriteLine("X={0} Y={1}",vertice.X,vertice.Y);
            }
        }
        public bool AddVertice(Vertice v)
        {
            foreach(Vertice vertice in Vertices)
            {
                if (v.VerticesIguais(vertice))
                    return false;
            }
            Vertices.Add(v);
            return true;
        }
        public bool RemoveVertice(Vertice v)
        {
            if (qtVertices > 3)
            {
                foreach (Vertice vertice in Vertices)
                {
                    if (v.VerticesIguais(vertice))
                    {
                        Vertices.Remove(vertice);
                        return true;
                    }
                }
            }
            return false;
        }
        public double perimetroPoligono()
        {
            double sum=0.0;
            for(int i = 0; i < qtVertices; i++)
            {
                if (i == Vertices.Count - 1)
                {
                    sum += Vertices[i].Distancia(Vertices[0]);
                }
                else
                {
                    sum += Vertices[i].Distancia(Vertices[i + 1]);
                }              
            }
            return sum;
        }
    }
}
