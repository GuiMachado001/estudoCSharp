//1. Faça um programa que leia um número inteiro e o imprima. 


using System;

class Exercicio01{
    static void Main(string[] args){
        Console.WriteLine("Entre com um numero: ");
        string input = Console.ReadLine();
        float value = int.Parse(input);
        Console.WriteLine("O numero que você digitou é: "+ input);
    }
}