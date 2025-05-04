using Lab10.Printers;
using Lab10;

Console.OutputEncoding = System.Text.Encoding.UTF8;

while (true)
{
    Console.Write("\nВведіть розмір паперу (A4, A3, A0): ");
    string size = Console.ReadLine().ToUpper();

    Console.Write("Чи кольоровий друк? (так/ні): ");
    bool isColor = Console.ReadLine().Trim().ToLower() == "так";

    Console.Write("Скільки сторінок?: ");
    int pages = int.Parse(Console.ReadLine());

    Console.Write("Введіть назву документа: ");
    string document = Console.ReadLine();

    var strategy = PrinterSelector.ChoosePrinter(size, isColor, pages);

    var context = new PrintContext();
    context.SetStrategy(strategy);
    context.Print(document);

    Console.Write("Натисніть Enter для продовження або 'exit' для виходу: ");
    if (Console.ReadLine().ToLower() == "exit")
        break;
}