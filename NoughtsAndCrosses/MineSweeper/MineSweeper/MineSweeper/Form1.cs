using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class Form1 : Form
    {
        //make an array of labels 20 x 10
        PictureBox[] tiles = new PictureBox[200];
        Button[] Minebut = new Button[200];
        int[] minelocations = new int[40];

        int count = 0;
        int loss = 0;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

            int vpos = 0;
            int hpos = 0; //add 40
            int vposbut = 0;
            int hposbut = 0;
            int maxmines = 20;
            for (int i = 0; i < 200; i++)
            {
                tiles[i] = new PictureBox();
                tiles[i].Width = 40;
                tiles[i].Height = 40;
                if (i % 20 == 0)
                {
                    hpos = 0;
                    vpos += 45;
                }
                tiles[i].Left = 0 + hpos;
                hpos += 45;
                tiles[i].Top = 0 + vpos;
                //vpos += 15;
                tiles[i].BackColor = Color.DimGray;
                Controls.Add(tiles[i]);
                tiles[i].BackgroundImageLayout = ImageLayout.Stretch;
                
            }
            for (int i = 0; i < 200; i++)
            {
                Minebut[i] = new Button();
                Minebut[i].Width = 40;
                Minebut[i].Height = 40;
                if (i % 20 == 0)
                {
                    hposbut = 0;
                    vposbut += 45;
                }
                Minebut[i].Left = 0 + hposbut;
                hposbut += 45;
                Minebut[i].Top = 0 + vposbut;
                //vpos += 15;
                Minebut[i].BackColor = Color.DimGray;
                Controls.Add(Minebut[i]);
                Minebut[i].BringToFront();
                Minebut[i].Click += new EventHandler(Minebut_Click);
            }
            bool[] numbertaken = new bool[200];
            int number = 0;
            for (int i = 0; i < 40; i++)
            {
                do
                {
                    Random rnd = new Random();
                    number = rnd.Next(1, 200);
                    tiles[number].Tag = "Mine";
                    minelocations[i] = number;
                }
                while (numbertaken[number - 1] == true);
                numbertaken[number - 1] = true;


            }
            for (int i = 0; i < 200; i++)
            {
                tiles[i].Text = Convert.ToString(tiles[i].Tag);
                if (tiles[i].Tag == "Mine")
                {
                    tiles[i].BackgroundImage = Image.FromFile(Application.StartupPath + "\\Images" + "\\mine.png");
                }
            }

            for (int i = 0; i < 1; i++)
            {
                count = 0;
                if (numbertaken[i] == true)
                {
                    count += 9;
                    loss += 1;
                }
                else
                {
                    if (numbertaken[i + 20] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 21] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 1] == true)
                    {
                        count += 1;
                    }
                }
                displaynum(count, i);
            }
            for (int i = 1; i < 19; i++)
            {
                count = 0;
                if (numbertaken[i] == true)
                {
                    count += 9;
                    loss += 1;
                }
                else
                {
                    if (numbertaken[i + 20] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 21] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 19] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 1] == true)
                    {
                        count += 1;
                    }
                }
                displaynum(count, i);
            }
            for (int i = 19; i < 20; i++)
            {
                count = 0;
                if (numbertaken[i] == true)
                {
                    count += 9;
                    loss += 1;
                }
                else
                {
                    if (numbertaken[i + 20] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 21] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 1] == true)
                    {
                        count += 1;
                    }
                }
                displaynum(count, i);
            }
            for (int i = 20; i < 161; i++)
            {
                count = 0;
                if (numbertaken[i] == true)
                {
                    count += 9;
                    loss += 1;
                }
                else
                {
                    if (numbertaken[i - 20] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i - 19] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 20] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 21] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i - 1] == true)
                    {
                        count += 1;
                    }
                }
               
                displaynum(count, i);
            }
            for (int i = 39; i < 179; i++)
            {
                count = 0;
                if (numbertaken[i] == true)
                {
                    count += 9;
                    loss += 1;
                }
                else
                {
                    if (numbertaken[i - 20] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i - 19] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 1] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 21] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 20] == true)
                    {
                        count += 1;
                    }
                }
               
                displaynum(count, i);
            }
            for (int i = 21; i < 28; i++)
            {
                count = 0;
                if (numbertaken[i] == true)
                {
                    count += 9;
                    loss += 1;
                }
                else
                {
                    if (numbertaken[i - 20] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i - 19] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i - 21] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 21] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 20] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 19] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 1] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i - 1] == true)
                    {
                        count += 1;
                    }
                }
                displaynum(count, i);
            }
            for (int i = 41; i < 58; i++)
            {
                count = 0;
                if (numbertaken[i] == true)
                {
                    count += 9;
                    loss += 1;
                }
                else
                {
                    if (numbertaken[i - 20] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i - 19] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i - 21] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 21] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 20] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 19] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 1] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i - 1] == true)
                    {
                        count += 1;
                    }
                }
                
                displaynum(count, i);
            }
            for (int i = 61; i < 78; i++)
            {
                count = 0;
                if (numbertaken[i] == true)
                {
                    count += 9;
                    loss += 1;
                }
                else
                {
                    if (numbertaken[i - 20] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i - 19] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i - 21] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 21] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 20] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 19] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 1] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i - 1] == true)
                    {
                        count += 1;
                    }
                }
                displaynum(count, i);
            }
            for (int i = 81; i < 98; i++)
            {
                count = 0;
                if (numbertaken[i] == true)
                {
                    count += 9;
                    loss += 1;
                }
                else
                {
                    if (numbertaken[i - 20] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i - 19] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i - 21] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 21] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 20] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 19] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 1] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i - 1] == true)
                    {
                        count += 1;
                    }
                }
                
                displaynum(count, i);
            }
            for (int i = 101; i < 118; i++)
            {
                count = 0;
                if (numbertaken[i] == true)
                {
                    count += 9;
                    loss += 1;
                }
                else
                {
                    if (numbertaken[i - 20] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i - 19] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i - 21] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 21] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 20] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 19] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 1] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i - 1] == true)
                    {
                        count += 1;
                    }
                }
               
                displaynum(count, i);
            }
            for (int i = 121; i < 138; i++)
            {
                count = 0;
                if (numbertaken[i] == true)
                {
                    count += 9;
                    loss += 1;
                }
                else
                {
                    if (numbertaken[i - 20] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i - 19] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i - 21] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 21] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 20] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 19] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 1] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i - 1] == true)
                    {
                        count += 1;
                    }
                }
                
                displaynum(count, i);
            }
            for (int i = 141; i < 158; i++)
            {
                count = 0;
                if (numbertaken[i] == true)
                {
                    count += 9;
                    loss += 1;
                }
                else
                {
                    if (numbertaken[i - 20] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i - 19] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i - 21] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 21] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 20] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 19] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 1] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i - 1] == true)
                    {
                        count += 1;
                    }
                }
                displaynum(count, i);
            }
            for (int i = 161; i < 179; i++)
            {
                count = 0;
                if (numbertaken[i] == true)
                {
                    count += 9;
                    loss += 1;
                }
                else
                {
                    if (numbertaken[i - 20] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i - 19] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i - 21] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 21] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 20] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 19] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 1] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i - 1] == true)
                    {
                        count += 1;
                    }
                }
                displaynum(count, i);
            }
            for (int i = 181; i < 199; i++)
            {
                count = 0;
                if (numbertaken[i] == true)
                {
                    count += 9;
                    loss += 1;
                }
                else
                {
                    if (numbertaken[i - 20] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i - 21] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 1] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i - 1] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i - 19] == true)
                    {
                        count += 1;
                    }
                }

                displaynum(count, i);
            }
            for (int i = 180; i < 181; i++)
            {
                count = 0;
                if (numbertaken[i] == true)
                {
                    count += 9;
                    loss += 1;
                }
                else
                {
                    if (numbertaken[i - 20] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i - 19] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 1] == true)
                    {
                        count += 1;
                    }
                }
                displaynum(count, i);
            }
            for (int i = 199; i < 200; i++)
            {
                count = 0;
                if (numbertaken[i] == true)
                {
                    count += 9;
                    loss += 1;
                }
                else
                {
                    if (numbertaken[i - 20] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i- 21] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i - 1] == true)
                    {
                        count += 1;
                    }
                }
                displaynum(count, i);
            }
            for (int i = 179; i < 180; i++)
            {
                count = 0;
                if (numbertaken[i] == true)
                {
                    count += 9;
                    loss += 1;
                }
                else
                {
                    if (numbertaken[i - 20] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i - 19] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i+ 20] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i + 19] == true)
                    {
                        count += 1;
                    }
                    if (numbertaken[i - 1] == true)
                    {
                        count += 1;
                    }
                }
                displaynum(count, i);
            }




        }
        void Minebut_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.Visible = false;
            lossvoid(e);
            
        }

        void displaynum(int value, int pos)
        {
            
            switch (value)
            {
                case (0):
                    tiles[pos].BackgroundImage = Image.FromFile(Application.StartupPath + "\\Images" + "\\blank.png");
                    break;
                case (1):
                    tiles[pos].BackgroundImage = Image.FromFile(Application.StartupPath + "\\Images" + "\\1.png");
                    break;
                case (2):
                    tiles[pos].BackgroundImage = Image.FromFile(Application.StartupPath + "\\Images" + "\\2.png");
                    break;
                case (3):
                    tiles[pos].BackgroundImage = Image.FromFile(Application.StartupPath + "\\Images" + "\\3.png");
                    break;
                case (4):
                    tiles[pos].BackgroundImage = Image.FromFile(Application.StartupPath + "\\Images" + "\\4.png");
                    break;
                case (5):
                    tiles[pos].BackgroundImage = Image.FromFile(Application.StartupPath + "\\Images" + "\\5.png");
                    break;
                case (6):
                    tiles[pos].BackgroundImage = Image.FromFile(Application.StartupPath + "\\Images" + "\\6.png");
                    break;
                case (7):
                    tiles[pos].BackgroundImage = Image.FromFile(Application.StartupPath + "\\Images" + "\\7.png");
                    break;
                case (8):
                    tiles[pos].BackgroundImage = Image.FromFile(Application.StartupPath + "\\Images" + "\\8.png");
                    break;
                case (9):
                    tiles[pos].BackgroundImage = Image.FromFile(Application.StartupPath + "\\Images" + "\\mine.png");
                    break;

            }
        }

        void lossvoid(EventArgs lossnum)
        {
            //MessageBox.Show(Convert.ToString(lossnum));
        }
    }
}
