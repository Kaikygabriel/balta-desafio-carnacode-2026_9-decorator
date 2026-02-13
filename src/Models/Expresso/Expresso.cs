using src.Interfaces;

namespace src.Models.Expresso;

public class Espresso : IExpresso
{
    public virtual decimal GetCost()
    {
        return 3.50m;
    }

    public virtual string GetDescription()
    {
        return "Espresso";
    }
}