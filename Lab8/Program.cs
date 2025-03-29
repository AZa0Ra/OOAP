using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            TextMediator mediator = new TextMediator();

            UIComponent component1 = new UIComponent("Компонент 1");
            UIComponent component2 = new UIComponent("Компонент 2");
            UIComponent component3 = new UIComponent("Компонент 3");
            UIComponent component4 = new UIComponent("Компонент 4");

            mediator.AddComponent(component1);
            mediator.AddComponent(component2);
            mediator.AddComponent(component3);
            mediator.AddComponent(component4);

            UIComponentCollection collection = new UIComponentCollection();
            collection.AddComponent(component1);
            collection.AddComponent(component2);
            collection.AddComponent(component3);
            collection.AddComponent(component4);

            Console.WriteLine($"Введіть текст для {component1.Name}");
            string input = Console.ReadLine();
            component1.SetText(input);

            UIComponentIterator iterator = new UIComponentIterator(new List<IUIComponent>(collection));
            while (iterator.MoveNext())
            {
                IUIComponent component = iterator.Current;
                Console.WriteLine($"[{component.Name}] {component.GetText()}");
            }
        }
    }
}
