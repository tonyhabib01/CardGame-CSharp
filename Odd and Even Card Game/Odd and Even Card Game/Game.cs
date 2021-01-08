using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odd_and_Even_Card_Game
{
    public class Game
    {
        public int GameNumber { get; set; }
        public Player P1 = new Player();
        public Player P2 = new Player();
       

        public void IndivScore (Player P, string C)
        {
            try
            {
                int result = Int32.Parse(C.Substring(6, 1));
                if (result == 1)
                    result = 10;

                if (result % 2 == 0) // Even Card
                {
                    if (P.PlayerType == "Even Player")
                    {
                        if (result <= 4)
                            P.Score += 2;
                        else
                            P.Score += 1;
                    }

                    else
                    {
                        if (result <= 4)
                            P.Score -= 1;
                        else
                            P.Score -= 2;
                    }
                }

                else // Odd Card
                {
                    if (P.PlayerType == "Even Player")
                    {
                        if (result <= 5)
                            P.Score -= 1;
                        else
                            P.Score -= 2;
                    }

                    else
                    {
                        if (result <= 5)
                            P.Score += 2;
                        else
                            P.Score += 1;
                    }


                }

            }

            catch (FormatException)
            {
                string CardName = C.Substring(6, 1);

                switch (CardName)
                {
                    case "A":

                        if (P.PlayerType == "Even Player")
                            P.Score -= 1;
                        else
                            P.Score += 2;

                        break;

                    case "Q":

                        if (P.PlayerType == "Even Player")
                            P.Score += 2;
                        else
                            P.Score -= 2;
                        break;

                    case "K":
                    case "J":

                        if (P.PlayerType == "Even Player")
                            P.Score -= 2;
                        else
                            P.Score += 2;
                        break;

                }
            }
        }

        public void CalctTotalScore(Player Player1, Player Player2, string Card1, string Card2)
        {
            if (Card1.Substring(6, 1) != "G") //Joker
            {
                IndivScore(Player1, Card1);
            }

            else
            {
                Player2.Score = 0;
                return;
            }

            if (Card2.Substring(6, 1) != "G") // Joker
            {
                IndivScore(Player2, Card2);
            }

            else
                Player1.Score = 0;


        }

        public override string ToString()
        {
            return "Game " + GameNumber.ToString() + ": " + DisplayWinner();
        }

        public string DisplayWinner()
        {
            string str;

            if (P1.Score > P2.Score)
                str = StartUp.Player1.Name + " Won, Score: " + P1.Score.ToString();
            else if (P1.Score == P2.Score)
                str = "Draw, Score: " + P1.Score.ToString();
            else
                str = StartUp.Player2.Name + " Won, Score: " + P2.Score.ToString();

            return str;
        }

        public string DisplayLoser()
        {
            string str="";

            if (P1.Score > P2.Score)
                str = StartUp.Player2.Name + " Lost, Score: " + P2.Score.ToString();

            else if (P1.Score < P2.Score)
                str = StartUp.Player1.Name + " Lost, Score: " + P1.Score.ToString();
            

            return str;
        }




    }
}
