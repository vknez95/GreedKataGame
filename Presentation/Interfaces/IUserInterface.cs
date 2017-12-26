namespace GreedKataGame.Presentation.Interfaces
{
    public interface IUserInterface
    {
        bool HasCommandToExecute();

        void ExecuteCurrentCommand();
    }
}
