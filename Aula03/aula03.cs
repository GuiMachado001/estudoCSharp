using System;

class Aula03{
    static void Main(){
        int n1 = -10;
        char letra = 'c';
        float valor = 1.10f;
        string nome = "Guilherme";
        var aux = 10; // var nao Específica a variavel

        var aux2 = nome;

        byte n2 = 10; // entre 0 e 255

        int num1, num2, res;
        num1 = 10;
        num2 = 2;
        res = num1 * num2;

        Console.WriteLine("A multiplicação de " +num1+ "*" +num2+ " é igual a: " +res);
    }
}