using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mp3Player
{
        public partial class Form1 : Form
        {
                private string outputfile;
                private string inputfile;
                Mp3Player mp3 = new Mp3Player();
                Converter conv = new Converter();
                

                public Form1()
                {
                        InitializeComponent();
                }

                private void PlayButton_Click(object sender, EventArgs e)
                {
                        
                       if (inputfile != null)
                        {
                                mp3.Play(inputfile);
                        }
                }

                private void StopButton_Click(object sender, EventArgs e)
                {
                        mp3.Stop();
                }

                private void ConvertButton_Click(object sender, EventArgs e)
                {
                        if (outputfile != null)
                        {
                                conv.ConvertToWav(outputfile);
                        }
                        
                }

                private void OFD_Click(object sender, EventArgs e)
                {

                        OpenFileDialog of = new OpenFileDialog();

                        if (of.ShowDialog() == DialogResult.OK)
                        {
                                inputfile = of.FileName;
                        }
                }
        }
}
