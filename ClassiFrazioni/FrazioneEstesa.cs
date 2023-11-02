using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassiFrazioni
{
    internal class FrazioneEstesa : Frazione
    {
        //costruttori
        public FrazioneEstesa()
        {
            base.Numeratore = 0;
            base.Denominatore = 0;
        }
        public FrazioneEstesa(int num, int den)
        {
            base.Numeratore = num;
            base.Denominatore = den;
        }
        public FrazioneEstesa(FrazioneEstesa frprec)
        {
            base.Numeratore = frprec.Numeratore;
            base.Denominatore = frprec.Denominatore;
        }

        //metodi aggiuntivi
        public double VDecimale(FrazioneEstesa fr)
        {
            return fr.Numeratore / fr.Denominatore;
        }


    }
}
