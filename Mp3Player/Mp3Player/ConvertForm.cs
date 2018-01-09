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
        public partial class ConvertForm : Form
        {
                private string inputfile;
                private string outputfile;

                public ConvertForm()
                {
                        InitializeComponent();
                }

                private void InputFileButton_Click(object sender, EventArgs e)
                {
                        FileDialog fd = new OpenFileDialog();

                        if (fd.ShowDialog() == DialogResult.OK)
                        {
                                inputfile = fd.FileName;
                        }

                        
                }

                private void OutputFileButton_Click(object sender, EventArgs e)
                {
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.DefaultExt = "wav";

                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                                outputfile = sfd.FileName;
                        }
                }

                private void ConvertButton_Click(object sender, EventArgs e)
                {
                        if ((inputfile != null) && (outputfile != null))
                        {
                                Converter converter = new Converter(inputfile,outputfile);
                                converter.ConvertToWav();

                        }
                        
                }
        }
}
