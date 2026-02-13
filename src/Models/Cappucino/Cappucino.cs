using src.Interfaces;

namespace src.Models.Cappucino;

public class Cappucino : ICappucino
{
    public virtual decimal GetCost()
    {
        return 4.50m;
    }

    public virtual string GetDescription()
    {
        return "Cappuccino";
    }
}