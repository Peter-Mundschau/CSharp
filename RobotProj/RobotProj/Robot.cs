using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Create a Robot project that implements proper classes, functions, and inheritance
Robot class contains appropriate member variables and functions.
Create four child robot classes that inherit from Robot. 
These child classes must contain appropriate member variables and functions.
Must implement if statements, switch cases, for loop, foreach loop and while loop in some way, so be creative!
Create two more classes that represent a fleet of robots. 
(Hint: you will need lists). Have the ability to add robots to a fleet of robots. 
Implement user input
Ensure the program flows well when you run it. 
That means making the program interactive as well as exciting. For instance, have robots interact with each other (ex: fighting).
*/
namespace RobotProj
{
    public class Robot
    {
        public int speed;
        public int powerLevel;
        public int ammoLevel;
        public int health;
        public string name;


        Robot simpleRobot = new Robot();
        simpleRobot.speed = 100;
        simpleRobot.powerlevel = 100;
        simpleRobot.ammoLevel = 100;
        simpleRobot.health = 100;
        simpleRobot.name = "simpleRobot"
        


    }
}
