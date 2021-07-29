# AllCardsOnDeckCS

<!-- PEDAC (Problem, Example, Data (Data Structure), Algorithm and Code.)

Problem Statement
******************
Explorer Mode Parts:
Once the program starts, you should create a new deck.
deckOfCards
After deck creation, you should shuffle the deck.
*****How do I shuffle the cards?****
After the deck is shuffled, display the top two cards.
firstCard
secondCard

Requirements:
Your deck should contain 52 unique cards.
All cards should be represented as a string such as "Ace of Hearts"
There are four suits: "Clubs", "Diamonds", "Hearts", and "Spades".
There are 13 ranks: "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", and "King".

Create a deck of 52 cards
Store cards in a variable as deck
Represent the cards as a list of cards in the form of a list of strings per cards.



Example Data:
******************
Create a deck of The deck of cards should contain 52 cards.
All cards should be represented as a string like this:
"Ace of Clubs",
"2 of Clubs",
"3 of Clubs",
"4 of Clubs",
"5 of Clubs",
"6 of Clubs",
"7 of Clubs",
"8 of Clubs",
"9 of Clubs",
"10 of Clubs",
"Jack of Clubs",
"Queen of Clubs,"
"King of Clubs",
"Ace of Diamonds",
"2 of Diamonds",
"3 of Diamonds",
"4 of Diamonds",
"5 of Diamonds",
"6 of Diamonds",
"7 of Diamonds",
"8 of Diamonds",
"9 of Diamonds",
"10 of Diamonds",
"Jack of Diamonds",
"Queen of Diamonds",
"King of Diamonds",
"Ace of Hearts",
"2 of Hearts",
"3 of Hearts",
"4 of Hearts",
"5 of Hearts",
"6 of Hearts",
"7 of Hearts",
"8 of Hearts",
"9 of Hearts",
"10 of Hearts",
"Jack of Hearts",
"Queen of Hearts",
"King of Hearts",
"Ace of Spades",
"2 of Spades",
"3 of Spades",
"4 of Spades",
"5 of Spades",
"6 of Spades",
"7 of Spades",
"8 of Spades",
"9 of Spades",
"10 of Spades",
"Jack of Spades",
"Queen of Spades",
"King of Spades"

Data Structure
******************
'strings'
'list'
'loops'
There are four suits: "Clubs", "Diamonds", "Hearts", and "Spades".
There are 13 ranks: "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", and "King".

Algorithm
******************

Algorithm A
-Make a empty string list and name it 'deck' and initialize them.
-Make two lists, one for the 'ranks' and initialize them.
-Make another one for the 'suits' and initialize them.
-Then, we will loop through both lists to add all of our list elements to a deck list. Once we loop, we would have built a deck of cards.
-Initialize the list of strings with 52 cards like in the example data to start and make sure we are getting the desired results.
For example an empty list.
-Shuffle them with Fisher Yates :

  numberOfCards = length of our deck

  for rightIndex from numberOfCards - 1 down to 1 do:
    leftIndex = random integer that is greater than or equal to 0 and LESS than rightIndex. See the section "How do we get a random integer")

    Now swap the values at rightIndex and leftIndex by doing this:
      leftCard = the value from deck[leftIndex]
      rightCard = the value from deck[rightIndex]
      deck[rightIndex] = leftCard
      deck[leftIndex] = rightCard
  *********end of Fisher Yates Algorithm

-first card = deck[0]
-second card = deck[1]
-print first and second card

-->
