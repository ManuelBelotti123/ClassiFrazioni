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

        public Form1()
        {
            fr = new Frazione(3, 5);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frazione fr1 = new Frazione(4, 9);
            fr = fr.Somma(fr1);
            MessageBox.Show(fr.Numeratore.ToString() + fr.Denominatore.ToString(), "Avviso");
        }
    }
}
