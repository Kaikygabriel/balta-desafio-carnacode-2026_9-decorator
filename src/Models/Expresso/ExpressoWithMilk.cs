using src.Interfaces;

namespace src.Models.Expresso;

public class ExpressoWithMilk : IExpresso
{
    private readonly IExpresso _expresso = new Espresso();

    public decimal GetCost()
    {
        return _expresso.GetCost()+ 0.50m;
    }

    public string GetDescription()
    {
        return _expresso.GetDescription() + " com Leite";
    }
}