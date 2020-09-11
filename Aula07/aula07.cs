using System;

class Aula07{

   static void Main(){
       
        //constantes ---> Ao atribuir um valor a uma constante ele não poderá ser modificado, diferente de uma variável.
        const string aluno= "Diefersou";
        const double idade=22;

        //aluno="Loukas"; //Ao compilar: aula07.cs(11,8): error CS0131: O lado esquerdo de uma atribuição deve ser uma variável, uma propriedade ou um indexador

        Console.WriteLine("Nome: {0}, idade: {1}",aluno,idade);

       //O importante da constante serve para proteger um conteúdo de uma variável;
   }

}