using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmTicTacToe
{
    internal class Class1
    {
        public bool toggleValue = true;
        string userOne = "O";
        string userTwo = "X";

        public bool getToggleValue
        {
            get { return toggleValue; }
        }

        public string getUserOne
        {
            get { return userOne; }
        }

        public string getUserTwo
        {
            get { return userTwo; }
        }

    }
}
