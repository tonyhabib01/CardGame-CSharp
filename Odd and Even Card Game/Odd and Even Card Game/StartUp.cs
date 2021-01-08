using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Odd_and_Even_Card_Game
{
    
    public partial class StartUp : Form
    {
        public static Player Player1 = new Player();
        public static Player Player2 = new Player();
        public static int RoundNumber = new int();
        public StartUp()
        {
            InitializeComponent();
        }

        private void StartUp_Load(object sender, EventArgs e)
        {
            //Making the player to choose what type he wants in the combobox
            Player1Type.Items.Add("Even Player");
            Player1Type.Items.Add("Odd Player");
            Player2Type.Items.Add("Even Player");
            Player2Type.Items.Add("Odd Player");

            //Adding the round number in the combobox from 1 to 27 
            for (int i=1;i<=27;i++)
               CBRound.Items.Add(i);


        }

        public void StartGame_Click(object sender, EventArgs e)
        {
            RoundNumber = Convert.ToInt32 (CBRound.Text);

            //Setting the Player Data
            Player1.Name = Player1Name.Text;
            Player2.Name = Player2Name.Text;

            Player1.PlayerType = Player1Type.Text;
            Player2.PlayerType = Player2Type.Text;


            //Showing the new form (The Game)
            this.Hide();
            Selection selection = new Selection();
            selection.ShowDialog();
            this.Close();
        }
    }
}
