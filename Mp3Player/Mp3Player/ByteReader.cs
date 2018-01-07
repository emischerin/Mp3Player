using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mp3Player
{
        class ByteReader
        {
                private byte[] file;
                private string path = "C:\\users/Egor/desktop/summernight.mp3";

                public byte[] File
                {
                        get { return file; }
                }


                public void ReadFile()
                {
                        file = System.IO.File.ReadAllBytes(path);
                       
                       
                }


        }
}
