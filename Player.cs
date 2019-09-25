using System;
using System.Collections.Generic;
using System.Text;

namespace War
{
    class Player
    {
        private int wins = 0;
        private string name;

        public int Wins
        {
            get => wins;
            set => wins = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }
    }
}
