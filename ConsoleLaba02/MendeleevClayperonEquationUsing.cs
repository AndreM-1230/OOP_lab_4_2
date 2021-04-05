using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLaba02
{
    class MendeleevClayperonEquationUsing : MendeleevClapeyronEquation
    {
        public MendeleevClayperonEquationUsing(int _m, int _M) : base(_m, _M)
        {
        }
        public double TemperatureKelvin
        {
            get
            {
                return T;
            }
        }
        public double TemperatureCelsius
        {
            get
            {
                return (T - 273);
            }
        }


    }
}
