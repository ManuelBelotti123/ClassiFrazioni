﻿using System;
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
            while(this.Numeratore > n && this.Denominatore > n)
            {
                while (this.Numeratore % n == 0 && this.Denominatore % n == 0)
                {
                    this.Numeratore = this.Numeratore / n;
                    this.Denominatore = this.Denominatore / n;
                }
                n++;
            }
        }
        public Frazione Somma(Frazione fr)
        {
            Frazione f = new Frazione();
            f.Denominatore = fr.Denominatore * this.Denominatore;
            f.Numeratore = fr.Numeratore * this.Denominatore + this.Numeratore * fr.Denominatore;
            return f;
        }
        public Frazione Sottrai(Frazione fr)
        {
            Frazione f = new Frazione();
            f.Denominatore = fr.Denominatore * this.Denominatore;
            f.Numeratore = fr.Numeratore * this.Denominatore - this.Numeratore * fr.Denominatore;
            return f;
        }
        public Frazione Moltiplica(Frazione fr)
        {
            Frazione f = new Frazione();
            f.Denominatore = fr.Denominatore * this.Denominatore;
            f.Numeratore = fr.Numeratore * this.Numeratore;
            return f;
        }
        public Frazione Dividi(Frazione fr)
        {
            Frazione f = new Frazione();
            f.Denominatore = fr.Denominatore * this.Numeratore;
            f.Numeratore = fr.Numeratore * this.Denominatore;
            return f;
        }
        public string Formato(Frazione fr)
        {
            return fr.Numeratore + "/" + fr.Denominatore;
        }
    }
}