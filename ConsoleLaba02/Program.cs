using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLaba02
{
    //1 variant
    public abstract class MCE
    {
        public abstract double CalculatePressure(double _V, double _T);
    }
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
    class Program
    {
        
        static void Main(string[] args)
        {
            int m, M, V = 50, T = 500;
            Console.WriteLine("Введите массу:");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите молярную массу:");
            M = Convert.ToInt32(Console.ReadLine());
            MendeleevClayperonEquationUsing Perfectgaz = new MendeleevClayperonEquationUsing(m, M);
            Console.WriteLine($"Значение давления: {Perfectgaz.CalculatePressure(V, T)} Па");
            Console.WriteLine($"Температура в градусах Цельсия: {Perfectgaz.TemperatureCelsius}");
            Console.ReadKey();
        }
    }
}
