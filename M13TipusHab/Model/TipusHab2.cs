using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace M13TipusHab.Model
{
    // Clase de tipo de habitación
    public partial class TipusHab
    {

        public TipusHab(TipusLlits tLlits, string tipusBalco, bool teBanyera)
        {
            llitsInd = tLlits.llitsI;
            llitsDob = tLlits.llitsD;
            this.qntPersones = (short)(llitsDob * 2 + llitsInd);
            this.tipusBalco = tipusBalco;
            if (teBanyera) { this.teBanyera = 1; }
            else { this.teBanyera = 0; }
            if(teBanyera) nom = tLlits.ToString()+"."+tipusBalco+".bany";
            else nom = tLlits.ToString()+"."+tipusBalco+".dutx";
        }

        public override string ToString()
        {
            return this.nom + " " + this.llitsInd + " " + this.llitsDob + " " + this.qntPersones + " " + this.tipusBalco + " " + this.teBanyera;
        }
    }
}