using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassiFrazioni
{
    public partial class Form1 : Form
    {
        Frazione fr;
        Frazione fr1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sempl_Click(object sender, EventArgs e)
        {
            fr = new Frazione(int.Parse(num1.Text), int.Parse(den1.Text));
            fr = fr.Semplifica(fr);
            ristext.Text = fr.Formato(fr);
        }

        private void somm_Click(object sender, EventArgs e)
        {
            fr = new Frazione(int.Parse(num1.Text), int.Parse(den1.Text));
            fr1 = new Frazione(int.Parse(num2.Text), int.Parse(den2.Text));
            fr = fr.Semplifica(fr.Somma(fr1));
            ristext.Text = fr.Formato(fr);
        }

        private void sottr_Click(object sender, EventArgs e)
        {
            fr = new Frazione(int.Parse(num1.Text), int.Parse(den1.Text));
            fr1 = new Frazione(int.Parse(num2.Text), int.Parse(den2.Text));
            fr = fr.Semplifica(fr.Sottrai(fr1));
            ristext.Text = fr.Formato(fr);
        }

        private void molt_Click(object sender, EventArgs e)
        {
            fr = new Frazione(int.Parse(num1.Text), int.Parse(den1.Text));
            fr1 = new Frazione(int.Parse(num2.Text), int.Parse(den2.Text));
            fr = fr.Semplifica(fr.Moltiplica(fr1));
            ristext.Text = fr.Formato(fr);
        }

        private void divisione_Click(object sender, EventArgs e)
        {
            fr = new Frazione(int.Parse(num1.Text), int.Parse(den1.Text));
            fr1 = new Frazione(int.Parse(num2.Text), int.Parse(den2.Text));
            fr = fr.Semplifica(fr.Dividi(fr1));
            ristext.Text = fr.Formato(fr);
        }
    }
}
