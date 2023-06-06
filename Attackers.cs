namespace Valorant;

public class Attackers
{
    public bool IsDead { get; set; }

    public Attackers()
    {
        IsDead = false;
    }

    private void FindBombSite()
    {
        Random successChance = new Random();
        successChance.Next(0, 10);
    }
}