using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab9.States;

namespace Lab9
{
    public class RadioPlayer
    {
        private IPlayerState _state;

        public void SetState(IPlayerState state)
        {
            _state = state;
        }

        public void Play() => _state.Play();
        public void Stop() => _state.Stop();
        public void Pause() => _state.Pause();
        public void Repeat() => _state.Repeat();
    }
}
