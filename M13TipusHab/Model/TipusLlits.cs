using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M13TipusHab.Model
{
    // Clase de tipos de camas
    public class TipusLlits
    {
        String nom;
        public short llitsI;
        public short llitsD;

        public TipusLlits(short? opcio)
        {
            switch (opcio)
            {
                case 0:
                    this.nom = "1I";
                    this.llitsI = 1;
                    this.llitsD = 0;
                    break;
                case 1:
                    this.nom = "2I";
                    this.llitsI = 2;
                    this.llitsD = 0;
                    break;
                case 2:
                    this.nom = "2D";
                    this.llitsI = 0;
                    this.llitsD = 1;
                    break;
                case 3:
                    this.nom = "3I";
                    this.llitsI = 3;
                    this.llitsD = 0;
                    break;
                case 4:
                    this.nom = "3D";
                    this.llitsI = 1;
                    this.llitsD = 1;
                    break;
            }
        }
        public override string ToString()
        {
            return nom;
        }


    }
}
