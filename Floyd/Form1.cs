using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Floyd
{
    public partial class Form1 : Form
    {
        int[,] matrix;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDugumSayisi.Text, out int n))
            {
                if (n > 1)
                {
                    Matris matris = new Matris(n);
                    matris.ShowDialog();
                }
                else
                    MessageBox.Show("Düğüm sayısı 1 den büyük olmalıdır!");
            }
            else
                MessageBox.Show("Tamsayı değeri girmelisiniz!");
            
        }

        internal void SetMatrix(int[,] matrisDeger)
        {
            matrix = matrisDeger;
            btnHesapla.Enabled = true;
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int xDim = matrix.GetLength(0);
            int[,] hesap = new int[xDim, xDim];

            for (int i = 0; i < xDim; ++i)
                for (int j = 0; j < xDim; ++j)
                    hesap[i, j] = matrix[i, j];
            
            for (int k = 0; k < xDim; ++k)
            {
                for (int i = 0; i < xDim; ++i)
                {
                    for (int j = 0; j < xDim; ++j)
                    {
                        if (hesap[i, k] + hesap[k, j] < hesap[i, j])
                            hesap[i, j] = hesap[i, k] + hesap[k, j];
                    }
                }
            }
            Matris matris = new Matris(hesap);
            matris.ShowDialog();
        }
        
    }
}
