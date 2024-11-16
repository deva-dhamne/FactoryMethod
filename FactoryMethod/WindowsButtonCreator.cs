namespace FactoryMethod
{
    public class WindowsButtonCreator: ButtonCreator
    {
        public override IButton CreateButton()
        {
            return new WindowsButton();
        }
    }
}
