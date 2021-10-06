using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccidentReportLibrary
{
    public enum AccidentType
    {
        Collision = 0,
        Rollover = 1,
        HitObstacle = 2,
        HitPedestrian = 3,
        HitCyclist = 4,
        HitAnimal = 5,
        HitHorseDrawnVehicle = 6,
        CollisionWithStationaryVehicle = 7
    }
}
