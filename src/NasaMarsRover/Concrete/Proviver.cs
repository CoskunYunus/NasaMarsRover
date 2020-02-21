using System;
using System.Collections.Generic;
using System.Text;

namespace NasaMarsRover
{
    public class Provider<T> where T : IRover, new()
    {
        public IRover CreateRoverMoving = new T();
    }
}
