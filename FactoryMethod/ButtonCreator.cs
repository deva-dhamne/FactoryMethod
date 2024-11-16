namespace FactoryMethod
{
    public abstract class ButtonCreator
    {
        public abstract IButton CreateButton();

        public void RenderButton()
        {
            IButton button = CreateButton();

            button.Render();
        }
    }
}
