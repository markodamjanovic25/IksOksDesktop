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

        Tabela glavna = new Tabela();
        public int brojac = 0;
        private int brojacElemenata = 0;
        public Button[] Dugmici = new Button[9];
        public PictureBox[] XPictures = new PictureBox[9];
        public PictureBox[] OXPictures = new PictureBox[9];
        public Panel[] paneliKojiPovezuju = new Panel[9];
        private bool PvP = true;
        private bool PvAI = false;
        public static Form1 self;

        public Form1()
        {
            InitializeComponent();
            NapuniListuDugmica();
            NapuniXeve();
            NapuniOXeve();
            NapuniListuPanela();
            self = this;
        }


        private void nula_Click(object sender, EventArgs e)
        {

            if (winnerLabel.Text.Length < 1)
            {
                if (PvP)
                {

                    nula.Hide();
                    if (glavna.IgraX)
                    {
                        xPB0.Show();
                    }
                    else if (!glavna.IgraX)
                    {
                        oxPB0.Show();
                    }
                    glavna.DodajUTabelu(0);
                }
                else if (PvAI)
                {
                    nula.Hide();
                    xPB0.Show();
                    glavna.DodajUTabelu(0);
                    for (int i = 0; i < 9; i++)
                    {
                        if (glavna.znakovi[i] != null)
                            brojacElemenata++;
                    }
                    if (brojacElemenata == 1)
                    {
                        glavna.MakeAMove(4);

                    }

                    else if (brojacElemenata == 4 && glavna.DaLiJeX(1))
                    {
                        glavna.MakeAMove(2);
                    }

                    else if (brojacElemenata == 4 && glavna.DaLiJeX(3))
                    {
                        glavna.MakeAMove(6);
                    }

                    else if (brojacElemenata == 4 && glavna.DaLiJeX(2))
                    {
                        glavna.MakeAMove(1); 
                    }

                    else if (brojacElemenata == 4 && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(1);                       
                    }

                    else if (brojacElemenata == 4 && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(3);
                    }

                    else if (brojacElemenata == 4 && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(6);
                    }
                    else if (brojacElemenata == 4 && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(3);                       
                    }

                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(6);                      
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(5);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(5);                   
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(6);                       
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(2) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(1); 
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(2) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(5);                     
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(2) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(1);                      
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(2) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(3);                       
                    }
                    if (brojacElemenata == 9 && glavna.DaLiJeX(6) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(1);                      
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(6) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(3);                      
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(6) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(1);                       
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(8) && glavna.DaLiJeX(3))
                    {
                        glavna.MakeAMove(2);                        
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(8) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(6);                       
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(8) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(2);                                              
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(3) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(1);                      
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(3) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(2);                       
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(5) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(2);                       
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(1) && glavna.DaLiJeX(6) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(3);                       
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(2) && glavna.DaLiJeX(5) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(1);                       
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(2) && glavna.DaLiJeX(3) && glavna.DaLiJeX(8) && glavna.DaLiJeOX(6) == false)
                    {
                        glavna.MakeAMove(7);                       
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(6) && glavna.DaLiJeX(1) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(3);                        
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(6) && glavna.DaLiJeX(1) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(5);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(8) && glavna.DaLiJeX(2) && glavna.DaLiJeX(3) && glavna.DaLiJeOX(6))
                    {
                        glavna.MakeAMove(1);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(2) && glavna.DaLiJeX(7) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(3);                        
                    }
                    if (brojacElemenata == 16 && glavna.DaLiJeX(1) && glavna.DaLiJeX(3) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(2);                      
                    }
                }
                glavna.HorizontalWinner();
                glavna.VerticalWinner();
                glavna.DiagonalWinner();

                brojac++;
                if (brojac == 9)
                    winnerLabel.Text = "TIE";
            }
            else
            {
                MessageBox.Show("Nice try. Game is over!!");
            }     
        }

        private void jedan_Click(object sender, EventArgs e)
        {
            
                if (winnerLabel.Text.Length < 1)
                {
                if (PvP)
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

                }
                else if (PvAI)
                {
                    jedan.Hide();
                    xPB1.Show();
                    glavna.DodajUTabelu(1);
                    for (int i = 0; i < 9; i++)
                    {
                        if (glavna.znakovi[i] != null)
                            brojacElemenata++;
                    }
                    if (brojacElemenata == 1)
                    {
                        glavna.MakeAMove(4);                       
                    }


                    else if (brojacElemenata == 4 && glavna.DaLiJeX(0))
                    {
                        glavna.MakeAMove(2);                       
                    }

                    else if (brojacElemenata == 4 && glavna.DaLiJeX(2))
                    {
                        glavna.MakeAMove(0);                        
                    }

                    else if (brojacElemenata == 4 && glavna.DaLiJeX(3))
                    {
                        glavna.MakeAMove(0);                       
                    }
                    else if (brojacElemenata == 4 && glavna.DaLiJeX(4))
                    {
                        glavna.MakeAMove(7);                        
                    }
                    else if (brojacElemenata == 4 && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(2);                      
                    }
                    else if (brojacElemenata == 4 && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(0);                      
                    }
                    else if (brojacElemenata == 4 && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(3);
                    }
                    else if (brojacElemenata == 4 && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(2);                      
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(0) && glavna.DaLiJeX(3))
                    {
                        glavna.MakeAMove(2);                        
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(0) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(5);                      
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(0) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(2);                      
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(0) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(5);                      
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(2) && glavna.DaLiJeX(3))
                    {
                        glavna.MakeAMove(8);                      
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(2) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(0);                      
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(2) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(5);                   
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(2) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(0);                      
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(2) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(3);                      
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(6) && glavna.DaLiJeX(3))
                    {
                        glavna.MakeAMove(8);                       
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(6) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(2);                       
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(6) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(0);                        
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(6) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(3);                      
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(8) && glavna.DaLiJeX(3))
                    {
                        glavna.MakeAMove(2);                       
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(8) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(6);                       
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(8) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(2);                      
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(3) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(6);                       
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(3) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(2);                     
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(5) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(0);                     
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(4) && glavna.DaLiJeX(2))
                    {
                        glavna.MakeAMove(3);                     
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(4) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(6);                     
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(4) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(7);                      
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(4) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(7);                       
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(3) && glavna.DaLiJeX(4))
                    {
                        glavna.MakeAMove(7);                        
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(3) && glavna.DaLiJeX(4) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(8);                       

                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(0) && glavna.DaLiJeX(5) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(6);                       
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(2) && glavna.DaLiJeX(3) && glavna.DaLiJeX(8) && glavna.DaLiJeOX(6) == false)
                    {
                        glavna.MakeAMove(7);                       
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(2) && glavna.DaLiJeX(5) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(0);                       
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(6) && glavna.DaLiJeX(3) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(2);                       
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(6) && glavna.DaLiJeX(0) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(5);                       
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(8) && glavna.DaLiJeX(2) && glavna.DaLiJeX(3) && glavna.DaLiJeOX(6))
                    {
                        glavna.MakeAMove(0);                        
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(2) && glavna.DaLiJeX(7) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(3);                       
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(2) && glavna.DaLiJeX(3) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(8);                       
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(0) && glavna.DaLiJeX(5) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(6);                       
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(2) && glavna.DaLiJeX(3) && glavna.DaLiJeX(4))
                    {
                        glavna.MakeAMove(7);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(8) && glavna.DaLiJeX(3) && glavna.DaLiJeX(4))
                    {
                        glavna.MakeAMove(7);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(4) && glavna.DaLiJeX(5) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(7);
                    }
                }
                }
                else
                {
                    MessageBox.Show("Nice try. Game is over!!");
                }
            glavna.HorizontalWinner();
            glavna.VerticalWinner();
            glavna.DiagonalWinner();
            brojac++;
            if (brojac == 9)
                    winnerLabel.Text = "TIE";         
        }

        private void dva_Click(object sender, EventArgs e)
        {

            if (winnerLabel.Text.Length < 1)
            {
                if (PvP)
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

                }
                if (PvAI)
                {
                    dva.Hide();
                    xPB2.Show();
                    glavna.DodajUTabelu(2);
                    for (int i = 0; i < 9; i++)
                    {
                        if (glavna.znakovi[i] != null)
                            brojacElemenata++;
                    }
                    if (brojacElemenata == 1)
                    {
                        glavna.MakeAMove(4);
                    }

                    else if (brojacElemenata == 4 && glavna.DaLiJeX(0))
                    {
                        glavna.MakeAMove(1);                       
                    }

                    else if (brojacElemenata == 4 && glavna.DaLiJeX(1))
                    {
                        glavna.MakeAMove(0);                      
                    }

                    else if (brojacElemenata == 4 && glavna.DaLiJeX(3))
                    {
                        glavna.MakeAMove(0);                       
                    }

                    else if (brojacElemenata == 4 && glavna.DaLiJeX(4))
                    {
                        glavna.MakeAMove(6);                      
                    }
                    else if (brojacElemenata == 4 && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(8);                       
                    }
                    else if (brojacElemenata == 4 && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(3);                       
                    }
                    else if (brojacElemenata == 4 && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(8);                       
                    }
                    else if (brojacElemenata == 4 && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(5);                        
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(3))
                    {
                        glavna.MakeAMove(8);                       
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(0);                        
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(8);                        
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(5);                        
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(0) && glavna.DaLiJeX(3))
                    {
                        glavna.MakeAMove(1);                        
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(0) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(7);                        
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(0) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(5);                       
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(0) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(1);                        
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(0) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(5);                      
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(6) && glavna.DaLiJeX(3))
                    {
                        glavna.MakeAMove(8);                       
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(6) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(1);                        
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(6) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(0);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(6) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(1);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(8) && glavna.DaLiJeX(3))
                    {
                        glavna.MakeAMove(5);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(8) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(5);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(3) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(1);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(3) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(0);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(5) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(0);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(4) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(6);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(4) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(6);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(4))
                    {
                        glavna.MakeAMove(6);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(3) && glavna.DaLiJeX(4))
                    {
                        glavna.MakeAMove(6);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(3) && glavna.DaLiJeX(4) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(6);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(1) && glavna.DaLiJeX(4) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(6);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(1) && glavna.DaLiJeX(3) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(5);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(1) && glavna.DaLiJeX(8) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(5);

                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(1) && glavna.DaLiJeX(7) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(6);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(0) && glavna.DaLiJeX(5) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(8);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(0) && glavna.DaLiJeX(5) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(7);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(6) && glavna.DaLiJeX(3) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(1);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(6) && glavna.DaLiJeX(0) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(5);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(6) && glavna.DaLiJeX(1) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(5);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(1) && glavna.DaLiJeX(3) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(8);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(1) && glavna.DaLiJeX(3) && glavna.DaLiJeX(4))
                    {
                        glavna.MakeAMove(6);
                    }
                }
            }
            else
                {
                    MessageBox.Show("Nice try. Game is over!!");
                }
            glavna.HorizontalWinner();
            glavna.VerticalWinner();
            glavna.DiagonalWinner();
            brojac++;
                if (brojac == 9)
                    winnerLabel.Text = "TIE";
               

            
        }

        private void tri_Click(object sender, EventArgs e)
        {
            
                if (winnerLabel.Text.Length < 1)
                {
                if (PvP)
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
                }
                if (PvAI)
                {
                    tri.Hide();
                    xPB3.Show();
                    glavna.DodajUTabelu(3);
                    for (int i = 0; i < 9; i++)
                    {
                        if (glavna.znakovi[i] != null)
                            brojacElemenata++;
                    }
                    if (brojacElemenata == 1)
                    {
                        glavna.MakeAMove(4);
                    }

                    else if (brojacElemenata == 4 && glavna.DaLiJeX(0))
                    {
                        glavna.MakeAMove(6);
                    }

                    else if (brojacElemenata == 4 && glavna.DaLiJeX(1))
                    {
                        glavna.MakeAMove(0);
                    }

                    else if (brojacElemenata == 4 && glavna.DaLiJeX(2))
                    {
                        glavna.MakeAMove(0);
                    }

                    else if (brojacElemenata == 4 && glavna.DaLiJeX(4))
                    {
                        glavna.MakeAMove(5);
                    }

                    else if (brojacElemenata == 4 && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(7);
                    }

                    else if (brojacElemenata == 4 && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(0);
                    }
                    else if (brojacElemenata == 4 && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(6);
                    }
                    else if (brojacElemenata == 4 && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(6);
                    }

                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(0))
                    {
                        glavna.MakeAMove(6);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(2))
                    {
                        glavna.MakeAMove(8);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(6);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(8);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(6);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(0) && glavna.DaLiJeX(2))
                    {
                        glavna.MakeAMove(7);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(0) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(7);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(0) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(2) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(0);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(2) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(0);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(2) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(6);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(6) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(1);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(6) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(0);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(6) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(1);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(8) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(6);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(8) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(5) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(0);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(4) && glavna.DaLiJeX(2))
                    {
                        glavna.MakeAMove(5);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(4) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(1);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(4) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(4) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(1);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(4))
                    {
                        glavna.MakeAMove(5);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(1) && glavna.DaLiJeX(2) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(6);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(1) && glavna.DaLiJeX(5) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(8);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(1) && glavna.DaLiJeX(8) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(1) && glavna.DaLiJeX(6) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(0);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(0) && glavna.DaLiJeX(5) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(0) && glavna.DaLiJeX(2) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(8);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(2) && glavna.DaLiJeX(5) && glavna.DaLiJeX(0))
                    {
                        glavna.MakeAMove(7);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(2) && glavna.DaLiJeX(0) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(6);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(6) && glavna.DaLiJeX(1) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(0);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(2) && glavna.DaLiJeX(7) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(0);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(0) && glavna.DaLiJeX(5) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(6);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(1) && glavna.DaLiJeX(2) && glavna.DaLiJeX(4))
                    {
                        glavna.MakeAMove(5);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(1) && glavna.DaLiJeX(6) && glavna.DaLiJeX(4))
                    {
                        glavna.MakeAMove(5);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(8) && glavna.DaLiJeX(1) && glavna.DaLiJeX(4))
                    {
                        glavna.MakeAMove(5);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(2) && glavna.DaLiJeX(7) && glavna.DaLiJeX(4))
                    {
                        glavna.MakeAMove(5);
                    }
                }
            }
            else
                {
                    MessageBox.Show("Nice try. Game is over!!");
                }
                if (brojac == 9)
                    winnerLabel.Text = "TIE";

            glavna.HorizontalWinner();
            glavna.VerticalWinner();
            glavna.DiagonalWinner();
            brojac++;
            
            
        }

        private void cetiri_Click(object sender, EventArgs e)
        {
            
                if (winnerLabel.Text.Length < 1)
                {
                if (PvP)
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
                }
                if (PvAI)
                {
                    cetiri.Hide();
                    xPB4.Show();
                    glavna.DodajUTabelu(4);
                    for (int i = 0; i < 9; i++)
                    {
                        if (glavna.znakovi[i] != null)
                            brojacElemenata++;
                    }
                    if (brojacElemenata == 1)
                    {
                        glavna.MakeAMove(0);
                    }

                    else if (brojacElemenata == 4 && glavna.DaLiJeX(1))
                    {
                        glavna.MakeAMove(7);
                    }

                    else if (brojacElemenata == 4 && glavna.DaLiJeX(3))
                    {
                        glavna.MakeAMove(5);
                    }

                    else if (brojacElemenata == 4 && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(3);
                    }

                    else if (brojacElemenata == 4 && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 4 && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(1);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(2) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(3);
                    }
                }                                       
                }
                else
                {
                    MessageBox.Show("Nice try. Game is over!!");
                }
            glavna.HorizontalWinner();
            glavna.VerticalWinner();
            glavna.DiagonalWinner();
            brojac++;
            if (brojac == 9)
                    winnerLabel.Text = "TIE";           
        }

        private void pet_Click(object sender, EventArgs e)
        {
            
                if (winnerLabel.Text.Length < 1)
                {
                    if (PvP)
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
                    
                    }
                else if (PvAI)
                {
                    pet.Hide();
                    xPB5.Show();
                    glavna.DodajUTabelu(5);
                    for (int i = 0; i < 9; i++)
                    {
                        if (glavna.znakovi[i] != null)
                            brojacElemenata++;
                    }
                    if (brojacElemenata == 1)
                    {
                        glavna.MakeAMove(4);
                    }
                    else if (brojacElemenata == 4 && glavna.DaLiJeX(0))
                    {
                        glavna.MakeAMove(1);
                    }
                    else if (brojacElemenata == 4 && glavna.DaLiJeX(1))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 4 && glavna.DaLiJeX(2))
                    {
                        glavna.MakeAMove(8);
                    }
                    else if (brojacElemenata == 4 && glavna.DaLiJeX(3))
                    {
                        glavna.MakeAMove(7);
                    }
                    else if (brojacElemenata == 4 && glavna.DaLiJeX(4))
                    {
                        glavna.MakeAMove(3);
                    }
                    else if (brojacElemenata == 4 && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(7);
                    }
                    else if (brojacElemenata == 4 && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(8);
                    }
                    else if (brojacElemenata == 4 && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(0))
                    {
                        glavna.MakeAMove(6);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(2))
                    {
                        glavna.MakeAMove(8);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(3))
                    {
                        glavna.MakeAMove(8);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(8);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(0);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(6);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(0) && glavna.DaLiJeX(2))
                    {
                        glavna.MakeAMove(7);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(0) && glavna.DaLiJeX(3))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(0) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(1);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(0) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(0) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(2) && glavna.DaLiJeX(3))
                    {
                        glavna.MakeAMove(8);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(2) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(8);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(2) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(0);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(6) && glavna.DaLiJeX(3))
                    {
                        glavna.MakeAMove(8);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(6) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(0);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(6) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(1);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(8) && glavna.DaLiJeX(3))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(8) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(3) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(4) && glavna.DaLiJeX(2))
                    {
                        glavna.MakeAMove(3);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(4) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(1);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(4) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(4) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(1);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(4))
                    {
                        glavna.MakeAMove(3);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(0) && glavna.DaLiJeX(1) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(8);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(1) && glavna.DaLiJeX(3) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(1) && glavna.DaLiJeX(8) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(1) && glavna.DaLiJeX(6) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(3);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(0) && glavna.DaLiJeX(2) && glavna.DaLiJeX(3))
                    {
                        glavna.MakeAMove(7);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(0) && glavna.DaLiJeX(2) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(8);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(2) && glavna.DaLiJeX(0) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(3);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(6) && glavna.DaLiJeX(3) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(1);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(6) && glavna.DaLiJeX(0) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(1);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(6) && glavna.DaLiJeX(1) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(2) && glavna.DaLiJeX(3) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(8);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(1) && glavna.DaLiJeX(2) && glavna.DaLiJeX(4))
                    {
                        glavna.MakeAMove(3);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(1) && glavna.DaLiJeX(6) && glavna.DaLiJeX(4))
                    {
                        glavna.MakeAMove(3);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(8) && glavna.DaLiJeX(1) && glavna.DaLiJeX(4))
                    {
                        glavna.MakeAMove(3);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(2) && glavna.DaLiJeX(7) && glavna.DaLiJeX(4))
                    {
                        glavna.MakeAMove(3);
                    }
                }
                }
                else
                    {
                        MessageBox.Show("Nice try. Game is over!!");
                    }
            glavna.HorizontalWinner();
            glavna.VerticalWinner();
            glavna.DiagonalWinner();
            brojac++;
            if (brojac == 9)
                    winnerLabel.Text = "TIE";            
        }

        private void sest_Click(object sender, EventArgs e)
        {
            
                if (winnerLabel.Text.Length < 1)
                {
                if (PvP)
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
                }
                
                else if (PvAI)
                {
                    sest.Hide();
                    xPB6.Show();
                    glavna.DodajUTabelu(6);
                    for (int i = 0; i < 9; i++)
                    {
                        if (glavna.znakovi[i] != null)
                            brojacElemenata++;
                    }
                    if (brojacElemenata == 1)
                    {
                        glavna.MakeAMove(4);
                    }
                    else if (brojacElemenata == 4 && glavna.DaLiJeX(0))
                    {
                        glavna.MakeAMove(3);
                    }
                    else if (brojacElemenata == 4 && glavna.DaLiJeX(1))
                    {
                        glavna.MakeAMove(0);
                    }

                    else if (brojacElemenata == 4 && glavna.DaLiJeX(2))
                    {
                        glavna.MakeAMove(3);
                    }
                    else if (brojacElemenata == 4 && glavna.DaLiJeX(3))
                    {
                        glavna.MakeAMove(0);
                    }
                    else if (brojacElemenata == 4 && glavna.DaLiJeX(4))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 4 && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(7);
                    }
                    else if (brojacElemenata == 4 && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(8);
                    }
                    else if (brojacElemenata == 4 && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(7);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(0))
                    {
                        glavna.MakeAMove(3);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(2))
                    {
                        glavna.MakeAMove(8);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(3))
                    {
                        glavna.MakeAMove(8);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(0);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(5);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(7);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(0) && glavna.DaLiJeX(2))
                    {
                        glavna.MakeAMove(7);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(0) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(7);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(0) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(5);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(2) && glavna.DaLiJeX(3))
                    {
                        glavna.MakeAMove(8);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(2) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(0);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(2) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(0);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(2) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(3);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(8) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(7);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(3) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(1);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(5) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(0);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(4) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(4) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(4) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(1);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(4))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(3) && glavna.DaLiJeX(4))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(1) && glavna.DaLiJeX(4) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(3) && glavna.DaLiJeX(4) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(1) && glavna.DaLiJeX(2) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(3);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(1) && glavna.DaLiJeX(7) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(8);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(0) && glavna.DaLiJeX(5) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(7);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(2) && glavna.DaLiJeX(3) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(7);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(2) && glavna.DaLiJeX(5) && glavna.DaLiJeX(0))
                    {
                        glavna.MakeAMove(7);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(2) && glavna.DaLiJeX(0) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(5);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(2) && glavna.DaLiJeX(3) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(7);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(0) && glavna.DaLiJeX(5) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(3);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(1) && glavna.DaLiJeX(3) && glavna.DaLiJeX(4))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(8) && glavna.DaLiJeX(3) && glavna.DaLiJeX(4))
                    {
                        glavna.MakeAMove(1);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(8) && glavna.DaLiJeX(1) && glavna.DaLiJeX(4))
                    {
                        glavna.MakeAMove(3);
                    }

                }
                }
                else
                {
                    MessageBox.Show("Nice try. Game is over!!");
                }
            glavna.HorizontalWinner();
            glavna.VerticalWinner();
            glavna.DiagonalWinner();
            brojac++;
            if (brojac == 9)
                    winnerLabel.Text = "TIE";                             
        }

        private void sedam_Click(object sender, EventArgs e)
        {
            
                if (winnerLabel.Text.Length < 1)
                {
                if (PvP)
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
                    
                }
                else if (PvAI)
                {
                    sedam.Hide();
                    xPB7.Show();
                    glavna.DodajUTabelu(7);
                    for (int i = 0; i < 9; i++)
                    {
                        if (glavna.znakovi[i] != null)
                            brojacElemenata++;
                    }
                    if (brojacElemenata == 1)
                    {
                        glavna.MakeAMove(4);
                    }

                    else if (brojacElemenata == 4 && glavna.DaLiJeX(0))
                    {
                        glavna.MakeAMove(6);
                    }

                    else if (brojacElemenata == 4 && glavna.DaLiJeX(1))
                    {
                        glavna.MakeAMove(3);
                    }

                    else if (brojacElemenata == 4 && glavna.DaLiJeX(2))
                    {
                        glavna.MakeAMove(8);
                    }

                    else if (brojacElemenata == 4 && glavna.DaLiJeX(3))
                    {
                        glavna.MakeAMove(6);
                    }

                    else if (brojacElemenata == 4 && glavna.DaLiJeX(4))
                    {
                        glavna.MakeAMove(1);
                                           }
                    else if (brojacElemenata == 4 && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(8);
                    }
                    else if (brojacElemenata == 4 && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(8);
                    }
                    else if (brojacElemenata == 4 && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(6);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(0))
                    {
                        glavna.MakeAMove(6);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(2))
                    {
                        glavna.MakeAMove(8);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(3))
                    {
                        glavna.MakeAMove(8);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(6);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(8);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(6);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(0) && glavna.DaLiJeX(2))
                    {
                        glavna.MakeAMove(3);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(0) && glavna.DaLiJeX(3))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(0) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(6);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(0) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(5);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(0) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(5);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(2) && glavna.DaLiJeX(3))
                    {
                        glavna.MakeAMove(8);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(2) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(0);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(2) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(5);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(2) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(3);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(6) && glavna.DaLiJeX(3))
                    {
                        glavna.MakeAMove(8);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(8) && glavna.DaLiJeX(3))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(8) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(6);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(3) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(1);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(4) && glavna.DaLiJeX(2))
                    {
                        glavna.MakeAMove(3);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(4) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(6);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(4) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(1);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(4) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(1);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(3) && glavna.DaLiJeX(4))
                    {
                        glavna.MakeAMove(1);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(3) && glavna.DaLiJeX(4) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(8);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(1) && glavna.DaLiJeX(4) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(6);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(0) && glavna.DaLiJeX(1) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(5);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(1) && glavna.DaLiJeX(2) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(3);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(1) && glavna.DaLiJeX(3) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(1) && glavna.DaLiJeX(5) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(8);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(0) && glavna.DaLiJeX(2) && glavna.DaLiJeX(3))
                    {
                        glavna.MakeAMove(8);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(0) && glavna.DaLiJeX(5) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(8);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(0) && glavna.DaLiJeX(5) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(6);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(2) && glavna.DaLiJeX(3) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(6);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(2) && glavna.DaLiJeX(5) && glavna.DaLiJeX(0))
                    {
                        glavna.MakeAMove(6);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(2) && glavna.DaLiJeX(5) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(0);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(2) && glavna.DaLiJeX(3) && glavna.DaLiJeX(8))
                    {
                        glavna.MakeAMove(6);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(8) && glavna.DaLiJeX(2) && glavna.DaLiJeX(3))
                    {
                        glavna.MakeAMove(0);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(2) && glavna.DaLiJeX(3) && glavna.DaLiJeX(4))
                    {
                        glavna.MakeAMove(1);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(4) && glavna.DaLiJeX(5) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(1);
                    }
                }
                }
            else
                {
                    MessageBox.Show("Nice try. Game is over!!");
                }
            glavna.HorizontalWinner();
            glavna.VerticalWinner();
            glavna.DiagonalWinner();
            brojac++;
            if (brojac == 9)
                    winnerLabel.Text = "TIE";                                   
        }

        private void osam_Click(object sender, EventArgs e)
        {

            if (winnerLabel.Text.Length < 1)
            {
                if (PvP)
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

                }

                else if (PvAI)
                {
                    osam.Hide();
                    xPB8.Show();
                    glavna.DodajUTabelu(8);
                    for (int i = 0; i < 9; i++)
                    {
                        if (glavna.znakovi[i] != null)
                            brojacElemenata++;
                    }
                    if (brojacElemenata == 1)
                    {
                        glavna.MakeAMove(4);
                    }
                    else if (brojacElemenata == 4 && glavna.DaLiJeX(0))
                    {
                        glavna.MakeAMove(3);
                    }
                    else if (brojacElemenata == 4 && glavna.DaLiJeX(1))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 4 && glavna.DaLiJeX(2))
                    {
                        glavna.MakeAMove(5);
                    }
                    else if (brojacElemenata == 4 && glavna.DaLiJeX(3))
                    {
                        glavna.MakeAMove(6);
                    }
                    else if (brojacElemenata == 4 && glavna.DaLiJeX(4))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 4 && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 4 && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(7);
                    }
                    else if (brojacElemenata == 4 && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(6);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(0))
                    {
                        glavna.MakeAMove(6);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(2))
                    {
                        glavna.MakeAMove(5);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(3))
                    {
                        glavna.MakeAMove(6);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(6);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(7);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(5);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(0) && glavna.DaLiJeX(2))
                    {
                        glavna.MakeAMove(7);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(0) && glavna.DaLiJeX(3))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(0) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(7);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(0) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(5);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(0) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(2) && glavna.DaLiJeX(3))
                    {
                        glavna.MakeAMove(5);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(2) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(5);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(6) && glavna.DaLiJeX(3))
                    {
                        glavna.MakeAMove(7);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(6) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(1);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(3) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(1);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(3) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(4) && glavna.DaLiJeX(2))
                    {
                        glavna.MakeAMove(3);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(4) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(6);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(4) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(1);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(4) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(1) && glavna.DaLiJeX(4))
                    {
                        glavna.MakeAMove(6);
                    }
                    else if (brojacElemenata == 9 && glavna.DaLiJeX(3) && glavna.DaLiJeX(4))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(3) && glavna.DaLiJeX(4) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(1) && glavna.DaLiJeX(4) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(6);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(0) && glavna.DaLiJeX(1) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(5);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(1) && glavna.DaLiJeX(5) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(7);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(1) && glavna.DaLiJeX(7) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(6);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(0) && glavna.DaLiJeX(2) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(5);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(0) && glavna.DaLiJeX(2) && glavna.DaLiJeX(3))
                    {
                        glavna.MakeAMove(7);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(0) && glavna.DaLiJeX(5) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(0) && glavna.DaLiJeX(5) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(7);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(0) && glavna.DaLiJeX(2) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(5);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(6) && glavna.DaLiJeX(1) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(0);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(1) && glavna.DaLiJeX(3) && glavna.DaLiJeX(5))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(2) && glavna.DaLiJeX(3) && glavna.DaLiJeX(7))
                    {
                        glavna.MakeAMove(5);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(1) && glavna.DaLiJeX(2) && glavna.DaLiJeX(4))
                    {
                        glavna.MakeAMove(3);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(1) && glavna.DaLiJeX(6) && glavna.DaLiJeX(4))
                    {
                        glavna.MakeAMove(5);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(1) && glavna.DaLiJeX(3) && glavna.DaLiJeX(4))
                    {
                        glavna.MakeAMove(2);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(2) && glavna.DaLiJeX(3) && glavna.DaLiJeX(4))
                    {
                        glavna.MakeAMove(7);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(8) && glavna.DaLiJeX(3) && glavna.DaLiJeX(4))
                    {
                        glavna.MakeAMove(1);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(4) && glavna.DaLiJeX(5) && glavna.DaLiJeX(6))
                    {
                        glavna.MakeAMove(1);
                    }
                    else if (brojacElemenata == 16 && glavna.DaLiJeX(2) && glavna.DaLiJeX(7) && glavna.DaLiJeX(4))
                    {
                        glavna.MakeAMove(3);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nice try. Game is over!!");
            }
            glavna.HorizontalWinner();
            glavna.VerticalWinner();
            glavna.DiagonalWinner();
            brojac++;
            if (brojac == 9)
                    winnerLabel.Text = "TIE";                          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {         
            NewGame();
        }

        private void NapuniListuDugmica()
        {
            Dugmici[0] = nula;
            Dugmici[1] = jedan;
            Dugmici[2] = dva;
            Dugmici[3] = tri;
            Dugmici[4] = cetiri;
            Dugmici[5] = pet;
            Dugmici[6] = sest;
            Dugmici[7] = sedam;
            Dugmici[8] = osam;
        }

        private void NapuniXeve()
        {
            XPictures[0] = xPB0;
            XPictures[1] = xPB1;
            XPictures[2] = xPB2;
            XPictures[3] = xPB3;
            XPictures[4] = xPB4;
            XPictures[5] = xPB5;
            XPictures[6] = xPB6;
            XPictures[7] = xPB7;
            XPictures[8] = xPB8;
        }

        private void NapuniOXeve()
        {
            OXPictures[0] = oxPB0;
            OXPictures[1] = oxPB1;
            OXPictures[2] = oxPB2;
            OXPictures[3] = oxPB3;
            OXPictures[4] = oxPB4;
            OXPictures[5] = oxPB5;
            OXPictures[6] = oxPB6;
            OXPictures[7] = oxPB7;
            OXPictures[8] = oxPB8;
        }

        private void NapuniListuPanela()
        {
            paneliKojiPovezuju[0] = prviRedPanel;
            paneliKojiPovezuju[1] = drugiRedPanel;
            paneliKojiPovezuju[2] = treciRedPanel;
            paneliKojiPovezuju[3] = prvaKolonaPanel;
            paneliKojiPovezuju[4] = drugaKolonaPanel;
            paneliKojiPovezuju[5] = trecaKolonaPanel;
        }

        private void PvPModeButton_Click(object sender, EventArgs e)
        {
            NewGame();
            PvAI = false;
            PvP = true;
        }

        private void PvAIModeButton_Click(object sender, EventArgs e)
        {
            NewGame();
            PvP = false;
            PvAI = true;
        }
        public void NewGame()
        {
            brojac = 0;
            brojacElemenata = 0;
            glavna.IgraX = true;
            winnerLabel.Text = null;
            try
            { 
            for (int i = 0; i < 9; i++)
            {
                glavna.znakovi[i] = null;
            }
            for(int i = 0; i< Dugmici.Length; i++)
            {
                if (!Dugmici[i].Visible)
                    Dugmici[i].Show();
            }
            for (int i = 0; i <XPictures.Length; i++)
            {
                if (XPictures[i].Visible)
                    XPictures[i].Hide();
            }
            for (int i = 0; i < OXPictures.Length; i++)
            {
                if (OXPictures[i].Visible)
                    OXPictures[i].Hide();
            }
            for (int i = 0; i < 9; i++)
            {
                if (paneliKojiPovezuju[i].Visible)
                    paneliKojiPovezuju[i].Hide();
            }
            }
            catch (NullReferenceException)
            {

            }
        }        
    }
}

