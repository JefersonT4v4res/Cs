using System;

class Aula06{

    static void Main(){
        
        //int n1=10,n2=20,n3=30;

          //Console.WriteLine(n1 + ", " + n2 + " e " + n3 ); ou dessa forma
         //"\n" para quebra de linha e "\t" é um espaçamento.
        // Console.WriteLine("Os valores correspondentes de n1={0}, n2={1} e n3={2}",n1,n2,n3);   
         
         double valorCompra=5.50;
         double valorVenda;
         double lucro=0.1;
         String produto="Pastel";

         valorVenda = valorCompra+(valorCompra*lucro);

         Console.WriteLine("Produto.......:{0,15}",produto);
         Console.WriteLine("Val.compra....:{0,15:c}",valorCompra);//":c" formato de saída, é um formato de saída Monetário adicionando o Sifrão;
         Console.WriteLine("Lucro.........:{0,15:p}",lucro);//":p" formatação de saída, formato de porcentagem;
         Console.WriteLine("Val.Venda.....:{0,15:c}\n\n",valorVenda);



    }
}