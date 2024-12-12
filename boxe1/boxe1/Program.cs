// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introdueix el nom del primer boxejador:");
        string nom1 = Console.ReadLine();
        Console.WriteLine("Quants cops pot aguantar?");
        int resistencia1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Introdueix el nom del segon boxejador:");
        string nom2 = Console.ReadLine();
        Console.WriteLine("Quants cops pot aguantar?");
        int resistencia2 = int.Parse(Console.ReadLine());

        Combat combat = new Combat(
            new Boxejador(nom1, resistencia1),
            new Boxejador(nom2, resistencia2)
        );

        combat.Iniciar();
    }
}