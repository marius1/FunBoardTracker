using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Vision.GlyphRecognition;

namespace FunBoardTracker.Demo
{
    public class Recognizer
    {
        public string Name { get; set; }
        public GlyphRecognizer GlyphRecognizer { get; set; }
        
        public override string ToString()
        {
            return Name;
        }
    }
}
