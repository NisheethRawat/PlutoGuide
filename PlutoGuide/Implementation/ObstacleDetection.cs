using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlutoGuide
{
    public class ObstacleDetection : IObstacleDetection
    {
        int x, y;
        public bool DetectObstacle(char command)
        {
            switch (Char.ToUpper(command))
            {
                case 'F':
                    this.EvaluateForwardLocation();
                    break;
                case 'B':
                    this.EvaluateBackwardLocation();
                    break;
            }

            if (RoverPosition.obstacleLocation.Any(e => e.Key == x && e.Value == y))
                return false;
            else
                return true;
        }

        private void EvaluateForwardLocation()
        {
            switch (RoverPosition.direction)
            {
                case 'N':
                    y = (RoverPosition.yPosition + 1) >= RoverPosition.gridSize ? 0 : (RoverPosition.yPosition + 1);
                    break;
                case 'S':
                    y = (RoverPosition.yPosition - 1) < 0 ? (RoverPosition.gridSize - 1) : (RoverPosition.yPosition - 1);
                    break;
                case 'E':
                    x = (RoverPosition.xPosition + 1) >= RoverPosition.gridSize ? 0 : (RoverPosition.xPosition + 1);
                    break;
                case 'W':
                    x = (RoverPosition.xPosition - 1) < 0 ? (RoverPosition.gridSize - 1) : (RoverPosition.xPosition - 1);
                    break;
                default:
                    break;
            }
        }

        private void EvaluateBackwardLocation()
        {
            switch (RoverPosition.direction)
            {
                case 'N':
                    y = (RoverPosition.yPosition - 1) < 0 ? (RoverPosition.gridSize - 1) : (RoverPosition.yPosition - 1);
                    break;
                case 'S':
                    y = (RoverPosition.yPosition + 1) >= RoverPosition.gridSize ? 0 : (RoverPosition.yPosition + 1);
                    break;
                case 'E':
                    x = (RoverPosition.xPosition - 1) < 0 ? (RoverPosition.gridSize - 1) : (RoverPosition.xPosition - 1);
                    break;
                case 'W':
                    x = (RoverPosition.xPosition + 1) >= RoverPosition.gridSize ? 0 : (RoverPosition.xPosition + 1);
                    break;
                default:
                    break;
            }
        }
    }
}
