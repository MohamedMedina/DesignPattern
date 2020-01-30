using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class MediaAdapter : MediaPlayer
    {

        AdvancedMediaPlayer advancedMusicPlayer;

        public MediaAdapter(String audioType)
        {

            if (audioType.Equals("vlc"))
            {
                advancedMusicPlayer = new VlcPlayer();

            }
            else if (audioType.Equals("mp4"))
            {
                advancedMusicPlayer = new Mp4Player();
            }
        }


        public void Play(string audioType, string fileName)
        {
            if (audioType.Equals("vlc"))
            {
                advancedMusicPlayer.PlayVlc(fileName);
            }
            else if (audioType.Equals("mp4"))
            {
                advancedMusicPlayer.PlayMp4(fileName);
            }

        }
        
    }
}
