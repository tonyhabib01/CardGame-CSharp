using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Odd_and_Even_Card_Game
{
    public partial class Selection : Form
    {
        Decks deck = new Decks();
        public List<Game> GameList = new List<Game>();
        string Card1, Card2;
        public int GamePlayed = 0;
        public Selection()
        {
            InitializeComponent();

        }

        private void Selection_Load(object sender, EventArgs e)
        {
            GameList.Add(new Game());

            GameList[GamePlayed].P1.Score = 0;
            GameList[GamePlayed].P2.Score = 0;


            ShowScore();

            for (int i = 1; i <= StartUp.RoundNumber; i++)
                ListBoxRound.Items.Add("Round " + i);

            DisplayPlayerInfo();

            deck.CardsImageLoad();

            SetNextCard(ref Card1,ref Card2);

            GameList[GamePlayed].CalctTotalScore(GameList[GamePlayed].P1, GameList[GamePlayed].P2, Card1, Card2);


            DisplayRemainings();

        }


        private void btnRoll_Click(object sender, EventArgs e)
        {


            if (ListBoxRound.Items.Count != 0)
            {
                ListBoxRound.SetSelected(0, true);

                P1Card.Image = P1NextCard.Image;
                P2Card.Image = P2NextCard.Image;

                DisplayRemainings();

                ShowScore();



                if (ListBoxRound.Items.Count == 1)
                {
                    P1NextCard.Image = null;
                    P2NextCard.Image = null;

                    GameList[GamePlayed].GameNumber = GamePlayed + 1;
                    ListBoxGamePlayed.Items.Add(GameList[GamePlayed]);
                    
                    GamePlayed++;

                    btnRoll.Text = "New Game";
                    BtnAuto.Visible = false;
                    BtnAuto.Text = "Stop";

                    BtnAuto_Click(sender, e);

                }

                else // If-Else in order to show the correct Cards Remaining in the Deck.
                {
                    SetNextCard(ref Card1, ref Card2);
                    GameList[GamePlayed].CalctTotalScore(GameList[GamePlayed].P1, GameList[GamePlayed].P2, Card1, Card2);
                }

                ListBoxRound.Items.RemoveAt(ListBoxRound.SelectedIndex);

                DisplayRemainings();
            }

            else
            {
                P1Card.Image = null;
                P2Card.Image = null;
                deck.Cards.Clear();
                Selection_Load(sender, e);

                BtnAuto.Visible = true;
                btnRoll.Text = "Roll";
            }



        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void SetNextCard (ref string _Card1, ref string _Card2)
        {
            _Card1 = deck.RandPick();
            _Card2 = deck.RandPick();
            P1NextCard.Image = Image.FromFile(_Card1);
            P2NextCard.Image = Image.FromFile(_Card2);

        }

        private void ShowScore ()
        {
            P1Score.Text = "Score " + GameList[GamePlayed].P1.Score.ToString();
            P2Score.Text = "Score " + GameList[GamePlayed].P2.Score.ToString();
        }

        private void DisplayPlayerInfo()
        {
            P1Name.Text = "Name: " + StartUp.Player1.Name;
            P2Name.Text = "Name: " + StartUp.Player2.Name;

            P1Type.Text = "Type: " + StartUp.Player1.PlayerType;
            P2Type.Text = "Type: " + StartUp.Player2.PlayerType;
        }

        private void DisplayRemainings()
        {
            LBRemainingRound.Text = "Remaining Rounds: " + ListBoxRound.Items.Count.ToString();
            LBRemainingCards.Text = "Remaining Cards: " + deck.Cards.Count.ToString();
        }

        private void BtnAuto_Click(object sender, EventArgs e)
        {
            if (BtnAuto.Text == "Stop")
            {
                AutoTimer.Enabled = false;
                BtnAuto.Text = "Auto";
                btnRoll.Enabled = true;

            }

            else
            {

                AutoTimer.Enabled = true;
                BtnAuto.Text = "Stop";
                btnRoll.Enabled = false;

            }

            
        }

        private void AutoTimer_Tick(object sender, EventArgs e)           
        {

            btnRoll_Click(sender, e);
          

        }


        private void ListBoxGamePlayed_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            {
                int nbrgame = ListBoxGamePlayed.SelectedIndex;
                string strGameNumb = ListBoxGamePlayed.SelectedItem.ToString().Substring(0, 5) + (nbrgame+1).ToString();
                string strWinner = GameList[nbrgame].DisplayWinner();
                string strLoser = GameList[nbrgame].DisplayLoser();

                MessageBox.Show(strGameNumb + "\n" + strWinner + "\n" + strLoser);
            }
        }
    }
}
