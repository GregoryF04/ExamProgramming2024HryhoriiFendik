using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class ColourfulPoint : Point, IReflectable
    {
        public PointColour Colour { get; set; }

        public ColourfulPoint(decimal x, decimal y, PointColour colour) : base(x, y)
        {
            Colour = colour;
        }
        public void ChangeColour(PointColour newColour)
        {
            Colour = newColour;
        }
        public void NextColour()
        {
            Colour = (PointColour)(((int)Colour + 1) % 3);
        }
    }
}
