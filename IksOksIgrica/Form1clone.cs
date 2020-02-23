using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IksOksIgrica
{
    public partial class Form1 : Form
    {
        //Znak x = new Znak("X");
        //Znak ox = new Znak("O");
        Tabela glavna = new Tabela();
        private int brojac = 0;
        List<Button> Dugmici = new List<Button>();
        List<PictureBox> XPictures = new List<PictureBox>();
        List<PictureBox> OXPictures = new List<PictureBox>();
        List<Panel> paneliKojiPovezuju = new List<Panel>();


        public Form1()
        {
            InitializeComponent();
            NapuniListuDugmica();
            NapuniXeve();
            NapuniOXeve();
            NapuniListuPanela();

        }

        public void HorizontalniPobednik(int r, int n)
        {
            if ((glavna.znakovi[r] == glavna.znakovi[n]) && glavna.znakovi[n] == glavna.znakovi[++r])
            {
                brojac--;
                winnerLabel.Text = $"THE WINNER IS {glavna.znakovi[n].ToString()}!!";
                if (n == 2)
                    prviRedPanel.Show();

                else if (n == 5)
                    drugiRedPanel.Show();

                else if (n == 8)
                    treciRedPanel.Show();


            }
        }
        public void VertikalniPobednik(int r, int n)
        {
            if ((glavna.znakovi[r] == glavna.znakovi[n]) && glavna.znakovi[n] == glavna.znakovi[r + 3])
            {
                brojac--;
                winnerLabel.Text = $"THE WINNER IS {glavna.znakovi[n].ToString()}!!";

                if (n == 6)
                    prvaKolonaPanel.Show();
                else if (n == 7)
                    drugaKolonaPanel.Show();
                else if (n == 8 && r == 2)
                    trecaKolonaPanel.Show();
            }
        }

        public void DijagonalniPobednik1(int r, int n)
        {
            if ((glavna.znakovi[r] == glavna.znakovi[n]) && glavna.znakovi[n] == glavna.znakovi[4])
            {
                brojac--;
                winnerLabel.Text = $"THE WINNER IS {glavna.znakovi[n].ToString()}!!";
            }
        }

        public void DijagonalniPobednik2(int r, int n)
        {
            if ((glavna.znakovi[r] == glavna.znakovi[n]) && glavna.znakovi[n] == glavna.znakovi[r + 2])
            {
                brojac--;
                winnerLabel.Text = $"THE WINNER IS {glavna.znakovi[n].ToString()}!!";
            }
        }


        private void nula_Click(object sender, EventArgs e)
        {
            if (winnerLabel.Text.Length < 1)
            {
                nula.Hide();
                if (glavna.IgraX)
                {
                    xPB0.Show();
                }
                else
                {
                    oxPB0.Show();
                }
                glavna.DodajUTabelu(0);

                HorizontalniPobednik(0, 2);
                VertikalniPobednik(0, 6);
                DijagonalniPobednik1(0, 8);
                brojac++;
            }
            else
            {
                MessageBox.Show("Nice try. Game is over!!");
            }
            if (brojac == 9)
                winnerLabel.Text = "TIE";

        }

        private void jedan_Click(object sender, EventArgs e)
        {
            if (winnerLabel.Text.Length < 1)
            {
                jedan.Hide();
                if (glavna.IgraX)
                {
                    xPB1.Show();
                }
                else
                {
                    oxPB1.Show();
                }
                glavna.DodajUTabelu(1);
                HorizontalniPobednik(0, 2);
                VertikalniPobednik(1, 7);
                brojac++;
            }
            else
            {
                MessageBox.Show("Nice try. Game is over!!");
            }
            if (brojac == 9)
                winnerLabel.Text = "TIE";
        }

        private void dva_Click(object sender, EventArgs e)
        {
            if (winnerLabel.Text.Length < 1)
            {
                dva.Hide();
                if (glavna.IgraX)
                {
                    xPB2.Show();
                }
                else
                {
                    oxPB2.Show();
                }
                glavna.DodajUTabelu(2);
                HorizontalniPobednik(0, 2);
                VertikalniPobednik(2, 8);
                DijagonalniPobednik2(2, 6);
                brojac++;
            }
            else
            {
                MessageBox.Show("Nice try. Game is over!!");
            }
            if (brojac == 9)
                winnerLabel.Text = "TIE";
        }

        private void tri_Click(object sender, EventArgs e)
        {
            if (winnerLabel.Text.Length < 1)
            {
                tri.Hide();
                if (glavna.IgraX)
                {
                    xPB3.Show();
                }
                else
                {
                    oxPB3.Show();
                }
                glavna.DodajUTabelu(3);
                HorizontalniPobednik(3, 5);
                VertikalniPobednik(0, 6);
                brojac++;
            }
            else
            {
                MessageBox.Show("Nice try. Game is over!!");
            }
            if (brojac == 9)
                winnerLabel.Text = "TIE";
        }

        private void cetiri_Click(object sender, EventArgs e)
        {
            if (winnerLabel.Text.Length < 1)
            {
                cetiri.Hide();
                if (glavna.IgraX)
                {
                    xPB4.Show();
                }
                else
                {
                    oxPB4.Show();
                }
                glavna.DodajUTabelu(4);
                HorizontalniPobednik(3, 5);
                VertikalniPobednik(1, 7);
                DijagonalniPobednik1(0, 8);
                DijagonalniPobednik2(2, 6);
                brojac++;
            }
            else
            {
                MessageBox.Show("Nice try. Game is over!!");
            }
            if (brojac == 9)
                winnerLabel.Text = "TIE";
        }

        private void pet_Click(object sender, EventArgs e)
        {
            if (winnerLabel.Text.Length < 1)
            {
                pet.Hide();
                if (glavna.IgraX)
                {
                    xPB5.Show();
                }
                else
                {
                    oxPB5.Show();
                }
                glavna.DodajUTabelu(5);
                HorizontalniPobednik(3, 5);
                VertikalniPobednik(2, 8);
                brojac++;
            }
            else
            {
                MessageBox.Show("Nice try. Game is over!!");
            }
            if (brojac == 9)
                winnerLabel.Text = "TIE";
        }

        private void sest_Click(object sender, EventArgs e)
        {
            if (winnerLabel.Text.Length < 1)
            {
                sest.Hide();
                if (glavna.IgraX)
                {
                    xPB6.Show();
                }
                else
                {
                    oxPB6.Show();
                }
                glavna.DodajUTabelu(6);
                HorizontalniPobednik(6, 8);
                VertikalniPobednik(0, 6);
                DijagonalniPobednik2(2, 6);
                brojac++;
            }
            else
            {
                MessageBox.Show("Nice try. Game is over!!");
            }
            if (brojac == 9)
                winnerLabel.Text = "TIE";
        }

        private void sedam_Click(object sender, EventArgs e)
        {
            if (winnerLabel.Text.Length < 1)
            {
                sedam.Hide();
                if (glavna.IgraX)
                {
                    xPB7.Show();
                }
                else
                {
                    oxPB7.Show();
                }
                glavna.DodajUTabelu(7);
                HorizontalniPobednik(6, 8);
                VertikalniPobednik(1, 7);
                brojac++;
            }
            else
            {
                MessageBox.Show("Nice try. Game is over!!");
            }
            if (brojac == 9)
                winnerLabel.Text = "TIE";
        }

        private void osam_Click(object sender, EventArgs e)
        {
            if (winnerLabel.Text.Length < 1)
            {
                osam.Hide();
                if (glavna.IgraX)
                {
                    xPB8.Show();
                }
                else
                {
                    oxPB8.Show();
                }
                glavna.DodajUTabelu(8);
                HorizontalniPobednik(6, 8);
                VertikalniPobednik(2, 8);
                DijagonalniPobednik1(0, 8);
                brojac++;
            }
            else
            {
                MessageBox.Show("Nice try. Game is over!!");
            }
            if (brojac == 9)
                winnerLabel.Text = "TIE";

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            brojac = 0;
            glavna.IgraX = true;
            winnerLabel.Text = null;
            for (int i = 0; i < 9; i++)
            { 
                glavna.znakovi[i] = null;
            }
           
            foreach(var i in Dugmici)
            {
                if (!i.Visible)
                    i.Show();
            }

            foreach(var i in XPictures)
            {
                if (i.Visible)
                    i.Hide();
            }

            foreach(var i in OXPictures)
            {
                if (i.Visible)
                    i.Hide();
            }

            foreach(var i in paneliKojiPovezuju)
            {
                if (i.Visible)
                    i.Hide();
            }

            

        }

        private void NapuniListuDugmica()
        {
            Dugmici.Add(nula);
            Dugmici.Add(jedan);
            Dugmici.Add(dva);
            Dugmici.Add(tri);
            Dugmici.Add(cetiri);
            Dugmici.Add(pet);
            Dugmici.Add(sest);
            Dugmici.Add(sedam);
            Dugmici.Add(osam);

        }

        private void NapuniXeve()
        {
            XPictures.Add(xPB0);
            XPictures.Add(xPB1);
            XPictures.Add(xPB2);
            XPictures.Add(xPB3);
            XPictures.Add(xPB4);
            XPictures.Add(xPB5);
            XPictures.Add(xPB6);
            XPictures.Add(xPB7);
            XPictures.Add(xPB8);
        }

        private void NapuniOXeve()
        {
            OXPictures.Add(oxPB0);
            OXPictures.Add(oxPB1);
            OXPictures.Add(oxPB2);
            OXPictures.Add(oxPB3);
            OXPictures.Add(oxPB4);
            OXPictures.Add(oxPB5);
            OXPictures.Add(oxPB6);
            OXPictures.Add(oxPB7);
            OXPictures.Add(oxPB8);
        }

        private void NapuniListuPanela()
        {
            paneliKojiPovezuju.Add(prviRedPanel);
            paneliKojiPovezuju.Add(drugiRedPanel);
            paneliKojiPovezuju.Add(treciRedPanel);
            paneliKojiPovezuju.Add(prvaKolonaPanel);
            paneliKojiPovezuju.Add(drugaKolonaPanel);
            paneliKojiPovezuju.Add(trecaKolonaPanel);

        }
    }
}

