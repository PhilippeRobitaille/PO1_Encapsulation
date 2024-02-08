using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO1_Encapsulation
{
    public class Personnage
    {
        string nom;
        int pointDeVie;
        int pointsDePuissance;
        
        public string Nom { get => nom; }
        public int PointDeVie { get => pointDeVie;
            set
            {

                if (value < 0)
                {
                    pointDeVie = 0;
                }
                else
                {
                    pointDeVie = value;
                }
            }
        }
        public int PointsDePuissance { get => pointsDePuissance; set => pointsDePuissance = value; }

        public bool EstEnVie
        {
            get
            {
                if (pointDeVie > 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
