class Boxejador
{
    public string Nom { get; private set; }
    public int ResistenciaMaxima { get; private set; }
    public int CopsRebuts { get; private set; }
    private Random random;

    public Boxejador(string nom, int resistencia)
    {
        Nom = nom;
        ResistenciaMaxima = Math.Min(resistencia, 10);
        CopsRebuts = 0;
        random = new Random();
    }

    public bool EstaKO()
    {
        return CopsRebuts >= ResistenciaMaxima;
    }

    public string Picar()
    {
        string[] zones = { "cap", "panxa", "esquerra", "dreta" };
        return zones[random.Next(zones.Length)];
    }

    public bool RebreCop(string zona)
    {
        var zonesProtegides = new HashSet<string>();
        string[] zones = { "cap", "panxa", "esquerra", "dreta" };
        
        while (zonesProtegides.Count < 3)
        {
            zonesProtegides.Add(zones[random.Next(zones.Length)]);
        }

        if (!zonesProtegides.Contains(zona))
        {
            CopsRebuts++;
            return true;
        }
        return false;
    }
}