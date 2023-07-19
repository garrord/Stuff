using PizzaOrderingSystem.Data;
using PizzaOrderingSystem.Factory;
using PizzaOrderingSystem.Form;
using PizzaOrderingSystem.Pizzas;
using PizzaOrderingSystem.Prompts;
using PizzaOrderingSystem.User;

namespace PizzaOrderingSystem.PizzaFacade
{
    public class PizzaFacade
    {
        private readonly IPrompts _prompts;
        private readonly IUserInput _userInput;
        private readonly IPizzaForm _pizzaForm;
        private readonly IPizzaFactory _pizzaFactory;
        private readonly IPizza _pizza;
        private readonly IOrder _order;

        public PizzaFacade(IPrompts prompts,
            IUserInput userInput,
            IPizzaForm pizzaForm,
            IPizzaFactory pizzaFactory,
            IPizza pizza,
            IOrder order)
        {
            _prompts = prompts;
            _userInput = userInput;
            _pizzaForm = pizzaForm;
            _pizzaFactory = pizzaFactory;
            _pizza = pizza;
            _order = order;

        }

        public void CreatingPizzaOrder()
        {
            _prompts.PizzaSelectionPrompt();
            _prompts.ListOfPizzas();
            int[] minMax = _pizza.ReturnMinMax(_pizza.GetPizzaList());
            int selection = _userInput.ReadUserInput(minMax[0], minMax[1]);
            PizzaOrderForm form = _pizzaFactory.CreatePizzaOrderForm(selection);
            string[][] createdPizza = _pizzaForm.CreatePizzaOrderForm(form);
            _order.DisplayOrder(createdPizza);
        }
    }
}
