using System;
using System.Numerics;
using System.Reflection.Metadata;

namespace Program
{
    class MetodoEFuncao
    {
        static void Main(string[] args)
        {

            MeuMetodo();
            string nome = RetornaNome("Vitor", "Hirt");
            Console.WriteLine(nome);
        }

        static void MeuMetodo() 
        { // Método
            Console.WriteLine("C# é foda");
        }

        static string RetornaNome(string nome, // Typo referência
                                  string sobrenome,
                                  bool test = true,
                                  double novo = 21.20021,
                                  int idade = 22 // Parametro opcional sempre o ultimo se não da problema
        ) // Método
        {
            return nome + " " + sobrenome + " " + idade.ToString();
        }
    }

}
