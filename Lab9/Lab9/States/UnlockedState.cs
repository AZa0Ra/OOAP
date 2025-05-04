using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9.States
{
    public class UnlockedState : IPlayerState
    {
        private RadioPlayer _player;

        public UnlockedState(RadioPlayer player) => _player = player;

        public void Play() => Console.WriteLine("Грає радіостанція...");
        public void Stop() => Console.WriteLine("Зупинено відтворення.");
        public void Pause() => Console.WriteLine("Призупинено.");
        public void Repeat() => Console.WriteLine("Повтор поточної станції.");
    }
}
