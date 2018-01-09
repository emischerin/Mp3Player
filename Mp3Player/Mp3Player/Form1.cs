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
                Player player = new Player();
               
                

                public Form1()
                {
                        InitializeComponent();
                }

                private void PlayButton_Click(object sender, EventArgs e)
                {
                        
                       if (inputfile != null)
                        {
                                player.Play(inputfile);
                        }
                }

                private void StopButton_Click(object sender, EventArgs e)
                {
                        player.Stop();
                }

                private void ConvertButton_Click(object sender, EventArgs e)
                {
                        ConvertForm cf = new ConvertForm();
                        cf.Show();
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
