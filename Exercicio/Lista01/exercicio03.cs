// 3. Peça ao usuário para digitar três valores inteiros e imprima a soma deles. 

using System;


class Exercicio03{
    static void Main(){
        Console.WriteLine("Digite um numero: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite outro numero: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Digite mais um numero: ");
        int num3 = int.Parse(Console.ReadLine());

        int res = num1 + num2 + num3; 

        Console.WriteLine("A soma: "+num1+ " + " +num2+ " + " +num3+ " é de: "+ res);
    }
}