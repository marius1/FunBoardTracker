using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Vision.GlyphRecognition;

namespace FunBoardTracker
{
    public class GlyphHelper
    {
        public static Bitmap CreateGlyphImage(Glyph glyph, int width)
        {
            Bitmap bitmap = new Bitmap(width, width, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            int cellSize = width / glyph.Size;
            int glyphSize = glyph.Size;

            for (int i = 0; i < width; i++)
            {
                int yCell = i / cellSize;

                for (int j = 0; j < width; j++)
                {
                    int xCell = j / cellSize;

                    if ((yCell >= glyphSize) || (xCell >= glyphSize))
                    {
                        // set pixel to transparent if it outside of the glyph
                        bitmap.SetPixel(j, i, Color.Transparent);
                    }
                    else
                    {
                        // set pixel to black or white depending on glyph value
                        bitmap.SetPixel(j, i,
                            (glyph.Data[yCell, xCell] == 0) ? Color.Black : Color.White);
                    }
                }
            }

            return bitmap;
        }
    }
}
