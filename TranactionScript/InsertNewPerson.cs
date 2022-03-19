namespace TranactionScript;

public class InsertNewPerson : ICommand<PersonSaveDto>
{
    public void Execute<T>(T input)
    {
        ValidateInput(input);
        CheckLogic(input);
        SaveToDatabase(input);
    }

    private void SaveToDatabase<T>(T input)
    {
        throw new NotImplementedException();
    }

    private void CheckLogic<T>(T input)
    {
        throw new NotImplementedException();
    }

    private void ValidateInput<T>(T input)
    {
        throw new NotImplementedException();
    }
}