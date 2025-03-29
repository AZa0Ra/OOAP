using System.Collections.Generic;
using System;
using System.Collections;

namespace Lab8
{
    public interface IUIComponent
    {
        string Name { get; }
        void SetMediator(IMediator mediator);
        void SetText(string text);
        void UpdateText(string text);
        string GetText();
    }

    public class UIComponent : IUIComponent
    {
        private IMediator mediator;
        private string text;

        public UIComponent(string name)
        {
            Name = name;
            text = "";
        }
        public string Name { get; }
        public void SetMediator(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public void SetText(string text)
        {
            this.text = text;
            mediator?.Notify(this, text);
        }
        public void UpdateText(string text)
        {
            this.text = text;
            Console.WriteLine($"{Name}: Оновлено текст на '{text}'");
        }

        public string GetText()
        {
            return text;
        }
    }

    public class UIComponentIterator : IEnumerator<IUIComponent>
    {
        private List<IUIComponent> components;
        private int position = -1;

        public UIComponentIterator(List<IUIComponent> components)
        {
            this.components = components;
        }

        public bool MoveNext()
        {
            position++;
            return position < components.Count;
        }

        public void Reset()
        {
            position = -1;
        }

        public IUIComponent Current
        {
            get { return components[position]; }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public void Dispose() { }
    }
    public class UIComponentCollection : IEnumerable<IUIComponent>
    {
        private List<IUIComponent> components = new List<IUIComponent>();

        public void AddComponent(IUIComponent component)
        {
            components.Add(component);
        }

        public IEnumerator<IUIComponent> GetEnumerator()
        {
            return new UIComponentIterator(components);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
