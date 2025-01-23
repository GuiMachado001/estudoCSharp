using System;

class Aula06{
    static void Main(){

        double valorCompra = 5.50;
        double valorVenda;
        double valorLucro = 0.1;
        string produto = "Pastel";

        valorVenda = valorCompra +(valorCompra*valorLucro);

        Console.WriteLine("produto.......:{0,15}",produto);
        Console.WriteLine("Val. Compra...:{0,15:c}",valorCompra);
        Console.WriteLine("Lucro.........:{0,15:p}",valorLucro);
        Console.WriteLine("Val. Venda....:{0,15:c}",valorVenda);

    }
}