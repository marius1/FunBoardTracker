using AForge.Vision.GlyphRecognition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunBoardTracker
{
    public enum IssueGlyph
    {
        A,
        B,
        C,
        D,
        E,
        F,
        G,
        H,
        I,
    }

    public class IssueGlyphs
    {
        private static Dictionary<IssueGlyph, Glyph> glyphs = new Dictionary<IssueGlyph, Glyph>{
            { IssueGlyph.A, new Glyph("A", new byte[5, 5] { 
                    { 0, 0, 0, 0, 0 }, 
                    { 0, 1, 1, 0, 0 }, 
                    { 0, 0, 1, 0, 0 }, 
                    { 0, 1, 0, 1, 0 }, 
                    { 0, 0, 0, 0, 0 } 
                })
            },
            { IssueGlyph.B, new Glyph("B", new byte[5, 5] { 
                    { 0, 0, 0, 0, 0 }, 
                    { 0, 1, 1, 0, 0 }, 
                    { 0, 1, 0, 1, 0 }, 
                    { 0, 0, 1, 0, 0 }, 
                    { 0, 0, 0, 0, 0 } 
                })
            },
            { IssueGlyph.C, new Glyph("C", new byte[5, 5] { 
                    { 0, 0, 0, 0, 0 }, 
                    { 0, 1, 1, 0, 0 }, 
                    { 0, 0, 1, 1, 0 }, 
                    { 0, 1, 1, 0, 0 }, 
                    { 0, 0, 0, 0, 0 } 
                })
            },
            { IssueGlyph.D, new Glyph("D", new byte[5, 5] { 
                    { 0, 0, 0, 0, 0 }, 
                    { 0, 1, 0, 0, 0 }, 
                    { 0, 0, 1, 0, 0 }, 
                    { 0, 1, 0, 1, 0 }, 
                    { 0, 0, 0, 0, 0 } 
                })
            },
            { IssueGlyph.E, new Glyph("E", new byte[5, 5] { 
                    { 0, 0, 0, 0, 0 }, 
                    { 0, 0, 0, 1, 0 }, 
                    { 0, 1, 1, 1, 0 }, 
                    { 0, 0, 1, 0, 0 }, 
                    { 0, 0, 0, 0, 0 } 
                })
            },
            { IssueGlyph.F, new Glyph("F", new byte[5, 5] { 
                    { 0, 0, 0, 0, 0 }, 
                    { 0, 1, 1, 1, 0 }, 
                    { 0, 0, 0, 1, 0 }, 
                    { 0, 0, 1, 0, 0 }, 
                    { 0, 0, 0, 0, 0 } 
                })
            },
            /*{ IssueGlyph., new Glyph("", new byte[5, 5] { 
                    { 0, 0, 0, 0, 0 }, 
                    { 0, 0, 0, 0, 0 }, 
                    { 0, 0, 0, 0, 0 }, 
                    { 0, 0, 0, 0, 0 }, 
                    { 0, 0, 0, 0, 0 } 
                })
            }*/
            };

        public static Dictionary<IssueGlyph, Glyph> Glyphs { get { return glyphs; } }
    }
}
