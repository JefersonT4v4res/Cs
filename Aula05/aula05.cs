using System;

class Aula05{

    static void Main(){

        int res=(10+5)*2;
        bool resp = 10>5;
  
        Console.WriteLine(res);
        Console.WriteLine(resp);
//----------------------------------------------------------

       int num=10;
         // num=num+1; forma resumida num+=1 ou num++
        //Para incrementar mais de 1
       //num=num+2; ou num+=2; ou num+=10 e até mesmo com outras operações, num*=2;
       num*=2;

        Console.WriteLine(num);
//----------------------------------------------------------
           
           //& = AND / E
          // | = OR / OU
           
      
      bool aux=(5>3) & (10>5);

      Console.WriteLine(aux);




    }

}