using Itenso.TimePeriod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    public class Intervalo
    {
        public DateTime HoraInicial { get; private set; }
        public DateTime HoraFinal { get; private set; }
        public Intervalo(DateTime horaInicial, DateTime horaFinal)
        {
            if(horaInicial <= horaFinal)
                HoraInicial = horaInicial;
            HoraFinal = horaFinal;
        }
        public bool TemIntersecao(Intervalo intervalo)
        { 
            
            if((HoraInicial>=intervalo.HoraInicial && HoraInicial<=intervalo.HoraFinal || HoraFinal>=intervalo.HoraInicial && HoraFinal<=intervalo.HoraFinal) || (intervalo.HoraInicial >= HoraInicial && intervalo.HoraInicial <= HoraFinal || intervalo.HoraFinal >= HoraInicial && intervalo.HoraFinal <= HoraFinal))
                return true;
            return false;
        }
        public bool IntervalosIguais(Intervalo intervalo)
        {
            if(HoraFinal.Equals(intervalo.HoraFinal) && HoraInicial.Equals(intervalo.HoraInicial))
                return true;
            return false;
        }
        public TimeSpan Duracao()
        {
            TimeSpan duracao = HoraFinal - HoraInicial;
            return duracao;
        }
    }
}
