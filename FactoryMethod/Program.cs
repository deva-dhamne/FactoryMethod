namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ButtonCreator buttonCreator;

            buttonCreator = new WindowsButtonCreator();

            buttonCreator.RenderButton();

            buttonCreator = new MacButtonCreator();

            buttonCreator.RenderButton();
        }
    }
}
