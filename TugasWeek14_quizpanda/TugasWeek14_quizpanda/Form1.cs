using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasWeek14_quizpanda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxKalimat_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void buttonKonversi_Click(object sender, EventArgs e)
        {
            textBoxKalimat.CharacterCasing = CharacterCasing.Upper;
            int jumlahhuruf = textBoxKalimat.TextLength;
            char[] input = textBoxKalimat.Text.ToCharArray();

            char[] hurufawal = textBoxHuruf.Text.ToCharArray();
            char val = hurufawal[0];
            
            
            char[] hurufmenjadi = textBoxMenjadi.Text.ToCharArray();
            char val1 = hurufmenjadi[0];
            
            int selisih1 = val1 - val;
            if (selisih1 < 0)
            {
                selisih1 += 26;
            }

            string alfa = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] alpha = alfa.ToCharArray();
            string tikus = String.Empty;
            for (int k = 0; k < jumlahhuruf;k++)
            {
                for (int j = 0; j < 26;j++)
                {
                    if (alpha[j] == input[k])
                    {
                        int tambah = j + selisih1;
                        if (tambah >= 26)
                        {
                            tambah -= 26;
                        }
                        input[k] = alpha[tambah];
                        tikus += input[k];
                        input[k] = 'a';
                    }
                    else if (input[k] == ' ')
                    {
                        tikus += " ";
                        input[k] = 'a';
                    }
                }
            }
            labelOutput.Text = tikus;
        }

        private void labelOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
