using System.Collections.Generic;

namespace Lab8
{
    public interface IMediator
    {
        void AddComponent(IUIComponent component);
        void Notify(IUIComponent sender, string text);
    }
    public class TextMediator : IMediator
    {
        private List<IUIComponent> components = new List<IUIComponent>();

        public void AddComponent(IUIComponent component)
        {
            components.Add(component);
            component.SetMediator(this);
        }

        public void Notify(IUIComponent sender, string text)
        {
            foreach (var component in components)
            {
                // Перевірка чи поле належить оригіналу який ми міняєм
                if (component != sender)
                {
                    component.UpdateText(text);
                }
            }
        }
    }
}
