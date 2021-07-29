﻿using System;
using System.Collections.Generic;
// using System.Linq;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Requirements
            // create a deck variable as a list and initialize as empty
            var deck = new List<string>();
            // create a card variable as a list and initialize as empty
            var card = new List<string>();
            // All cards should be represented as a string such as "Ace of Hearts"
            // There are four suits: "Clubs", "Diamonds", "Hearts", and "Spades".
            var suits = new List<string>() { "Clubs", "Diamonds", "Hearts", "Spades" };
            //length of suits
            var suitsLength = suits.Count;
            // There are 13 ranks: "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", and "King".
            var ranks = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            //length of ranks
            var ranksLength = ranks.Count;
            //these nested foreach loops is like having many loops but with a multiplication effect! :-0 DRY \0/
            //Make a loop that goes through the list of ranks
            foreach (var suit in suits)
            {
                //Make a loop that goes through the list of ranks
                // Console.WriteLine($"SuitsLength: {suitsLength}.");
                foreach (var rank in ranks)
                {
                    //displaying the cards each of the 52
                    var cards = $"{rank} of {suit}";
                    //printing the cards
                    Console.WriteLine($"and it's a: {cards}");
                    deck.Add(cards);
                    //this makes the loop go as many times as there are elements on the rank
                    // Console.WriteLine("\n");
                }
                // Console.Write($"Total of cards : {deck.Count} ");
                // Console.WriteLine("Counting my suits and there are : " + deck.Count + " of them at this point.");
            };
            var allCardsOnTheDeck = deck.Count;
            //How do we shuffle?
            //for rightIndex from numberOfCards - 1 down to 1 do:
            for (var rightIndex = allCardsOnTheDeck - 1; rightIndex >= 1; rightIndex--)
            {
                //leftIndex = random integer that is greater than or equal to 0 and LESS than rightIndex. 
                var randomNumberGenerator = new Random();
                var leftIndex = randomNumberGenerator.Next(rightIndex);
                // Now swap the values at rightIndex and leftIndex by doing this:
                var leftCard = deck[leftIndex];
                var rightCard = deck[rightIndex];
                deck[leftIndex] = rightCard;
                deck[rightIndex] = leftCard;
                // After the deck is shuffled, display the top two cards.
                //Showing firstCard
                var firstCard = deck[0];
                //Showing SecondCard
                var secondCard = deck[1];
                Console.WriteLine($"The first card is: {firstCard}, the second card is: {secondCard}");
                //and then swaps that card with a randomly selected element that comes before it.
            };
            Console.WriteLine("End of Shuffle");
        }

    }
}
