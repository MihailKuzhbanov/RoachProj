using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RoachProj
{
    public partial class Form1 : Form
    {
        List<TextBox> txtBet = new List<TextBox>();
        List<Player> players = new List<Player>();
        List<PictureBox> pics = new List<PictureBox>();
        public int bank = 0;
        public int step = 10;
        public Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            string[] names = {"First", "Second", "Third"};
            playerSelect.Items.AddRange (names);
            Player manOne = new Player(0);
            Player manTwo = new Player(1);
            Player manThree = new Player(2);
            txtBet.Add(roachOneBet);
            txtBet.Add(roachTwoBet);
            txtBet.Add(roachThreeBet);
            txtBet.Add(roachFourBet);
            players.Add(manOne);
            players.Add(manTwo);
            players.Add(manThree);
            pics.Add(onePic);
            pics.Add(twoPic);
            pics.Add(threePic);
            pics.Add(fourPic);
            playerSelect.SelectedIndex = 0;
        }

        class Player
        {
            public int num;
            public int money = 1000;
            public int[] bets = { 0, 0, 0, 0 };
            public Player(int i)
            {
                this.num = i;
            }
        }

        public void fresh()
        {
            valueMoney.Text = players[playerSelect.SelectedIndex].money.ToString();
        }

        public bool getBet()
        {
            
            foreach (Player p in players)
            {
                if (playerSelect.SelectedIndex == p.num)
                {
                    for (int i = 0; i < p.bets.Length; i++)
                    {
                            bool err;
                            if (txtBet[i].Text == "")
                            {
                                txtBet[i].Text = "0";
                            }
                            err = Int32.TryParse(txtBet[i].Text, out p.bets[i]);
                            p.money -= p.bets[i];
                            bank += p.bets[i];
                            if (err == false)
                            {
                                MessageBox.Show("Invalid value");
                                return false;
                            };
                    }
                }
               
            }
            return true;
        }

        public void getMoney(int r)
        {
            int reserved = 0;
            foreach (Player p in players)
            {
                reserved += p.bets[r];
            }
            foreach (Player p in players)
            {
                p.money +=  (p.bets[r]*bank)/(reserved);
            }
        }

        public int go()
        {
            foreach (PictureBox pic in pics)
            {
                if (pic.Location.X < finishPic.Location.X - 10)
                {
                    Point point = new Point();
                    point = pic.Location;
                    point.X += rnd.Next(step);
                    pic.Location = point;
                }
                else return pics.IndexOf(pic);
            }
            return 100;
        }

        private void mainButon_Click(object sender, EventArgs e)
        {
            if (onePic.Location.X > 139)
            {
                preparation();
            }
            if (bank != 0)
            {
                fresh();
                mainButon.Enabled = false;
                betButton.Enabled = false;
                clrTxt();
                ticker.Enabled = true;
            }
            else MessageBox.Show("Bets not founded");
        }

        public void preparation()
        {
            foreach (PictureBox pic in pics)
            {
                Point point = new Point();
                point = pic.Location;
                point.X = 139;
                pic.Location = point;
            }
            foreach (Player p in players)
            {
                for (int i = 0; i < p.bets.Length; i++)
                {
                    p.bets[i] = 0;
                }
            }
            bank = 0;
        }

        public void clrTxt()
        {
            roachOneBet.Text = "0";
            roachTwoBet.Text = "0";
            roachThreeBet.Text = "0";
            roachFourBet.Text = "0";
        }

        private void playerSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            fresh();
            clrTxt();
        }

        private void ticker_Tick(object sender, EventArgs e)
        {
            int winner = go();
            if (winner != 100)
            {
                ticker.Enabled = false;
                MessageBox.Show("Roach " + (winner+1).ToString() + " wins!");
                getMoney(winner);
                fresh();
                mainButon.Enabled = true;
                betButton.Enabled = true;
                
            };
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            if (getBet() == true)
            {
                MessageBox.Show("Bets accepted");
                fresh();
            };
        }
    }
}
