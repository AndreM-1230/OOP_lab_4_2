using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLaba02
{
    class MendeleevClapeyronEquation : MCE
    {
        public double p, T, V, m, M;
        const double R = 8.31;
        public MendeleevClapeyronEquation(double _m, double _M)
        {
            m = _m;
            M = _M;
        }
        public override double CalculatePressure(double _V, double _T)
        {
            V = _V;
            T = _T;
            p = (m / M * R * T) / V;
            return (p);
        }

    }
}
