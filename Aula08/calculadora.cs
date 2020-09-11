using System;

class calculadora{

    static void Main(){

        float v1,v2;
        char op;
        int flag=1;

        while(flag==1){
            Console.Write("Digite o primeiro valor: ");
            v1=float.Parse(Console.ReadLine());

            Console.Write("\n\n");
            Console.Write("Informe a operação: ");
            op=char.Parse(Console.ReadLine());

            
            Console.Write("\n\n");
            Console.Write("Digite o segundo valor: ");
            v2=float.Parse(Console.ReadLine());

            if(op == '+'){
             Console.WriteLine("{0} + {1} = {2}",v1,v2,(v1+v2));
            }else{if(op=='-'){
                Console.WriteLine("{0} - {1} = {2}",v1,v2,(v1-v2));
            }else{if(op=='*'){
                Console.WriteLine("{0} * {1} = {2}",v1,v2,(v1*v2));
            }else{if(op=='/'){
                Console.WriteLine("{0} / {1} = {2}",v1,v2,(v1/v2));
            }else{Console.WriteLine("Refaça o processo! \n\n");}}}}

            Console.Write("Deseja fazer outro calculo? (Sim = 1/Não = 0): "); 
             flag=int.Parse(Console.ReadLine());  

        }
        Console.WriteLine("Calculo finalizado...");
    }
}