using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlutoGuide
{
    public static class RoverPosition
    {
        public static int xPosition { get; set; }
        public static int yPosition { get; set; }
        public static char direction { get; set; } = 'N';
        public static int gridSize { get { return 1000; } }
        public static Dictionary<int, int> obstacleLocation { get { return new Dictionary<int, int>() { { 3, 3 }, { 4, 4 }, { 5, 5 } }; } }
    }
}
