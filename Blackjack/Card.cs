﻿namespace Blackjack
{
    public class Card : ICard
    {
        private int point;
        private string _value;

        public Card(string value)
        {
            _value = value;
        }

        public string Value
        {
            get => _value;
        }

        public int Points
        {
            get
            {
                switch (_value)
                {
                    case "1": return 1;
                    case "2": return 2;
                    case "3": return 3;
                    case "4": return 4;
                    case "5": return 5;
                    case "6": return 6;
                    case "7": return 7;
                    case "8": return 8;
                    case "9": return 9;
                    case "10": return 10;
                    case "J": return 10;
                    case "K": return 10;
                    case "Q": return 10;
                    case "A": return 11;
                    default: return 0;
                }
            }
        }
    }
}