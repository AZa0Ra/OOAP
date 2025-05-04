using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9.States
{
    public class BatteryLowState : IPlayerState
    {
        private RadioPlayer _player;
        public BatteryLowState(RadioPlayer player) => _player = player;

        public void Play() => ShowChargeMessage();
        public void Stop() => ShowChargeMessage();
        public void Pause() => ShowChargeMessage();
        public void Repeat() => ShowChargeMessage();

        private void ShowChargeMessage() => Console.WriteLine("Батарея розряджена. Підключіть зарядку.");
    }
}
