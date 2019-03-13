using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPintura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a largura do comodo?");
            double largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a profundidade do comodo?");
            double profundidade = double.Parse(Console.ReadLine());

            Console.WriteLine("A Area das Paredes : ");
            const double Altura = 2.9;

            Calculadora calculadora = new Calculadora();
            Console.WriteLine(calculadora.CalcularAreaParedes(largura, profundidade, Altura));

            Console.WriteLine("A Area do teto : ");
            Console.WriteLine(calculadora.CalcularAreaTeto(largura, profundidade));

            Console.WriteLine("A litragem de tinta necessaria e : ");
            Console.WriteLine(calculadora.CalcularLitragemNecessaria());
            Console.ReadLine();
        }
    }
}
