using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Vision.GlyphRecognition;

namespace FunBoardTracker
{
    public class BoundryGlyph : Glyph
    {
        public BoundryGlyph(string name, int size) : base(name, size)
        {
        }

        public BoundryGlyph(BoundryId id, int size) : base(id.ToString(), size)
        {
            Id = id;
        }

        public BoundryGlyph(string name, byte[,] data) : base(name, data)
        {
        }

        public BoundryGlyph(BoundryId id, byte[,] data) : base(id.ToString(), data)
        {
            Id = id;
        }

        public BoundryGlyph(Glyph glyph) : base(glyph.Name, glyph.Data)
        {
            Id = (BoundryId)Enum.Parse(typeof(BoundryId), glyph.Name);
        }

        public BoundryId Id { get; set; }
    }

    public enum BoundryId
    {
        LeftTop,
        LeftBottom,

        TodoTop,
        TodoBottom,

        DoingTop,
        DoingBottom,

        TestTop,
        TestBottom,

        RightTop,
        RightBottom
    }
}
