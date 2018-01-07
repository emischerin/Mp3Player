using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using NAudio.Wave;

namespace Mp3Player
{
        class Converter
        {
                private string path = "C:\\users/Egor/desktop/summernight.mp3";
                private string filename = "C:\\users/Egor/desktop/summernight1.wav";

                public void ConvertToWav(string outputfile)
                {
                        using (Mp3FileReader mp3reader = new Mp3FileReader(path))
                        {
                                WaveFileWriter.CreateWaveFile(outputfile, mp3reader);
                        }
                }
                
        }
}
