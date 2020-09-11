using System;

namespace Aula02 //forma de organização
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Diefersou em C#"); //WriteLine tem quebra de linha no final
            if (args.GetLength(0) > 0){

            Console.Write(args.GetValue(0)); //pegando valor
            }

        }
    }
}
