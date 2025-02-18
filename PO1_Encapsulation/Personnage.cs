using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO1_Encapsulation
{
    public class Personnage
    {
      private int pointDeVie;
      private int attaque;
        private int pointDeVieMaximal;

        public int PointDeVie { get => pointDeVie; 
            set {
                if (value < 0)
                {
                    pointDeVie = 0;
                }
                else if (value > pointDeVieMaximal)
                {
                    pointDeVie = pointDeVieMaximal;
                }
                else
                {
                    pointDeVie = value;
                }
            }
        }
        public int Attaque { get => attaque; set => attaque = value; }

        public bool EstMort 
        {
            get
            {
                if (pointDeVie == 0)
                {
                    return true;
                }
                
                else
                {
                    return false;
                }
            }
            
        }

        public int PointDeVieMaximal { get => pointDeVieMaximal; set => pointDeVieMaximal = value; }
    }
}
