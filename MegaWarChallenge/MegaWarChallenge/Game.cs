using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaWarChallenge
{
    public class Game
    {
        private Player _player1;
        private Player _player2;
        

        public Game(string player1Name, string player2Name)
        {
            _player1 = new Player() { Name = player1Name };
            _player2 = new Player() { Name = player2Name };
            
        }

        public string Play()
        {

            Deck deck = new Deck();
            int round = 0;
            string result = "<h2>Distributing weapons to each faction...</h2>";
                result += deck.Deal(_player1, _player2);
                result += "<h2>Let the war begin...</h2>";

            while (_player1.Cards.Count != 0 && _player2.Cards.Count != 0)
            {
                Battle battle = new Battle();
                result += battle.PerformBattle(_player1, _player2);

                round++;
                if (round > 20)
                    break;
            }
            result += determineWinner();
            return result;
            
        }
       
        private string determineWinner()
        {
            string result = "";
            if (_player1.Cards.Count > _player2.Cards.Count)
                result += "<br/></strong>Bill wins the war!";
            else
                result += "<br/</strong>Ted wins the war!";
            result += "<br/>Bill's Card Count:" + _player1.Cards.Count + " Ted's Card Count:" + _player2.Cards.Count;
            return result;
        }       
    }
}

    
