using System;
using Alura.Financas.Modelos;

namespace Alura.Financas.ConsoleApp 
{
    public class Programa 
    {
        static void Main() 
        {
            var cliente = new Cliente("Fulano de Tal");
            var conta = new Conta("2890-13", cliente);
            conta.Depositar(200);

            #if DEBUG
            conta.Sacar(50);
            #endif
            conta.Depositar(50);
            conta.Sacar(50);
            Console.WriteLine(conta.Saldo);
        }
    }
}