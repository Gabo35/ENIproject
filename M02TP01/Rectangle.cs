using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02TP01
{    internal class Rectangle : Forme
    {
        public int Longueur { get; set; }
        public virtual int Largeur { get; set; }

        public override double Aire => Longueur * Largeur;

        public override double Perimetre => 2 * ( Longueur + Largeur);

        public override string ToString()
        {
            return $"Rectangle de longueur ={Longueur} et largeur={Largeur}\n{base.ToString()}";
        }
    }
}
