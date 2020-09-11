using System;

class Aula08{

    static void Main(){
        //Lendo valores do teclado e passando para uma variável;

        int v1,v2,soma;
        string nome;

       // Console.Write("Digite seu nome: ");
      //  nome=Console.ReadLine();
     //   Console.WriteLine("Seu nome é: {0}",nome);

      //Ao pegar um valor do teclado, esse valor vem em um formato string e por isso deve-se converter o dado antes de alocar na variável;
     Console.Write("Digite o primeiro valor: ");
     //v1=Console.ReadLine(); formato sem a conversão
     v1=Int16.Parse(Console.ReadLine()); //Uma das formas de conversão em inteiro;
     Console.Write("Digite o segundo valor: ");
     //v2=Console.RealLine();Formato sem conversão;
     v2=Convert.ToInt32(Console.ReadLine());//ToInt32("32" é tamanho do inteiro);
     soma=v1+v2;
     Console.WriteLine("A soma de {0} + {1} é igual a {2}",v1,v2,soma);


    }

}