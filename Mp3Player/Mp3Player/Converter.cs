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
                private string outputfile;
                private string inputfile;

                public string Outputfile
                {
                       get { return outputfile; }
                       set { outputfile = value; }
                }

                public string Inputfile
                {
                        get { return inputfile; }
                        set { Outputfile = value; }
                }

                public Converter()
                {

                }

                public Converter(string inputfile, string outputfile)
                {
                        this.inputfile = inputfile;
                        this.Outputfile = outputfile;
                }

                public void ConvertToWav()
                {
                        if ((inputfile != null) && (outputfile != null))
                        {
                                using (Mp3FileReader mp3reader = new Mp3FileReader(inputfile))
                                {
                                        WaveFileWriter.CreateWaveFile(outputfile, mp3reader);
                                }
                        }
                }
                
        }
}
