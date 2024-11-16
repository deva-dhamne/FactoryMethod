namespace FactoryMethod
{
    public class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Windows button");
        }
    }
}
