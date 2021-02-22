using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlutoGuide
{
    public class Navigate : INavigate
    {
        public bool EvaluateNavigation(char command)
        {
            switch (Char.ToUpper(command))
            {
                case 'L':
                    this.Rotate90Left();
                    break;
                case 'R':
                    this.Rotate90Right();
                    break;
                case 'F':
                    this.MoveForward();
                    break;
                case 'B':
                    this.MoveBackward();
                    break;
            }
            return true;
        }

        private void Rotate90Left()
        {
            switch (RoverPosition.direction)
            {
                case 'N':
                    RoverPosition.direction = 'W';
                    break;
                case 'S':
                    RoverPosition.direction = 'E';
                    break;
                case 'E':
                    RoverPosition.direction = 'N';
                    break;
                case 'W':
                    RoverPosition.direction = 'S';
                    break;
                default:
                    break;
            }
        }

        private void Rotate90Right()
        {
            switch (RoverPosition.direction)
            {
                case 'N':
                    RoverPosition.direction = 'E';
                    break;
                case 'S':
                    RoverPosition.direction = 'W';
                    break;
                case 'E':
                    RoverPosition.direction = 'S';
                    break;
                case 'W':
                    RoverPosition.direction = 'N';
                    break;
                default:
                    break;
            }
        }

        private void MoveForward()
        {
            switch (RoverPosition.direction)
            {
                case 'N':
                    RoverPosition.yPosition = (RoverPosition.yPosition + 1) >= RoverPosition.gridSize ? 0 : (RoverPosition.yPosition + 1);
                    break;
                case 'S':
                    RoverPosition.yPosition = (RoverPosition.yPosition - 1) <0 ? (RoverPosition.gridSize - 1) : (RoverPosition.yPosition - 1);
                    break;
                case 'E':
                    RoverPosition.xPosition = (RoverPosition.xPosition + 1) >= RoverPosition.gridSize ? 0 : (RoverPosition.xPosition + 1);
                    break;
                case 'W':
                    RoverPosition.xPosition = (RoverPosition.xPosition - 1) < 0 ? (RoverPosition.gridSize - 1) : (RoverPosition.xPosition - 1);
                    break;
                default:
                    break;
            }
        }

        private void MoveBackward()
        {
            switch (RoverPosition.direction)
            {
                case 'N':
                    RoverPosition.yPosition = (RoverPosition.yPosition - 1) < 0 ? (RoverPosition.gridSize - 1) : (RoverPosition.yPosition - 1);
                    break;
                case 'S':
                    RoverPosition.yPosition = (RoverPosition.yPosition + 1) >= RoverPosition.gridSize ? 0 : (RoverPosition.yPosition + 1);
                    break;
                case 'E':
                    RoverPosition.xPosition = (RoverPosition.xPosition - 1) < 0 ? (RoverPosition.gridSize - 1) : (RoverPosition.xPosition - 1);
                    break;
                case 'W':
                    RoverPosition.xPosition = (RoverPosition.xPosition + 1) >= RoverPosition.gridSize ? 0 : (RoverPosition.xPosition + 1);
                    break;
                default:
                    break;
            }
        }

    }
}
