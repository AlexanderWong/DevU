using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;


namespace SimpleDartsChallenge
{
    public class Game
    {
        private Player _player1;
        private Player _player2;

        private Random _random;

        public Game()
        {
            _player1 = new Player();
            _player1.Name = "Bill";

            _player2 = new Player();
            _player2.Name = "Ted";

            _random = new Random();
        }

        public string Play()
        {
            while (_player1.Score < 300 && _player2.Score <300)
            {
                playRound(_player1);
                playRound(_player2);
            }
           return displayResults();
            
        }

        private string displayResults()
        {
            string result = "";

            if (_player1.Score > _player2.Score)           
                return result = String.Format("{0}: {1}<br/>{2}: {3}<br/>{4} is the winner!", _player1.Name, _player1.Score, _player2.Name, _player2.Score , _player1.Name);           
            else
                return result = String.Format("{0}: {1}<br/>{2}: {3}<br/>{4} is the winner!", _player1.Name, _player1.Score, _player2.Name, _player2.Score, _player2.Name);
        }

        private void playRound(Player player)
        {
            for (int i = 0; i < 3; i++)
            {
                Dart dart = new Dart(_random);
                dart.Throw();
                Score.ScoreOfGame(player, dart);
            }
        }
    }

    
}