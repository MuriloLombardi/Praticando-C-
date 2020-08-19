/*Desenvolver os dois exercícios abaixo:
3. Faça um Programa que peça dois números e imprima a soma.
4. Faça um Programa que peça as 4 notas bimestrais e mostre a média.
Fonte: https://wiki.python.org.br/EstruturaSequencial
Colocar como entrega o link do repositório no Github.*/


//Excercício 1
/*using System;

class MainClass {
  public static float Operacoes(float n1, float n2){ 
  return(n1+n2);
  }
  public static void Main (string[] args) {
    float n1, n2;
    Console.WriteLine ("Digite dois números: ");
    n1=float.Parse(Console.ReadLine());
    n2=float.Parse(Console.ReadLine());
    Console.WriteLine("A soma dos dois números é: {0}",Operacoes(n1,n2));
  }
}*/


//Excercício 2
using System;

class MainClass {
  public static float Operacoes(float n1, float n2, float n3, float n4){ 
  return((n1+n2+n3+n4)/4);
  }
  public static void Main (string[] args) {
    float n1, n2, n3, n4;
    Console.WriteLine ("Digite as quatros notas: ");
    n1=float.Parse(Console.ReadLine());
    n2=float.Parse(Console.ReadLine());
    n3=float.Parse(Console.ReadLine());
    n4=float.Parse(Console.ReadLine());
    Console.WriteLine("A média das notas é: {0}",Operacoes(n1,n2,n3,n4));
  }
}