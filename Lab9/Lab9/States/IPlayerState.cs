using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9.States
{
    public interface IPlayerState
    {
        void Play();
        void Stop();
        void Pause();
        void Repeat();
    }
}
