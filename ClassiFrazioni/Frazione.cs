using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassiFrazioni
{
    internal class Frazione : ICloneable
    {
        //attributi
        private int _numeratore;
        private int _denominatore;

        //costruttori
        public Frazione()
        {
            Numeratore = 0;
            Denominatore = 0;
        }
        public Frazione(int num, int den)
        {
            Numeratore = num;
            Denominatore = den;
        }
        public Frazione(Frazione frprec)
        {
            Numeratore = frprec.Numeratore;
            Denominatore = frprec.Denominatore;
        }

        //proprietà
        public int Numeratore
        {
            get { return _numeratore; }
            set { _numeratore = value; }
        }
        public int Denominatore
        {
            get { return _denominatore; }
            set 
            {
                if (value != 0)
                {
                    _denominatore = value;
                }
                else
                {
                    _denominatore = 0;
                }
            }
        }

        //metodo clone
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        //metodi
        public void Semplifica()
        {
            //MCD
            int n = 2;
            int i = 0;
            int[] arr = new int[10000000];
            int[] arr1 = new int[10000000];
            int MCD = 0;
            int num = this.Numeratore;
            int denom = this.Denominatore;
            while (num != 1)
            {
                while (num % n == 0)
                {
                    num = num / n;
                    arr[i] = n;
                    i++;
                }
                n++;
            }
            i = 0;
            while (denom != 1)
            {
                while (denom % n == 0)
                {
                    denom = denom / n;
                    arr1[i] = n;
                    i++;
                }
                n++;
            }
            //confronto scomposizioni
            for (int j = 0; j < 10; j++)
            {
                for (int k = 0; k < 10; k++)
                {
                    if (arr[j] == arr1[k] && MCD < arr[j])
                    {
                        MCD = arr[j];
                    }
                }
            }
            //semplificazione
            this.Numeratore = this.Numeratore / MCD;
            this.Denominatore = this.Denominatore / MCD;
        }
        public Frazione Somma(Frazione fr)
        {
            Frazione f = new Frazione();
            f.Denominatore = fr.Denominatore * this.Denominatore;
            f.Numeratore = fr.Numeratore * this.Denominatore + this.Numeratore * fr.Denominatore;
            return f;
        }

    }
}
