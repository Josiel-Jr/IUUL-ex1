namespace ex5 
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime horaInicial1 = new DateTime(2010, 2, 1, 8, 0, 15);
            DateTime horaFinal1 = new DateTime(2010, 4, 18, 13, 30, 30);
            Intervalo i1 = new Intervalo(horaInicial1, horaFinal1);

            DateTime horaInicial2 = new DateTime(2010, 1, 1, 8, 0, 15);
            DateTime horaFinal2 = new DateTime(2010, 2, 18, 13, 30, 30);

            Intervalo i2 = new Intervalo(horaInicial2, horaFinal2);
            Console.WriteLine(i1.TemIntersecao(i2));
        }
    }
}