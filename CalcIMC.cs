using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalcIMC
    {
        public void calcimc(decimal p, decimal h) {
            decimal value = Convert.ToDecimal(p / (h * h));

            if (value < Convert.ToDecimal(18.5)) { Console.WriteLine("Você encontra-se na categoria: MAGREZA"); }
            else if (value > Convert.ToDecimal(18.6) && value < Convert.ToDecimal(24.9)) { Console.WriteLine("Você encontra-se na categoria: PESO NORMAL"); }
            else if (value > Convert.ToDecimal(25) && value < Convert.ToDecimal(29.9)) { Console.WriteLine("Você encontra-se na categoria: SOBREPESO"); }
            else if (value > Convert.ToDecimal(30) && value < Convert.ToDecimal(34.9)) { Console.WriteLine("Você encontra-se na categoria: OBESIDADE DE GRAU I"); }
            else if (value > Convert.ToDecimal(35) && value < Convert.ToDecimal(39.9)) { Console.WriteLine("Você encontra-se na categoria: OBESIDADE DE GRAU II"); }
            else if (value > Convert.ToDecimal(40)) { Console.WriteLine("Você encontra-se na categoria: OBESIDADE DE GRAU III"); }
        }
    }
}
