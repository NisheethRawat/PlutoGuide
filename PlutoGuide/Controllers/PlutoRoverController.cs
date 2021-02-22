using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PlutoGuide
{
    [ApiController]
    [Route("[controller]")]
    public class PlutoRoverController : ControllerBase
    {
        private readonly INavigate _navigate;
        private readonly IObstacleDetection _obstacleDetection;
        private readonly IValidateCommand _validateCommand;

        public PlutoRoverController(INavigate navigate, IObstacleDetection obstacleDetection, IValidateCommand validateCommand)
        {
            _navigate = navigate;
            _obstacleDetection = obstacleDetection;
            _validateCommand = validateCommand;
        }

        [HttpGet("GetPlutoRover")]
        public string GetPlutoRover() {
            return "Welcome to PlutoRover";
        }

        [HttpPost("MoveRoverRequest")]
        public string MoveRoverRequest([FromBody] string stgCommand)
        {
            string validation = string.Empty;
            _validateCommand.ValidateInputCommand(stgCommand);
            foreach (char command in stgCommand)
            {
                if (_obstacleDetection.DetectObstacle(command))
                    _navigate.EvaluateNavigation(command);
                else
                {
                    validation = string.Concat("Obstacle Detected. ");
                    break;
                }
            }

            return string.Concat(validation, "Rover Location : ", RoverPosition.xPosition, "/", RoverPosition.yPosition, "/", RoverPosition.direction);
        }
    }
}
