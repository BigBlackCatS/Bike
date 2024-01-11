using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public enum BikeComponentType
    {
        Frame,
        Wheel,
        Colour,
        Fork,
        RearShock,
        HeadSet,
        HandleBars, // Part that connects a frame with a fork and contains a bearing
        Stem, // A coonector between the handlebars and a fork
        HandleBarGrips, // The gum items intended for the handle bars
        Saddle,
        Brakes,
        Crankset, // A set of the chainrings ans a crank
        Pedals,
        Chain,
        Tube,
        GearShifters
    }
}
