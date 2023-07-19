using PizzaOrderingSystem.Pizzas;

namespace PizzaOrderingSystem.Factory
{
    public interface IPizzaFactory
    {
        PizzaOrderForm CreatePizzaOrderForm(int selection);
    }
}
