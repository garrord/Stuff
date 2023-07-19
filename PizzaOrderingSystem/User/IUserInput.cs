namespace PizzaOrderingSystem.User
{
    public interface IUserInput
    {
        int ReadUserInput(int min, int max);
        List<int> ReadUserInputMultiple(int min, int max);
    }
}
