# PlutoGuide

The solution contains an API that will allow the Rover to move around the planet. The rover's position and location is represented by a combination of x and y coordinates and a letter representing one of the four cardinal compass points.

The only valid commands for the rover are ‘F’,’B’,’L’ and ‘R’. Command ‘F’, ’B’ move the rover forward and backward by one grid point, and must maintain the same heading. Command ‘L’, ’R’ turn the rover left and right by spinning rover by 90 degree without moving from its current spot.

Endpoint url - https://localhost:44374/PlutoRover/MoveRoverRequest

# Input:

Input to the API contains the command sequence string, ex. "FFRFF".

# Response

Response contains the string with x coordinate, y coordinate and the direction of the rover seperated by '/'. Sample output "Rover Location : 998/998/E". 

In case rover hits the obsticle response wil alert the user via response "Obstacle Detected.", along with the last rover position.

# Regarding project

1. At the project initiation the rover is set at 0,0 location facing north. After the startup the last location is stored in the static memory location and can be used for next API command.
2. Rover Position class stores the location of the rover. 
3. Navigate class is created to evaluate the next rover position.
4. ObstacleDetection class is created to throw obstacle response in case rover hits the obstacle location.
5. ValidateCommand class is used to validate the input command sequence. 
6. All the interfaces are injected to PlutoRoverController.cs.
7. Unit test cases are present on NUnitTestProject project.
8. Obstacle locations are stored in variable obstacleLocation in RoverPosition class.

# C# development skills show case
1. SOLID principles, Single responsibility principle, Interface design, Open closed principle.
2. Dependency Injection, C#, NUnit Test Framework
3. TDD, ability to write unit tests.