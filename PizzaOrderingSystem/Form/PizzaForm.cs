using PizzaOrderingSystem.Pizzas;
using PizzaOrderingSystem.User;

namespace PizzaOrderingSystem.Form
{

    public class PizzaForm : IPizzaForm
    {
        private readonly IUserInput _userInput;

        public PizzaForm(IUserInput userInput)
        {
            _userInput = userInput;
        }

        public string[][] CreatePizzaOrderForm(PizzaOrderForm form)
        {
            DisplaySelections(form.Size);
            string sizeSelected = SelectSizeOrCrust(form.Size);

            DisplaySelections(form.CrustTypes);
            string crustSelected = SelectSizeOrCrust(form.CrustTypes);

            DisplaySelections(form.Toppings);
            List<int> toppingsSelection = _userInput.ReadUserInputMultiple(1, form.Toppings.Length);
            string[] toppingsSelected = ToppingsSelection(form.Toppings, toppingsSelection);

            return new string[3][] { new string[] { sizeSelected }, new string[] { crustSelected }, toppingsSelected };
        }

        private string SingleSelection(string[] choices, int pick)
        {
            return choices[pick - 1];
        }

        private string[] ToppingsSelection(string[] toppings, List<int> selections)
        {
            List<string> top = new List<string>();
            foreach (int sec in selections)
            {
                top.Add(toppings[sec - 1]);
            }
            return top.ToArray();
        }

        private string SelectSizeOrCrust(string[] choices)
        {
            int choiceSelection = _userInput.ReadUserInput(1, choices.Length);
            string choiceSelected = SingleSelection(choices, choiceSelection);
            return choiceSelected;
        }

        private void DisplaySelections(string[] selections)
        {
            int number = 1;
            foreach (string selection in selections)
            {
                Console.WriteLine($"{number}. {selection}");
                number++;
            }
        }
    }
}