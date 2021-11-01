using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLab
{
    class Randa: Player
    {
        public Randa()
        {

        }

        public override RPSEnum GetRPS()
        {

            Random randomRPS = new Random();

            int ran = randomRPS.Next(0, 3);

            RPSEnum placeHolder;

            switch (ran)
            {
                case 0:
                    placeHolder = RPSEnum.Rock;
                    break;
                case 1:
                    placeHolder = RPSEnum.Paper;
                    break;
                case 2:
                    placeHolder = RPSEnum.Scissors;
                    break;
                default:
                    return GetRPS();

            }

            return placeHolder;
        }
    }
}
