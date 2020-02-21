using System;
using System.Collections.Generic;
using System.Text;

namespace NasaMarsRover.Concrat
{
    public class RoverMotion : IRover
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Direction Direction { get; private set; }
        public void DirectionSet(string _d)
        {
            Direction = _d.ToUpper() switch
            {
                "N" => Direction.North,
                "S" => Direction.South,
                "E" => Direction.East,
                "W" => Direction.West,
                _ => Direction
            };
        }


        public void Moving(string moves)
        {
            foreach (var move in moves)
            {
                switch (move)
                {
                    case 'M':
                        this.GoStraight();
                        break;
                    case 'L':
                        this.TurnLeft();
                        break;
                    case 'R':
                        this.TurnRight();
                        break;
                    default:
                        throw new Exception("Wrong Step");
                }
            }

        }

        public string LastPosition() => $"{X} {Y} {this.Direction.ToString().Substring(0, 1)}  =>  ( X: {X} - Y: {Y} - Direction: {this.Direction})";

        private void TurnLeft()
        {
            this.Direction = this.Direction switch
            {
                Direction.North => Direction.West,
                Direction.South => Direction.East,
                Direction.East => Direction.North,
                Direction.West => Direction.South,
                _ => this.Direction
            };
        }

        private void TurnRight()
        {
            this.Direction = this.Direction switch
            {
                Direction.North => Direction.East,
                Direction.South => Direction.West,
                Direction.East => Direction.South,
                Direction.West => Direction.North,
                _ => this.Direction
            };
        }

        private void GoStraight()
        {
            switch (this.Direction)
            {
                case Direction.North:
                    Y += 1;
                    break;
                case Direction.South:
                    Y -= 1;
                    break;
                case Direction.East:
                    X += 1;
                    break;
                case Direction.West:
                    X -= 1;
                    break;
            }
        }


    }
}
