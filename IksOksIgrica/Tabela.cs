using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IksOksIgrica
{
    class Tabela
    {
        public Znak[] znakovi;
        Znak x = new Znak("X");
        Znak ox = new Znak("O");
        public bool IgraX = true;
        
        public void DodajUTabelu(int mesto)
        {
            if (IgraX)
            {
                znakovi[mesto] = x;
                IgraX = false;
            }
            else
            {
                znakovi[mesto] = ox;
                IgraX = true;
            }
        }

        public void MakeAMove(int position)
        {
            DodajUTabelu(position);
            Form1.self.Dugmici[position].Hide();
            Form1.self.OXPictures[position].Show();
            Form1.self.brojac++;
        }

        public void WeGotAWinner(int position)
        {
            Form1.self.brojac--;

            if(znakovi[position] != null)
            Form1.self.winnerLabel.Text = $"THE WINNER IS {znakovi[position].ToString()}!!";
        }

        public void DiagonalWinner()
        {
            if ((znakovi[2] == znakovi[4]) && znakovi[4] == znakovi[6] && znakovi[4] != null)
            {
                WeGotAWinner(4);
            }
            else if ((znakovi[0] == znakovi[4]) && znakovi[4] == znakovi[8] && znakovi[4] != null)
            {
                WeGotAWinner(4);
            }
        }

        public void HorizontalWinner()
        {
            if ((znakovi[0] == znakovi[1]) && znakovi[1] == znakovi[2] && znakovi[1] != null)
            {
                WeGotAWinner(0);
                Form1.self.prviRedPanel.Show();
            }
            else if ((znakovi[3] == znakovi[4]) && znakovi[4] == znakovi[5] && znakovi[4] != null)
            {
                WeGotAWinner(4);
                Form1.self.drugiRedPanel.Show();
            }
            else if ((znakovi[6] == znakovi[7]) && znakovi[7] == znakovi[8] && znakovi[7] != null)
            {
                WeGotAWinner(7);
                Form1.self.treciRedPanel.Show();
            }

        }

        public void VerticalWinner()
        {
            if ((znakovi[0] == znakovi[3]) && znakovi[3] == znakovi[6] && znakovi[3] != null)
            {
                WeGotAWinner(3);
                Form1.self.prvaKolonaPanel.Show();
            }
            else if((znakovi[1] == znakovi[4]) && znakovi[4] == znakovi[7] && znakovi[4] != null)
            {
                WeGotAWinner(4);
                Form1.self.drugaKolonaPanel.Show();
            }
            else if((znakovi[2] == znakovi[5]) && znakovi[5] == znakovi[8] && znakovi[5] != null)
            {
                WeGotAWinner(5);
                Form1.self.trecaKolonaPanel.Show();
            }
        }
        public bool DaLiJeX(int mesto)
        {
            if (znakovi[mesto] == x)
                return true;
            else
                return false;
        }
        public bool DaLiJeOX(int mesto)
        {
            if (znakovi[mesto] == ox)
                return true;
            else
                return false;
        }
        public Tabela()
        {
            znakovi = new Znak[9];
            Znak x = new Znak("X");
            Znak ox = new Znak("O");
        }

    }
}

