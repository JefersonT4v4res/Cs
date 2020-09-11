using System;

class Aula03{

    static void Main(){
        /* Primeira parte estudo;

        byte n1 = 10; // 0 até 255
        int num=0; //negativo ou positivo
        char letra='c'; //apóstolo limitação para caracter e aspas para string
        float valor =5.3f;
        string nome="Diefersou";

        var aux=22; //Var não especifica o tipo de variável, quando compilado ela atribui o tipo
        var auxe=nome;

        Console.WriteLine(auxe);
        Console.WriteLine("Diefersou tem: " + aux + " anos...");
        */
        
        int num1=10, num2=2, res=num1*num2;

        Console.WriteLine("A multiplicação de " + num1 + " vezes " + num2 + " é igual a: " + res);

        //ou podemos não declarar a variável "res" e só colocar num1*num2
        // Console.WriteLine("A multiplicação de " + num1 + " vezes " + num2 + " é igual a: " + num1*num2); tbm funciona.

    }
}