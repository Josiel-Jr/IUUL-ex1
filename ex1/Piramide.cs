using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Piramide
    {
        private int _n;
        public Piramide(int n)
        {
            N = n;
        }
        public int N
        {
            get => _n;
            private set
            {
                if (value >= 1)
                {
                    _n = value;
                }
            }
        }
        public void Desenha()
        {
            for(int i=1; i <= N; i++)
            {
                int aux = 1;
                for(int j=i; j<=N; j++)
                {
                    Console.Write(" ");
                }
                for(int j=1; j<i; j++)
                {
                    Console.Write(aux++ + "");
                }
                for(int j=1; j <= i; j++)
                {
                    Console.Write(aux-- + "");
                }
                Console.WriteLine();
            }
        }
    }
}
