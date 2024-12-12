class Combat
{
    private Boxejador Boxejador1 { get; set; }
    private Boxejador Boxejador2 { get; set; }

    public Combat(Boxejador b1, Boxejador b2)
    {
        Boxejador1 = b1;
        Boxejador2 = b2;
    }

    public void Iniciar()
    {
        Console.WriteLine($"\nCombat entre {Boxejador1.Nom} i {Boxejador2.Nom}");
        Console.WriteLine("-------------------------------------");

        while (!Boxejador1.EstaKO() && !Boxejador2.EstaKO())
        {
            ExecutarTorn(Boxejador1, Boxejador2);
            if (Boxejador2.EstaKO()) break;

            ExecutarTorn(Boxejador2, Boxejador1);
            Thread.Sleep(500);
        }

        string guanyador = Boxejador2.EstaKO() ? Boxejador1.Nom : Boxejador2.Nom;
        string perdedor = Boxejador2.EstaKO() ? Boxejador2.Nom : Boxejador1.Nom;
        
        Console.WriteLine($"{perdedor} CAU!");
        Console.WriteLine($"GUANYADOR: {guanyador}");
    }

    private void ExecutarTorn(Boxejador atacant, Boxejador defensor)
    {
        string zonaCop = atacant.Picar();
        bool copReeixit = defensor.RebreCop(zonaCop);

        if (copReeixit)
        {
            Console.WriteLine($"— {atacant.Nom} pica: Cop a {zonaCop}");
        }
        else
        {
            Console.WriteLine($"— {atacant.Nom} pica: Protegit");
        }
    }
}