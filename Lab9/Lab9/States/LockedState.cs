using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9.States
{
    public class LockedState : IPlayerState
    {
        private RadioPlayer _player;

        public LockedState(RadioPlayer player) => _player = player;

        public void Play() => ShowUnlockScreen();
        public void Stop() => ShowUnlockScreen();
        public void Pause() => ShowUnlockScreen();
        public void Repeat() => ShowUnlockScreen();

        private void ShowUnlockScreen() => Console.WriteLine("Плеєр заблоковано. Розблокуйте для дій.");
    }
}
