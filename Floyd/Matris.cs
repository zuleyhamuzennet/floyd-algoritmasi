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
    public partial class Matris : Form
    {
        private int DugumSayisi;
        private TextBox[,] txtMatrisler;
        private Label[,] lblMatrisler;
        private Button btnOk;
        private int[,] matrisDeger;

        int maxVal = 99999999;
        public Matris()
        {
            InitializeComponent();
        }

        public Matris(int n)
        {
            this.DugumSayisi = n;
            InitializeComponent();
            txtMatrisler = new TextBox[DugumSayisi, DugumSayisi];
            lblMatrisler = new Label[DugumSayisi, DugumSayisi];
            Label[] lblSatirGoster = new Label[DugumSayisi];
            Label[] lblSutunGoster = new Label[DugumSayisi];
            int tabIndex = 0;
            for (int i = 0; i < DugumSayisi; i++)
            {
                for (int j = 0; j < DugumSayisi; j++)
                {
                    txtMatrisler[i, j] = new TextBox
                    {
                        Size = new Size(30, 30),
                        Location = new Point(50 + 35 * j, 35 + 35 * i),
                        TabIndex = tabIndex
                    };
                    this.pnlMatris.Controls.Add(txtMatrisler[i, j]);
                    if (i == 0)
                    {
                        lblSatirGoster[j] = new Label
                        {
                            Size = new Size(30, 20),
                            Text = ((char)('A' + (j))).ToString(),
                            Location = new Point(50 + 35 * j, 10 + 35 * i)
                        };
                        this.pnlMatris.Controls.Add(lblSatirGoster[j]);
                    }
                }
                lblSutunGoster[i] = new Label
                {
                    Size = new Size(20, 22),
                    Text = ((char)('A' + (i))).ToString(),
                    Location = new Point(20, 37 + 35 * i)
                };
                this.pnlMatris.Controls.Add(lblSutunGoster[i]);
            }

            btnOk = new Button
            {
                Size = new Size(100, 30),
                Text = "Matrisi Gönder",
                Location = new Point(200 + (35 * (DugumSayisi + 1)) / 2, 35 + (35 * (DugumSayisi + 1) / 2))
            };
            btnOk.Click += BtnOk_Click;
            this.pnlMatris.Controls.Add(btnOk);
        }

        public Matris(int[,] sonuc)
        {
            InitializeComponent();

            this.DugumSayisi = sonuc.GetLength(0);
            txtMatrisler = new TextBox[DugumSayisi, DugumSayisi];
            lblMatrisler = new Label[DugumSayisi, DugumSayisi];
            Label[] lblSatirGoster = new Label[DugumSayisi];
            Label[] lblSutunGoster = new Label[DugumSayisi];
            int tabIndex = 0;
            for (int i = 0; i < DugumSayisi; i++)
            {
                for (int j = 0; j < DugumSayisi; j++)
                {
                    txtMatrisler[i, j] = new TextBox
                    {
                        Size = new Size(30, 30),
                        Location = new Point(50 + 35 * j, 35 + 35 * i),
                        TabIndex = tabIndex,
                        Text = sonuc[i, j].ToString(),
                        ReadOnly = true
                    };
                    if (sonuc[i, j] == maxVal)
                    {
                        txtMatrisler[i, j].Text = "SON";
                    }
                    this.pnlMatris.Controls.Add(txtMatrisler[i, j]);
                    if (i == 0)
                    {
                        lblSatirGoster[j] = new Label
                        {
                            Size = new Size(30, 20),
                            Text = ((char)('A' + (j))).ToString(),
                            Location = new Point(50 + 35 * j, 10 + 35 * i)
                        };
                        this.pnlMatris.Controls.Add(lblSatirGoster[j]);
                    }
                }
                lblSutunGoster[i] = new Label
                {
                    Size = new Size(20, 22),
                    Text = ((char)('A' + (i))).ToString(),
                    Location = new Point(20, 37 + 35 * i)
                };
                this.pnlMatris.Controls.Add(lblSutunGoster[i]);
            }
        }

        private void Matris_Load(object sender, EventArgs e)
        {
            
        }
        private void BtnOk_Click(object sender, EventArgs e)
        {
            matrisDeger = new int[DugumSayisi, DugumSayisi];
            for (int i = 0; i < DugumSayisi; i++)
                for (int j = 0; j < DugumSayisi; j++)
                {
                    if (!int.TryParse(txtMatrisler[i, j].Text, out matrisDeger[i, j]))
                    {
                        MessageBox.Show("Değer boş veya tamsayı girilmemiş!");
                        return;
                    }
                    else if (matrisDeger[i, j] == -1)
                    {
                        matrisDeger[i, j] = maxVal;//int.MaxValue;
                    }
                    else if(matrisDeger[i,j] < -1)
                    {
                        MessageBox.Show("Negatif değer giremezsiniz!");
                        return;
                    }
                }
            

            Form1 xd = Application.OpenForms[0] as Form1;
            xd.SetMatrix(matrisDeger);

            this.Dispose();
        }
    }
}
