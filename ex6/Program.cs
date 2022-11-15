using ex5;
using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime horaInicial1 = new DateTime(2010, 2, 1, 8, 0, 15);
            DateTime horaFinal1 = new DateTime(2010, 4, 18, 13, 30, 30);
            Intervalo i1 = new Intervalo(horaInicial1, horaFinal1);

            DateTime horaInicial2 = new DateTime(2010, 1, 1, 8, 0, 15);
            DateTime horaFinal2 = new DateTime(2010, 8, 18, 13, 30, 30);
            Intervalo i2 = new Intervalo(horaInicial2, horaFinal2);

            ListaIntervalo l1 = new ListaIntervalo();

            l1.Add(i1);
            l1.Add(i2);
            l1.Imprime();
  
        }
    }
}