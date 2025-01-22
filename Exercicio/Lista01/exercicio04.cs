//4. Leia um número real e imprima o resultado do quadrado desse número. 

using System;

class Exercicio04{
    static void Main(){
        Console.WriteLine("Digite um número Real: ");
        int numero = float.Parse(Console.WriteLine());

        float res = numero * numero;

        Console.WriteLine("O quadrado é: " + res);
    }
}