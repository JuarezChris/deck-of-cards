using System;
using System.Collections.Generic;

namespace Deck_of_cards
{
    class Card
{
    public string stringVal;
    public string suit;
    public int val;
}
    class Deck
{
    public List<Card> cards;
        
    public Deck()
        {
            cards = new List<Card>();
            List<string>suit = new List<string>{"Club","Spade","Hearts","Diamonds"};
            List<string>faceVal = new List<string>{"Ace","2","3","4","5","6","7","8","9","10","Jack","Queen","King"};
            List<int>numVal = new List<int>{1,2,3,4,5,6,7,8,9,10,11,12,13};

           for(int i = 0; i<suit.Count; i++)
           {
               for(int j = 0; j<faceVal.Count; j++)
               {
                   Card newCard = new Card();
                    newCard.stringVal = faceVal[j];
                    newCard.suit = suit[i];
                    newCard.val = numVal[j];
                    cards.Add(newCard);
               }
           } 
        }  
    public Card Deal()
    {
        
            Card topCard = new Card();
            topCard = cards[0];
            cards.RemoveAt(0);
            return topCard;
    } 
    public void reset()
    {
       cards.Clear();
        cards = new List<Card>();
            List<string>suit = new List<string>{"Club","Spade","Hearts","Diamonds"};
            List<string>faceVal = new List<string>{"Ace","2","3","4","5","6","7","8","9","10","Jack","Queen","King"};
            List<int>numVal = new List<int>{1,2,3,4,5,6,7,8,9,10,11,12,13};

           for(int i = 0; i<suit.Count; i++)
           {
               for(int j = 0; j<faceVal.Count; j++)
               {
                   Card newCard = new Card();
                    newCard.stringVal = faceVal[j];
                    newCard.suit = suit[i];
                    newCard.val = numVal[j];
                    cards.Add(newCard);
               }
           } 
        
    }
    public void shuffle(){
           for(int i=0;i<cards.Count;i++)
           {
               Random rand=new Random();
               int idx= rand.Next(cards.Count);
               Card temp = cards[i];
               cards[i] = cards[idx];
               cards[idx] = temp;
           }
       }
}
    class Player
{
    public string Name;
    public List<Card> Hand;

    public List<Card> Draw()
       {
           Player NewPlayer = new Player();
        //    NewPlayer.Name = "PlayerOne";
           Hand = new List<Card>();
           Deck NewGame = new Deck();
           NewGame.shuffle();
           Hand.Add(NewGame.Deal());
           Console.WriteLine("*****************************************************************************************************");
           Console.WriteLine("The card in hand is");
           Console.WriteLine(Hand[0].stringVal);
           Console.WriteLine("of");
           Console.WriteLine(Hand[0].suit);
           Console.WriteLine(NewGame.cards.Count);
           Console.WriteLine(Hand.Count);
           return NewPlayer.Hand;
       }

}

    class Program
    {
        static void Main(string[] args)
        {
            // Deck myDeck = new Deck();
            // myDeck.shuffle();
            // foreach (Card numVal in myDeck.cards)
            // {
            //     Console.WriteLine($"{numVal.stringVal} of {numVal.suit}");
            //     // Console.WriteLine(myDeck.cards.Count);
            // }

            // Deck myDeck = new Deck();
            // myDeck.Deal();
            // // Console.WriteLine(myDeck.cards.Count);
            // Console.WriteLine(myDeck.cards.Count);
            // myDeck.reset();
            // Console.WriteLine(myDeck.cards.Count);

           Player playerOne = new Player();
           playerOne.Name = "Chris";
           playerOne.Draw();

        }
    }
}
