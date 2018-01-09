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
                // Вспомогательный класс для редакторов и ковертеров.
                private byte[] file;
                private string path;
               
               
                public string Path
                {
                        get { return path; }
                        set { path = value; }
                }
                                
                public byte[] File
                {
                        get { return file; }
                }

                public ByteReader(string path)
                {
                        this.path = path;
                }

                public void ReadFile()
                {
                        file = System.IO.File.ReadAllBytes(path);                                             
                }

             
        }
}
