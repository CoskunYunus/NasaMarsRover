using System;
using System.Collections.Generic;
using System.Text;

namespace NasaMarsRover
{
    public interface IRover : IPosition
    {
        void Moving(string moves);
        string LastPosition();
    }

}
