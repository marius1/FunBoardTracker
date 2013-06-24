using System.Collections.Generic;

namespace FunBoardTracker.GlyphDb
{
    public class Boundries
    {
        private static Dictionary<BoundryId, BoundryGlyph> glyphs = new Dictionary<BoundryId, BoundryGlyph>{
            { BoundryId.TodoTop, new BoundryGlyph(BoundryId.TodoTop, new byte[6, 6] { 
                    { 0, 0, 0, 0, 0, 0 }, 
                    { 0, 0, 1, 0, 1, 0 },
                    { 0, 1, 1, 0, 1, 0 }, 
                    { 0, 1, 0, 1, 1, 0 }, 
                    { 0, 0, 1, 1, 0, 0 }, 
                    { 0, 0, 0, 0, 0, 0 } 
                })
            },
            { BoundryId.TodoBottom, new BoundryGlyph(BoundryId.TodoBottom, new byte[6, 6] { 
                    { 0, 0, 0, 0, 0, 0 }, 
                    { 0, 1, 0, 0, 0, 0 },
                    { 0, 1, 1, 1, 1, 0 }, 
                    { 0, 0, 1, 0, 0, 0 }, 
                    { 0, 1, 0, 0, 1, 0 }, 
                    { 0, 0, 0, 0, 0, 0 }  
                })
            },
            { BoundryId.DoingTop, new BoundryGlyph(BoundryId.DoingTop, new byte[6, 6] { 
                    { 0, 0, 0, 0, 0, 0 }, 
                    { 0, 0, 1, 0, 0, 0 },
                    { 0, 1, 0, 1, 1, 0 }, 
                    { 0, 0, 1, 0, 0, 0 }, 
                    { 0, 0, 0, 1, 1, 0 }, 
                    { 0, 0, 0, 0, 0, 0 }  
                })
            },
            { BoundryId.DoingBottom, new BoundryGlyph(BoundryId.DoingBottom, new byte[6, 6] { 
                    { 0, 0, 0, 0, 0, 0 }, 
                    { 0, 1, 0, 0, 1, 0 },
                    { 0, 1, 1, 1, 0, 0 }, 
                    { 0, 1, 0, 0, 0, 0 }, 
                    { 0, 0, 0, 0, 1, 0 }, 
                    { 0, 0, 0, 0, 0, 0 }  
                })
            },
            { BoundryId.TestTop, new BoundryGlyph(BoundryId.TestTop, new byte[6, 6] { 
                    { 0, 0, 0, 0, 0, 0 }, 
                    { 0, 1, 0, 1, 0, 0 },
                    { 0, 1, 0, 1, 1, 0 }, 
                    { 0, 0, 1, 1, 0, 0 }, 
                    { 0, 0, 1, 0, 1, 0 }, 
                    { 0, 0, 0, 0, 0, 0 } 
                })
            },
            { BoundryId.TestBottom, new BoundryGlyph(BoundryId.TestBottom, new byte[6, 6] { 
                    { 0, 0, 0, 0, 0, 0 }, 
                    { 0, 0, 0, 1, 1, 0 },
                    { 0, 1, 0, 0, 1, 0 }, 
                    { 0, 1, 0, 1, 0, 0 }, 
                    { 0, 0, 1, 1, 0, 0 }, 
                    { 0, 0, 0, 0, 0, 0 } 
                })
            },
            /*{ BoundryId., new BoundryGlyph(BoundryId., new byte[6, 6] { 
                    { 0, 0, 0, 0, 0, 0 }, 
                    { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }, 
                    { 0, 0, 0, 0, 0, 0 }, 
                    { 0, 0, 0, 0, 0, 0 }, 
                    { 0, 0, 0, 0, 0, 0 } 
                })
            },*/
        };

        public static Dictionary<BoundryId, BoundryGlyph> Glyphs { get { return glyphs; } }
    }
}
