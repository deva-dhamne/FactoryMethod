namespace FactoryMethod
{
    public class MacButtonCreator : ButtonCreator
    {
        public override IButton CreateButton()
        {
            return new MacButton();
        }
    }
}
