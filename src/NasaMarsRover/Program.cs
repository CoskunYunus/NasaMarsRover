using System;
using System.Collections.Generic;
using System.Text;
using NasaMarsRover.Concrat;

namespace NasaMarsRover
{
    public static class Program
    {

        static void Main(string[] args /**/)
        {
            var _roverMotion = new Provider<RoverMotion>().CreateRoverMoving;

            var _example1 = "1 2 N";
            var _exampleMov1 = "LMLMLMLMM";
            var _example2 = "3 3 E";
            var _exampleMove2 = "MMRMMRMRRM";

            _roverMotion.MoveStarting(_example1, _exampleMov1);
            _roverMotion.MoveStarting(_example2, _exampleMove2);

            Console.Write("Inpu Position:");
            var _customExamPosition = Console.ReadLine();
            Console.Write("Inpu Motion:");
            var _customExamMove = Console.ReadLine();
            _roverMotion.MoveStarting(_customExamPosition, _customExamMove);



            Console.ReadLine();
        }


        static void MoveStarting(this IRover rover, string position, string mov)
        {
            var splitMovingData = position.Split(' ');

            if (splitMovingData.Length != 3)
                throw new Exception("Wrong Parameter Entry");

            rover.X = Convert.ToInt32(splitMovingData[0]);
            rover.Y = Convert.ToInt32(splitMovingData[1]); ;
            rover.DirectionSet(splitMovingData[2]);
            rover.Moving(mov);


            Console.WriteLine($"Input: =>{position} {mov}");
            Console.WriteLine("Output::");
            Console.WriteLine(rover.LastPosition());
            Console.WriteLine("__________________________________________");
        }


    }
}
