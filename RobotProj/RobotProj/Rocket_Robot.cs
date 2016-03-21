using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotProj
{
    public class Rocket_Robot : Robot
    {
        public string rocketLauncher;
        public int rocketDamage;

        Robot Rocket_Robot = new Robot();
        Rocket_Robot.speed = 100;
        Rocket_Robot.powerlevel = 100;
        Rocket_Robot.ammoLevel = 100;
        Rocket_Robot.health = 100;
        Rocket_Robot.name = "Rocket_Robot";
    }
}
