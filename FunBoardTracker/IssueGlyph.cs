using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Vision.GlyphRecognition;

namespace FunBoardTracker
{
    public class IssueGlyph : Glyph
    {
        public IssueGlyph(string name, int size) : base(name, size)
        {
        }

        public IssueGlyph(int id, int size) : base(id.ToString(), size)
        {
            Id = id;
            UserData = Id;
        }

        public IssueGlyph(string name, byte[,] data) : base(name, data)
        {
        }

        public IssueGlyph(int id, byte[,] data): base(id.ToString(), data)
        {
            Id = id;
            UserData = Id;
        }

        public IssueGlyph(Glyph glyph) : base(glyph.Name, glyph.Data)
        {
            Id = Convert.ToInt32(glyph.Name);
            UserData = Id;
        }

        private int _id;
        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                UserData = Id;
            }
        }

        public Bitmap PrintImage
        {
            get { return GlyphHelper.CreateGlyphImage(this, 250); }
        }
    }
}
