using PizzaOrderingSystem.Pizzas;

namespace PizzaOrderingSystem.Factory
{
    public class PizzaFactory : IPizzaFactory
    {
        public PizzaOrderForm CreatePizzaOrderForm(int selection)
        {
            switch (selection)
            {
                case 1:
                    return new PepperoniForm();
                case 2:
                    return new MargheritaForm();
                case 3:
                    return new VegetarianForm();
                case 4:
                    return new HawaiianForm();
                default:
                    return new DefaultForm();
            }
        }
    }
}
