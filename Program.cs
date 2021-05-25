using System;
using ExemploSobrecarga.Classes;

namespace ExemploSobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            for (var i = 0; i < f.lista.Length; i++)
            {
                Console.Write("Digite um item para a lista: ");
                f.lista[i] = Console.ReadLine();
            }
            
            Console.WriteLine("\nMostrar sem argumentos");
            f.Mostrar();
            
            Console.WriteLine("\nMostrar com argumento int");
            f.Mostrar(2);
            
            Console.WriteLine("\nMostrar com argumento string");
            f.Mostrar("manga");

        }
    }
}
