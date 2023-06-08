using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrialScrambel.Interface
{
    public interface ICoordinate
    {
        int X { get; }
        int Y { get; }
    }


    class Coordinate : ICoordinate
    {
        public int X { get; }
        public int Y { get; }

        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

}