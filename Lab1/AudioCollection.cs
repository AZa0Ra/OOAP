using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class AudioCollection
    {
        private List<AudioTrack> tracks = new List<AudioTrack>();

        public void AddAudioTrack(AudioTrack track)
        {
            tracks.Add(track);
            Console.WriteLine($"Added: {track.Title}");
        }

        public AudioTrack FindAudioTrack(string title)
        {
            return tracks.FirstOrDefault(track => track.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }

        public void RemoveAudioTrack(string title)
        {
            var track = FindAudioTrack(title);
            if (track != null)
            {
                tracks.Remove(track);
                Console.WriteLine($"Removed: {track.Title}");
            }
            else
            {
                Console.WriteLine($"Track '{title}' not found");
            }
        }

        public void DisplayAllTracks()
        {
            Console.WriteLine("\nAudio Tracks:");
            foreach (var track in tracks)
            {
                Console.WriteLine(track);
            }
        }
    }
}
