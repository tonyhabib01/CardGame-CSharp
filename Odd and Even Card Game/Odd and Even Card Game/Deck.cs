using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace Odd_and_Even_Card_Game
{
    public class Decks
    {
        int card;
        Random rnd = new Random();
        public string carddraw;
        public List<string> Cards = new List<string>();
        string[] CardsFolder;
        
        public string RandPick()
        {

            card = rnd.Next(0, Cards.Count);
            carddraw = Cards[card].ToString();
            Cards.RemoveAt(card);

            return carddraw;

        }

        public void CardsImageLoad()
        {
            CardsFolder = Directory.GetFiles("Cards");
            foreach (string card in CardsFolder)
            {
                Cards.Add(card);
            }

        }

        public bool isEmpty()
        {
            if (Cards.Count == 0)
                return true;
            else
                return false;
        }
    }
}
