using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public interface IAudioCollection
    {
        void AddAudioTrack(AudioTrack track);
        AudioTrack FindAudioTrack(string title);
        void RemoveAudioTrack(string title);
        void DisplayAllTracks();
    }
}
