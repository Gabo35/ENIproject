using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02TP01
{
    public class Cercle : Forme
    {
        public int Rayon { get; set; }
         
        public override double Aire { get { return Rayon * Rayon * Math.PI; } }

        public override double Perimetre => 2 * Math.PI * Rayon;

        public override string ToString()
        {
            return $"Cercle de Rayon {Rayon}\n{base.ToString()}";
        }
    }
}
