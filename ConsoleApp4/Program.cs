using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();

            persona1.Nome = "MArio";
            persona1.Cognome = "Rossi";
            persona1.Età = 30;

            Console.WriteLine($"Nome : {persona1.GetNome()}");
            Console.WriteLine($"Cognome : {persona1.GetCognome()}");
            Console.WriteLine($"Età : {persona1.GetEta()}");
            Console.WriteLine($"Dettagli : {persona1.GetDettagli()}");


            Console.ReadLine();
        }

    }
}
