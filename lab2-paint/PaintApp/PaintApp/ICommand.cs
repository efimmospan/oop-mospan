namespace PaintApp
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}