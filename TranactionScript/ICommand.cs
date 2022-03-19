namespace TranactionScript;

public interface ICommand<T> where T : class
{
    void Execute<T>(T input);
}