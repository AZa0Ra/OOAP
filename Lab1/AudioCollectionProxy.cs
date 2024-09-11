using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class AudioCollectionProxy : IAudioCollection
    {
        private AudioCollection _realCollection;

        public AudioCollectionProxy()
        {
            _realCollection = new AudioCollection();
        }

        public void AddAudioTrack(AudioTrack track)
        {
            Console.WriteLine("Proxy checking permission to add track");
            _realCollection.AddAudioTrack(track);
        }

        public AudioTrack FindAudioTrack(string title)
        {
            Console.WriteLine("Proxy searching for a track...");
            var track = _realCollection.FindAudioTrack(title);
            if (track != null)
            {
                Console.WriteLine($"Proxy track '{title}' found");
            }
            else
            {
                Console.WriteLine($"Proxy track '{title}' not found");
            }
            return track;
        }

        public void RemoveAudioTrack(string title)
        {
            Console.WriteLine("Proxy removing track");
            _realCollection.RemoveAudioTrack(title);
        }

        public void DisplayAllTracks()
        {
            Console.WriteLine("Proxy displaying all tracks");
            _realCollection.DisplayAllTracks();
        }
    }
}
