using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IAudioCollection audioCollection = new AudioCollectionProxy();

            audioCollection.AddAudioTrack(new AudioTrack("Song 1", "Artist 1", new TimeSpan(0, 3, 45)));
            audioCollection.AddAudioTrack(new AudioTrack("Song 2", "Artist 2", new TimeSpan(0, 4, 20)));
            audioCollection.AddAudioTrack(new AudioTrack("Song 3", "Artist 3", new TimeSpan(0, 5, 10)));

            
            audioCollection.DisplayAllTracks();

            audioCollection.FindAudioTrack("Song 2");

            audioCollection.RemoveAudioTrack("Song 1");

            audioCollection.DisplayAllTracks();
        }
    }
}
