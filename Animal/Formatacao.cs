using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Estimacao.Animal
{
    public class Formatacao
    {
        internal static void Formatar ()
        {   
            
            var animal1 = new Animal();
            var animal2 = new Animal();
            var animal3 = new Animal();
            var animal4 = new Animal();
            var animal5 = new Animal();
            string tipoFomatado;
            Console.WriteLine($"Por favor digite o 1º nome e tipo de animal");
            Console.Write("Nome: ");
            animal1.Nome = Console.ReadLine();
            Console.Write("\nTipo: ");
            tipoFomatado = Console.ReadLine().ToLower();
            var upper = char.ToUpper(tipoFomatado[0]) + tipoFomatado.Substring(1);
            animal1.Tipo = upper;
            Console.WriteLine(animal1.Tipo);

            Console.WriteLine($"Por favor digite o 2º nome e tipo de animal");
            Console.Write("Nome: ");
            animal2.Nome = Console.ReadLine();
            Console.Write("\nTipo: ");
            tipoFomatado = Console.ReadLine().ToLower();
            upper = char.ToUpper(tipoFomatado[0]) + tipoFomatado.Substring(1);
            animal2.Tipo = upper;

            Console.WriteLine($"tipo: {animal1.Tipo} nome:{animal1.Nome} nome: {animal2.Nome} tipo: {animal2.Tipo}");


        }
    }
}
