using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02TP01
{
    internal class Carre : Rectangle
    {
        public override int Largeur { get => base.Longueur; set => base.Longueur = value; }

        public override string ToString()
        {
            return $"Carré de côté ={Largeur}\n{base.ToString()}";
        }
    }
}
