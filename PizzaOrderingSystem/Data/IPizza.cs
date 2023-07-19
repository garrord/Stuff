namespace PizzaOrderingSystem.Data
{
    public interface IPizza
    {
        List<Pizza> GetPizzaList();
        int[] ReturnMinMax(List<Pizza> Pizzas);
    }
}
