using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using NAudio.Wave;
namespace Mp3Player
{
        class Mp3Player
        {
                IWavePlayer waveoutdevice;
                AudioFileReader af;

                public void Play(string path)
                {
                        waveoutdevice = new WaveOut();
                        af = new AudioFileReader(path);

                        waveoutdevice.Init(af);
                        waveoutdevice.Play();
                }

                public void Stop()
                {
                        if (waveoutdevice != null)
                        {
                                waveoutdevice.Stop();
                                waveoutdevice.Dispose();
                                waveoutdevice = null;

                        }
                                
                        
                }
        }
}
