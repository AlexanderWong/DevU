using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace MegaWarChallenge
{
    public class Battle
    {
        private List<Card> _loot;
        private StringBuilder _sb;

        public Battle ()
        {
            _loot = new List<Card>();
            _sb = new StringBuilder();
        }

        public string PerformBattle(Player player1, Player player2)
        {
            Card player1Card = getCard(player1);
            Card player2Card = getCard(player2);

            compareCardValues(player1, player2, player1Card, player2Card);
            return _sb.ToString();
        }
        
        private Card getCard(Player player)
        {
            Card card = player.Cards.ElementAt(0);
            player.Cards.Remove(card);
            _loot.Add(card);
            return card;
        }

        private void compareCardValues(Player player1, Player player2, Card card1, Card card2)
        {
            displayWarCards(card1, card2);
            if (card1.CardValue() == card2.CardValue())
                war(player1,player2);
            if (card1.CardValue() > card2.CardValue())
                awardWinner(player1);
            else
                awardWinner(player2);
            
        }

        private void awardWinner(Player player)
        {
            if (_loot.Count == 0) return;
            displayLoot();
            player.Cards.AddRange(_loot);
            _loot.Clear();
            _sb.Append("<br/><strong>");
            _sb.Append(player.Name);
            _sb.Append(" wins!</strong><br/>");
        }

        private void war(Player player1, Player player2)
        {
            _sb.Append("</br>============== I DECLARE WAR =================<br/>");
            getCard(player1);
            Card warCard1 = getCard(player1);
            getCard(player1);
            


            getCard(player2);
            Card warCard2 = getCard(player2);
            getCard(player2);
            

            compareCardValues(player1, player2, warCard1, warCard2);
        }

        private void displayWarCards(Card card1, Card card2)
        {
            _sb.Append("<br/>Cards to fight: ");
            _sb.Append(card1.Kind);
            _sb.Append(" of ");
            _sb.Append(card1.Suit);
            _sb.Append(" vs. ");
            _sb.Append(card2.Kind);
            _sb.Append(" of ");
            _sb.Append(card2.Suit);

        }

        private void displayLoot()
        {
            _sb.Append("<br/> Loot");
            foreach (var card in _loot)
            {
                _sb.Append("<br/>&nbsp;&nbsp;&nbsp;&nbsp;");
                _sb.Append(card.Kind);
                _sb.Append(" of ");
                _sb.Append(card.Suit);
            }         
        }

    }
}