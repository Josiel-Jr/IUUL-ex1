using ex5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    class ListaIntervalo
    {
        List<Intervalo> intervalos = new List<Intervalo>();
        public bool Add(Intervalo intervalo)
        {
            foreach(Intervalo intervalo1 in intervalos)
            {
                if (intervalo1.TemIntersecao(intervalo)==true)
                {
                    return false;
                }
            }
            intervalos.Add(intervalo);
            return true;
        }
        public void Imprime()
        {
            if(intervalos != null)
            {
                foreach (Intervalo intervalo in intervalos)
                {
                    Console.WriteLine("Hora inicial: {0} Hora final: {1}",intervalo.HoraInicial,intervalo.HoraFinal);
                }
            }
        }
    }
}
