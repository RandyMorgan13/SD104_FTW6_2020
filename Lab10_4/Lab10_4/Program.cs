using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10_4
{
    class Program
    {

        public static void Main ()
        {
            Artist avengedsevenfold = new Artist("Avenged Sevenfold");
            avengedsevenfold.AddToPlaylist("Nightmare");
            avengedsevenfold.AddToPlaylist("The Stage");
            avengedsevenfold.AddToPlaylist("Strength of the World");
            avengedsevenfold.AddToPlaylist("Warmness on the Soul");

            MediaPlayer player = new MediaPlayer();
            player.PlayMedia(avengedsevenfold);

            AudioBook howto = new AudioBook("A Game of Thrones", "George R.R. Martin");
            player.PlayMedia(howto);

            MovieSoundTrack starWars = new MovieSoundTrack("Star Wars");
            starWars.SelectTrack("Opening Credits Theme");
            player.PlayMedia(starWars);

        }
    }
}
