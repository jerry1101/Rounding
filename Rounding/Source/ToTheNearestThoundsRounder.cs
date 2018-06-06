using System;

namespace Rounding
{
    internal class ToTheNearestThoundsRounder : IRoundingCommand
    {
        double IRoundingCommand.roundDouble(double v) => Math.Round(v, 3);
    }
}