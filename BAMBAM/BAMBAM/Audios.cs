using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace BAMBAM
{
    class Audios
    {
        public void strondaAudio() // defining the function
        {
            SoundPlayer audio = new SoundPlayer(BAMBAM.Properties.Resources.Bonde_Da_Stronda___Blindão_Feat__mp3cut_net_); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            audio.PlayLooping();
        }
        public void birlAudio()
        {
            SoundPlayer audio = new SoundPlayer(BAMBAM.Properties.Resources.birl);
            audio.Play();
        }
    }
}
