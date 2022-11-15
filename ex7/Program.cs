using Caelum.Stella.CSharp.Validation;
using System;
using System.Data.SqlTypes;
using System.Globalization;

namespace ex7
{
    class Program
    {

        static void Main(string[] args)
        {
            string str = "";
            
            string nome = LerNome(str);

            long cpf = Convert.ToInt64(LerCpf(str));
 
            DateTime dataNascimento = Convert.ToDateTime(LerDataNascimento(str));
            
            float rendaMensal = Convert.ToSingle(LerRendaMensal(str),new CultureInfo("pt-br"));

            char estadoCivil = Convert.ToChar(LerEstadoCivil(str));  

            int qtDependentes = Convert.ToInt32(LerQtDependentes(str));

            Console.WriteLine("\nNome: {0}\nCPF: {1}\nData de Nascimento: {2}\nRenda Mensal: {3}\nEstado civil: {4}\nQuantidade de dependentes: {5}",nome,cpf,dataNascimento.Date,rendaMensal.ToString("F2",CultureInfo.InvariantCulture).Replace('.',','),estadoCivil,qtDependentes);
        }
        public static string LerNome(String str)
        {
            Console.Write("Nome: ");
            str = Console.ReadLine();
                while (str.Length < 5)
                {
                    Console.WriteLine("O nome deve possuir pelo menos 5 caracteres");
                    Console.Write("Nome: ");
                    str = Console.ReadLine();
                }
            return str;
        }
        public static string LerCpf(string str)
        {
            Console.Write("CPF: ");
            str = Console.ReadLine();
            while (VerificaFormatoCpf(str) != true)
            {
                Console.WriteLine("Formato inadequado para CPF");
                Console.Write("CPF: ");
                str = Console.ReadLine();
            }
            return str;
        }
        public static bool VerificaFormatoCpf(string str)
        {
            try
            {
                new CPFValidator().AssertValid(str);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static string LerDataNascimento(String str)
        {
            DateTime dataNascimento = DateTime.Now;
            Console.Write("Data de nascimento (DD/MM/AAAA): ");
            str = Console.ReadLine();
            dataNascimento = DateTime.Parse(str);
            while (MaiorDeIdade(dataNascimento) != true)
            {
                Console.WriteLine("Deve ser maior de idade");
                Console.Write("Data de nascimento (DD/MM/AAAA): ");
                str = Console.ReadLine();
                dataNascimento = DateTime.Parse(str);
            }
            return str;
        }
        public static bool MaiorDeIdade(DateTime dataNascimento)
        {
            int idade = (DateTime.Now.Year - dataNascimento.Year);
            if (DateTime.Now.Month < dataNascimento.Month || (DateTime.Now.Month == dataNascimento.Month && DateTime.Now.Day < dataNascimento.Day))
            {
                idade--;
            }
            if (idade >= 18)
            {
                return true;
            }
            return false;
        }
        public static string LerRendaMensal(string str)
        {
            Console.Write("Renda mensal: ");
            str = Console.ReadLine();
            float n;
            bool ehNumero = float.TryParse(str, out n);
            while (ehNumero.Equals(false) || numCasasDecimais(str) != 2)
            {
                Console.WriteLine("Formato inadequado. Deve ser digitado um número com duas casas decimais e vírgula decimal");
                Console.Write("Renda mensal: ");
                str = Console.ReadLine();
                ehNumero = float.TryParse(str, out n);
            }
            return str;
        }
        public static int numCasasDecimais(string str)
        {
            var res = str.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            int num=0;
            if (res.Count() > 1)
                num = res[1].Count();
            return num;
        }
        public static string LerEstadoCivil(String str)
        {
            Console.Write("Estado civil: ");
            str = Console.ReadLine();
            while (!(str.ToUpper().Equals("C") || str.ToUpper().Equals("S") || str.ToUpper().Equals("V") || str.ToUpper().Equals("D")))
            {
                Console.WriteLine("Deve ser digitado somente [C/c], [S/s], [V/v] ou [D/d]");
                Console.Write("Estado civil: ");
                str = Console.ReadLine();
            }
            return str;
        }
        public static string LerQtDependentes(String str)
        {
            Console.Write("Quantidade de dependentes: ");
            str = Console.ReadLine();
            while (verificaQtDependentes(str) != true)
            {
                Console.WriteLine("São aceitos somente a entrada de 0 a 10 dependentes.");
                Console.Write("Quantidade de dependentes: ");
                str = Console.ReadLine();
            }
            return str;
        }
        public static bool verificaQtDependentes(string str)
        {
            for (int i = 0; i <= 10; i++)
            {
                string aux = Convert.ToString(i);
                if (str.Equals(aux))
                {
                    return true;
                }
            }
            return false;
        }
    }
}