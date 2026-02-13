using src.Interfaces;

namespace src.Models.Expresso;

public class EspressoComLeiteEChocolate: IExpresso
{
    private readonly IExpresso _expresso = new ExpressoWithMilk();

    
    public  decimal GetCost()
    {
        return _expresso.GetCost() + 0.70m;
    }

    public  string GetDescription()
    {
        return _expresso.GetDescription() + "e Chocolate";
    }
}