using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlutoGuide
{
    public interface IObstacleDetection
    {
        bool DetectObstacle(char command);
    }
}
