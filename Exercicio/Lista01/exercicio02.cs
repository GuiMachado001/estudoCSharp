//2. Faça um programa que leia um número real e o imprima. 


using System;

class Exercicio02{
    static void Main(string[] args){
        Console.WriteLine("Digite um numero Real: ");
        string numero = Console.ReadLine();

        float valor = float.Parse(numero);
        Console.WriteLine("O valor digitado é: " + valor);
    }
}