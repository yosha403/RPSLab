using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLab
{
    class RPSApp
    {    

        public UserPlayer Player { get; set; } = new UserPlayer();
        public int Draws { get; set; } = 0;

        //We leave this property blank since we want the user to select who they play
        public Player Opponent { get; set; }


        public RPSApp()
        {
            

        }        

    }
}

