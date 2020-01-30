using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
 public interface AdvancedMediaPlayer
    {
        public void PlayVlc(string fileName);
        public void PlayMp4(string fileName);
    }
}
