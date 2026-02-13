using src.Interfaces;

namespace src.Models.Cappucino;

public class CappuccionoComChocolate : ICappucino
{
    private readonly ICappucino _cappucino = new Cappucino();
    public decimal GetCost()
    {
        return _cappucino.GetCost() + 0.70m;
    }

    public string GetDescription()
    {
        return _cappucino.GetDescription() + " com Chocolate";
    }
}