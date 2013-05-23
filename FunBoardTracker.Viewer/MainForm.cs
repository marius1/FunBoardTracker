using FundaBoardTracker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunBoardTracker.Viewer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            using (Grabber grabber = new Grabber()) 
            {
                Bitmap img = grabber.Grab();           

                pictureBox1.Image = img;
            }
        }
    }
}
