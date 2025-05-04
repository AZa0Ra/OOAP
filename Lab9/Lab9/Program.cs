using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab9.States;

namespace Lab9
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            RadioPlayer player = new RadioPlayer();
            IPlayerState unlocked = new UnlockedState(player);
            IPlayerState locked = new LockedState(player);
            IPlayerState batteryLow = new BatteryLowState(player);

            player.SetState(unlocked);

            while (true)
            {
                Console.WriteLine("\nВведіть команду: play / stop / pause / repeat / lock / unlock / low / exit");
                Console.Write("> ");
                string input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "play":
                        player.Play();
                        break;
                    case "stop":
                        player.Stop();
                        break;
                    case "pause":
                        player.Pause();
                        break;
                    case "repeat":
                        player.Repeat();
                        break;
                    case "lock":
                        player.SetState(locked);
                        Console.WriteLine("Стан: заблоковано.");
                        break;
                    case "unlock":
                        player.SetState(unlocked);
                        Console.WriteLine("Стан: розблоковано.");
                        break;
                    case "low":
                        player.SetState(batteryLow);
                        Console.WriteLine("Стан: розряджено.");
                        break;
                    case "exit":
                        Console.WriteLine("Вихід з програми...");
                        return;
                    default:
                        Console.WriteLine("Невідома команда.");
                        break;
                }
            }
        }
    }
}
