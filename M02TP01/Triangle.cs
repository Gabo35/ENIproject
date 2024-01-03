using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02TP01
{
    internal class Triangle : Forme
    {
        public int A { get; set; }
        public int B { get; set; }  
        public int C { get; set; }       

        public override double Aire => Math.Sqrt(p*(p-A)*(p-B)*(p-C));
        public override double Perimetre => A + B + C;
        private double p => Perimetre / 2;
        public override string ToString()
        {
            return $"Triangle de coté A={A}, B={B}, C={C}\n{base.ToString()}";
        }
    }
}
