﻿using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FundaBoardTracker
{
    public class Grabber : IDisposable
    {
        private Bitmap frame;
        private VideoCaptureDevice device;

        public Grabber()
        {
            FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            device = new VideoCaptureDevice(videoDevices[0].MonikerString);

            VideoCapabilities a = device.VideoCapabilities.OrderByDescending(m => m.FrameSize.Height * m.FrameSize.Width).First();
            device.DesiredFrameSize = a.FrameSize;
            //device.DesiredFrameSize = new Size(1280, 960);
            //device.DesiredFrameSize = new Size(1280, 720);
            device.NewFrame += device_NewFrame;
            device.Start();     
        }
        
        public Bitmap Grab()
        {
            Thread.Sleep(1000);
            while (frame == null) { Thread.Sleep(50); };

            return (Bitmap)frame.Clone();
        }

        private void device_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            frame = (Bitmap)eventArgs.Frame.Clone();
        }

        public void Dispose()
        {
            device.Stop();            
        }
    }
}
