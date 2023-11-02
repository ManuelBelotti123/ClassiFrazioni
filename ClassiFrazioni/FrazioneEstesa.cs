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
        public FrazioneEstesa() : base()
        {
            Numeratore = 0;
            Denominatore = 0;
        }
        public FrazioneEstesa(int num, int den) : base(num, den)
        {
            Numeratore = num;
            Denominatore = den;
        }
        public FrazioneEstesa(FrazioneEstesa frprec) : base(frprec)
        {
            Numeratore = frprec.Numeratore;
            Denominatore = frprec.Denominatore;
        }
        //metodi overloading
        public FrazioneEstesa Semplifica(FrazioneEstesa fr)
        {
            int n = 2;
            while (fr.Numeratore > n || fr.Denominatore > n)
            {
                while (fr.Numeratore % n == 0 && fr.Denominatore % n == 0)
                {
                    fr.Numeratore = fr.Numeratore / n;
                    fr.Denominatore = fr.Denominatore / n;
                }
                n++;
            }
            if (fr.Numeratore == fr.Denominatore)
            {
                fr.Numeratore = 1;
                fr.Denominatore = 1;
            }
            return fr;
        }
        public FrazioneEstesa Somma(FrazioneEstesa fr)
        {
            FrazioneEstesa f = new FrazioneEstesa();
            f.Denominatore = fr.Denominatore * this.Denominatore;
            f.Numeratore = fr.Numeratore * this.Denominatore + this.Numeratore * fr.Denominatore;
            return f;
        }
        public FrazioneEstesa Sottrai(FrazioneEstesa fr)
        {
            FrazioneEstesa f = new FrazioneEstesa();
            f.Denominatore = fr.Denominatore * this.Denominatore;
            f.Numeratore = fr.Numeratore * this.Denominatore - this.Numeratore * fr.Denominatore;
            return f;
        }
        public FrazioneEstesa Moltiplica(FrazioneEstesa fr)
        {
            FrazioneEstesa f = new FrazioneEstesa();
            f.Denominatore = fr.Denominatore * this.Denominatore;
            f.Numeratore = fr.Numeratore * this.Numeratore;
            return f;
        }
        public FrazioneEstesa Dividi(FrazioneEstesa fr)
        {
            FrazioneEstesa f = new FrazioneEstesa();
            f.Denominatore = fr.Denominatore * this.Numeratore;
            f.Numeratore = fr.Numeratore * this.Denominatore;
            return f;
        }
        public string Formato(FrazioneEstesa fr)
        {
            return fr.Numeratore + "/" + fr.Denominatore;
        }

        //metodi aggiuntivi
        public double VDecimale(FrazioneEstesa fr)
        {
            double n = fr.Numeratore;
            double d = fr.Denominatore;
            return n / d;
        }
        public FrazioneEstesa VFrazione(double v)
        {
            FrazioneEstesa f = new FrazioneEstesa();
            string n = v.ToString();
            string[] div = n.Split(',');
            int len = div[1].Length;
            if (div[0] != "0")
            {
                div[1] = div[0] + div[1];
            }
            f.Numeratore = int.Parse(div[1]);
            string den = "1";
            for (int i = 0; i < len; i++)
            {
                den += "0";
            }
            f.Denominatore = int.Parse(den);
            return f;
        }
        public FrazioneEstesa Potenza(FrazioneEstesa fr, int esp)
        {
            FrazioneEstesa f = new FrazioneEstesa();
            f.Numeratore = fr.Numeratore ^ esp;
            f.Denominatore = fr.Denominatore ^ esp;
            return f;
        }

    }
}
