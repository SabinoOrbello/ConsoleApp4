using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Età {  get; set; }

        public string GetNome()
        {
            return Nome;
        }

        public string GetCognome()
        {
            return Cognome;
        }

        public int GetEta()
        {
            return Età;
        }

        public string GetDettagli()
        {
            return $"Nome : {Nome}, Cognome: {Cognome}, Età: {Età}";
        }
    }
}
