using PizzaOrderingSystem.Data;

namespace PizzaOrderingSystem.Prompts
{
    public class Prompts : IPrompts
    {
        private readonly IPizza _pizza;

        public Prompts(IPizza pizza)
        {
            _pizza = pizza;
        }

        public void PizzaSelectionPrompt()
        {
            Console.WriteLine("Select what type of pizza you want to order:");
        }

        public void ListOfPizzas()
        {
            List<Pizza> pizzas = _pizza.GetPizzaList();
            foreach (Pizza pizza in pizzas)
            {
                Console.WriteLine($"{pizza.Number}. {pizza.Name}");
            }
        }

        public void MakeAnotherPizza()
        {
            Console.WriteLine("Do you want to make another pizza?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. Quit");
        }
    }
}
