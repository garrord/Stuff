namespace PizzaOrderingSystem.User
{
    public class UserInput : IUserInput
    {
        public int ReadUserInput(int min, int max)
        {
            bool isValid = false;
            int selection = -1;

            while (!isValid)
            {
                isValid = int.TryParse(Console.ReadLine(), out selection);
                if (isValid && selection >= min && selection <= max)
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                    Console.WriteLine("Enter a valid number, please.");
                }
            }
            return selection;
        }

        public List<int> ReadUserInputMultiple(int min, int max)
        {
            List<int> li = new List<int>();
            bool isValid = false;
            while (!isValid)
            {
                Console.WriteLine("Make selections, separated by commas.");
                string selection = Console.ReadLine();
                string[] secs = selection.Split(',');
                foreach (string sec in secs)
                {
                    int s;
                    isValid = int.TryParse(sec, out s);
                    if (isValid && s >= min && s <= max)
                    {
                        li.Add(s);
                        isValid = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid selection.");
                        isValid = false;
                        break;
                    }
                }
            }
            return li;
        }
    }
}
