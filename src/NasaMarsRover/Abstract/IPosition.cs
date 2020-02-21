using System;
using System.Collections.Generic;
using System.Text;

namespace NasaMarsRover
{
    public interface IPosition
    {
        int X { get; set; }
        int Y { get; set; }
        Direction Direction { get; }
        void DirectionSet(string _d);
    }
}
