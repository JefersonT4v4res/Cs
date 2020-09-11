using System;

class Aula04{

    // int num=10; Variável global
    static int num=10; //Método statico, vartiável statica.

    static void Main(){
        int num2=0; //variável local.
        Console.WriteLine(num);

    }

       //void test(){
      //int num2=0;
     //Console.WriteLine(num); //variável local! Se tentar escrever a variável "num", ela não retornará nada, pois não foi declarada no escopo.

        //Até aqui existem duas variáveis de mesmo nome, mas são diferentes.}   
    
}
