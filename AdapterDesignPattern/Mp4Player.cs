using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class Mp4Player : AdvancedMediaPlayer
    {
        public void PlayMp4(string fileName)
        {
            Console.WriteLine("the media is" + fileName);
        }

        public void PlayVlc(string fileName)
        {
           // Console.WriteLine("the media is" + fileName);
        }
    }
}
